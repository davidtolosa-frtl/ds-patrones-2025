using System;

namespace Strategy;

public class DibujaTresVehiculosPorLinea : DibujaCatalogo
{
    public void Dibuja(List<VistaVehiculo> contenido)
    {
        for (int i = 0; i < contenido.Count; i++)
        {
            contenido[i].Dibuja();
            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine();
            }
        }
        // Agregar nueva línea si no se completó la última línea de 3
        if (contenido.Count % 3 != 0)
        {
            Console.WriteLine();
        }
    }
}
