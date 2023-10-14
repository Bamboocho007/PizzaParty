namespace PizzaParty.Models;

public class Pizza
{
    public Guid PizzaId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public float Price { get; set; }
}
