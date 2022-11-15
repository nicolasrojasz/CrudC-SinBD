using CRUD_ProyectoActividad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_ProyectoActividad.Controladores
{
    class ImprimirNomina
    {
        public static void imprimirNomina(List<ClaseNomina> Nomina)
        {
            foreach (var item in Nomina)
            {
                Console.WriteLine("Id : {0} / Fecha : {1} / IdEmpleado :{2} / Sueldo : {3} / Dias :{4} /Total Basico :{5} / Otros :{6} / Devengado {7} ", item.Id, item.Fecha, item.IdEmpleado, item.Sueldo, item.Dias,item.TotalBasico,item.Otros,item.Devengado);
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
