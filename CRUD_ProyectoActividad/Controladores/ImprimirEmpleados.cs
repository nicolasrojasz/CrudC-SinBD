using CRUD_ProyectoActividad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_ProyectoActividad.Controladores
{
    class ImprimirEmpleados
    {
        public static void ImprimirEmpleado(List<ClaseEmpleados> Empleados)
        {
            foreach (var item in Empleados)
            {
                Console.WriteLine("Id : {0} / Nombre : {1} / Apellidos :{2} / Direccion : {3} / Telefono: {4} / FechaIngreso : {5}  / IdArea : {6}", item.Id, item.Nombre,item.Apellidos,item.Direccion,item.Telefono,item.FechaIngreso,item.IdArea);
            }
            Console.ReadKey();
            Console.Clear();

        }
    }
}
