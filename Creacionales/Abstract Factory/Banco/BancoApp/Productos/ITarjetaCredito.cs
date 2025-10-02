namespace BancoApp.Productos
{
    /// <summary>
    /// Interfaz para las tarjetas de crédito
    /// </summary>
    public interface ITarjetaCredito
    {
        string ObtenerTipo();
        decimal ObtenerLimiteCredito();
        decimal ObtenerTasaInteres();
        string ObtenerBeneficios();
        void ProcesarPago(decimal monto);
    }
}
