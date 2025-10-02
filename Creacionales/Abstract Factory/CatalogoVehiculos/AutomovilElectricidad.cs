using System;

namespace CatalogoVehiculos;

public class AutomovilElectricidad : Automovil
{
    public AutomovilElectricidad(string modelo, string marca, int anio) : base(modelo, marca, anio)
    {
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Automóvil Eléctrico - Modelo: {modelo}, Marca: {marca}, Año: {anio}");
    }
}
