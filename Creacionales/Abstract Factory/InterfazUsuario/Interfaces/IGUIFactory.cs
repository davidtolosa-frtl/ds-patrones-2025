namespace InterfazUsuario.Interfaces
{
    /// <summary>
    /// Interfaz del Abstract Factory que define los métodos para crear
    /// familias de productos relacionados (UI Elements)
    /// </summary>
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
