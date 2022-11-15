using CRUD_ProyectoActividad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CRUD_ProyectoActividad.Controladores
{
    class Controlador_Nomina
    {

        public Controlador_Nomina(){
            arrayNomina = new List<ClaseNomina>();
        }

        private List<ClaseNomina> arrayNomina;
        public List<ClaseNomina> accederArrayNomina { get { return arrayNomina; } }

        //Listo
        #region LlenarArray
        public void LlenarArrayNomina()
        {


            //Limpia el array
            accederArrayNomina.Clear();

            //Agrega Objetos a la propiedad privada desde la propiedad publica
            //Ademas de que crea una nueva instancia de la clase Areas para agregar los nuevos objetos
            accederArrayNomina.Add(new ClaseNomina()
            {
                Id = 1,
                Fecha = new DateTime(2020, 11, 11),
                IdEmpleado = 1,
                Sueldo = 1200000,
                Dias = 30,
                TotalBasico = 1200000 * 30 / 30,
                Otros = 100000,
                Devengado = (1200000*30/30)+100000
            }) ;
            accederArrayNomina.Add(new ClaseNomina()
            {
                Id = 2,
                Fecha = new DateTime(2020, 11, 11),
                IdEmpleado = 2,
                Sueldo = 1300000,
                Dias = 25,
                TotalBasico = 1300000 * 25 / 30,
                Otros = 50000,
                Devengado = (1300000 * 25 / 30) + 50000
            });
            accederArrayNomina.Add(new ClaseNomina()
            {
                Id = 3,
                Fecha = new DateTime(2020, 11, 11),
                IdEmpleado = 3,
                Sueldo = 1300000,
                Dias = 28,
                TotalBasico = 2300000 * 28 / 30,
                Otros = 50000,
                Devengado = (2300000 * 28 / 30) + 50000
            });
            accederArrayNomina.Add(new ClaseNomina()
            {
                Id = 4,
                Fecha = new DateTime(2020, 11, 11),
                IdEmpleado = 4,
                Sueldo = 2000000,
                Dias = 28,
                TotalBasico = 2000000 * 28 / 30,
                Otros = 150000,
                Devengado = (2000000 * 28 / 30) + 150000
            });
            accederArrayNomina.Add(new ClaseNomina()
            {
                Id = 5,
                Fecha = new DateTime(2020, 11, 11),
                IdEmpleado = 5,
                Sueldo = 3300000,
                Dias = 26,
                TotalBasico = 3300000 * 26 / 30,
                Otros = 50000,
                Devengado = (3300000 * 26 / 30) + 50000
            });
        }

        #endregion LlenarArray

        //Listo
        #region Trae_DatosNomina
        public void TraerDatosNomina()
        {
            List<ClaseNomina> listaNomina = new List<ClaseNomina>();
            listaNomina.AddRange(from p in accederArrayNomina orderby p.Id select p);
            if (listaNomina.Count > 0)
            {
                ImprimirNomina.imprimirNomina(listaNomina);
            }
            else
            {
                Console.WriteLine("[]");
            }
           
        }

        #endregion Trae_DatosNomina

        //Listo
        #region Mostrar_PorIdNomina
        public void MostrarPorId(int id)
        {
            List<ClaseNomina> listaPordId = new List<ClaseNomina>();
            listaPordId.AddRange(from o in accederArrayNomina where o.Id == id select o);
            if (listaPordId.Count > 0)
            {
                ImprimirNomina.imprimirNomina(listaPordId);
            }
            else
            {
                Console.WriteLine("No exite el Id " + id + " en nuestra BD");
                Console.ReadKey();
                Console.Clear();
            }
          
        }

        #endregion Mostrar_PorIdNomina

        //Listo
        #region Agregar_Nomina
        public void Agregar_Nomina(int id, DateTime fecha,int idEmpleado, decimal sueldo, int dias,decimal otros)
        {
            var verificarId = accederArrayNomina.Any(i => i.Id == id);
            if (!verificarId)
            {
                accederArrayNomina.Add(new ClaseNomina()
                {
                    Id = id,
                    Fecha = fecha,
                    IdEmpleado = idEmpleado,
                    Sueldo = sueldo,
                    Dias = dias,
                    TotalBasico = sueldo * dias / 30,
                    Otros = otros,
                    Devengado = (sueldo * dias / 30) + otros
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

        #endregion Agregar_Nomina

        //Listo
        #region ActualizarNomina
        public void Actualizar_Nomina(int id, DateTime fecha, int idEmpleado, decimal sueldo, int dias, decimal otros)
        {
            var nominaActualizar = new ClaseNomina
            {
                Id = id,
                Fecha = fecha,
                IdEmpleado = idEmpleado,
                Sueldo = sueldo,
                Dias = dias,
                TotalBasico = sueldo * dias / 30,
                Otros = otros,
                Devengado = (sueldo * dias / 30) + otros
            };

            var nominaCoincidencia = accederArrayNomina.FirstOrDefault(i => i.Id == nominaActualizar.Id);
            if (accederArrayNomina != null)
            {
                accederArrayNomina.Remove(nominaCoincidencia);
                accederArrayNomina.Add(nominaActualizar);
                Console.WriteLine("Registro Actualizado con exito!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error 505");
                Console.ReadKey();
            }
        }

        #endregion ActualizarNomina

        //Listo
        #region BorrarPorIdNomina
        public void BorrarPorId(int id)
        {
            var EliminarNomina = accederArrayNomina.FirstOrDefault(i => i.Id == id);
            if (EliminarNomina != null)
            {
                accederArrayNomina.Remove(EliminarNomina);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
                Console.ReadKey();
            }
          
        }
        #endregion BorrarPorIdNomina

    }
}
