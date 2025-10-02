using BancoApp.Productos;

namespace BancoApp.Productos.Platinum
{
    public class TarjetaDebitoPlatinum : ITarjetaDebito
    {
        private decimal _saldoDisponible = 100000m; // Saldo inicial para demo

        public string ObtenerTipo()
        {
            return "Tarjeta de Débito Platinum";
        }

        public decimal ObtenerLimiteRetiroDiario()
        {
            return 200000m; // Límite máximo para Platinum
        }

        public decimal ObtenerComisionTransaccion()
        {
            return 0m; // Sin comisiones para Platinum
        }

        public string ObtenerBeneficios()
        {
            return "• Transacciones ilimitadas sin costo mundial\n• Retiros sin límite en cualquier cajero\n• Seguro integral de compras y viaje\n• Acceso a eventos exclusivos\n• Concierge financiero personal";
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
            decimal descuento = monto * 0.03m; // 3% de descuento
            decimal puntos = monto * 3; // 3 puntos por peso
            Console.WriteLine($"Compra realizada: ${monto:N2} - Descuento Platinum: ${descuento:N2} - Puntos: {puntos:N0} - Saldo disponible: ${_saldoDisponible:N2}");
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
            Console.WriteLine($"Retiro realizado: ${monto:N2} - Servicio premium sin cargos - Saldo disponible: ${_saldoDisponible:N2}");
            return true;
        }
    }
}
