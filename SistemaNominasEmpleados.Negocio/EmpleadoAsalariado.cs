using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class EmpleadoAsalariado : Empleado
    {
        // VARIABLE DE INSTANCIA EXTRA
        private decimal salarioSemanal;

        // CONSTRUCTOR SOBRECARGADO
        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, int numeroSeguroSocial, decimal salarioSemanal):base(primerNombre, apellidoPaterno, numeroSeguroSocial) {
       
            this.salarioSemanal = salarioSemanal;

        }

        // PROPIEDAD
        public decimal GSsalarioSemanal
        {
            get { return salarioSemanal; }
            set {
                if (value < 0)
                    throw new ArgumentException("El valor no puede ser negativo.");
                    salarioSemanal = value; }
        }

        // METODO ABSTRACTO
        public override decimal calcularPagoSemanal()
        {
            return this.salarioSemanal;
        }
    }
}
