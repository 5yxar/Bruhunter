using Microsoft.AspNetCore.Mvc;

namespace Bruhunter.Api.Controllers;

[ApiController]
[Route("api/candidates")]
public class CustomersController : ControllerBase
{
    private readonly CustomersController customersController;

    public CustomersController(CustomersController customersController)
    {
        this.customersController = customersController;
    }
}