using FrontDeskApp.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FrontDeskApp.Repositories.EfCore
{
    public class EfCoreCustomerRepository : ICustomerRepository
    {
        private readonly FrontDeskAppDbContext _database;

        public EfCoreCustomerRepository(FrontDeskAppDbContext database)
        {
            _database = database;
        }

        public async Task<int> CreateAsync(Customer customer)
        {
            _database.Add(customer);
            await _database.SaveChangesAsync();

            var entity = await _database.Set<Record>().FirstOrDefaultAsync();
            return entity==null ? 0 : entity.Id;
        }

        public async Task UpdateAsync(Customer customer)
        {
            _database.Update(customer);
            await _database.SaveChangesAsync();
        }

        public async Task<Customer> GetAsync(int id)
        {
            return await _database.Customers
                .Where(v => v.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Customer>> GetAsync()
        {
            return await _database.Customers
                .ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetAsync(Expression<Func<Customer, bool>> filter)
        {
            return await _database.Customers
                .Where(filter)
                .ToListAsync();
        }
    }
}
