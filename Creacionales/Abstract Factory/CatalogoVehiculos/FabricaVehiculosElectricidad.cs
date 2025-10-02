using System;

namespace CatalogoVehiculos;

public class FabricaVehiculosElectricidad : FabricaVehiculos
{
    public Automovil CrearAutomovil(string modelo, string marca, int anio)
    {
        return new AutomovilElectricidad(modelo, marca, anio);
    }
    public Scooter CrearScooter(string modelo, string marca, int cilindrada)
    {
        return new ScooterElectricidad(modelo, marca, cilindrada);
    }
}
