// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


partial class Program
{
    static void Main(string[] args)
    {
        // Crear carros
        Carro carro1 = new Carro("Toyota", "Corolla", 2020, 4, "Gasolina");
        Carro carro2 = new Carro("Tesla", "Model 3", 2021, 4, "Eléctrico");

        // Crear motos
        Moto moto1 = new Moto("Honda", "CBR500R", 2019, 500, true);
        Moto moto2 = new Moto("Yamaha", "MT-07", 2022, 689, false);

        Console.WriteLine("Información de los carros:");
        carro1.MostrarInformacion();
        Console.WriteLine(); // Línea en blanco
        carro2.MostrarInformacion();
        Console.WriteLine();

        Console.WriteLine("Información de las motos:");
        moto1.MostrarInformacion();
        Console.WriteLine();
        moto2.MostrarInformacion();

        Console.ReadLine();
    }
}
