using System;

namespace CatalogoVehiculos;

public class FabricaVehiculosHibrido : FabricaVehiculos
{
    public Automovil CrearAutomovil(string modelo, string marca, int anio)
    {
        return new AutomovilHibrido(modelo, marca, anio);
    }

    public Scooter CrearScooter(string modelo, string marca, int cilindrada)
    {
        return new ScooterHibrido(modelo, marca, cilindrada);
    }
}
