using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace soRestaurante
{
    class bd
    {
        public static void cadastraTudo(string nome, string tempoPreparo, int dificuldade, int numeroServidos, string categoria, string ingredientes, string modoPreparo)
        {                      
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Aunt Restaurant\bin\data\bd_soRestaurante.mdf;Integrated Security=True");

            connection.Open();

            try
            {
                SqlCommand insert = new SqlCommand(String.Format("INSERT INTO receitas (nome, categoria, tempo_duracao, grau_dificuldade, numero_servidos, ingredientes, modo_preparo) VALUES ('{0}','{1}','{2}',{3},{4},'{5}','{6}')", nome, categoria, tempoPreparo, dificuldade, numeroServidos, ingredientes, modoPreparo), connection);

                insert.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Cadastro realizado com sucesso!", "Aunt Restaurant");
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar a gravação.", "Aunt Restaurant");
            }
        }

        public static void editaTudo(string nome, string tempoPreparo, int dificuldade, int numeroServidos, string categoria, string ingredientes, string modoPreparo, string idReceita)
        {          
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Aunt Restaurant\bin\data\bd_soRestaurante.mdf;Integrated Security=True");

            connection.Open();

            try
            {
                SqlCommand update = new SqlCommand(String.Format("UPDATE receitas SET nome = '{0}', categoria = '{1}', tempo_duracao = '{2}', grau_dificuldade = {3}, numero_servidos = {4}, ingredientes = '{5}', modo_preparo = '{6}' WHERE id_receita = {7}", nome, categoria, tempoPreparo, dificuldade, numeroServidos, ingredientes, modoPreparo, idReceita), connection);

                update.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Registro atualizado com sucesso!", "Aunt Restaurant");
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar a edição.", "Aunt Restaurant");
            }
        }

        public static void removeReceita(int idReceita)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Aunt Restaurant\bin\data\bd_soRestaurante.mdf;Integrated Security=True");

            connection.Open();

            try
            {
                SqlCommand delete = new SqlCommand(String.Format("DELETE FROM receitas WHERE id_receita = {0}", idReceita), connection);

                delete.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Registro deletado com sucesso!", "Aunt Restaurant");
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
                MessageBox.Show("Não foi possível realizar a remoção.", "Aunt Restaurant");
            }
        }
    }
}
