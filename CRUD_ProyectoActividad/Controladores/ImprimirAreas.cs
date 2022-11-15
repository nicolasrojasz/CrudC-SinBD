using CRUD_ProyectoActividad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_ProyectoActividad.Controladores
{
    class ImprimirAreas
    {
        public static void ImprimirArea(List<ClaseAreas> Area)
        {
            foreach (var item in Area)
            {
                Console.WriteLine("Id : {0} / Area : {1}", item.Id, item.Nombre);
            }
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
