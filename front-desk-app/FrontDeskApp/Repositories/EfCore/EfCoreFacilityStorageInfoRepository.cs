using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using FrontDeskApp.Common.Models;

namespace FrontDeskApp.Repositories.EfCore
{
    public class EfCoreFacilityStorageInfoRepository : IFacilityStorageInfoRepository
    {
        private readonly FrontDeskAppDbContext _database;

        public EfCoreFacilityStorageInfoRepository(FrontDeskAppDbContext database)
        {
            _database = database;
        }

        public async Task<IEnumerable<FacilityStorageInfo>> GetAsync(int facilityId)
        {
            return await _database.FacilityStorageInfo
                .Where(v => v.FacilityId == facilityId)
                .ToListAsync();
        }
    }
}
