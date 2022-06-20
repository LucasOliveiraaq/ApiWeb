using System.Collections.Generic;
using WebApiProject.Dao;
using WebApiProject.Model;

namespace WebApiProject.Repositorio
{
    public class ContaRepositorio
    {
        private readonly DaoConta daoConta;

        public ContaRepositorio()
        {
            daoConta = new DaoConta();  
        }
        public List<Conta> GetConta
        {
            get
            {
                return daoConta.getConta();
            }
        }
        public void inserirConta(Conta conta)
        {
            daoConta.inserirConta(conta);
        }
        public void updateConta(Conta conta)
        {
            daoConta.upadateConta(conta);
        }
        public void deleteConta(Conta conta)
        {
            daoConta.deleteConta(conta);
        }
    }
}
