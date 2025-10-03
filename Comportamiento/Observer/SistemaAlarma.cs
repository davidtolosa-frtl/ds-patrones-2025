using System;

namespace Observer;

public class SistemaAlarma : IObservador
{
    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"[ALARMA] ⚠️  {mensaje}");
        Console.Beep();
    }
}
