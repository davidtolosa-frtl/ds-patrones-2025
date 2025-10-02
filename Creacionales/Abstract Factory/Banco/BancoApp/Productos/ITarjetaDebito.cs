namespace BancoApp.Productos
{
    /// <summary>
    /// Interfaz para las tarjetas de débito
    /// </summary>
    public interface ITarjetaDebito
    {
        string ObtenerTipo();
        decimal ObtenerLimiteRetiroDiario();
        decimal ObtenerComisionTransaccion();
        string ObtenerBeneficios();
        bool RealizarCompra(decimal monto);
        bool RetirarEfectivo(decimal monto);
    }
}
