using System;

namespace Builder;

public interface ICasaBuilder
{
    ICasaBuilder SetCantidadHabitaciones(int cantidadHabitaciones);
    ICasaBuilder SetCantidadBaños(int cantidadBaños);
    ICasaBuilder SetTieneGarage(bool tieneGarage);
    ICasaBuilder SetTieneJardin(bool tieneJardin);
    ICasaBuilder SetTienePiscina(bool tienePiscina);
    ICasaBuilder SetMetrosCuadrados(int metrosCuadrados);
    ICasaBuilder SetColor(string color);
    Casa Build();
}
