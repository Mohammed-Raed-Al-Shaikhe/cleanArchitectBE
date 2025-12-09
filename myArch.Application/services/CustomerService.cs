using myArch.Application.interfaces;
using myArch.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myArch.Application.services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        async Task<Customer> ICustomerService.CreateAsync(Customer customer)
        {
            return await _repository.AddAsync(customer);
        }

        Task ICustomerService.DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        async Task<IEnumerable<Customer>> ICustomerService.GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        async Task<Customer> ICustomerService.GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        async Task<Customer> ICustomerService.UpdateAsync(Customer customer)
        {
            return await _repository.UpdateAsync(customer);
        }
    }
}
