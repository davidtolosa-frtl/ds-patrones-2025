using System;

namespace Observer;

public class Vehiculo : Sujeto
{
    private string descripcion;
    private string modelo;

    public Vehiculo(string modelo)
    {
        this.modelo = modelo;
        this.descripcion = string.Empty;
    }

    public void CambiarDescripcion(string nuevaDescripcion)
    {
        descripcion = nuevaDescripcion;
        NotificarObservadores($"El vehículo {modelo} ha cambiado su descripción a: {descripcion}");
    }
}
