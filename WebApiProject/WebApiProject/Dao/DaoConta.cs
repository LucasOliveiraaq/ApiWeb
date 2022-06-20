using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApiProject.Model;

namespace WebApiProject.Dao
{
    public class DaoConta
    {
        string conexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Aula; Integrated Security = True";
        public List<Conta> getConta()
        {
            List<Conta> contas = new List<Conta>();

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM conta", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                var conta = new Conta();
                               // conta.agencia = reader["agencia"].GetHashCode();
                            }
                        }
                    }

                }
            }
                return contas;
        }
        public void inserirConta(Conta conta)
        {
            List<Conta> contas = new List<Conta>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into conta(agencia, numerodaconta) values(@AGENCIA, @NUMERODACONTA)", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@agencia", conta.agencia);
                    cmd.Parameters.AddWithValue("@numerodaconta", conta.numeroDaConta);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void upadateConta(Conta conta)
        {
            List<Conta> contas = new List<Conta>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("update conta set agencia = @agencia where Id = @id ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@agencia", conta.agencia);
                    cmd.Parameters.AddWithValue("@id", conta.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteConta(Conta conta)
        {
            List<Conta> contas = new List<Conta>();
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("delete conta where id = @id", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", conta.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
