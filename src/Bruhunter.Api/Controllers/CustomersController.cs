using Microsoft.AspNetCore.Mvc;

namespace Bruhunter.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly CustomersController customersController;

    public CustomersController(CustomersController customersController)
    {
        this.customersController = customersController;
    }
}