namespace WebApiGroceryStore.Model
{
    public class Compra_e_Venda
    { 
        public int Id_produto { get; set; }
        public int Valor { get; set; } 
        public int Id_Cliente { get; set; }

        public override string ToString()
        {
            return Id_produto + " - " + Valor + " - " + Id_Cliente;
        }
    }
}
