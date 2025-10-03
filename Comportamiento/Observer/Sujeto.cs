using System;

namespace Observer;

public abstract class Sujeto
{
    protected List<IObservador> observadores = new List<IObservador>();

    public void AgregarObservador(IObservador observador)
    {
        observadores.Add(observador);
    }

    public void EliminarObservador(IObservador observador)
    {
        observadores.Remove(observador);
    }

    protected void NotificarObservadores(string mensaje)
    {
        foreach (var observador in observadores)
        {
            observador.Actualizar(mensaje);
        }
    }
}
