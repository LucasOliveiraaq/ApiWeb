using System.Collections.Generic;
using WebApiProject.Dao;
using WebApiProject.Model;

namespace WebApiProject.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly DaoCliente daoCliente;

        public ClienteRepositorio()
        {
            daoCliente = new DaoCliente();
        }
        public List<Cliente> GetCliente
        {
            get { return daoCliente.getCliente(); }
        }
        public void InserirCliente(Cliente cliente)
        {
            daoCliente.InserirCliente(cliente);
        }
        public void UpdateCliente(Cliente cliente)
        {
            daoCliente.updateCliente(cliente);
        }
        public void DeleteCliente(Cliente cliente)
        {
            daoCliente.deleteCliente(cliente);
        }
    }
}
