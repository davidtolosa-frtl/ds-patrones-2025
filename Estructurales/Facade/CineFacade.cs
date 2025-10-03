namespace Facade;

/// <summary>
/// Facade que simplifica la interacción con el sistema complejo de cine en casa
/// Proporciona una interfaz unificada para controlar múltiples subsistemas
/// </summary>
public class CineFacade
{
    private readonly SistemaLuces _luces;
    private readonly SistemaSonido _sonido;
    private readonly Proyector _proyector;
    private readonly ReproductorStreaming _reproductor;
    private readonly SistemaButacas _butacas;

    public CineFacade()
    {
        _luces = new SistemaLuces();
        _sonido = new SistemaSonido();
        _proyector = new Proyector();
        _reproductor = new ReproductorStreaming();
        _butacas = new SistemaButacas();
    }

    /// <summary>
    /// Prepara todo el sistema para ver una película
    /// </summary>
    public void VerPelicula(string nombrePelicula)
    {
        Console.WriteLine("\n🎭 Preparando el cine en casa para ver la película...\n");

        _luces.Atenuar();
        _butacas.Reclinar();
        _proyector.Encender();
        _proyector.SeleccionarEntradaHDMI();
        _proyector.ModoWidescreen();
        _sonido.Encender();
        _sonido.SeleccionarModoSurround();
        _sonido.AjustarVolumen(8);
        _reproductor.Encender();
        _reproductor.ReproducirPelicula(nombrePelicula);

        Console.WriteLine("\n✅ ¡Todo listo! Disfruta tu película.\n");
    }

    /// <summary>
    /// Apaga todos los sistemas después de ver la película
    /// </summary>
    public void FinalizarPelicula()
    {
        Console.WriteLine("\n🎬 Finalizando sesión de cine...\n");

        _reproductor.Detener();
        _reproductor.Apagar();
        _sonido.Apagar();
        _proyector.Apagar();
        _butacas.Enderezar();
        _luces.Encender();

        Console.WriteLine("\n✅ Sistema apagado correctamente.\n");
    }

    /// <summary>
    /// Pausa la película manteniendo el sistema listo para reanudar
    /// </summary>
    public void PausarPelicula()
    {
        Console.WriteLine("\n⏸️  Pausando película...\n");

        _reproductor.Detener();
        _luces.Encender();

        Console.WriteLine("\n✅ Película pausada.\n");
    }
}
