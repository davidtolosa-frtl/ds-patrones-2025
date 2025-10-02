using System;

namespace CatalogoVehiculos;

public class AutomovilGasolina : Automovil
{
    public AutomovilGasolina(string modelo, string marca, int anio) : base(modelo, marca, anio)
    {
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Automóvil a Gasolina - Modelo: {modelo}, Marca: {marca}, Año: {anio}");
    }
}
