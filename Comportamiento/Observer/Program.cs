using Observer;

Console.WriteLine("=== Patrón Observer - Sistema de Notificaciones de Vehículos ===\n");

// Crear el sujeto (vehículo)
Vehiculo vehiculo = new Vehiculo("Tesla Model 3");

// Crear observadores
ClienteNotificaciones cliente1 = new ClienteNotificaciones("Juan Pérez");
ClienteNotificaciones cliente2 = new ClienteNotificaciones("María García");
SistemaAlarma alarma = new SistemaAlarma();
RegistroLog log = new RegistroLog();

// Suscribir observadores al vehículo
Console.WriteLine("Suscribiendo observadores...\n");
vehiculo.AgregarObservador(cliente1);
vehiculo.AgregarObservador(cliente2);
vehiculo.AgregarObservador(alarma);
vehiculo.AgregarObservador(log);

// Cambiar descripción del vehículo (notifica a todos)
Console.WriteLine("--- Primer cambio ---");
vehiculo.CambiarDescripcion("Disponible para entrega inmediata");

Console.WriteLine("\n--- Segundo cambio ---");
vehiculo.CambiarDescripcion("En mantenimiento programado");

// Eliminar un observador
Console.WriteLine("\n--- Eliminando cliente1 ---");
vehiculo.EliminarObservador(cliente1);

Console.WriteLine("\n--- Tercer cambio (sin cliente1) ---");
vehiculo.CambiarDescripcion("Listo para prueba de manejo");

Console.WriteLine("\n=== Fin de la demostración ===");
