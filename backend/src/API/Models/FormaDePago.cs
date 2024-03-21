using API.Models.Enums;

namespace API.Models;
public class FormaDePago
{
    public double importe { get; set; }
}

public class Efectivo : FormaDePago
{
    public string aFavorDe { get; set; }
}

public class Tarjeta : FormaDePago
{
    public string banco { get; set; }
    public TipoDeTarjeta tipoDeTarjeta { get; set; }
    public int cuotas { get; set; }
}
