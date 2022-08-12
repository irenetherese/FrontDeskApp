using FrontDeskApp.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FrontDeskApp.Repositories.EfCore
{
    public class EfCoreRecordRepository : IRecordRepository
    {
        private readonly FrontDeskAppDbContext _database;

        public EfCoreRecordRepository(FrontDeskAppDbContext database)
        {
            _database = database;
        }

        public async Task<int> CreateAsync(Record record)
        {
            _database.Add(record);
            await _database.SaveChangesAsync();

            var entity = await _database.Set<Record>().FirstOrDefaultAsync();
            return entity == null ? 0 : entity.Id;
        }

        public async Task UpdateAsync(Record record)
        {
            _database.Update(record);
            await _database.SaveChangesAsync();
        }

        public async Task<Record> GetAsync(int id)
        {
            return await _database.Records
                .Where(v => v.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Record>> GetAsync()
        {
            var records =  await _database.Records
                .Join(_database.Customers, r => r.CustomerId, c => c.Id, (r,c) => new { Record = r , Customer = c })
                .Join(_database.Facilities, r => r.Record.FacilityId, f => f.Id, (r, f) => new { RecordCustomer = r, Facility = f })
                .ToListAsync();

            var list = new List<Record>();
            foreach(var r in records)
            {
                r.RecordCustomer.Record.Customer = r.RecordCustomer.Customer;
                r.RecordCustomer.Record.Facility = r.Facility;
                list.Add(r.RecordCustomer.Record);
            }

            return list;
        }

        public async Task<IEnumerable<Record>> GetAsync(Expression<Func<Record, bool>> filter)
        {
            return await _database.Records
                .Where(filter)
                .ToListAsync();
        }
    }
}
