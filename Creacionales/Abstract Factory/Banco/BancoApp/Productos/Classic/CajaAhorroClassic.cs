using BancoApp.Productos;

namespace BancoApp.Productos.Classic
{
    public class CajaAhorroClassic : ICajaAhorro
    {
        private decimal _saldo = 0;

        public string ObtenerTipo()
        {
            return "Caja de Ahorro Classic";
        }

        public decimal ObtenerTasaInteres()
        {
            return 15.0m; // 15% anual
        }

        public decimal ObtenerMontoMinimoApertura()
        {
            return 5000m;
        }

        public string ObtenerBeneficios()
        {
            return "• Hasta 5 extracciones gratuitas por mes\n• Transferencias gratuitas\n• Homebanking básico";
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            _saldo += monto;
            Console.WriteLine($"Depósito realizado: ${monto:N2} - Saldo actual: ${_saldo:N2}");
        }

        public bool Retirar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            if (monto > _saldo)
            {
                Console.WriteLine("Fondos insuficientes");
                return false;
            }

            _saldo -= monto;
            Console.WriteLine($"Retiro realizado: ${monto:N2} - Saldo actual: ${_saldo:N2}");
            return true;
        }

        public decimal ConsultarSaldo()
        {
            return _saldo;
        }
    }
}
