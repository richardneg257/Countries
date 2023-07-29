using Countries.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Countries.Controllers;
[ApiController]
[Route("[controller]")]
public class CensosController : ControllerBase
{
    private readonly string _rutaCenso;
    public CensosController()
    {
        _rutaCenso = @"D:\Data\censo2023.json";
    }

    [HttpGet("mostrar-censo")]
    public async Task<ActionResult<Censo>> GetCenso()
    {
        using(var sr = new StreamReader(_rutaCenso))
        {
            string jsonString = sr.ReadToEnd();

            var censoResultado = JsonConvert.DeserializeObject<Censo>(jsonString);

            return censoResultado;
        }
    }
}
