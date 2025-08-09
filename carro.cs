using System;

public class Carro : Vehiculo
{
    public int NumeroPuertas { get; set; }
    public string TipoCombustible { get; set; }

    public Carro(string marca, string modelo, int año, int numeroPuertas, string tipoCombustible)
        : base(marca, modelo, año)
    {
        NumeroPuertas = numeroPuertas;
        TipoCombustible = tipoCombustible;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Número de Puertas: {NumeroPuertas}, Tipo de Combustible: {TipoCombustible}");
    }
}
