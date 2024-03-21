namespace API.Models;

public class Persona
{
    public int id { get; set; }
    public string nombre { get; set; }
    public List<Deuda> deudas { get; set; }
}
