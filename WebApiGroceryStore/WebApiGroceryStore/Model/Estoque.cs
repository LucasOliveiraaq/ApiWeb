using System;

namespace WebApiGroceryStore.Model
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Alteracao { get; set; }

        public override string ToString()
        {
            return Id + " - " + Nome + " - " + Quantidade + " - " + Data_Cadastro + " - " + Data_Alteracao;
        }
    }
}
