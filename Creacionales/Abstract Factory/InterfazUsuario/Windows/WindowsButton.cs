using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Windows
{
    /// <summary>
    /// Implementación concreta de Button para Windows
    /// </summary>
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("🪟 Renderizando botón de Windows con estilo nativo de Windows");
            Console.WriteLine("   [  Botón Windows  ]");
        }

        public void OnClick()
        {
            Console.WriteLine("💻 Click en botón de Windows - Ejecutando acción específica de Windows");
        }
    }
}
