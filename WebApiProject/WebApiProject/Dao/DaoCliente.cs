using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApiProject.Model;

namespace WebApiProject.Dao
{
    public class DaoCliente
    {
        string conexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Aula; Integrated Security = True";

        public List<Cliente> getCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM cliente", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var cliente = new Cliente();
                                cliente.nome = reader["nome"].ToString();
                                cliente.cpf = reader["cpf"].ToString();
                                cliente.rg = reader["rg"].ToString();
                                ///Não aceita coluna que esteja null.
                               // cliente.endereco = reader["endereco"].ToString();
                                clientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            return clientes;
        }
        public void InserirCliente(Cliente cliente)
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into cliente(nome, cpf) values(@NOME, @CPF)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NOME", cliente.nome);
                    cmd.Parameters.AddWithValue("@CPF", cliente.cpf);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void updateCliente(Cliente cliente)
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update cliente set rg = @rg where Id = @id ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@rg", cliente.rg);
                    cmd.Parameters.AddWithValue("@id", cliente.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteCliente(Cliente cliente)
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete cliente where id = @id", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", cliente.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
