namespace BancoApp.Productos
{
    /// <summary>
    /// Interfaz para las cajas de ahorro
    /// </summary>
    public interface ICajaAhorro
    {
        string ObtenerTipo();
        decimal ObtenerTasaInteres();
        decimal ObtenerMontoMinimoApertura();
        string ObtenerBeneficios();
        void Depositar(decimal monto);
        bool Retirar(decimal monto);
        decimal ConsultarSaldo();
    }
}
