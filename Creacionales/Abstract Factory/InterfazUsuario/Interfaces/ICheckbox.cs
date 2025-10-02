namespace InterfazUsuario.Interfaces
{
    /// <summary>
    /// Interfaz para el producto abstracto Checkbox
    /// </summary>
    public interface ICheckbox
    {
        void Render();
        void Toggle();
        bool IsChecked { get; }
    }
}
