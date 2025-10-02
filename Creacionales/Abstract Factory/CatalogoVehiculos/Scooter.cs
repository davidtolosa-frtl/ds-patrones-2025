using System;

namespace CatalogoVehiculos;

public abstract class Scooter
{
    protected string modelo;
    protected string marca;
    protected int cilindrada;

    public Scooter(string modelo, string marca, int cilindrada)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.cilindrada = cilindrada;
    }

    public abstract void MostrarInformacion();
}
