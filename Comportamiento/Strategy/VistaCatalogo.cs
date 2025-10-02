using System;

namespace Strategy;

public class VistaCatalogo
{
    public List<VistaVehiculo> contenido;
    private DibujaCatalogo estrategia;

    public VistaCatalogo(DibujaCatalogo estrategia)
    {
        contenido = new List<VistaVehiculo>();
        contenido.Add(new VistaVehiculo("Auto"));
        contenido.Add(new VistaVehiculo("Camioneta"));
        contenido.Add(new VistaVehiculo("Camion"));
        contenido.Add(new VistaVehiculo("Moto"));
        contenido.Add(new VistaVehiculo("Bicicleta"));
        this.estrategia = estrategia;
    }
    
    public void Dibuja()
    {
        estrategia.Dibuja(contenido);
    }
    
    public void CambiarEstrategia(DibujaCatalogo nuevaEstrategia)
    {
        this.estrategia = nuevaEstrategia;
    }
}
