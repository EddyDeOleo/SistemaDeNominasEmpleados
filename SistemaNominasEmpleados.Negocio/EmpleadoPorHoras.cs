using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public class EmpleadoPorHoras : Empleado
    {

        private decimal sueldoPorHora;
        private int horasTrabajadas;

        public EmpleadoPorHoras(string apellidoPaterno, int numeroSeguroSocial, decimal sueldoPorHora, int horasTrabajadas) : base(apellidoPaterno, numeroSeguroSocial)
        {
            this.sueldoPorHora = sueldoPorHora;
            this.horasTrabajadas = horasTrabajadas;
        }
        // PROPIEDADES

        public decimal GSsueldoPorHora{

            get {return sueldoPorHora; } 
            set
            {
                if (value < 0)
                throw new ArgumentException("El valor no puede ser negativo.");
                sueldoPorHora = value;
            }
        }

        public int GShorasTrabajadas
        {

            get { return horasTrabajadas; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El valor no puede ser negativo.");
                horasTrabajadas = value;
            }
        }


        // METODO ABSTRACTO 
        public override decimal calcularPagoSemanal()
        {
            if (this.horasTrabajadas <= 40 && this.horasTrabajadas > 0)
            {
                return this.sueldoPorHora * this.horasTrabajadas;
            } else if (this.horasTrabajadas > 40)
            {
                return (this.sueldoPorHora * 40) + (this.sueldoPorHora * 1.5M * (this.horasTrabajadas - 40));
            } else
            {
                return 0;
            }
        }

    }
}
