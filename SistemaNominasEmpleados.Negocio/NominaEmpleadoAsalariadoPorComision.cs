using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class NominaEmpleadoAsalariadoPorComision : Nomina
    {
        public NominaEmpleadoAsalariadoPorComision(EmpleadoAsalariadoPorComision empleado) : base(empleado) { }

        public override decimal CalcularPago()
        {
            var emp = (EmpleadoAsalariadoPorComision)Empleado;
            return (emp.VentasBrutas * emp.TarifaComision) + emp.SalarioBase + (emp.SalarioBase * 0.10m);
        }
    }
}
