using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class NominaEmpleadoPorHoras : Nomina
    {
        public NominaEmpleadoPorHoras(EmpleadoPorHoras empleado) : base(empleado) { }

        public override decimal CalcularPago()
        {
            var emp = (EmpleadoPorHoras)Empleado;

            if (emp.HorasTrabajadas <= 40)
                return emp.SueldoPorHora * emp.HorasTrabajadas;
            else
                return (emp.SueldoPorHora * 40) +
                       (emp.SueldoPorHora * 1.5m * (emp.HorasTrabajadas - 40));
        }
    }
}
