using BancoApp.Productos;

namespace BancoApp.Factories
{
    /// <summary>
    /// Factory abstracto para crear familias de productos bancarios
    /// </summary>
    public abstract class IBancoProductoFactory
    {
        public abstract ITarjetaCredito CrearTarjetaCredito();
        public abstract ICajaAhorro CrearCajaAhorro();
        public abstract ITarjetaDebito CrearTarjetaDebito();
        
        public virtual string ObtenerNombrePaquete()
        {
            return this.GetType().Name.Replace("Factory", "");
        }
    }
}
