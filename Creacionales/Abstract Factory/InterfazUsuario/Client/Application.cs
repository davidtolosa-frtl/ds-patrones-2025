using InterfazUsuario.Interfaces;

namespace InterfazUsuario.Client
{
    /// <summary>
    /// Cliente que utiliza la fábrica abstracta para crear elementos de UI
    /// sin conocer las implementaciones concretas
    /// </summary>
    public class Application
    {
        private readonly IGUIFactory _factory;
        private IButton? _button;
        private ICheckbox? _checkbox;

        public Application(IGUIFactory factory)
        {
            _factory = factory;
        }

        public void CreateUI()
        {
            Console.WriteLine("🚀 Creando interfaz de usuario...\n");
            
            _button = _factory.CreateButton();
            _checkbox = _factory.CreateCheckbox();
            
            Console.WriteLine("✅ Elementos de UI creados exitosamente\n");
        }

        public void RenderUI()
        {
            Console.WriteLine("🎨 Renderizando interfaz de usuario:");
            Console.WriteLine("=====================================");
            
            _button?.Render();
            _checkbox?.Render();
            
            Console.WriteLine("=====================================\n");
        }

        public void InteractWithUI()
        {
            Console.WriteLine("🖱️ Simulando interacciones con la UI:");
            Console.WriteLine("======================================");
            
            // Interacción con el botón
            _button?.OnClick();
            
            // Interacción con el checkbox
            _checkbox?.Toggle();
            _checkbox?.Render();
            
            _checkbox?.Toggle();
            _checkbox?.Render();
            
            Console.WriteLine("======================================\n");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"📊 Estado del checkbox: {(_checkbox?.IsChecked == true ? "Seleccionado" : "No seleccionado")}");
        }
    }
}
