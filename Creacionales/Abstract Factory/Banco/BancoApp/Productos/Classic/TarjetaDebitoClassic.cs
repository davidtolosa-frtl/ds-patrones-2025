using BancoApp.Productos;

namespace BancoApp.Productos.Classic
{
    public class TarjetaDebitoClassic : ITarjetaDebito
    {
        private decimal _saldoDisponible = 10000m; // Saldo inicial para demo

        public string ObtenerTipo()
        {
            return "Tarjeta de Débito Classic";
        }

        public decimal ObtenerLimiteRetiroDiario()
        {
            return 20000m;
        }

        public decimal ObtenerComisionTransaccion()
        {
            return 50m; // $50 por transacción en otros bancos
        }

        public string ObtenerBeneficios()
        {
            return "• Compras sin costo adicional\n• Retiros gratuitos en cajeros propios\n• Consultas de saldo ilimitadas";
        }

        public bool RealizarCompra(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            if (monto > _saldoDisponible)
            {
                Console.WriteLine("Fondos insuficientes para la compra");
                return false;
            }

            _saldoDisponible -= monto;
            Console.WriteLine($"Compra realizada: ${monto:N2} - Saldo disponible: ${_saldoDisponible:N2}");
            return true;
        }

        public bool RetirarEfectivo(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            if (monto > ObtenerLimiteRetiroDiario())
            {
                Console.WriteLine($"Excede el límite diario de retiro (${ObtenerLimiteRetiroDiario():N2})");
                return false;
            }

            if (monto > _saldoDisponible)
            {
                Console.WriteLine("Fondos insuficientes");
                return false;
            }

            _saldoDisponible -= monto;
            Console.WriteLine($"Retiro realizado: ${monto:N2} - Saldo disponible: ${_saldoDisponible:N2}");
            return true;
        }
    }
}
