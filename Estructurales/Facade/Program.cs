using Facade;

Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
Console.WriteLine("║        PATRÓN FACADE - Sistema de Cine en Casa            ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

// Sin Facade: El cliente tendría que interactuar con múltiples subsistemas
Console.WriteLine("\n❌ SIN FACADE - Control manual de todos los subsistemas:\n");
Console.WriteLine("(El usuario tendría que hacer 10+ llamadas diferentes)");
Console.WriteLine("- luces.Atenuar()");
Console.WriteLine("- butacas.Reclinar()");
Console.WriteLine("- proyector.Encender()");
Console.WriteLine("- proyector.SeleccionarEntradaHDMI()");
Console.WriteLine("- sonido.Encender()");
Console.WriteLine("- sonido.SeleccionarModoSurround()");
Console.WriteLine("- ... etc");

// Con Facade: Una sola llamada simplifica todo
Console.WriteLine("\n\n✅ CON FACADE - Interfaz simplificada:\n");
Console.WriteLine(new string('═', 60));

CineFacade cine = new CineFacade();

// Operación 1: Ver película
cine.VerPelicula("The Matrix");

Console.WriteLine("⏱️  [Pasaron 30 minutos...]\n");

// Operación 2: Pausar
cine.PausarPelicula();

Console.WriteLine("⏱️  [Descanso de 5 minutos...]\n");

// Operación 3: Continuar viendo (reiniciar)
cine.VerPelicula("The Matrix (continuación)");

Console.WriteLine("⏱️  [Película terminada...]\n");

// Operación 4: Finalizar
cine.FinalizarPelicula();

Console.WriteLine(new string('═', 60));
Console.WriteLine("\n💡 VENTAJAS DEL PATRÓN FACADE:");
Console.WriteLine("   • Simplifica el uso de sistemas complejos");
Console.WriteLine("   • Reduce el acoplamiento entre cliente y subsistemas");
Console.WriteLine("   • Proporciona una interfaz de alto nivel fácil de usar");
Console.WriteLine("   • Los subsistemas siguen siendo accesibles directamente si se necesita");
