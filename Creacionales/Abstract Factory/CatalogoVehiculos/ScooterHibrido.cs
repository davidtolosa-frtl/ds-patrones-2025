using System;

namespace CatalogoVehiculos;

public class ScooterHibrido : Scooter
{
    public ScooterHibrido(string modelo, string marca, int cilindrada) : base(modelo, marca, cilindrada)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Scooter Híbrido - Modelo: {modelo}, Marca: {marca}, Cilindrada: {cilindrada}");
    }

}
