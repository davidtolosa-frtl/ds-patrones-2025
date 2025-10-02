using Builder;

// Casa casa = new Casa(4, 3, true, true, false);
// Console.WriteLine(casa);

// // Output: Casa con 4 habitaciones, 3 baños, con garage, con jardín, sin piscina.

// Casa casa1 = new Casa(2, 1, false, false, false);
// Console.WriteLine(casa1);

Casa casa2 = new CasaBuilder()
    .SetColor("Azul")
    .SetCantidadBaños(1)
    .SetCantidadHabitaciones(2)
    .SetTieneJardin(false)
    .SetTienePiscina(false)
    .SetMetrosCuadrados(50)
    .Build();

Console.WriteLine(casa2.ToString());

// Output: Casa con 2 habitaciones, 1 baños, sin garage, sin jardín, sin piscina.