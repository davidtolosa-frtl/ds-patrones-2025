using System;

namespace CatalogoVehiculos;

public interface FabricaVehiculos
{
    Automovil CrearAutomovil(string modelo, string marca, int anio);
    Scooter CrearScooter(string modelo, string marca, int cilindrada);
}
