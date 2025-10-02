using System;

namespace Builder;

public class Casa
{
    public int CantidadHabitaciones { get; set; }
    public int CantidadBaños { get; set; }
    public bool TieneGarage { get; set; }
    public bool TieneJardin { get; set; }
    public bool TienePiscina { get; set; }
    public int MetrosCuadrados { get; set; }

    public string Color { get; set; }

    public Casa(int cantidadHabitaciones, int cantidadBaños, bool tieneGarage, bool tieneJardin, bool tienePiscina, int metrosCuadrados, string color)
    {
        CantidadHabitaciones = cantidadHabitaciones;
        CantidadBaños = cantidadBaños;
        TieneGarage = tieneGarage;
        TieneJardin = tieneJardin;
        TienePiscina = tienePiscina;
        MetrosCuadrados = metrosCuadrados;
        Color = color;
    }
    public override string ToString()
    {
        return $"Casa con {CantidadHabitaciones} habitaciones, {CantidadBaños} baños, " +
               $"{(TieneGarage ? "con" : "sin")} garage, " +
               $"{(TieneJardin ? "con" : "sin")} jardín, " +
               $"{(TienePiscina ? "con" : "sin")} piscina." +
               $" Color: {Color}, Metros cuadrados: {MetrosCuadrados}.";
    }
}
