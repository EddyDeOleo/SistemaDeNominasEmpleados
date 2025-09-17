using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class NominaEmpleadoAsalariado : Nomina
    {
        public NominaEmpleadoAsalariado(EmpleadoAsalariado empleado) : base(empleado) { }

        public override decimal CalcularPago()
        {
            var emp = (EmpleadoAsalariado)Empleado;
            return emp.SalarioSemanal;
        }
    }
}


  
