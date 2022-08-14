using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bruhunter.Application;
using Bruhunter.Shared.Documents;
using Microsoft.AspNetCore.Mvc;

namespace Bruhunter.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly CustomerService customerService;

    public CustomersController(CustomerService customerService)
    {
        this.customerService = customerService;
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<CustomerDocument> GetCustomer(Guid id)
    {
        return await customerService.GetCustomer(id);
    }
    
    [HttpGet]
    [Route("query")]
    public async Task<IEnumerable<CustomerDocument>> GetAllCustomers()
    {
        return await customerService.GetAllCustomers();
    }
    
    [HttpPost]
    public async Task CreateDocument(CustomerDocument customerDocument)
    {
        await customerService.AddCustomer(customerDocument);
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task ChangeCustomer(CustomerDocument customerDocument)
    {
        await customerService.ChangeCustomer(customerDocument);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public async Task DeleteCustomer(Guid id)
    {
        await customerService.DeleteCustomer(id);
    }
}