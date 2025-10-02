using BancoApp.Productos;

namespace BancoApp.Models
{
    public class Cliente
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string TipoPaquete { get; set; } = string.Empty;
        
        public ITarjetaCredito? TarjetaCredito { get; set; }
        public ICajaAhorro? CajaAhorro { get; set; }
        public ITarjetaDebito? TarjetaDebito { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"\n=== INFORMACIÓN DEL CLIENTE ===");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Paquete: {TipoPaquete}");
            
            if (TarjetaCredito != null)
            {
                Console.WriteLine($"\n--- {TarjetaCredito.ObtenerTipo()} ---");
                Console.WriteLine($"Límite de crédito: ${TarjetaCredito.ObtenerLimiteCredito():N2}");
                Console.WriteLine($"Tasa de interés: {TarjetaCredito.ObtenerTasaInteres()}% anual");
                Console.WriteLine($"Beneficios:\n{TarjetaCredito.ObtenerBeneficios()}");
            }

            if (CajaAhorro != null)
            {
                Console.WriteLine($"\n--- {CajaAhorro.ObtenerTipo()} ---");
                Console.WriteLine($"Tasa de interés: {CajaAhorro.ObtenerTasaInteres()}% anual");
                Console.WriteLine($"Monto mínimo apertura: ${CajaAhorro.ObtenerMontoMinimoApertura():N2}");
                Console.WriteLine($"Saldo actual: ${CajaAhorro.ConsultarSaldo():N2}");
                Console.WriteLine($"Beneficios:\n{CajaAhorro.ObtenerBeneficios()}");
            }

            if (TarjetaDebito != null)
            {
                Console.WriteLine($"\n--- {TarjetaDebito.ObtenerTipo()} ---");
                Console.WriteLine($"Límite retiro diario: ${TarjetaDebito.ObtenerLimiteRetiroDiario():N2}");
                Console.WriteLine($"Comisión transacción: ${TarjetaDebito.ObtenerComisionTransaccion():N2}");
                Console.WriteLine($"Beneficios:\n{TarjetaDebito.ObtenerBeneficios()}");
            }
        }
    }
}
