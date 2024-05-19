using Taller.Datos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Taller.Repositorios
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly DBContext _context;

        public RepositorioCita(DBContext context)
        {
            _context = context;
        }

        public async Task<Cita> Add(Cita cita)
        {
            await _context.Citas.AddAsync(cita);
            await _context.SaveChangesAsync();
            return cita;
        }

        public async Task DeleteCita(int citaID)
        {
            var cita = await _context.Citas.FindAsync(citaID);
            if (cita != null)
            {
                _context.Citas.Remove(cita);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cita?> GetCita(int citaID)
        {
            return await _context.Citas.FindAsync(citaID);
        }

        public async Task UpdateCita(int id, Cita cita)
        {
            var citaActual = await _context.Citas.FindAsync(id);
            if (citaActual != null)
            {
                citaActual.ClienteID = cita.ClienteID;
                citaActual.ServicioID = cita.ServicioID;
                citaActual.FechaCita = cita.FechaCita;
                citaActual.HoraCita = cita.HoraCita;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Cita>> GetAll()
        {
            return await _context.Citas.ToListAsync();
        }
    }
}
