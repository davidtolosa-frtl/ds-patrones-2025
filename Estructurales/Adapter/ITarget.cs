namespace Adapter;

// La interfaz objetivo que el cliente conoce
public interface ITarget
{
    // Devuelve un mensaje "normalizado" que el cliente espera
    string Request();
}
