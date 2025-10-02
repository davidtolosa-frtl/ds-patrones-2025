using BancoApp.Productos;
using BancoApp.Productos.Classic;

namespace BancoApp.Factories
{
    public class ClassicFactory : IBancoProductoFactory
    {
        public override ITarjetaCredito CrearTarjetaCredito()
        {
            return new TarjetaCreditoClassic();
        }

        public override ICajaAhorro CrearCajaAhorro()
        {
            return new CajaAhorroClassic();
        }

        public override ITarjetaDebito CrearTarjetaDebito()
        {
            return new TarjetaDebitoClassic();
        }
    }
}
