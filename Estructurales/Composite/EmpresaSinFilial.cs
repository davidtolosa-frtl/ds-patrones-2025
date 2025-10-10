using System;

namespace Composite;

public class EmpresaSinFilial : Empresa
{
    public override double calculaCosteMantenimiento()
    {
        return nVehiculos * costeUnitarioVehiculo;
    }

    public override bool agregaFilial(Empresa filial)
    {
        return false;
    }

}
