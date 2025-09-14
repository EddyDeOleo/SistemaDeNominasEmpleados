using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        protected decimal salarioBase;

        // constructor

        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, int numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase) : base(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision){
        this.salarioBase = salarioBase;
        }

        // propiedades

        public decimal GSsalarioBase
        {
            get { return salarioBase ; } set
            {
                if (value < 0)
                    throw new ArgumentException("El valor no puede ser negativo.");
                salarioBase = value;
            }
        }

        // metodo abstracto

        
        public override decimal calcularPagoSemanal()
        {
            return (this.ventasBrutas * this.tarifaComision) + this.salarioBase + (this.salarioBase * 0.10M);
        }
    }
}
