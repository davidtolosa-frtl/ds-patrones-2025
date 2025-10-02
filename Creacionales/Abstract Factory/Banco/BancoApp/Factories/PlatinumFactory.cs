using BancoApp.Productos;
using BancoApp.Productos.Platinum;

namespace BancoApp.Factories
{
    public class PlatinumFactory : IBancoProductoFactory
    {
        public override ITarjetaCredito CrearTarjetaCredito()
        {
            return new TarjetaCreditoPlatinum();
        }

        public override ICajaAhorro CrearCajaAhorro()
        {
            return new CajaAhorroPlatinum();
        }

        public override ITarjetaDebito CrearTarjetaDebito()
        {
            return new TarjetaDebitoPlatinum();
        }
    }
}
