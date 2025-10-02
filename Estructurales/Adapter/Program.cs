using Adapter;

// Ejemplo simple del patrón Adapter en C#

Adaptee adaptee = new();
ITarget target = new AdapterClass(adaptee);

Console.WriteLine("Cliente: Trabajo con la interfaz ITarget.");
Console.WriteLine("Resultado (sin conocer Adaptee): " + target.Request());

// También podemos mostrar qué pasaría si el cliente intentara usar Adaptee directamente
Console.WriteLine("\n(Para comparar) Adaptee expone: " + adaptee.SpecificRequest());
Console.WriteLine("\nFin del ejemplo Adapter.");

