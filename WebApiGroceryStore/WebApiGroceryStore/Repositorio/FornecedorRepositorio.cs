using System.Collections.Generic;
using WebApiGroceryStore.Dao;
using WebApiGroceryStore.Model;

namespace WebApiGroceryStore.Repositorio
{
    public class FornecedorRepositorio
    {
        private readonly DaoFornecedor daoFornecedor;

        public FornecedorRepositorio()
        {
            daoFornecedor = new DaoFornecedor();
        }
        public List<Fornecedor> GetFornecedor
        {
            get { return daoFornecedor.getFornecedor(); }
        }
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            daoFornecedor.InserirFornecedor(fornecedor);
        }
        public void UpdateFornecedor(Fornecedor fornecedor)
        {
            daoFornecedor.updateFornecedor(fornecedor);
        }
        public void DeleteFornecedor(Fornecedor fornecedor)
        {
            daoFornecedor.deleteFornecedor(fornecedor);
        }
    }
}

