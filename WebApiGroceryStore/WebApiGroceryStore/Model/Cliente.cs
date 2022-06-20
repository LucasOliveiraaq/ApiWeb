namespace WebApiGroceryStore.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }

        public override string ToString()
        {
            return id + " - " + nome;
        }
    }
}
