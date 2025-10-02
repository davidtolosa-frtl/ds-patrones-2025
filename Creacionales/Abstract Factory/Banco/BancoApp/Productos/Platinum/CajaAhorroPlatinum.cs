using BancoApp.Productos;

namespace BancoApp.Productos.Platinum
{
    public class CajaAhorroPlatinum : ICajaAhorro
    {
        private decimal _saldo = 0;

        public string ObtenerTipo()
        {
            return "Caja de Ahorro Platinum";
        }

        public decimal ObtenerTasaInteres()
        {
            return 30.0m; // 30% anual (la mejor tasa)
        }

        public decimal ObtenerMontoMinimoApertura()
        {
            return 50000m;
        }

        public string ObtenerBeneficios()
        {
            return "• Gestión de patrimonio personalizada\n• Acceso a inversiones exclusivas\n• Asesor financiero dedicado\n• Homebanking empresarial\n• Chequera y tarjetas premium\n• Seguros incluidos";
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            _saldo += monto;
            decimal interesBonificado = monto * 0.005m; // Bonificación del 0.5% por depósito
            decimal puntos = monto * 1.5m; // 1.5 puntos por peso depositado
            Console.WriteLine($"Depósito realizado: ${monto:N2} - Bonificación: ${interesBonificado:N2} - Puntos: {puntos:N0} - Saldo actual: ${_saldo:N2}");
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
            Console.WriteLine($"Retiro realizado: ${monto:N2} - Gestión premium sin costos - Saldo actual: ${_saldo:N2}");
            return true;
        }

        public decimal ConsultarSaldo()
        {
            return _saldo;
        }
    }
}
