using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Shared.Documents;
using Bruhunter.DataAccessLayer;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Bruhunter.Application;

public class CustomerService
{
    private readonly ICustomerRepository customerRepository;
    private readonly ILogger<CustomerService> logger;

    public CustomerService(ICustomerRepository customerRepository, ILogger<CustomerService> logger)
    {
        this.customerRepository = customerRepository;
        this.logger = logger;
    }

    public async Task AddCustomer(CustomerDocument customerDocument)
    {
        logger.LogInformation("Adding customer {customerDocument} to database ...",
            customerDocument);

        var newGuid = Guid.NewGuid();

        customerDocument.Id = newGuid;
        await customerRepository.AddCustomer(customerDocument);

        logger.LogDebug("Customer {customerDocument} with id = {newGuid} was added to database.",
            customerDocument, customerDocument.Id);
    }

    public async Task<CustomerDocument> GetCustomer(Guid id)
    {
        logger.LogInformation("Getting customer witn id = {id} from database ...", id);

        var receivedCustomer = await customerRepository.GetCustomer(id);

        logger.LogDebug("Customer {receivedCustomer} with id = {id} was received from database.",
            receivedCustomer, id);

        return receivedCustomer;
    }

    public async Task<IEnumerable<CustomerDocument>> GetAllCustomers()
    {
        logger.LogInformation("Getting all customers from database ...");

        var receivedCustomers = await customerRepository.GetAllCustomers();

        logger.LogDebug("{customersCount} customers was received from database.",
            receivedCustomers.Count());

        return receivedCustomers;
    }

    public async Task ChangeCustomer(CustomerDocument customerDocument)
    {
        logger.LogInformation("Changing customer {customerDocument} in the database ...",
            customerDocument);

        await customerRepository.ChangeCustomer(customerDocument);

        logger.LogDebug("Customer was changed to {customerDocument}.", customerDocument);
    }

    public async Task DeleteCustomer(Guid guid)
    {
        logger.LogInformation("Deleting customer with id {guid} in database ...", guid);

        await customerRepository.DeleteCustomer(guid);

        logger.LogDebug("Customer with id = {guid} was deleted in database.", guid);
    }
}