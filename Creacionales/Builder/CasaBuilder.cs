using System;

namespace Builder;

public class CasaBuilder : ICasaBuilder
{
    Casa casa;

    public CasaBuilder()
    {
        casa = new Casa(0, 0, false, false, false, 0, "Blanco");
    }
    
    public ICasaBuilder SetCantidadHabitaciones(int cantidadHabitaciones)
    {
        casa.CantidadHabitaciones = cantidadHabitaciones;
        return this;
    }
    public ICasaBuilder SetCantidadBaños(int cantidadBaños)
    {   
        casa.CantidadBaños = cantidadBaños;
        return this;
    }

    public ICasaBuilder SetTieneGarage(bool tieneGarage)
    {
        casa.TieneGarage = tieneGarage;
        return this;
    }

    public ICasaBuilder SetTieneJardin(bool tieneJardin)
    {
        casa.TieneJardin = tieneJardin;
        return this;
    }

    public ICasaBuilder SetTienePiscina(bool tienePiscina)
    {
        casa.TienePiscina = tienePiscina;
        return this;
    }

    public ICasaBuilder SetMetrosCuadrados(int metrosCuadrados)
    {
        casa.MetrosCuadrados = metrosCuadrados;
        return this;
    }

    public ICasaBuilder SetColor(string color)
    {
        casa.Color = color;
        return this;
    }

    public Casa Build()
    {
        return casa;
    }
}
