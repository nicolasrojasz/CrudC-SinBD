using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CRUD_ProyectoActividad.Modelos
{
    class ClaseAreas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Nombre { get; set; }
    }
}
