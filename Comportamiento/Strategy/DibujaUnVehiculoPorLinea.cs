using System;

namespace Strategy;

public class DibujaUnVehiculoPorLinea : DibujaCatalogo
{
    public void Dibuja(List<VistaVehiculo> contenido)
    {
        foreach (var item in contenido)
        {
            item.Dibuja();
            Console.WriteLine();
        }
    }
}
