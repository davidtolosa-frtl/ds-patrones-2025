using BancoApp.Productos;

namespace BancoApp.Productos.Gold
{
    public class TarjetaDebitoGold : ITarjetaDebito
    {
        private decimal _saldoDisponible = 25000m; // Saldo inicial para demo

        public string ObtenerTipo()
        {
            return "Tarjeta de Débito Gold";
        }

        public decimal ObtenerLimiteRetiroDiario()
        {
            return 50000m; // Límite superior para Gold
        }

        public decimal ObtenerComisionTransaccion()
        {
            return 0m; // Sin comisiones para Gold
        }

        public string ObtenerBeneficios()
        {
            return "• Compras sin costo en el mundo\n• Retiros gratuitos en cualquier cajero\n• Seguro de compras incluido\n• Descuentos en comercios adheridos";
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
            decimal descuento = monto * 0.01m; // 1% de descuento
            Console.WriteLine($"Compra realizada: ${monto:N2} - Descuento Gold: ${descuento:N2} - Saldo disponible: ${_saldoDisponible:N2}");
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
            Console.WriteLine($"Retiro realizado: ${monto:N2} - Sin comisiones - Saldo disponible: ${_saldoDisponible:N2}");
            return true;
        }
    }
}
