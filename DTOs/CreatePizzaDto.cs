﻿namespace PizzaParty.DTOs;

public class CreatePizzaDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public float Price { get; set; }
}
