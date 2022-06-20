namespace WebApiProject.Model
{
    public class Conta
    {
        public int id { get; set; }
        public int agencia { get; set; }
        public int numeroDaConta { get; set; }
        public string correntista { get; set; }
        public double saldo { get; set; }
        public int quantidadeDeContas { get; set; }

        public override string ToString()
        {
            return id + " - " + agencia + " - " + numeroDaConta + " - " + correntista + " - " + saldo + " - " + quantidadeDeContas;
        }
    }
}
