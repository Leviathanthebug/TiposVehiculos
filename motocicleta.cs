using System;

public class Moto : Vehiculo
{
    public int Cilindrada { get; set; }
    public bool TieneMaletero { get; set; }

    public Moto(string marca, string modelo, int año, int cilindrada, bool tieneMaletero)
        : base(marca, modelo, año)
    {
        Cilindrada = cilindrada;
        TieneMaletero = tieneMaletero;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        string maleteroTexto = TieneMaletero ? "Si" : "No";
        Console.WriteLine($"Cilindrada: {Cilindrada}cc, Tiene maletero: {maleteroTexto}");
    }
}
