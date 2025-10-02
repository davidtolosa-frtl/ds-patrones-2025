namespace Adapter;

// El Adaptador hace compatible la interfaz del Adaptee con la interfaz ITarget
public class AdapterClass : ITarget
{
    private readonly Adaptee _adaptee;

    public AdapterClass(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    // Traduce la salida del Adaptee al formato que el cliente espera
    public string Request()
    {
        var reversed = _adaptee.SpecificRequest();
        // Convierte el texto invertido a su forma normal
        char[] arr = reversed.ToCharArray();
        System.Array.Reverse(arr);
        return new string(arr); // "IncSe de La Legue" -> "IncSe de La Legue" (de ejemplo)
    }
}
