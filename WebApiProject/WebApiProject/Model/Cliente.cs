namespace WebApiProject.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public override string ToString()
        {
            return id + " - " + nome + " - " + cpf + " - " + rg + " - " + endereco;
        }
    }
}
