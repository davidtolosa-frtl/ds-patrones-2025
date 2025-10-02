using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Linux
{
    /// <summary>
    /// Implementación concreta de Checkbox para Linux
    /// </summary>
    public class LinuxCheckbox : ICheckbox
    {
        private bool _isChecked = false;

        public bool IsChecked => _isChecked;

        public void Render()
        {
            string checkState = _isChecked ? "[X]" : "[ ]";
            Console.WriteLine($"🐧 Renderizando checkbox de Linux: {checkState} Opción Linux");
        }

        public void Toggle()
        {
            _isChecked = !_isChecked;
            Console.WriteLine($"🖱️ Checkbox de Linux {(_isChecked ? "activado" : "desactivado")}");
        }
    }
}
