using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class NominaEmpleadoPorComision : Nomina
    {
        public NominaEmpleadoPorComision(EmpleadoPorComision empleado) : base(empleado) { }

        public override decimal CalcularPago()
        {
            var emp = (EmpleadoPorComision)Empleado;
            return emp.VentasBrutas * emp.TarifaComision;
        }
    }
}
