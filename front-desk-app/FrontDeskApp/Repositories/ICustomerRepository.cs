using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FrontDeskApp.Models;

namespace FrontDeskApp.Repositories
{
    public interface ICustomerRepository
    {
        Task<int> CreateAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task<Customer> GetAsync(int id);
        Task<IEnumerable<Customer>> GetAsync();
        Task<IEnumerable<Customer>> GetAsync(Expression<Func<Customer,bool>> filter);
    }
}
