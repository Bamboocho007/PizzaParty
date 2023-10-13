namespace PizzaParty.Models;

public class Pizza
{
    Guid Id { get; set; }
    string Name { get; set; } = string.Empty;
    string Description { get; set; } = string.Empty;
    float Price { get; set; }
}
