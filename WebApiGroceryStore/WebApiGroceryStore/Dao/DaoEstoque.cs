using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApiGroceryStore.Model;

namespace WebApiGroceryStore.Dao
{
    public class DaoEstoque
    {
        string conexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Mercearia; Integrated Security = True";

        public List<Estoque> getEstoque()
        {
            List<Estoque> estoques = new List<Estoque>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM estoque", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var Estoque = new Estoque();
                                Estoque.Nome = reader["nome"].ToString();
                                Estoque.Quantidade = reader ["quantidade"].GetHashCode();
                                estoques.Add(Estoque);
                            }
                        }
                    }
                }
            }
            return estoques;
        }

        public void InserirEstoque(Estoque estoque)
        {
            List<Estoque> estoques = new List<Estoque>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into estoque(nome, quantidade) values(@NOME, @QUANTIDADE)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NOME", estoque.Nome);
                    cmd.Parameters.AddWithValue("@QUANTIDADE", estoque.Quantidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void updateEstoque(Estoque estoque)
        {
            List<Estoque> estoques = new List<Estoque>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update estoque set nome = @nome where Id = @id ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NOME", estoque.Nome);
                    cmd.Parameters.AddWithValue("@id", estoque.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void deleteEstoque(Estoque estoque)
        {
            List<Estoque> estoques = new List<Estoque>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete estoque where id = @id", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", estoque.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
