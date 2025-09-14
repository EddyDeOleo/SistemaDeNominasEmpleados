using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaNominasEmpleados.Negocio;

namespace SistemaNominasEmpleados.MenuSystem
{
    public static class Menu
    {
        public static void mostrarMenu()
        {

            byte opcion, opcionsecundaria;
            string primerNombre, apellidoPaterno;
            int numeroSeguroSocial, horasTrabajadas;
            decimal salarioSemanal, sueldoPorHora, ventasBrutas, tarifaComision, salarioBase;

            List<Empleado> empleados = new List<Empleado>();

            List<EmpleadoAsalariado> asalariados = new List<EmpleadoAsalariado>();
            List<EmpleadoPorComision> comosionaros = new List<EmpleadoPorComision>();
            List<EmpleadoAsalariadoPorComision> comisionarios_asalariados = new List<EmpleadoAsalariadoPorComision>();
            List<EmpleadoPorHoras> empleadosporhoras = new List<EmpleadoPorHoras>();



            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("*~~ SISTEMA DE NOMINAS DE EMPLEADOS ~~* \n[1] AGREGAR EMPLEADOS \n[2] GENERAR REPORTE \n[3] ELIMINAR EMPLEADOS \n[4] EDITAR EMPLEADOS \n[5] PROBAR RENDIMIENTO \n[6] SALIR");

                Console.WriteLine("ELIGE UNA OPCION:");
                string input = Console.ReadLine();
                bool exito = byte.TryParse(input, out opcion);

                if (exito)
                {
                    Console.WriteLine("Tu opcion es: " + opcion);

                    switch (opcion)
                    {

                        case 1:

                            do
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("*~~ TIPOS DE EMPLEADOS ~~* \n[1] EMPLEADO ASALARIADO \n[2] EMPLEADO POR COMISION \n[3] EMPLEADO ASALARIADO POR COMISION \n[4] EMPLEADO POR HORA \n[5] SALIR");
                                Console.WriteLine("ELIGE UNA OPCION:");

                                input = Console.ReadLine();
                                exito = byte.TryParse(input, out opcionsecundaria);

                                if (exito)
                                {

                                    switch (opcionsecundaria)
                                    {

                                        case 1:

                                            Console.WriteLine("INGRESA EL PRIMER NOMBRE DEL EMPLEADO");
                                            primerNombre = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                            apellidoPaterno = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                            numeroSeguroSocial = int.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA EL SALARIO SEMANAL DEL EMPLEADO");
                                            salarioSemanal = decimal.Parse(Console.ReadLine());

                                            EmpleadoAsalariado emp_as = new EmpleadoAsalariado(primerNombre, apellidoPaterno, numeroSeguroSocial, salarioSemanal);

                                            Console.WriteLine($"NOMBRE: {emp_as.GS_primerNombre} \nAPELLIDO: {emp_as.GS_apellidoPaterno} \nNSS: {emp_as.GS_numeroSeguroSocial} \nSALARIO SEMANAL: {emp_as.GSsalarioSemanal} \nSALARIO CALCULADO: {emp_as.calcularPagoSemanal():C}");

                                            empleados.Add(emp_as);
                                            asalariados.Add(emp_as);



                                            break;

                                        case 2:

                                            Console.WriteLine("INGRESA EL PRIMER NOMBRE DEL EMPLEADO");
                                            primerNombre = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                            apellidoPaterno = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                            numeroSeguroSocial = int.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA LAS VENTAS BRUTAS DEL EMPLEADO");
                                            ventasBrutas = decimal.Parse(Console.ReadLine());

                                            Console.WriteLine("INGRESA LA TARIFA DE COMISION DEL EMPLEADO");
                                            tarifaComision = decimal.Parse(Console.ReadLine());

                                            EmpleadoPorComision emp_com = new EmpleadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision);

                                            Console.WriteLine($"NOMBRE: {emp_com.GS_primerNombre} \nAPELLIDO: {emp_com.GS_apellidoPaterno} \nNSS: {emp_com.GS_numeroSeguroSocial} \nVENTAS BRUTAS: {emp_com.GSventasBrutas} \nTARIFA DE COMISIONES: {emp_com.GStarifaComision} \nSALARIO CALCULADO: {emp_com.calcularPagoSemanal():C}");

                                            empleados.Add(emp_com);
                                            comosionaros.Add(emp_com);


                                            break;

                                        case 3:

                                            Console.WriteLine("INGRESA EL PRIMER NOMBRE DEL EMPLEADO");
                                            primerNombre = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                            apellidoPaterno = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                            numeroSeguroSocial = int.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA LAS VENTAS BRUTAS DEL EMPLEADO");
                                            ventasBrutas = decimal.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA LA TARIFA DE COMISION DEL EMPLEADO");
                                            tarifaComision = decimal.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA EL SALARIO BASE DEL EMPLEADO");
                                            salarioBase = decimal.Parse(Console.ReadLine());

                                            EmpleadoAsalariadoPorComision emp_ascom = new EmpleadoAsalariadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision, salarioBase);

                                            Console.WriteLine($"NOMBRE: {emp_ascom.GS_primerNombre} \nAPELLIDO: {emp_ascom.GS_apellidoPaterno} \nNSS: {emp_ascom.GS_numeroSeguroSocial} \nVENTAS BRUTAS: {emp_ascom.GSventasBrutas} \nTARIFA DE COMISIONES: {emp_ascom.GStarifaComision} \nSALARIO BASE: {emp_ascom.GSsalarioBase}\nSALARIO CALCULADO: {emp_ascom.calcularPagoSemanal():C}");

                                            empleados.Add(emp_ascom);
                                            comisionarios_asalariados.Add(emp_ascom);

                                            break;

                                        case 4:

                                            Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                            apellidoPaterno = Console.ReadLine();
                                            Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                            numeroSeguroSocial = int.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA EL SUELDO POR HORA DEL EMPLEADO");
                                            sueldoPorHora = decimal.Parse(Console.ReadLine());
                                            Console.WriteLine("INGRESA LAS HORAS TRABAJADAS DEL EMPLEADO");
                                            horasTrabajadas = int.Parse(Console.ReadLine());


                                            EmpleadoPorHoras emp_h = new EmpleadoPorHoras(apellidoPaterno, numeroSeguroSocial, sueldoPorHora, horasTrabajadas);

                                            Console.WriteLine($"APELLIDO: {emp_h.GS_apellidoPaterno} \nNSS: {emp_h.GS_numeroSeguroSocial} \nSUELDO POR HORA: {emp_h.GSsueldoPorHora} \nHORAS TRABAJADAS: {emp_h.GShorasTrabajadas} \nSALARIO CALCULADO: {emp_h.calcularPagoSemanal():C}");

                                            empleados.Add(emp_h);
                                            empleadosporhoras.Add(emp_h);


                                            break;

                                        case 5:

                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No ingresaste un número válido.");
                                }
                            } while (opcionsecundaria != 5);

                            break;

                        case 2:

                            Console.WriteLine("----- EMPLEADOS ASALARIADOS ----- ");

                            foreach (EmpleadoAsalariado asalariado in asalariados)
                            {
                                Console.WriteLine($"NOMBRE: {asalariado.GS_primerNombre} APELLIDO: {asalariado.GS_apellidoPaterno} NSS: {asalariado.GS_numeroSeguroSocial} SALARIO SEMANAL: {asalariado.GSsalarioSemanal} SALARIO CALCULADO: {asalariado.calcularPagoSemanal():C}");
                            }

                            Console.WriteLine("----- EMPLEADOS POR COMISION ----- ");

                            foreach (EmpleadoPorComision comisionario in comosionaros)
                            {
                                Console.WriteLine($"NOMBRE: {comisionario.GS_primerNombre} APELLIDO: {comisionario.GS_apellidoPaterno} NSS: {comisionario.GS_numeroSeguroSocial} VENTAS BRUTAS: {comisionario.GSventasBrutas} TARIFA COMISION: {comisionario.GStarifaComision} SALARIO CALCULADO: {comisionario.calcularPagoSemanal():C}");
                            }

                            Console.WriteLine("----- EMPLEADOS ASALARIADOS POR COMISION ----- ");

                            foreach (EmpleadoAsalariadoPorComision comisionario_asalariado in comisionarios_asalariados)
                            {
                                Console.WriteLine($"NOMBRE: {comisionario_asalariado.GS_primerNombre} APELLIDO: {comisionario_asalariado.GS_apellidoPaterno} NSS: {comisionario_asalariado.GS_numeroSeguroSocial} VENTAS BRUTAS: {comisionario_asalariado.GSventasBrutas} TARIFA COMISION: {comisionario_asalariado.GStarifaComision} SALARIO BASE: {comisionario_asalariado.GSsalarioBase} SALARIO CALCULADO: {comisionario_asalariado.calcularPagoSemanal():C}");
                            }

                            Console.WriteLine("----- EMPLEADOS POR HORAS ----- ");

                            foreach (EmpleadoPorHoras empleadoporhoras in empleadosporhoras)
                            {
                                Console.WriteLine($"APELLIDO: {empleadoporhoras.GS_apellidoPaterno} NSS: {empleadoporhoras.GS_numeroSeguroSocial} SUELDO POR HORA: {empleadoporhoras.GSsueldoPorHora} HORAS TRABAJADAS: {empleadoporhoras.GShorasTrabajadas} SALARIO CALCULADO: {empleadoporhoras.calcularPagoSemanal():C}");
                            }

                            break;

                        case 3:

                            Console.WriteLine("ESCRIBE EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO QUE QUIERES BORRAR:");

                            numeroSeguroSocial = int.Parse(Console.ReadLine());

                            empleados.RemoveAll(e => e.GS_numeroSeguroSocial == numeroSeguroSocial);

                            asalariados.RemoveAll(e => e.GS_numeroSeguroSocial == numeroSeguroSocial);
                            comisionarios_asalariados.RemoveAll(e => e.GS_numeroSeguroSocial == numeroSeguroSocial);
                            comosionaros.RemoveAll(e => e.GS_numeroSeguroSocial == numeroSeguroSocial);
                            empleadosporhoras.RemoveAll(e => e.GS_numeroSeguroSocial == numeroSeguroSocial);

                            break;

                        case 4:


                            Console.WriteLine("ESCRIBE EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO QUE QUIERES EDITAR:");
                            numeroSeguroSocial = int.Parse(Console.ReadLine());

                            

                            do
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("*~~ ESPECIFICA EL TIPO DE CONTRATO ~~* \n[1] EMPLEADO ASALARIADO \n[2] EMPLEADO POR COMISION \n[3] EMPLEADO ASALARIADO POR COMISION \n[4] EMPLEADO POR HORA \n[5] SALIR");
                                Console.WriteLine("ELIGE UNA OPCION:");

                                input = Console.ReadLine();
                                exito = byte.TryParse(input, out opcionsecundaria);

                                if (exito)
                                {

                                    switch (opcionsecundaria)
                                    {

                                        case 1:

                                            foreach (EmpleadoAsalariado emp_as in asalariados)
                                            {
                                                if (numeroSeguroSocial == emp_as.GS_numeroSeguroSocial)
                                                {
                                                    Console.WriteLine("INGRESA EL PRIMER NOMBRE DEL EMPLEADO");
                                                    emp_as.GS_primerNombre = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                                    emp_as.GS_apellidoPaterno = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                                    emp_as.GS_numeroSeguroSocial = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA EL SALARIO SEMANAL DEL EMPLEADO");
                                                    emp_as.GSsalarioSemanal = decimal.Parse(Console.ReadLine());

                                                    Console.WriteLine($"LOS NUEVOS VALORES SON => NOMBRE: {emp_as.GS_primerNombre} \nAPELLIDO: {emp_as.GS_apellidoPaterno} \nNSS: {emp_as.GS_numeroSeguroSocial} \nSALARIO SEMANAL: {emp_as.GSsalarioSemanal} \nSALARIO CALCULADO: {emp_as.calcularPagoSemanal():C}");


                                                }
                                            }

                                            break;

                                        case 2:

                                            foreach (EmpleadoPorComision emp_com in comosionaros)
                                            {

                                                if (numeroSeguroSocial == emp_com.GS_numeroSeguroSocial)
                                                {

                                                    Console.WriteLine("INGRESA EL PRIMER NOMBRE DEL EMPLEADO");
                                                    emp_com.GS_primerNombre = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                                    emp_com.GS_apellidoPaterno = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                                    emp_com.GS_numeroSeguroSocial = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA LAS VENTAS BRUTAS DEL EMPLEADO");
                                                    emp_com.GSventasBrutas = decimal.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA LA TARIFA DE COMISION DEL EMPLEADO");
                                                    emp_com.GStarifaComision = decimal.Parse(Console.ReadLine());

                                                    Console.WriteLine($"LOS NUEVOS VALORES SON => NOMBRE: {emp_com.GS_primerNombre} \nAPELLIDO: {emp_com.GS_apellidoPaterno} \nNSS: {emp_com.GS_numeroSeguroSocial} \nVENTAS BRUTAS: {emp_com.GSventasBrutas} \nTARIFA DE COMISIONES: {emp_com.GStarifaComision} \nSALARIO CALCULADO: {emp_com.calcularPagoSemanal():C}");



                                                }
                                            }

                                            break;

                                        case 3:

                                            foreach (EmpleadoAsalariadoPorComision emp_ascom in comisionarios_asalariados)
                                            {

                                                if (numeroSeguroSocial == emp_ascom.GS_numeroSeguroSocial)
                                                {

                                                    Console.WriteLine("INGRESA EL PRIMER NOMBRE DEL EMPLEADO");
                                                    emp_ascom.GS_primerNombre = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                                    emp_ascom.GS_apellidoPaterno = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                                    emp_ascom.GS_numeroSeguroSocial = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA LAS VENTAS BRUTAS DEL EMPLEADO");
                                                    emp_ascom.GSventasBrutas = decimal.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA LA TARIFA DE COMISION DEL EMPLEADO");
                                                    emp_ascom.GStarifaComision = decimal.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA EL SALARIO BASE DEL EMPLEADO");
                                                    emp_ascom.GSsalarioBase = decimal.Parse(Console.ReadLine());

                                                    Console.WriteLine($"LOS NUEVOS VALORES SON => NOMBRE: {emp_ascom.GS_primerNombre} \nAPELLIDO: {emp_ascom.GS_apellidoPaterno} \nNSS: {emp_ascom.GS_numeroSeguroSocial} \nVENTAS BRUTAS: {emp_ascom.GSventasBrutas} \nTARIFA DE COMISIONES: {emp_ascom.GStarifaComision} \nSALARIO BASE: {emp_ascom.GSsalarioBase}\nSALARIO CALCULADO: {emp_ascom.calcularPagoSemanal():C}");


                                                 
                                                }
                                            }
                                            break;

                                        case 4:

                                            foreach (EmpleadoPorHoras emp_h in empleadosporhoras)
                                            {
                                                if (numeroSeguroSocial == emp_h.GS_numeroSeguroSocial)
                                                {

                                                    Console.WriteLine("INGRESA EL APELLIDO PATERNO DEL EMPLEADO");
                                                    emp_h.GS_apellidoPaterno = Console.ReadLine();
                                                    Console.WriteLine("INGRESA EL NUMERO DEL SEGURO SOCIAL DEL EMPLEADO");
                                                    emp_h.GS_numeroSeguroSocial = int.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA EL SUELDO POR HORA DEL EMPLEADO");
                                                    emp_h.GSsueldoPorHora = decimal.Parse(Console.ReadLine());
                                                    Console.WriteLine("INGRESA LAS HORAS TRABAJADAS DEL EMPLEADO");
                                                    emp_h.GShorasTrabajadas = int.Parse(Console.ReadLine());

                                                    Console.WriteLine($"LOS NUEVOS VALORES SON => APELLIDO: {emp_h.GS_apellidoPaterno} \nNSS: {emp_h.GS_numeroSeguroSocial} \nSUELDO POR HORA: {emp_h.GSsueldoPorHora} \nHORAS TRABAJADAS: {emp_h.GShorasTrabajadas} \nSALARIO CALCULADO: {emp_h.calcularPagoSemanal():C}");

                                                    
                                                }
                                            }

                                            break;

                                        case 5:

                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No ingresaste un número válido.");
                                }
                            } while (opcionsecundaria != 5);


                            break;

                        case 5:

                            int id = 1;
                            Stopwatch sw = Stopwatch.StartNew();

                            for (int i = 1; i <= 250; i++)
                            {
                                EmpleadoAsalariado emp_a = new EmpleadoAsalariado("Sin Nombre", "Sin Apellido", 333, 333.00m);
                                Console.WriteLine($"Pago del empleado asalariado ({id++}) :  {emp_a.calcularPagoSemanal():C}");

                                EmpleadoPorComision emp_c = new EmpleadoPorComision("Sin Nombre", "Sin Apellido", 333, 333.00m, 444.00m);
                                Console.WriteLine($"Pago del empleado por comision  ({id++}) :  {emp_c.calcularPagoSemanal():C}");

                                EmpleadoAsalariadoPorComision emp_ac = new EmpleadoAsalariadoPorComision("Sin Nombre", "Sin Apellido", 333, 333.00m, 444.00m, 555.00m);
                                Console.WriteLine($"Pago del empleado asalariado por comision ({id++}) :  {emp_ac.calcularPagoSemanal():C}");

                                EmpleadoPorHoras emp_h = new EmpleadoPorHoras("Sin Apellido", 333, 333.00m, 3);
                                Console.WriteLine($"Pago del empleado por horas ({id++}) :  {emp_h.calcularPagoSemanal():C}");
                            }

                            sw.Stop();
                            Console.WriteLine($"Tiempo total: {sw.ElapsedMilliseconds} ms");

                            break;
                        case 6:
                            Console.WriteLine("SALIENDO... ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("No ingresaste un número válido.");
                }
            } while (opcion != 6);
        }
    }
}
