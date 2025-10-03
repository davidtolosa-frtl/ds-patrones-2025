namespace Facade;

// Subsistema 1: Sistema de Luces
public class SistemaLuces
{
    public void Atenuar()
    {
        Console.WriteLine("🔅 Luces atenuadas al 20%");
    }

    public void Encender()
    {
        Console.WriteLine("💡 Luces encendidas al 100%");
    }
}

// Subsistema 2: Sistema de Sonido
public class SistemaSonido
{
    public void Encender()
    {
        Console.WriteLine("🔊 Sistema de sonido encendido");
    }

    public void Apagar()
    {
        Console.WriteLine("🔇 Sistema de sonido apagado");
    }

    public void AjustarVolumen(int nivel)
    {
        Console.WriteLine($"🎚️  Volumen ajustado a {nivel}");
    }

    public void SeleccionarModoSurround()
    {
        Console.WriteLine("🎵 Modo Surround 5.1 activado");
    }
}

// Subsistema 3: Proyector
public class Proyector
{
    public void Encender()
    {
        Console.WriteLine("📽️  Proyector encendido");
    }

    public void Apagar()
    {
        Console.WriteLine("⏻  Proyector apagado");
    }

    public void SeleccionarEntradaHDMI()
    {
        Console.WriteLine("🔌 Entrada HDMI seleccionada");
    }

    public void ModoWidescreen()
    {
        Console.WriteLine("📺 Modo Widescreen 16:9 activado");
    }
}

// Subsistema 4: Reproductor de Streaming
public class ReproductorStreaming
{
    public void Encender()
    {
        Console.WriteLine("📱 Reproductor de streaming encendido");
    }

    public void Apagar()
    {
        Console.WriteLine("📴 Reproductor de streaming apagado");
    }

    public void ReproducirPelicula(string pelicula)
    {
        Console.WriteLine($"🎬 Reproduciendo: '{pelicula}'");
    }

    public void Detener()
    {
        Console.WriteLine("⏹️  Reproducción detenida");
    }
}

// Subsistema 5: Sistema de Butacas
public class SistemaButacas
{
    public void Reclinar()
    {
        Console.WriteLine("🪑 Butacas reclinadas para máxima comodidad");
    }

    public void Enderezar()
    {
        Console.WriteLine("🪑 Butacas en posición vertical");
    }
}
