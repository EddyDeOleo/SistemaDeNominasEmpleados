using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominasEmpleados.Negocio
{
    public abstract class Empleado
    {
        // VARIABLES DE INSTANCIA
        protected string primerNombre;
        protected string apellidoPaterno;
        protected int numeroSeguroSocial;

        //CONSTRUCTORES
        public Empleado(string primerNombre, string apellidoPaterno, int numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        public Empleado(string apellidoPaterno, int numeroSeguroSocial)
        {
            this.primerNombre = "EPH";
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }


        // PROPIEDADES
        public string GS_primerNombre
        {
            get { return primerNombre; }
            set { primerNombre = value; }
        }

        public string GS_apellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }    
        }

        public int GS_numeroSeguroSocial
        {
            get { return numeroSeguroSocial; }

            set {
                if (value > 9999999 && value < 1000000)
                    throw new ArgumentException($"El valor ingresado: {value} debe contener 7 digitos...");
                    numeroSeguroSocial = value; }
        }

        // METODO ABSTRACTO

        public abstract decimal calcularPagoSemanal();
        
        


    }
}
