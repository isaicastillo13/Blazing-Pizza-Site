namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<List<Pizza>> GetPizzasAsync()
    {
        List<Pizza> pizzas = new()
        {
            new Pizza
            {
                PizzaId = 1,
                Name = "Margherita",
                Description = "Tomato sauce, mozzarella and basil.",
                Price = 8.99m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 2,
                Name = "Pepperoni",
                Description = "Tomato sauce, mozzarella and pepperoni.",
                Price = 10.99m,
                Vegetarian = false,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 3,
                Name = "Hawaiian",
                Description = "Tomato sauce, mozzarella, ham and pineapple.",
                Price = 11.99m,
                Vegetarian = false,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 4,
                Name = "Veggie",
                Description = "Tomato sauce, mozzarella, bell peppers, onions, mushrooms and olives.",
                Price = 9.99m,
                Vegetarian = true,
                Vegan = false
            }
        };

        return Task.FromResult(pizzas);
    }
}