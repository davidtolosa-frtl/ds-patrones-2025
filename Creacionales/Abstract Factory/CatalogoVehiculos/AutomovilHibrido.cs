using System;

namespace CatalogoVehiculos;

public class AutomovilHibrido : Automovil
{
    public AutomovilHibrido(string modelo, string marca, int anio) : base(modelo, marca, anio)
    {
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Automóvil Híbrido - Modelo: {modelo}, Marca: {marca}, Año: {anio}");
    }
}
