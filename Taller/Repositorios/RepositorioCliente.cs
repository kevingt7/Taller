using Taller.Datos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Taller.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly DBContext _context;

        public RepositorioCliente(DBContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task DeleteCliente(int ClienteID)
        {
            var cliente = await _context.Clientes.FindAsync(ClienteID);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> GetCliente(int ClienteID)
        {
            return await _context.Clientes.FindAsync(ClienteID);
        }

        public async Task UpdateCliente(int id, Cliente cliente)
        {
            var clienteActual = await _context.Clientes.FindAsync(id);
            if (clienteActual != null)
            {
                clienteActual.Nombre = cliente.Nombre;
                clienteActual.Correo = cliente.Correo;
                clienteActual.Telefono = cliente.Telefono;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Cliente>> GetAll() 
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
