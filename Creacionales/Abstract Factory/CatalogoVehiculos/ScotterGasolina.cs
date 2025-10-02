using System;

namespace CatalogoVehiculos;

public class ScooterElectricidad : Scooter
{   
    public ScooterElectricidad(string modelo, string marca, int cilindrada) : base(modelo, marca, cilindrada)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Scooter Eléctrico - Modelo: {modelo}, Marca: {marca}, Cilindrada: {cilindrada}cc");
    }
}
