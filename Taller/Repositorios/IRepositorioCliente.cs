using Taller.Datos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Taller.Repositorios
{
    public interface IRepositorioCliente
    {
        Task<Cliente> Add(Cliente cliente);
        Task DeleteCliente(int id);
        Task<Cliente?> GetCliente(int id);
        Task UpdateCliente(int id, Cliente cliente);
        Task<List<Cliente>> GetAll(); 
    }
}
