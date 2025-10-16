using System;

namespace Decorator;

public class Decorador : ComponenteGraficoVehiculo
{
    private ComponenteGraficoVehiculo _componente;

    public Decorador(ComponenteGraficoVehiculo componente)
    {
        _componente = componente;
    }

    public virtual void visualiza()
    {
        _componente.visualiza();
    }
}
