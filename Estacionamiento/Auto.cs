public class Auto
{
    public string Placas { get; set; }
    public string Propietario { get; set; }

    public Auto(string placas, string propietario)
    {
        this.Placas = placas;  // Usamos "this" para referirnos a la propiedad del objeto actual
        this.Propietario = propietario;  // Usamos "this" para referirnos a la propiedad del objeto actual
    }
}
