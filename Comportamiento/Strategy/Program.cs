using Strategy;

try
{
    Console.WriteLine("=== DEMOSTRACIÓN DEL PATRÓN STRATEGY ===");
    Console.WriteLine("Este programa muestra diferentes formas de dibujar un catálogo de vehículos.\n");

    // Crear la vista del catálogo con una estrategia inicial
    VistaCatalogo vista = new VistaCatalogo(new DibujaTresVehiculosPorLinea());

    bool continuar = true;

    while (continuar)
    {
        try
        {
            // Elegir estrategia usando el menú
            DibujaCatalogo? estrategiaSeleccionada = MenuEstrategia.ElegirEstrategia();
            
            if (estrategiaSeleccionada == null)
            {
                // Usuario eligió salir
                Console.WriteLine("\n¡Gracias por usar el programa!");
                break;
            }
            
            // Cambiar la estrategia y dibujar
            vista.CambiarEstrategia(estrategiaSeleccionada);
            Console.WriteLine("\n--- CATÁLOGO DE VEHÍCULOS ---");
            vista.Dibuja();
            Console.WriteLine("--- FIN DEL CATÁLOGO ---\n");
            
            // Preguntar si desea continuar
            continuar = MenuEstrategia.DeseaContinuar();
            
            if (continuar)
            {
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();
                Console.Clear(); // Limpiar pantalla para una mejor experiencia
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Intente nuevamente.\n");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error fatal: {ex.Message}");
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
