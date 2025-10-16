using System;

namespace Decorator;

public class VistaVehiculo : ComponenteGraficoVehiculo
{
    public void visualiza()
    {
        Console.WriteLine("Visualizando vehículo...");
    }
}
