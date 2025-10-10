using System;

namespace Composite;

public class EmpresaMadre : Empresa
{
    private List<Empresa> filiales = new List<Empresa>();

    public override double calculaCosteMantenimiento()
    {
        double costeTotal = 0;
        foreach (var filial in filiales)
        {
            costeTotal += filial.calculaCosteMantenimiento();
        }
        return costeTotal + (nVehiculos * costeUnitarioVehiculo);
    }

    public override bool agregaFilial(Empresa filial)
    {
        filiales.Add(filial);
        return true;
    }

}
