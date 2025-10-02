using System;

namespace CatalogoVehiculos;

public class FabricaVehiculosGasolina : FabricaVehiculos
{
    public Automovil CrearAutomovil(string modelo, string marca, int anio)
    {
        return new AutomovilGasolina(modelo, marca, anio);
    }

    public Scooter CrearScooter(string modelo, string marca, int cilindrada)
    {
        return new ScooterGasolina(modelo, marca, cilindrada);
    }
}
