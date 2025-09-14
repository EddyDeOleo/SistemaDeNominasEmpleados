using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class EmpleadoPorComision : Empleado
    {
        protected decimal ventasBrutas;
        protected decimal tarifaComision;


        //constructor
        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, int numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision) : base(primerNombre, apellidoPaterno, numeroSeguroSocial) { 
        
            this.ventasBrutas = ventasBrutas;
            this.tarifaComision= tarifaComision;
        }

        // propiedad

        public decimal GSventasBrutas
        {

            get { return ventasBrutas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El valor no puede ser negativo.");
                ventasBrutas = value;
            }
        }

        public decimal GStarifaComision
        {

            get { return tarifaComision; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El valor no puede ser negativo.");
                tarifaComision = value;
            }
        }

        // METODO ABSTRACTO


        public override decimal calcularPagoSemanal()
        {
            return this.ventasBrutas * this.tarifaComision;
        }
    }
}
