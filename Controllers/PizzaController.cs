using Microsoft.AspNetCore.Mvc;
using PizzaParty.DTOs;
using PizzaParty.Models;
using PizzaParty.Services;

namespace PizzaParty.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    readonly PizzaService _pizzaService;

    public PizzaController(PizzaService pizzaService)
    {
        _pizzaService = pizzaService;
    }

    [HttpGet(Name = "GetPizzaList")]
    public IEnumerable<Pizza> Get()
    {
        return new List<Pizza>();
    }

    [HttpPost(Name = "CreateNewPizza")]
    public async Task<IActionResult> Post([FromBody] CreatePizzaDto data)
    {
        var newPizza = await _pizzaService.Add(data);

        return Ok(newPizza);
    }

    [HttpDelete(Name = "Delete pizza")]
    public async Task Delete()
    {
        await Task.Delay(1000);
    }
}
