using System;

namespace Decorator;

public class MarcaDecorador : Decorador
{
    public MarcaDecorador(ComponenteGraficoVehiculo componente) : base(componente)
    {
    }
    
    public override void visualiza()
    {
        base.visualiza();
        Console.WriteLine("Mostrando marca del vehículo...");
    }
}
