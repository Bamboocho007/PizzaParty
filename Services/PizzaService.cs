using PizzaParty.DB;
using PizzaParty.DTOs;
using PizzaParty.Exceptions;
using PizzaParty.Models;

namespace PizzaParty.Services;

public class PizzaService
{
    readonly PostgresContext _context;

    public PizzaService(PostgresContext context)
    {
        _context = context;
    }

    public async Task<Pizza> Add(CreatePizzaDto data)
    {
        var newPizza = new Pizza
        {
            Name = data.Name,
            Description = data.Description,
            PizzaId = Guid.NewGuid(),
            Price = data.Price
        };
        await _context.Pizzas.AddAsync(newPizza);
        await _context.SaveChangesAsync();

        throw new HttpResponseException(StatusCodes.Status400BadRequest, "Something went wrong");
        return newPizza;
    }
}

