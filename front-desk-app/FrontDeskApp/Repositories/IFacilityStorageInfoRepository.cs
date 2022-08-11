using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FrontDeskApp.Models;

namespace FrontDeskApp.Repositories
{
    public interface IFacilityStorageInfoRepository
    {
        Task<IEnumerable<FacilityStorageInfo>> GetAsync(int facilityId);
    }
}
