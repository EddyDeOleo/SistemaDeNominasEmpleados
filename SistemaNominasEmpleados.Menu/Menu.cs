
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
            string primerNombre, apellidoPaterno, numeroSeguroSocial;
            int horasTrabajadas;
            decimal salarioSemanal, sueldoPorHora, ventasBrutas, tarifaComision, salarioBase;

            List<EmpleadoAsalariado> asalariados = new List<EmpleadoAsalariado>();
            List<EmpleadoPorComision> comisionarios = new List<EmpleadoPorComision>();
            List<EmpleadoAsalariadoPorComision> comisionariosAsalariados = new List<EmpleadoAsalariadoPorComision>();
            List<EmpleadoPorHoras> empleadosPorHoras = new List<EmpleadoPorHoras>();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("*~~ SISTEMA DE NOMINAS DE EMPLEADOS ~~*");
                Console.WriteLine("[1] AGREGAR EMPLEADOS");
                Console.WriteLine("[2] GENERAR REPORTE");
                Console.WriteLine("[3] ELIMINAR EMPLEADOS");
                Console.WriteLine("[4] EDITAR EMPLEADOS");
                Console.WriteLine("[5] PROBAR RENDIMIENTO");
                Console.WriteLine("[6] SALIR");
                Console.Write("ELIGE UNA OPCION: ");

                string input = Console.ReadLine();
                bool exito = byte.TryParse(input, out opcion);

                if (!exito)
                {
                    Console.WriteLine("No ingresaste un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1: // AGREGAR EMPLEADOS
                        do
                        {
                            Console.WriteLine("\n*~~ TIPOS DE EMPLEADOS ~~*");
                            Console.WriteLine("[1] EMPLEADO ASALARIADO");
                            Console.WriteLine("[2] EMPLEADO POR COMISION");
                            Console.WriteLine("[3] EMPLEADO ASALARIADO POR COMISION");
                            Console.WriteLine("[4] EMPLEADO POR HORA");
                            Console.WriteLine("[5] SALIR");
                            Console.Write("ELIGE UNA OPCION: ");

                            input = Console.ReadLine();
                            exito = byte.TryParse(input, out opcionsecundaria);

                            if (!exito) { Console.WriteLine("No ingresaste un número válido."); continue; }

                            switch (opcionsecundaria)
                            {
                                case 1:
                                    Console.Write("Primer nombre: ");
                                    primerNombre = Console.ReadLine();
                                    Console.Write("Apellido paterno: ");
                                    apellidoPaterno = Console.ReadLine();
                                    Console.Write("Número seguro social: ");
                                    numeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Salario semanal: ");
                                    salarioSemanal = decimal.Parse(Console.ReadLine());

                                    var empAs = new EmpleadoAsalariado(primerNombre, apellidoPaterno, numeroSeguroSocial, salarioSemanal);
                                    asalariados.Add(empAs);

                                    var nominaAs = new NominaEmpleadoAsalariado(empAs);
                                    Console.WriteLine($"{empAs} - SALARIO CALCULADO: {nominaAs.CalcularPago():C}");
                                    break;

                                case 2:
                                    Console.Write("Primer nombre: ");
                                    primerNombre = Console.ReadLine();
                                    Console.Write("Apellido paterno: ");
                                    apellidoPaterno = Console.ReadLine();
                                    Console.Write("Número seguro social: ");
                                    numeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Ventas brutas: ");
                                    ventasBrutas = decimal.Parse(Console.ReadLine());
                                    Console.Write("Tarifa comisión: ");
                                    tarifaComision = decimal.Parse(Console.ReadLine());

                                    var empCom = new EmpleadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision);
                                    comisionarios.Add(empCom);

                                    var nominaCom = new NominaEmpleadoPorComision(empCom);
                                    Console.WriteLine($"{empCom} - SALARIO CALCULADO: {nominaCom.CalcularPago():C}");
                                    break;

                                case 3:
                                    Console.Write("Primer nombre: ");
                                    primerNombre = Console.ReadLine();
                                    Console.Write("Apellido paterno: ");
                                    apellidoPaterno = Console.ReadLine();
                                    Console.Write("Número seguro social: ");
                                    numeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Ventas brutas: ");
                                    ventasBrutas = decimal.Parse(Console.ReadLine());
                                    Console.Write("Tarifa comisión: ");
                                    tarifaComision = decimal.Parse(Console.ReadLine());
                                    Console.Write("Salario base: ");
                                    salarioBase = decimal.Parse(Console.ReadLine());

                                    var empAsCom = new EmpleadoAsalariadoPorComision(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision, salarioBase);
                                    comisionariosAsalariados.Add(empAsCom);

                                    var nominaAsCom = new NominaEmpleadoAsalariadoPorComision(empAsCom);
                                    Console.WriteLine($"{empAsCom} - SALARIO CALCULADO: {nominaAsCom.CalcularPago():C}");
                                    break;

                                case 4:
                                    Console.Write("Primer nombre: ");
                                    primerNombre = Console.ReadLine();
                                    Console.Write("Apellido paterno: ");
                                    apellidoPaterno = Console.ReadLine();
                                    Console.Write("Número seguro social: ");
                                    numeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Sueldo por hora: ");
                                    sueldoPorHora = decimal.Parse(Console.ReadLine());
                                    Console.Write("Horas trabajadas: ");
                                    horasTrabajadas = int.Parse(Console.ReadLine());

                                    var empH = new EmpleadoPorHoras(primerNombre, apellidoPaterno, numeroSeguroSocial, sueldoPorHora, horasTrabajadas);
                                    empleadosPorHoras.Add(empH);

                                    var nominaH = new NominaEmpleadoPorHoras(empH);
                                    Console.WriteLine($"{empH} - SALARIO CALCULADO: {nominaH.CalcularPago():C}");
                                    break;
                            }
                        } while (opcionsecundaria != 5);
                        break;

                    case 2: // REPORTE
                        Console.WriteLine("\n--- REPORTE DE EMPLEADOS ---");
                        foreach (var emp in asalariados)
                            Console.WriteLine(new NominaEmpleadoAsalariado(emp));
                        foreach (var emp in comisionarios)
                            Console.WriteLine(new NominaEmpleadoPorComision(emp));
                        foreach (var emp in comisionariosAsalariados)
                            Console.WriteLine(new NominaEmpleadoAsalariadoPorComision(emp));
                        foreach (var emp in empleadosPorHoras)
                            Console.WriteLine(new NominaEmpleadoPorHoras(emp));
                        break;

                    case 3: // ELIMINAR EMPLEADOS
                        Console.Write("ESCRIBE EL NÚMERO DE SEGURO SOCIAL DEL EMPLEADO A ELIMINAR: ");
                        numeroSeguroSocial = Console.ReadLine();

                        asalariados.RemoveAll(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                        comisionarios.RemoveAll(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                        comisionariosAsalariados.RemoveAll(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                        empleadosPorHoras.RemoveAll(e => e.NumeroSeguroSocial == numeroSeguroSocial);

                        Console.WriteLine("Empleado eliminado (si existía).");
                        break;

                    case 4: // EDITAR EMPLEADOS
                        Console.Write("ESCRIBE EL NÚMERO DE SEGURO SOCIAL DEL EMPLEADO A EDITAR: ");
                        numeroSeguroSocial = Console.ReadLine();

                        Console.WriteLine("\n*~~ ESPECIFICA EL TIPO DE CONTRATO ~~*");
                        Console.WriteLine("[1] EMPLEADO ASALARIADO");
                        Console.WriteLine("[2] EMPLEADO POR COMISION");
                        Console.WriteLine("[3] EMPLEADO ASALARIADO POR COMISION");
                        Console.WriteLine("[4] EMPLEADO POR HORA");
                        Console.Write("Elige una opción: ");

                        input = Console.ReadLine();
                        exito = byte.TryParse(input, out opcionsecundaria);

                        if (!exito) { Console.WriteLine("No ingresaste un número válido."); break; }

                        switch (opcionsecundaria)
                        {
                            case 1: // Asalariado
                                var empAs = asalariados.Find(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                                if (empAs != null)
                                {
                                    Console.Write("Nuevo nombre: "); empAs.PrimerNombre = Console.ReadLine();
                                    Console.Write("Nuevo apellido: "); empAs.ApellidoPaterno = Console.ReadLine();
                                    Console.Write("Nuevo NSS: "); empAs.NumeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Nuevo salario semanal: "); empAs.SalarioSemanal = decimal.Parse(Console.ReadLine());

                                    var nomina = new NominaEmpleadoAsalariado(empAs);
                                    Console.WriteLine($"EDITADO => {empAs.PrimerNombre} {empAs.ApellidoPaterno} - NSS: {empAs.NumeroSeguroSocial} - PAGO: {nomina.CalcularPago():C}");
                                }
                                break;

                            case 2: // Por Comisión
                                var empCom = comisionarios.Find(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                                if (empCom != null)
                                {
                                    Console.Write("Nuevo nombre: "); empCom.PrimerNombre = Console.ReadLine();
                                    Console.Write("Nuevo apellido: "); empCom.ApellidoPaterno = Console.ReadLine();
                                    Console.Write("Nuevo NSS: "); empCom.NumeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Nuevas ventas brutas: "); empCom.VentasBrutas = decimal.Parse(Console.ReadLine());
                                    Console.Write("Nueva tarifa comisión: "); empCom.TarifaComision = decimal.Parse(Console.ReadLine());

                                    var nomina = new NominaEmpleadoPorComision(empCom);
                                    Console.WriteLine($"EDITADO => {empCom.PrimerNombre} {empCom.ApellidoPaterno} - NSS: {empCom.NumeroSeguroSocial} - PAGO: {nomina.CalcularPago():C}");
                                }
                                break;

                            case 3: // Asalariado por Comisión
                                var empAsCom = comisionariosAsalariados.Find(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                                if (empAsCom != null)
                                {
                                    Console.Write("Nuevo nombre: "); empAsCom.PrimerNombre = Console.ReadLine();
                                    Console.Write("Nuevo apellido: "); empAsCom.ApellidoPaterno = Console.ReadLine();
                                    Console.Write("Nuevo NSS: "); empAsCom.NumeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Nuevas ventas brutas: "); empAsCom.VentasBrutas = decimal.Parse(Console.ReadLine());
                                    Console.Write("Nueva tarifa comisión: "); empAsCom.TarifaComision = decimal.Parse(Console.ReadLine());
                                    Console.Write("Nuevo salario base: "); empAsCom.SalarioBase = decimal.Parse(Console.ReadLine());

                                    var nomina = new NominaEmpleadoAsalariadoPorComision(empAsCom);
                                    Console.WriteLine($"EDITADO => {empAsCom.PrimerNombre} {empAsCom.ApellidoPaterno} - NSS: {empAsCom.NumeroSeguroSocial} - PAGO: {nomina.CalcularPago():C}");
                                }
                                break;

                            case 4: // Por Horas
                                var empH = empleadosPorHoras.Find(e => e.NumeroSeguroSocial == numeroSeguroSocial);
                                if (empH != null)
                                {
                                    Console.Write("Nuevo nombre: "); empH.PrimerNombre = Console.ReadLine();
                                    Console.Write("Nuevo apellido: "); empH.ApellidoPaterno = Console.ReadLine();
                                    Console.Write("Nuevo NSS: "); empH.NumeroSeguroSocial = Console.ReadLine();
                                    Console.Write("Nuevo sueldo por hora: "); empH.SueldoPorHora = decimal.Parse(Console.ReadLine());
                                    Console.Write("Nuevas horas trabajadas: "); empH.HorasTrabajadas = int.Parse(Console.ReadLine());

                                    var nomina = new NominaEmpleadoPorHoras(empH);
                                    Console.WriteLine($"EDITADO => {empH.PrimerNombre} {empH.ApellidoPaterno} - NSS: {empH.NumeroSeguroSocial} - PAGO: {nomina.CalcularPago():C}");
                                }
                                break;
                        }
                        break;

                    case 5: // PRUEBA DE RENDIMIENTO
                        Stopwatch sw = Stopwatch.StartNew();
                        for (int i = 1; i <= 100; i++)
                        {
                            var e1 = new EmpleadoAsalariado("Test", "A", "111", 3000m);
                            Console.WriteLine(new NominaEmpleadoAsalariado(e1));

                            var e2 = new EmpleadoPorComision("Test", "B", "222", 50000m, 0.05m);
                            Console.WriteLine(new NominaEmpleadoPorComision(e2));

                            var e3 = new EmpleadoAsalariadoPorComision("Test", "C", "333", 70000m, 0.04m, 2500m);
                            Console.WriteLine(new NominaEmpleadoAsalariadoPorComision(e3));

                            var e4 = new EmpleadoPorHoras("Test", "D", "444", 200m, 42);
                            Console.WriteLine(new NominaEmpleadoPorHoras(e4));
                        }
                        sw.Stop();
                        Console.WriteLine($"Tiempo total: {sw.ElapsedMilliseconds} ms");
                        break;

                    case 6:
                        Console.WriteLine("SALIENDO...");
                        break;
                }
            } while (opcion != 6);
        }
    }
}
