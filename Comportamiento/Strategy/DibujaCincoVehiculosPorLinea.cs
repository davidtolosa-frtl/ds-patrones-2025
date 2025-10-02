using System;

namespace Strategy;

public class DibujaCincoVehiculosPorLinea : DibujaCatalogo
{
    public void Dibuja(List<VistaVehiculo> contenido)
    {
        for (int i = 0; i < contenido.Count; i++)
        {
            contenido[i].Dibuja();
            if ((i + 1) % 5 == 0)
            {
                Console.WriteLine();
            }
        }
        // Agregar nueva línea si no se completó la última línea de 5
        if (contenido.Count % 5 != 0)
        {
            Console.WriteLine();
        }
    }
}
