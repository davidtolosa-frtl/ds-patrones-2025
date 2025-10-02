using BancoApp.Productos;

namespace BancoApp.Productos.Gold
{
    public class TarjetaCreditoGold : ITarjetaCredito
    {
        private decimal _saldoUtilizado = 0;

        public string ObtenerTipo()
        {
            return "Tarjeta de Crédito Gold";
        }

        public decimal ObtenerLimiteCredito()
        {
            return 150000m; // Límite mejorado para Gold
        }

        public decimal ObtenerTasaInteres()
        {
            return 28.0m; // 28% anual (mejor que Classic)
        }

        public string ObtenerBeneficios()
        {
            return "• Sin cuota anual permanente\n• Cashback 2% en todas las compras\n• Descuentos en restaurantes\n• Seguro de viaje incluido\n• Asistencia 24/7";
        }

        public void ProcesarPago(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            if (_saldoUtilizado + monto > ObtenerLimiteCredito())
                throw new InvalidOperationException("Excede el límite de crédito disponible");

            _saldoUtilizado += monto;
            decimal cashback = monto * 0.02m; // 2% de cashback
            Console.WriteLine($"Pago procesado: ${monto:N2} - Cashback: ${cashback:N2} - Saldo utilizado: ${_saldoUtilizado:N2}");
        }
    }
}
