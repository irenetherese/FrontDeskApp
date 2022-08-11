using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FrontDeskApp.Common.Models;

namespace FrontDeskApp.Repositories
{
    public interface IFacilityStorageInfoRepository
    {
        Task<IEnumerable<FacilityStorageInfo>> GetAsync(int facilityId);
    }
}
