using System;

namespace Observer;

public class RegistroLog : IObservador
{
    public void Actualizar(string mensaje)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"[LOG {timestamp}] {mensaje}");
    }
}
