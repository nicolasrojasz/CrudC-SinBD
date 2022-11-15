using CRUD_ProyectoActividad.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD_ProyectoActividad.Controladores
{
    class Controlador_Areas
    {

        //Constructor
        public Controlador_Areas()
        {
            ArrayAreas = new List<ClaseAreas>();
        }
        
        //Propiedades
        private List<ClaseAreas> ArrayAreas;

        //Acceder a una propiedad Privada
        public List<ClaseAreas> AccederArrayAreas { get { return ArrayAreas; } }

        #region LlenarArray
        public void LlenarArray()
        {
            //Limpia La consola
            AccederArrayAreas.Clear();

            //Agrega Objetos a la propiedad privada desde la propiedad publica
            //Ademas de que crea una nueva instancia de la clase Areas para agregar los nuevos objetos
            AccederArrayAreas.Add(new ClaseAreas()
            {
                Id = 1,
                Nombre = "Desarrollador"
            });
            AccederArrayAreas.Add(new ClaseAreas()
            {
                Id = 2,
                Nombre = "Gerente"
            });
            AccederArrayAreas.Add(new ClaseAreas()
            {
                Id = 3,
                Nombre = "Administrador"
            });
            AccederArrayAreas.Add(new ClaseAreas()
            {
                Id = 4,
                Nombre = "Soporte IT"
            });
            AccederArrayAreas.Add(new ClaseAreas()
            {
                Id = 5,
                Nombre = "Recepcionista"
            });
        }

        #endregion LlenarArray

        
        #region Traer_Datos
        public void TrearDatosProductos()
        {
            List<ClaseAreas> listaProductos = new List<ClaseAreas>();
            listaProductos.AddRange(from p in AccederArrayAreas orderby p.Id select p);
            if (listaProductos.Count > 0)
            {
                ImprimirAreas.ImprimirArea(listaProductos);
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
            List<ClaseAreas> lista = new List<ClaseAreas>();
            lista.AddRange(from o in AccederArrayAreas where o.Id == id select o);
            if (lista.Count > 0)
            {
                ImprimirAreas.ImprimirArea(lista);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " en nuestra BD");
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        #endregion Mostrar_PorId


        #region Agregar_Area
        public void Agregar_Area(int id, string nombre)
        {
            var verificarId = AccederArrayAreas.Any(i => i.Id == id);
            if (!verificarId)
            {
                AccederArrayAreas.Add(new ClaseAreas()
                {
                    Id = id,
                    Nombre = nombre
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

               
#endregion Agregar_Area


#region ActualizarArea
public void ActualizarArea(int id, string nombre)
        {
            var areaActualizar = new ClaseAreas
            {
                Id = id,
                Nombre = nombre
            };
            var areaCoincidencia = AccederArrayAreas.FirstOrDefault(i => i.Id == areaActualizar.Id);

            if (areaCoincidencia != null)
            {
                AccederArrayAreas.Remove(areaCoincidencia);
                AccederArrayAreas.Add(areaActualizar);
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
            var EliminarArea = AccederArrayAreas.FirstOrDefault(i => i.Id == id);
            if (EliminarArea != null)
            {
                AccederArrayAreas.Remove(EliminarArea);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
                Console.ReadKey();
            }
        }
    }
        #endregion BorrarPorId


     
}
