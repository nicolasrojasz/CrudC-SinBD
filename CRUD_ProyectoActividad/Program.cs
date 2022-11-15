using CRUD_ProyectoActividad.Controladores;
using CRUD_ProyectoActividad.Modelos;
using System;

namespace CRUD_ProyectoActividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            int id = 0;
            string nombre;
            string apellidos;
            string direccion;
            string telefono;
            DateTime fechaIngreso;
            int idArea = 0;
            
            DateTime fecha;
            int idEmpleado = 0;
            decimal sueldo = 0;
            int dias = 0;
            decimal otros = 0;
           
 
            do
            {
                Console.Clear();
                Menu menu = new Menu();
                menu.Mostrarmenu();
                Console.Write("Elige una Opcion : ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Bienvenido a las Areas");
                        Console.ReadKey();

                        #region MostrarLista
                        Console.WriteLine("Mostrando Lista de Areas");
                        Console.ReadKey();
                        Controlador_Areas controlador_Areas = new Controlador_Areas();

                        controlador_Areas.LlenarArray();
                        controlador_Areas.TrearDatosProductos();
                        #endregion MostrarLista


                        #region BuscarPorId
                       
                        Console.WriteLine("Buscar Area");
                        Console.Write("Id de Area a buscar : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        controlador_Areas.MostrarPorId(id);
                       
                        #endregion BuscarPorId


                        #region AgregarArea
                        
                        Console.WriteLine("Agrega una Area");
                        Console.ReadKey();
                        Console.Write("Ingresa un Id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa el nombre del Area : ");
                        nombre = Convert.ToString(Console.ReadLine());

                        controlador_Areas.Agregar_Area(id, nombre);
                        controlador_Areas.TrearDatosProductos();
                        
                        #endregion AgregarArea


                        #region ActualizarArea
                        Console.WriteLine("Actualizar Area");
                        Console.ReadKey();
                        Console.Write("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduzca Nombre: ");
                        nombre = (Console.ReadLine());

                        controlador_Areas.ActualizarArea(id, nombre);
                        controlador_Areas.TrearDatosProductos();
                        
                        #endregion ActualizarArea



                        #region BorrarId
                       
                        Console.WriteLine("Borrar por ID:");
                        Console.ReadKey();
                        Console.Write("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        controlador_Areas.BorrarPorId(id);
                        controlador_Areas.TrearDatosProductos();
       
                        #endregion BorrarId


                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Bienvenido a Empleados");
                        Console.ReadKey();

                        #region MostrarListaEmpleados
                        Console.WriteLine("Mostrando Lista de Empleados");
                        Console.ReadKey();
                        Controlador_Empleados controladores_Empleados = new Controlador_Empleados();

                        controladores_Empleados.LlenarArrayEmpleados();
                        controladores_Empleados.TraerDatosEmpleados();
                        #endregion MostrarListaEmpleados


                        #region BuscarPorIdEmpleados
                        
                        Console.WriteLine("Buscar Empleados:");
                        Console.Write("Id de Empleado a buscar : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        controladores_Empleados.MostrarPorId(id);
                       
                        #endregion BuscarPorIdEmpleados


                        #region AgregarEmpleados
                       
                        Console.WriteLine("Agrega una empleado");
                        Console.ReadKey();

                        Console.Write("Ingresa un Id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa el nombre del empleado : ");
                        nombre = Convert.ToString(Console.ReadLine());

                        Console.Write("Apellidos del empleado : ");
                        apellidos = Convert.ToString(Console.ReadLine());
                        Console.Write("Direccion del empleado : ");
                        direccion = Convert.ToString(Console.ReadLine());

                        Console.Write("Telefono del empleados : ");
                        telefono = Convert.ToString(Console.ReadLine());
                        Console.Write("Fecha de ingreso del empleado : ");
                        fechaIngreso = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("IdArea del empleado : ");
                        idArea = Convert.ToInt32(Console.ReadLine());

                        controladores_Empleados.Agregar_Empleado(id, nombre, apellidos, direccion, telefono, fechaIngreso, idArea);
                        controladores_Empleados.TraerDatosEmpleados();

                        #endregion AgregarArea


                        #region ActualizarEmpleado
                       
                        Console.WriteLine("Actualizar el empleado");


                        Console.Write("Ingresa el Id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa nombre a actualizar del empleado : ");
                        nombre = Convert.ToString(Console.ReadLine());

                        Console.Write("Apellidos a actualizar del empleado : ");
                        apellidos = Convert.ToString(Console.ReadLine());
                        Console.Write("Direccion a actualizar del empleado : ");
                        direccion = Convert.ToString(Console.ReadLine());

                        Console.Write("Telefono a actualizar del empleados : ");
                        telefono = Convert.ToString(Console.ReadLine());
                        Console.Write("Fecha de ingreso a actualizar del empleado : ");
                        fechaIngreso = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("IdArea a actualizar del empleado : ");
                        idArea = Convert.ToInt32(Console.ReadLine());


                        controladores_Empleados.Actualizar_Empleado(id, nombre, apellidos, direccion, telefono, fechaIngreso, idArea);
                        controladores_Empleados.TraerDatosEmpleados();

                        #endregion ActualizarEmpleado



                        #region BorrarId
                        
                        Console.WriteLine("Borrar por ID del empleado:");
                        Console.ReadKey();
                        Console.Write("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        controladores_Empleados.BorrarPorId(id);
                        controladores_Empleados.TraerDatosEmpleados();
                        ;
                        #endregion BorrarId


                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Bienvenido a Nominas");
                        Console.ReadKey();

                        
                        #region MostrarListaNomina
                        Console.WriteLine("Mostrando Lista de Nomina");
                        Console.ReadKey();
                        Controlador_Nomina controladores_Nomina = new Controlador_Nomina();

                        controladores_Nomina.LlenarArrayNomina();
                        controladores_Nomina.TraerDatosNomina();
                        #endregion MostrarListaNomina

                        
                        #region BuscarPorIdNomina
                        
                        Console.WriteLine("Buscar Nomina:");
                        Console.Write("Id de Nomina a buscar : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        controladores_Nomina.MostrarPorId(id);
                       
                        #endregion BuscarPorIdNomina

                        
                        #region AgregarNomina
                      
                        Console.WriteLine("Agrega una Nomina");
                        Console.ReadKey();

                        Console.Write("Ingresa un Id para la nomina: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingresa una fecha para la nomina : ");
                        fecha = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Ingresa el id del empleado : ");
                        idEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Sueldo : ");
                        sueldo = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Dias laborados : ");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Otros ingresos : ");
                        otros = Convert.ToDecimal(Console.ReadLine());



                        controladores_Nomina.Agregar_Nomina(id, fecha, idEmpleado, sueldo, dias, otros);
                        controladores_Nomina.TraerDatosNomina();

                        #endregion AgregarNomina


                        
                        #region ActualizarNomina
                       
                        Console.WriteLine("Actualizar nomina");
                        Console.ReadKey();

                        Console.Write("Ingresa un Id para la nomina: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Actualiza la fecha para la nomina : ");
                        fecha = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Actualiza el id del empleado : ");
                        idEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Actuliza Sueldo : ");
                        sueldo = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Actualiza dias laborados : ");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Actualiza otros ingresos : ");
                        otros = Convert.ToDecimal(Console.ReadLine());

                        controladores_Nomina.Actualizar_Nomina(id, fecha, idEmpleado, sueldo, dias, otros);
                        controladores_Nomina.TraerDatosNomina();
                        #endregion ActualizarNomina


                        
                        #region BorrarIdNomina
                       
                        Console.WriteLine("Borrar por ID de nomina:");
                        Console.ReadKey();
                        Console.Write("Introduzca Id: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        controladores_Nomina.BorrarPorId(id);
                        controladores_Nomina.TraerDatosNomina();
                       
                        Console.WriteLine("Es todo con nomina, gracias!");
                        #endregion BorrarIdNomina


                        break;
                    case 4:
                        Console.WriteLine("Seguro que quieres Salir? /si /no");
                        string respuesta = Convert.ToString(Console.ReadLine());

                        if (respuesta == "si")
                        {
                            opc = 4;
                        }
                        else
                        {
                            Console.Clear();
                            opc = 0; 
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        Console.Clear();
                        break;

                }

            } while (opc!=4);


        }
        public class Menu
        {
            public void Mostrarmenu()
            {
                Console.WriteLine("1: Areas");
                Console.WriteLine("2: Empleados");
                Console.WriteLine("3: Nomina");
                Console.WriteLine("4: Salir");
            }
        }
    }
}
