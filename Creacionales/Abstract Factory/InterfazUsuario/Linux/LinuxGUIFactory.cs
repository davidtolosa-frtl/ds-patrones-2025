using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Linux
{
    /// <summary>
    /// Fábrica concreta para crear elementos de UI de Linux
    /// </summary>
    public class LinuxGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }
    }
}
