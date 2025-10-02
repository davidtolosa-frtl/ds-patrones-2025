using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Linux
{
    /// <summary>
    /// Implementación concreta de Button para Linux
    /// </summary>
    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("🐧 Renderizando botón de Linux con estilo GTK/Qt");
            Console.WriteLine("   |  Botón Linux  |");
        }

        public void OnClick()
        {
            Console.WriteLine("🖱️ Click en botón de Linux - Ejecutando acción específica de Linux");
        }
    }
}
