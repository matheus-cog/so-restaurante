using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace soRestaurante
{
    public partial class remocaoReceita : Form
    {
        public remocaoReceita()
        {
            InitializeComponent();
        }

        int idReceita;

        private void limpaCampos()
        {
            txtNomeReceita.Text = "";
            mskTempoPreparo.Text = "";

            if (rdoFacil.Checked == true)
            {
                rdoFacil.Checked = false;
            }

            if (rdoMedio.Checked == true)
            {
                rdoMedio.Checked = false;
            }

            if (rdoDificil.Checked == true)
            {
                rdoDificil.Checked = false;
            }

            txtNSS.Text = "";
            txtCategoria.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			if (txtNomeReceita.Text == "")
			{
				MessageBox.Show("Você deve inserir um nome para busca", "Aunt Restaurant");
			}

			else
			{
				if (MessageBox.Show("Você realmente quer aplicar as alterações?", "Aunt Restaurant", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
                    try
                    {
                        string nomeReceita = txtNomeReceita.Text;

                        bd.removeReceita(idReceita);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Não foi possível aplicar as alterações. Procure o administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
			}
		}

		private void btnLimpa_Click(object sender, EventArgs e)
		{
			txtNomeReceita.Text = "";
		}

        private void btnBusca_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Aunt Restaurant\bin\data\bd_soRestaurante.mdf;Integrated Security=True");

            connection.Open();

            try
            {
                SqlCommand getNomeReceita = new SqlCommand(String.Format("SELECT * FROM receitas WHERE nome='{0}'", txtNomeReceita.Text), connection);

                SqlDataReader dataReader = getNomeReceita.ExecuteReader();

                if (dataReader.Read())
                {
                    txtNomeReceita.Text = (dataReader["nome"].ToString());
                    mskTempoPreparo.Text = (dataReader["tempo_duracao"].ToString());

                    if ((dataReader["grau_dificuldade"].ToString()) == "1")
                    {
                        rdoFacil.Checked = true;
                    }
                    if ((dataReader["grau_dificuldade"].ToString() == "2"))
                    {
                        rdoMedio.Checked = true;
                    }
                    if ((dataReader["grau_dificuldade"].ToString() == "3"))
                    {
                        rdoDificil.Checked = true;
                    }

                    txtNSS.Text = (dataReader["numero_servidos"].ToString());
                    txtCategoria.Text = (dataReader["categoria"].ToString());
                    idReceita = Convert.ToInt32(dataReader["id_receita"].ToString());
                    idReceita = Convert.ToInt32(idReceita);

                    MessageBox.Show("Listagem realizada com sucesso!", "Aunt Restaurant");
                }

                else
                {
                    MessageBox.Show("Receita não encontrada.");
                    limpaCampos();
                }

                connection.Close();                
            }

            catch
            {
                MessageBox.Show("Não foi possível realizar a listagem.", "Aunt Restaurant");
            }
        }
    }
}
