using System;

namespace Decorator;

public class ModeloDecorador : Decorador
{
    public ModeloDecorador(ComponenteGraficoVehiculo componente) : base(componente)
    {
    }
    
    public override void visualiza()
    {
        base.visualiza();
        Console.WriteLine("Mostrando modelo del vehículo...");
    }   
}
