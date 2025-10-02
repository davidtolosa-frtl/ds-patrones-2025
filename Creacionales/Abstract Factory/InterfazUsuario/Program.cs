using InterfazUsuario.Client;
using InterfazUsuario.Factory;
using InterfazUsuario.Interfaces;

namespace InterfazUsuario
{
    /// <summary>
    /// Programa principal que demuestra el patrón Abstract Factory
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("🏭 DEMOSTRACIÓN DEL PATRÓN ABSTRACT FACTORY");
            Console.WriteLine("   Elementos de Interfaz de Usuario");
            Console.WriteLine("=================================================\n");

            try
            {
                // Demostración 1: Detección automática del SO
                Console.WriteLine("🔍 DEMOSTRACIÓN 1: Detección automática del SO");
                Console.WriteLine("-----------------------------------------------");
                
                IGUIFactory autoFactory = GUIFactoryProvider.GetFactory();
                Application autoApp = new Application(autoFactory);
                
                autoApp.CreateUI();
                autoApp.RenderUI();
                autoApp.InteractWithUI();
                autoApp.ShowInfo();

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Demostración 2: Selección manual - Windows
                Console.WriteLine("🔧 DEMOSTRACIÓN 2: Fábrica de Windows (manual)");
                Console.WriteLine("-----------------------------------------------");
                
                IGUIFactory windowsFactory = GUIFactoryProvider.GetFactory("windows");
                Application windowsApp = new Application(windowsFactory);
                
                windowsApp.CreateUI();
                windowsApp.RenderUI();
                windowsApp.InteractWithUI();
                windowsApp.ShowInfo();

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Demostración 3: Selección manual - Linux
                Console.WriteLine("🔧 DEMOSTRACIÓN 3: Fábrica de Linux (manual)");
                Console.WriteLine("---------------------------------------------");
                
                IGUIFactory linuxFactory = GUIFactoryProvider.GetFactory("linux");
                Application linuxApp = new Application(linuxFactory);
                
                linuxApp.CreateUI();
                linuxApp.RenderUI();
                linuxApp.InteractWithUI();
                linuxApp.ShowInfo();

                Console.WriteLine("\n" + new string('=', 50) + "\n");

                // Demostración interactiva
                Console.WriteLine("🎮 DEMOSTRACIÓN INTERACTIVA");
                Console.WriteLine("---------------------------");
                DemostracionInteractiva();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

            Console.WriteLine("\n🏁 ¡Demostración completada!");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void DemostracionInteractiva()
        {
            while (true)
            {
                Console.WriteLine("\nSelecciona el tipo de interfaz:");
                Console.WriteLine("1. Windows");
                Console.WriteLine("2. Linux");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                string? input = Console.ReadLine();
                
                if (input == "3" || string.IsNullOrEmpty(input))
                    break;

                try
                {
                    IGUIFactory factory = input switch
                    {
                        "1" => GUIFactoryProvider.GetFactory("windows"),
                        "2" => GUIFactoryProvider.GetFactory("linux"),
                        _ => throw new ArgumentException("Opción no válida")
                    };

                    Console.WriteLine($"\n🎯 Creando interfaz para {(input == "1" ? "Windows" : "Linux")}:");
                    
                    Application app = new Application(factory);
                    app.CreateUI();
                    app.RenderUI();
                    app.InteractWithUI();
                    app.ShowInfo();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error: {ex.Message}");
                }
            }
        }
    }
}
