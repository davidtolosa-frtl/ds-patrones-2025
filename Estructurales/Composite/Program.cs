using Composite;

Empresa empresaSinFilial1 = new EmpresaSinFilial();
empresaSinFilial1.agregaVehiculo();
empresaSinFilial1.agregaVehiculo();
empresaSinFilial1.agregaVehiculo();

Console.WriteLine($"Coste mantenimiento empresa 1: {empresaSinFilial1.calculaCosteMantenimiento()}");

Empresa empresaSinFilial2 = new EmpresaSinFilial();
empresaSinFilial2.agregaVehiculo();
empresaSinFilial2.agregaVehiculo();
empresaSinFilial2.agregaVehiculo();
empresaSinFilial2.agregaVehiculo();

Console.WriteLine($"Coste mantenimiento empresa 2: {empresaSinFilial2.calculaCosteMantenimiento()}");

Empresa empresaMadre = new EmpresaMadre();
empresaMadre.agregaVehiculo();
empresaMadre.agregaVehiculo();
    
empresaMadre.agregaFilial(empresaSinFilial1);
empresaMadre.agregaFilial(empresaSinFilial2);

Console.WriteLine($"Coste mantenimiento empresa madre: {empresaMadre.calculaCosteMantenimiento()}");