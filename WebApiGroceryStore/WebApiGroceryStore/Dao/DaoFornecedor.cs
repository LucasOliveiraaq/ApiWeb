using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApiGroceryStore.Model;

namespace WebApiGroceryStore.Dao
{
    public class DaoFornecedor
    {
        string conexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Mercearia; Integrated Security = True";

        public List<Fornecedor> getFornecedor()
        {
            List<Fornecedor> fornecedors = new List<Fornecedor>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM fornecedor", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                               var fornecedor = new Fornecedor();
                               fornecedor.Nome = reader["nome"].ToString();
                               fornecedors.Add(fornecedor);
                            }
                        }
                    }
                }
            }
            return fornecedors;
        }
        public void InserirFornecedor(Fornecedor fornecedor)
        {
            List<Fornecedor> fornecedors = new List<Fornecedor>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into fornecedor(nome) values(@NOME)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NOME", fornecedor.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void updateFornecedor(Fornecedor fornecedor)
        {
            List<Fornecedor> fornecedors = new List<Fornecedor>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update fornecedor set nome = @nome where Id = @id ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@rg", fornecedor.Nome);
                    cmd.Parameters.AddWithValue("@id", fornecedor.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteFornecedor(Fornecedor fornecedor)
        {
            List<Fornecedor> fornecedors = new List<Fornecedor>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete fornecedor where id = @id", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", fornecedor.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
