using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Taller.Datos
{
    public class Servicio
    {
        public int ServicioID { get; set; }

        [Required(ErrorMessage = "El nombre del servicio es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string NombreServicio { get; set; }

        [Required(ErrorMessage = "La descripción del servicio es requerida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La duración estimada del servicio es requerida")]
        public TimeSpan DuracionEstimada { get; set; }

        [Required(ErrorMessage = "El precio del servicio es requerido")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a cero")]
        public decimal Precio { get; set; }

        public List<Cita> Citas { get; set; }
    }
}
