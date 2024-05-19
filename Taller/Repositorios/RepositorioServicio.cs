using Taller.Datos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Taller.Repositorios
{
    public class RepositorioServicio : IRepositorioServicio
    {
        private readonly DBContext _context;

        public RepositorioServicio(DBContext context)
        {
            _context = context;
        }

        public async Task<Servicio> Add(Servicio servicio)
        {
            await _context.Servicios.AddAsync(servicio);
            await _context.SaveChangesAsync();
            return servicio;
        }

        public async Task DeleteServicio(int servicioID)
        {
            var servicio = await _context.Servicios.FindAsync(servicioID);
            if (servicio != null)
            {
                _context.Servicios.Remove(servicio);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Servicio?> GetServicio(int servicioID)
        {
            return await _context.Servicios.FindAsync(servicioID);
        }

        public async Task UpdateServicio(int id, Servicio servicio)
        {
            var servicioActual = await _context.Servicios.FindAsync(id);
            if (servicioActual != null)
            {
                servicioActual.NombreServicio = servicio.NombreServicio;
                servicioActual.Descripcion = servicio.Descripcion;
                servicioActual.DuracionEstimada = servicio.DuracionEstimada;
                servicioActual.Precio = servicio.Precio;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Servicio>> GetAll()
        {
            return await _context.Servicios.ToListAsync();
        }
    }
}
