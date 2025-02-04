using System.Data;

public static class PizzaService {
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {Id = 1, Name = "p1", IsGlutenFree = false},
            new Pizza {Id = 2, Name = "p22", IsGlutenFree = false},
        };
    }

    public static List<Pizza> GetAll() => Pizzas;
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza p)
    {
        p.Id = nextId++;
        Pizzas.Add(p);
    }

    public static void Delete(int id)
    {
        var p = Get(id);
        if(p is null) return;

        Pizzas.Remove(p);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1) return;

        Pizzas[index] = pizza;
    }
}