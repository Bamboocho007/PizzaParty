using Microsoft.AspNetCore.Mvc;
using PizzaParty.Models;

namespace PizzaParty.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    [HttpGet(Name = "GetPizzaList")]
    public IEnumerable<Pizza> Get()
    {
        return new List<Pizza>();
    }

    [HttpPost(Name = "CreateNewPizza")]
    public async Task<Pizza> Post()
    {
        await Task.Delay(1000);
        return new Pizza();
    }

    [HttpDelete(Name = "Delete pizza")]
    public async Task Delete()
    {
        await Task.Delay(1000);
    }
}
