using BancoApp.Productos;
using BancoApp.Productos.Gold;

namespace BancoApp.Factories
{
    public class GoldFactory : IBancoProductoFactory
    {
        public override ITarjetaCredito CrearTarjetaCredito()
        {
            return new TarjetaCreditoGold();
        }

        public override ICajaAhorro CrearCajaAhorro()
        {
            return new CajaAhorroGold();
        }

        public override ITarjetaDebito CrearTarjetaDebito()
        {
            return new TarjetaDebitoGold();
        }
    }
}
