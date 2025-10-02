using BancoApp.Productos;

namespace BancoApp.Productos.Gold
{
    public class CajaAhorroGold : ICajaAhorro
    {
        private decimal _saldo = 0;

        public string ObtenerTipo()
        {
            return "Caja de Ahorro Gold";
        }

        public decimal ObtenerTasaInteres()
        {
            return 22.0m; // 22% anual (mejor que Classic)
        }

        public decimal ObtenerMontoMinimoApertura()
        {
            return 15000m;
        }

        public string ObtenerBeneficios()
        {
            return "• Extracciones ilimitadas sin costo\n• Transferencias internacionales\n• Asesor financiero personal\n• Homebanking premium\n• Chequera incluida";
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            _saldo += monto;
            decimal interesBonificado = monto * 0.001m; // Bonificación del 0.1% por depósito
            Console.WriteLine($"Depósito realizado: ${monto:N2} - Bonificación: ${interesBonificado:N2} - Saldo actual: ${_saldo:N2}");
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
