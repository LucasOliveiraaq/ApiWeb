using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApiGroceryStore.Model;

namespace WebApiGroceryStore.Dao
{
    public class DaoCompra_e_Venda
    {
        string conexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Mercearia; Integrated Security = True";

        public List<Compra_e_Venda> getCompra_e_venda()
        {
            List<Compra_e_Venda> compra_E_Vendas = new List<Compra_e_Venda>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM compra_e_venda", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var compra_e_venda = new Compra_e_Venda();
                                //compra_e_venda.nome = reader["nome"].ToString();
                                compra_E_Vendas.Add(compra_e_venda);
                            }
                        }
                    }
                }
            }
            return compra_E_Vendas;
        }
        public void InserirCompra_E_venda(Compra_e_Venda compra_E_Venda)
        {
            List<Compra_e_Venda> compra_E_Vendas = new List<Compra_e_Venda>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into compra_e_venda(valor) values(@VALOR)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NOME", compra_E_Venda.Valor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void updateCompra_E_venda(Compra_e_Venda compra_E_Venda)
        {
            List<Compra_e_Venda> compra_E_Vendas = new List<Compra_e_Venda>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update compra_e_venda set valor = @valor where Id = @id_produto ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@rg", compra_E_Venda.Valor);
                    cmd.Parameters.AddWithValue("@id", compra_E_Venda.Id_produto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteCompra_E_venda(Compra_e_Venda compra_E_Venda)
        {
            List<Compra_e_Venda> compra_E_Vendas = new List<Compra_e_Venda>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete compra_e_venda where id = @id", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", compra_E_Venda.Id_produto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
