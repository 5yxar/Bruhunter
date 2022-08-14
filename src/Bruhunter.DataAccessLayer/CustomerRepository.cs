using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;
using LiteDB;

namespace Bruhunter.DataAccessLayer;

public class CustomerRepository : RepositoryBase, ICustomerRepository
{
    private readonly ILiteCollection<CustomerDocument> collection;

    public CustomerRepository(LiteDatabase db) : base(db)
    {
        collection = db.GetCollection<CustomerDocument>("customers");
    }
    
    public async Task AddCustomer(CustomerDocument customerDocument)
    {
        collection.Insert(customerDocument);
    }

    public async Task<CustomerDocument> GetCustomer(Guid id)
    {
        return collection.FindById(id);
    }

    public async Task<IEnumerable<CustomerDocument>> GetAllCustomers()
    {
        return collection.FindAll();
    }

    public async Task ChangeCustomer(CustomerDocument customerDocument)
    {
        collection.Upsert(customerDocument);
    }

    public async Task UpdateCustomers(IEnumerable<CustomerDocument> customerDocuments)
    {
        collection.Update(customerDocuments);
    }

    public async Task DeleteCustomer(Guid id)
    {
        collection.Delete(id);
    }
}