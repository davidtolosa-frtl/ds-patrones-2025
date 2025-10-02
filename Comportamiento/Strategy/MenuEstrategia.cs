using System;

namespace Strategy;

public class MenuEstrategia
{
    public static DibujaCatalogo? ElegirEstrategia()
    {
        Console.WriteLine("=== SELECTOR DE ESTRATEGIA DE DIBUJO ===");
        Console.WriteLine("1. Un vehículo por línea");
        Console.WriteLine("2. Tres vehículos por línea");
        Console.WriteLine("3. Cinco vehículos por línea");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción (0-3): ");

        string? input = Console.ReadLine();
        
        if (int.TryParse(input, out int opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Estrategia seleccionada: Un vehículo por línea");
                    return new DibujaUnVehiculoPorLinea();
                case 2:
                    Console.WriteLine("Estrategia seleccionada: Tres vehículos por línea");
                    return new DibujaTresVehiculosPorLinea();
                case 3:
                    Console.WriteLine("Estrategia seleccionada: Cinco vehículos por línea");
                    return new DibujaCincoVehiculosPorLinea();
                case 0:
                    return null; // Indica salir del programa
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    return ElegirEstrategia(); // Recursión para volver a mostrar el menú
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Intente nuevamente.");
            return ElegirEstrategia(); // Recursión para volver a mostrar el menú
        }
    }

    public static bool DeseaContinuar()
    {
        Console.WriteLine("\n¿Desea probar otra estrategia? (s/n): ");
        string? respuesta = Console.ReadLine()?.ToLower();
        return respuesta == "s" || respuesta == "si" || respuesta == "sí";
    }
}