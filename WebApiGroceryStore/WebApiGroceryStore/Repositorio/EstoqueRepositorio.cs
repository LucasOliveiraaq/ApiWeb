using System.Collections.Generic;
using WebApiGroceryStore.Dao;
using WebApiGroceryStore.Model;

namespace WebApiGroceryStore.Repositorio
{
    public class EstoqueRepositorio
    {
        private readonly DaoEstoque daoEstoque;

        public EstoqueRepositorio()
        {
            daoEstoque = new DaoEstoque();
        }
        public List<Estoque> GetEstoque
        {
            get { return daoEstoque.getEstoque(); }
        }
        public void InserirEstoque(Estoque estoque)
        {
            daoEstoque.InserirEstoque(estoque);
        }
        public void UpdateEstoque(Estoque estoque)
        {
            daoEstoque.updateEstoque(estoque);
        }
        public void DeleteEstoque(Estoque estoque)
        {
            daoEstoque.deleteEstoque(estoque);
        }
    }
}
