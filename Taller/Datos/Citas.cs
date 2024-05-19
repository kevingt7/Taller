using System;
using System.ComponentModel.DataAnnotations;

namespace Taller.Datos
{
    public class Cita
    {
        public int CitaID { get; set; }

        [Required(ErrorMessage = "El ClienteID es requerido")]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "El ServicioID es requerido")]
        public int ServicioID { get; set; }

        [Required(ErrorMessage = "La fecha de la cita es requerida")]
        public DateTime FechaCita { get; set; }

        [Required(ErrorMessage = "La hora de la cita es requerida")]
        public TimeSpan HoraCita { get; set; }

        // Relación uno a uno con la tabla de clientes
        public Cliente Cliente { get; set; }

        // Relación uno a uno con la tabla de servicios
        public Servicio Servicio { get; set; }
    }
}
