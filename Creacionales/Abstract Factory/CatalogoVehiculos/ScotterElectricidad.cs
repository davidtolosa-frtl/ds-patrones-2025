using System;

namespace CatalogoVehiculos;

public class ScooterGasolina : Scooter
{
    public ScooterGasolina(string modelo, string marca, int cilindrada) : base(modelo, marca, cilindrada)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Scooter a Gasolina - Modelo: {modelo}, Marca: {marca}, Cilindrada: {cilindrada}cc");
    }
}
