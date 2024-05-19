using Taller.Datos;

namespace Taller.Repositorios
{
    public interface IRepositorioServicio
    {
        Task<Servicio> Add(Servicio servicio);
        Task DeleteServicio(int id);
        Task<Servicio?> GetServicio(int id);
        Task UpdateServicio(int id, Servicio servicio);
        Task<List<Servicio>> GetAll();
    }
}
