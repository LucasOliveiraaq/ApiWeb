using System.Collections.Generic;
using WebApiGroceryStore.Dao;
using WebApiGroceryStore.Model;

namespace WebApiGroceryStore.Repositorio
{
    public class Compra_e_vendaRepositorio
    {
        private readonly DaoCompra_e_Venda daoCompra_E_Venda;

        public Compra_e_vendaRepositorio()
        {
            daoCompra_E_Venda = new DaoCompra_e_Venda();
        }
        public List<Compra_e_Venda> GetCompra_e_venda
        {
            get { return daoCompra_E_Venda.getCompra_e_venda(); }
        }
        public void InserirCompra_e_Venda(Compra_e_Venda compra_E_Venda)
        {
            daoCompra_E_Venda.InserirCompra_E_venda(compra_E_Venda);
        }
        public void UpdateCompra_e_venda(Compra_e_Venda compra_E_Venda)
        {
            daoCompra_E_Venda.updateCompra_E_venda(compra_E_Venda);
        }
        public void DeleteCompra_e_venda(Compra_e_Venda compra_E_Venda)
        {
            daoCompra_E_Venda.deleteCompra_E_venda(compra_E_Venda);
        }
    }
}
