using CRUD_ProyectoActividad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CRUD_ProyectoActividad.Controladores
{
    class Controlador_Empleados
    {
        public Controlador_Empleados() {
            ArrayEmpleados = new List<ClaseEmpleados>();
        }

        private List<ClaseEmpleados> ArrayEmpleados;

        public List<ClaseEmpleados> AccederArrayEmpleados { get { return ArrayEmpleados; } }


        #region LlenarArray
        public void LlenarArrayEmpleados()
        {
            //Limpia el array
            AccederArrayEmpleados.Clear();

            //Agrega Objetos a la propiedad privada desde la propiedad publica
            //Ademas de que crea una nueva instancia de la clase Areas para agregar los nuevos objetos
            AccederArrayEmpleados.Add(new ClaseEmpleados()
            {
                Id = 1,
                Nombre = "Nicolas",
                Apellidos = "Rojas Sanchez",
                Direccion = "Cra 1 #66-42",
                Telefono = "3164449571",
                FechaIngreso = new DateTime(2020,11,11),
                IdArea = 1
            });
            AccederArrayEmpleados.Add(new ClaseEmpleados()
            {
                Id = 2,
                Nombre = "Felipe",
                Apellidos = "Ortiz Nuñez",
                Direccion = "Cra 3 #26-42",
                Telefono = "3023456534",
                FechaIngreso = new DateTime(2021,12,11),
                IdArea = 2
            });
            AccederArrayEmpleados.Add(new ClaseEmpleados()
            {
                Id = 3,
                Nombre = "Valeria",
                Apellidos = "Corral Caicedo",
                Direccion = "Av 5 #26-10",
                Telefono = "3014501010",
                FechaIngreso = new DateTime(2021,08,11),
                IdArea = 3
            });
            AccederArrayEmpleados.Add(new ClaseEmpleados()
            {
                Id = 4,
                Nombre = "Luisa",
                Apellidos = "Orjuela Tamayo",
                Direccion = "Cra 6 #10-2",
                Telefono = "3014503345",
                FechaIngreso = new DateTime(2022,11,11),
                IdArea = 4
            });
            AccederArrayEmpleados.Add(new ClaseEmpleados()
            {
                Id = 5,
                Nombre = "Mario",
                Apellidos = "Sanchez Cubides",
                Direccion = "Cra 9 #30-5",
                Telefono = "3124355655",
                FechaIngreso = new DateTime(2019,10,5),
                IdArea = 5
            });
        }

        #endregion LlenarArray


        #region Traer_Datos
        public void TraerDatosEmpleados()
        {
            List<ClaseEmpleados> listaEmpleados = new List<ClaseEmpleados>();
            listaEmpleados.AddRange(from p in AccederArrayEmpleados orderby p.Id select p);
            if (listaEmpleados.Count > 0)
            {
                ImprimirEmpleados.ImprimirEmpleado(listaEmpleados);
            }
            else
            {
                Console.WriteLine("[]");
            }

            
        }

        #endregion Traer_Datos


        #region Mostrar_PorId
        public void MostrarPorId(int id)
        {
            List<ClaseEmpleados> listaPordId = new List<ClaseEmpleados>();
            listaPordId.AddRange(from o in AccederArrayEmpleados where o.Id == id select o);
            if (listaPordId.Count > 0)
            {
                ImprimirEmpleados.ImprimirEmpleado(listaPordId);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " en nuestra BD");
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        #endregion Mostrar_PorId


        #region Agregar_Empleado
        public void Agregar_Empleado(int id, string nombre, string apellidos, string direccion, string telefono, DateTime fechaIngreso, int idArea)
        {
            var verificarId = AccederArrayEmpleados.Any(i => i.Id == id);
            if (!verificarId)
            {
                AccederArrayEmpleados.Add(new ClaseEmpleados()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    FechaIngreso = fechaIngreso,
                    IdArea = idArea
                });
                Console.WriteLine("Estado 201");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
                Console.ReadKey();
                Console.Clear();
            }
        }

        #endregion Agregar_Empleado


        #region ActualizarEmpleado
        public void Actualizar_Empleado(int id, string nombre, string apellidos, string direccion, string telefono, DateTime fechaIngreso, int idArea)
        {
            var empleadoActualizar = new ClaseEmpleados
            {
                Id = id,
                Nombre = nombre,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                FechaIngreso = fechaIngreso,
                IdArea = idArea
            };

            var empleadoCoincidencia = AccederArrayEmpleados.FirstOrDefault(i => i.Id == empleadoActualizar.Id);
            if (empleadoCoincidencia != null)
            {
                AccederArrayEmpleados.Remove(empleadoCoincidencia);
                AccederArrayEmpleados.Add(empleadoActualizar);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error 505");
                Console.ReadKey();
            }

        }

        #endregion ActualizarArea


        #region BorrarPorId
    public void BorrarPorId(int id)
    {
        var EliminarEmpleado = AccederArrayEmpleados.FirstOrDefault(i => i.Id == id);
            if (EliminarEmpleado != null)
            {
                AccederArrayEmpleados.Remove(EliminarEmpleado);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
                Console.ReadKey();
            }
           
    }
        #endregion BorrarPorId

    }


}


