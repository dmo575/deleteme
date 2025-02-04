using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PizzaController
{
    public PizzaController()
    {

    }

    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
    public ActionResult<Pizza> Get(int id) => PizzaService.Get(id);
}