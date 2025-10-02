using System;

namespace CatalogoVehiculos;

public abstract class Automovil
{
    protected string modelo;
    protected string marca;
    protected int anio;

    public Automovil(string modelo, string marca, int anio)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.anio = anio;
    }

    public abstract void MostrarInformacion();
}
