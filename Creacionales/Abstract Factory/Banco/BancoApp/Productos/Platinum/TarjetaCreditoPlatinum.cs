using BancoApp.Productos;

namespace BancoApp.Productos.Platinum
{
    public class TarjetaCreditoPlatinum : ITarjetaCredito
    {
        private decimal _saldoUtilizado = 0;

        public string ObtenerTipo()
        {
            return "Tarjeta de Crédito Platinum";
        }

        public decimal ObtenerLimiteCredito()
        {
            return 500000m; // Límite premium para Platinum
        }

        public decimal ObtenerTasaInteres()
        {
            return 18.0m; // 18% anual (la mejor tasa)
        }

        public string ObtenerBeneficios()
        {
            return "• Sin límite de cuota anual\n• Cashback 5% en todas las compras\n• Acceso a salas VIP en aeropuertos\n• Concierge 24/7\n• Seguro de vida y viaje premium\n• Puntos que no vencen";
        }

        public void ProcesarPago(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            if (_saldoUtilizado + monto > ObtenerLimiteCredito())
                throw new InvalidOperationException("Excede el límite de crédito disponible");

            _saldoUtilizado += monto;
            decimal cashback = monto * 0.05m; // 5% de cashback
            decimal puntos = monto * 2; // 2 puntos por peso
            Console.WriteLine($"Pago procesado: ${monto:N2} - Cashback: ${cashback:N2} - Puntos: {puntos:N0} - Saldo utilizado: ${_saldoUtilizado:N2}");
        }
    }
}
