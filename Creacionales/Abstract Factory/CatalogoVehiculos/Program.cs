using CatalogoVehiculos;

FabricaVehiculos fabricaVehiculos = new FabricaVehiculosHibrido();

Automovil auto = fabricaVehiculos.CrearAutomovil("Mustang", "Ford", 2021);
Scooter scooter = fabricaVehiculos.CrearScooter("Ninja", "Kawasaki", 250);

auto.MostrarInformacion();
scooter.MostrarInformacion();