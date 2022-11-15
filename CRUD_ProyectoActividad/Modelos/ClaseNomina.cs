using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD_ProyectoActividad.Modelos
{
    class ClaseNomina
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public decimal Sueldo { get; set; }
        public int Dias { get; set; }

        public decimal TotalBasico { get; set; } //Sueldo*dias/30
        public decimal Otros { get; set; }
        public decimal Devengado { get; set; } //TtotalBasico +Otros
    }
}
