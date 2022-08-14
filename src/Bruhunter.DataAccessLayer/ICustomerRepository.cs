using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;

namespace Bruhunter.DataAccessLayer
{
    public interface ICustomerRepository
    {
        Task AddCustomer(CustomerDocument customerDocument);
        Task<CustomerDocument> GetCustomer(Guid id);
        Task<IEnumerable<CustomerDocument>> GetAllCustomers();
        Task ChangeCustomer(CustomerDocument customerDocument);
        Task UpdateCustomers(IEnumerable<CustomerDocument> customerDocuments);
        Task DeleteCustomer(Guid id);
    }
}