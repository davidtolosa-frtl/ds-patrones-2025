using System;

namespace Observer;

public class ClienteNotificaciones : IObservador
{
    private string nombre;

    public ClienteNotificaciones(string nombre)
    {
        this.nombre = nombre;
    }

    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"[Cliente {nombre}] Notificación recibida: {mensaje}");
    }
}
