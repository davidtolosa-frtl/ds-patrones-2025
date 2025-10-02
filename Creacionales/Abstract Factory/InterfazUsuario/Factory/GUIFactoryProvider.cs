using InterfazUsuario.Interfaces;
using InterfazUsuario.Windows;
using InterfazUsuario.Linux;
using System.Runtime.InteropServices;

namespace InterfazUsuario.Factory
{
    /// <summary>
    /// Clase utilitaria para crear la fábrica apropiada según el sistema operativo
    /// </summary>
    public static class GUIFactoryProvider
    {
        public static IGUIFactory GetFactory()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.WriteLine("🪟 Sistema operativo detectado: Windows");
                return new WindowsGUIFactory();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Console.WriteLine("🐧 Sistema operativo detectado: Linux");
                return new LinuxGUIFactory();
            }
            else
            {
                Console.WriteLine("❓ Sistema operativo no reconocido, usando fábrica de Windows por defecto");
                return new WindowsGUIFactory();
            }
        }

        public static IGUIFactory GetFactory(string osType)
        {
            return osType.ToLower() switch
            {
                "windows" => new WindowsGUIFactory(),
                "linux" => new LinuxGUIFactory(),
                _ => throw new ArgumentException($"Tipo de SO no soportado: {osType}")
            };
        }
    }
}
