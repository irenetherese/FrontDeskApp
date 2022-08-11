using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Linq.Expressions;
using FrontDeskApp.Models;

namespace FrontDeskApp.Repositories.EfCore
{
    public class EfCoreFacilityRepository : IFacilityRepository
    {
        private readonly FrontDeskAppDbContext _database;

        public EfCoreFacilityRepository(FrontDeskAppDbContext database)
        {
            _database = database;
        }

        public async Task<IEnumerable<Facility>> GetAsync()
        {
            return await _database.Facilities.ToListAsync();
        }

         public async Task<Facility> GetAsync(int id)
        {
            return await _database.Facilities
                .Where(v => v.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Facility>> GetAsync(Expression<Func<Facility, bool>> filter)
        {
            return await _database.Facilities
                .Where(filter)
                .ToListAsync();
        }
    }
}
