using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public abstract class Nomina
    {
        protected Empleado Empleado { get; }

        protected Nomina(Empleado empleado)
        {
            Empleado = empleado;
        }

        public abstract decimal CalcularPago();

        public override string ToString()
        {
            return $"{Empleado} - Pago semanal: {CalcularPago():C}";
        }
    }
}
