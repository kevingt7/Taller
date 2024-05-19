using Taller.Datos;

namespace Taller.Repositorios
{
    public interface IRepositorioCita
    {
        Task<Cita> Add(Cita cita);
        Task DeleteCita(int id);
        Task<Cita?> GetCita(int id);
        Task UpdateCita(int id, Cita cita);
        Task<List<Cita>> GetAll();
    }
}

