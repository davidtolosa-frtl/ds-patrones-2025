using BancoApp.Productos;

namespace BancoApp.Productos.Classic
{
    public class TarjetaCreditoClassic : ITarjetaCredito
    {
        private decimal _saldoUtilizado = 0;

        public string ObtenerTipo()
        {
            return "Tarjeta de Crédito Classic";
        }

        public decimal ObtenerLimiteCredito()
        {
            return 50000m; // Límite básico para Classic
        }

        public decimal ObtenerTasaInteres()
        {
            return 35.0m; // 35% anual
        }

        public string ObtenerBeneficios()
        {
            return "• Sin cuota anual el primer año\n• Descuentos en supermercados\n• Asistencia básica";
        }

        public void ProcesarPago(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            if (_saldoUtilizado + monto > ObtenerLimiteCredito())
                throw new InvalidOperationException("Excede el límite de crédito disponible");

            _saldoUtilizado += monto;
            Console.WriteLine($"Pago procesado: ${monto:N2} - Saldo utilizado: ${_saldoUtilizado:N2}");
        }
    }
}
