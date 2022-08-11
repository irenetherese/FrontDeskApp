using FrontDeskApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FrontDeskApp.Repositories
{
    public interface IRecordRepository
    {
        Task<int> CreateAsync(Record record);
        Task UpdateAsync(Record record);
        Task<Record> GetAsync(int id);
        Task<IEnumerable<Record>> GetAsync();
        Task<IEnumerable<Record>> GetAsync(Expression<Func<Record, bool>> filter);
    }
}
