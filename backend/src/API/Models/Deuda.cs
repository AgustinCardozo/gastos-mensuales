using API.Models.Enums;

namespace API.Models;

public class Deuda
{
    public int id { get; set; }
    public string mes { get; set;  }
    public string descripcion { get; set; }
    public Deudor deudor { get; set; }
    public FormaDePago formaDePago { get; set; }
}
