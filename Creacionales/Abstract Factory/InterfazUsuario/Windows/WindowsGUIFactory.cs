using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Windows
{
    /// <summary>
    /// Fábrica concreta para crear elementos de UI de Windows
    /// </summary>
    public class WindowsGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
