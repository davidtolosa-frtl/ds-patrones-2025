using BancoApp.Factories;
using BancoApp.Models;

namespace BancoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA BANCARIO - PATRÓN ABSTRACT FACTORY ===");
            Console.WriteLine("Simulación de productos bancarios con diferentes paquetes\n");

            try
            {
                // Demostrar la creación de productos para diferentes paquetes
                DemostrarPaqueteClassic();
                DemostrarPaqueteGold();
                DemostrarPaquetePlatinum();

                // Demostrar transacciones
                DemostrarTransacciones();

                // Menú interactivo
                MenuInteractivo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void DemostrarPaqueteClassic()
        {
            Console.WriteLine("=== DEMOSTRACIÓN PAQUETE CLASSIC ===");
            
            var factory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Classic);
            var cliente = CrearCliente("Juan", "Pérez", "juan.perez@email.com", factory, "Classic");
            
            cliente.MostrarInformacion();
            Console.WriteLine(new string('=', 50));
        }

        static void DemostrarPaqueteGold()
        {
            Console.WriteLine("\n=== DEMOSTRACIÓN PAQUETE GOLD ===");
            
            var factory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Gold);
            var cliente = CrearCliente("María", "González", "maria.gonzalez@email.com", factory, "Gold");
            
            cliente.MostrarInformacion();
            Console.WriteLine(new string('=', 50));
        }

        static void DemostrarPaquetePlatinum()
        {
            Console.WriteLine("\n=== DEMOSTRACIÓN PAQUETE PLATINUM ===");
            
            var factory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Platinum);
            var cliente = CrearCliente("Carlos", "Rodríguez", "carlos.rodriguez@email.com", factory, "Platinum");
            
            cliente.MostrarInformacion();
            Console.WriteLine(new string('=', 50));
        }

        static void DemostrarTransacciones()
        {
            Console.WriteLine("\n=== DEMOSTRACIÓN DE TRANSACCIONES ===");
            
            var factoryGold = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Gold);
            var clienteGold = CrearCliente("Ana", "López", "ana.lopez@email.com", factoryGold, "Gold");

            Console.WriteLine("\n--- Transacciones con productos Gold ---");
            
            // Operaciones con Caja de Ahorro
            Console.WriteLine("\n• Operaciones Caja de Ahorro:");
            clienteGold.CajaAhorro?.Depositar(50000);
            clienteGold.CajaAhorro?.Depositar(25000);
            clienteGold.CajaAhorro?.Retirar(15000);

            // Operaciones con Tarjeta de Crédito
            Console.WriteLine("\n• Operaciones Tarjeta de Crédito:");
            clienteGold.TarjetaCredito?.ProcesarPago(5000);
            clienteGold.TarjetaCredito?.ProcesarPago(12000);

            // Operaciones con Tarjeta de Débito
            Console.WriteLine("\n• Operaciones Tarjeta de Débito:");
            clienteGold.TarjetaDebito?.RealizarCompra(8000);
            clienteGold.TarjetaDebito?.RetirarEfectivo(10000);

            Console.WriteLine(new string('=', 50));
        }

        static Cliente CrearCliente(string nombre, string apellido, string email, IBancoProductoFactory factory, string tipoPaquete)
        {
            var cliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                TipoPaquete = tipoPaquete,
                TarjetaCredito = factory.CrearTarjetaCredito(),
                CajaAhorro = factory.CrearCajaAhorro(),
                TarjetaDebito = factory.CrearTarjetaDebito()
            };

            return cliente;
        }

        static void MenuInteractivo()
        {
            Console.WriteLine("\n=== MENÚ INTERACTIVO ===");
            
            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Crear cliente con paquete Classic");
                Console.WriteLine("2. Crear cliente con paquete Gold");
                Console.WriteLine("3. Crear cliente con paquete Platinum");
                Console.WriteLine("4. Comparar paquetes");
                Console.WriteLine("5. Salir");
                
                Console.Write("Opción: ");
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearClienteInteractivo(TipoPaquete.Classic);
                        break;
                    case "2":
                        CrearClienteInteractivo(TipoPaquete.Gold);
                        break;
                    case "3":
                        CrearClienteInteractivo(TipoPaquete.Platinum);
                        break;
                    case "4":
                        CompararPaquetes();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void CrearClienteInteractivo(TipoPaquete tipoPaquete)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            var nombre = Console.ReadLine() ?? "Cliente";
            
            Console.Write("Ingrese el apellido del cliente: ");
            var apellido = Console.ReadLine() ?? "Ejemplo";
            
            Console.Write("Ingrese el email del cliente: ");
            var email = Console.ReadLine() ?? "cliente@email.com";

            var factory = BancoFactoryProvider.ObtenerFactory(tipoPaquete);
            var cliente = CrearCliente(nombre, apellido, email, factory, tipoPaquete.ToString());
            
            cliente.MostrarInformacion();
        }

        static void CompararPaquetes()
        {
            Console.WriteLine("\n=== COMPARACIÓN DE PAQUETES ===");
            
            var paquetes = new[] { TipoPaquete.Classic, TipoPaquete.Gold, TipoPaquete.Platinum };
            
            Console.WriteLine($"{"Característica",-25} {"Classic",-15} {"Gold",-15} {"Platinum",-15}");
            Console.WriteLine(new string('-', 70));
            
            foreach (var paquete in paquetes)
            {
                var factory = BancoFactoryProvider.ObtenerFactory(paquete);
                var tarjetaCredito = factory.CrearTarjetaCredito();
                var cajaAhorro = factory.CrearCajaAhorro();
                var tarjetaDebito = factory.CrearTarjetaDebito();

                if (paquete == TipoPaquete.Classic)
                {
                    Console.WriteLine($"{"Límite Crédito",-25} {tarjetaCredito.ObtenerLimiteCredito():C0,-15} {"",-15} {"",-15}");
                    Console.WriteLine($"{"Tasa Crédito",-25} {tarjetaCredito.ObtenerTasaInteres() + "%",-15} {"",-15} {"",-15}");
                    Console.WriteLine($"{"Tasa Ahorro",-25} {cajaAhorro.ObtenerTasaInteres() + "%",-15} {"",-15} {"",-15}");
                    Console.WriteLine($"{"Límite Retiro Diario",-25} {tarjetaDebito.ObtenerLimiteRetiroDiario():C0,-15} {"",-15} {"",-15}");
                }
                else if (paquete == TipoPaquete.Gold)
                {
                    var classicFactory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Classic);
                    var classicCredito = classicFactory.CrearTarjetaCredito();
                    var classicAhorro = classicFactory.CrearCajaAhorro();
                    var classicDebito = classicFactory.CrearTarjetaDebito();
                    
                    Console.WriteLine($"{"Límite Crédito",-25} {classicCredito.ObtenerLimiteCredito():C0,-15} {tarjetaCredito.ObtenerLimiteCredito():C0,-15} {"",-15}");
                    Console.WriteLine($"{"Tasa Crédito",-25} {classicCredito.ObtenerTasaInteres() + "%",-15} {tarjetaCredito.ObtenerTasaInteres() + "%",-15} {"",-15}");
                    Console.WriteLine($"{"Tasa Ahorro",-25} {classicAhorro.ObtenerTasaInteres() + "%",-15} {cajaAhorro.ObtenerTasaInteres() + "%",-15} {"",-15}");
                    Console.WriteLine($"{"Límite Retiro Diario",-25} {classicDebito.ObtenerLimiteRetiroDiario():C0,-15} {tarjetaDebito.ObtenerLimiteRetiroDiario():C0,-15} {"",-15}");
                }
                else if (paquete == TipoPaquete.Platinum)
                {
                    var classicFactory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Classic);
                    var goldFactory = BancoFactoryProvider.ObtenerFactory(TipoPaquete.Gold);
                    
                    var classicCredito = classicFactory.CrearTarjetaCredito();
                    var goldCredito = goldFactory.CrearTarjetaCredito();
                    
                    var classicAhorro = classicFactory.CrearCajaAhorro();
                    var goldAhorro = goldFactory.CrearCajaAhorro();
                    
                    var classicDebito = classicFactory.CrearTarjetaDebito();
                    var goldDebito = goldFactory.CrearTarjetaDebito();
                    
                    Console.WriteLine($"{"Límite Crédito",-25} {classicCredito.ObtenerLimiteCredito():C0,-15} {goldCredito.ObtenerLimiteCredito():C0,-15} {tarjetaCredito.ObtenerLimiteCredito():C0,-15}");
                    Console.WriteLine($"{"Tasa Crédito",-25} {classicCredito.ObtenerTasaInteres() + "%",-15} {goldCredito.ObtenerTasaInteres() + "%",-15} {tarjetaCredito.ObtenerTasaInteres() + "%",-15}");
                    Console.WriteLine($"{"Tasa Ahorro",-25} {classicAhorro.ObtenerTasaInteres() + "%",-15} {goldAhorro.ObtenerTasaInteres() + "%",-15} {cajaAhorro.ObtenerTasaInteres() + "%",-15}");
                    Console.WriteLine($"{"Límite Retiro Diario",-25} {classicDebito.ObtenerLimiteRetiroDiario():C0,-15} {goldDebito.ObtenerLimiteRetiroDiario():C0,-15} {tarjetaDebito.ObtenerLimiteRetiroDiario():C0,-15}");
                    break;
                }
            }
        }
    }
}
