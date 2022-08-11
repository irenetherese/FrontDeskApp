using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FrontDeskApp.Models;

namespace FrontDeskApp.Repositories
{
    public interface IFacilityRepository
    {
        Task<Facility> GetAsync(int id);
        Task<IEnumerable<Facility>> GetAsync();
        Task<IEnumerable<Facility>> GetAsync(Expression<Func<Facility,bool>> filter);
    }
}
