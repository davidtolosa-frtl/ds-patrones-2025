using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Windows
{
    /// <summary>
    /// Implementación concreta de Checkbox para Windows
    /// </summary>
    public class WindowsCheckbox : ICheckbox
    {
        private bool _isChecked = false;

        public bool IsChecked => _isChecked;

        public void Render()
        {
            string checkState = _isChecked ? "☑" : "☐";
            Console.WriteLine($"🪟 Renderizando checkbox de Windows: {checkState} Opción Windows");
        }

        public void Toggle()
        {
            _isChecked = !_isChecked;
            Console.WriteLine($"💻 Checkbox de Windows {(_isChecked ? "seleccionado" : "deseleccionado")}");
        }
    }
}
