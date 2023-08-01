namespace Countries.Models.Tarea1;

public class Censo
{
    public Name Name { get; set; }
    public Currency Currencies { get; set; }
    public Language Languages { get; set; }
    public List<Departamento> Departamentos { get; set; }
    public List<Provincia> Provincias { get; set; }
    public List<Distrito> Distritos { get; set; }

}
