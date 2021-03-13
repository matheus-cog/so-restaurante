using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soRestaurante
{
    public partial class edicaoReceita : Form
    {
        public edicaoReceita()
        {
            InitializeComponent();
        }

        string idReceita;

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

            txtNumeroServidos.Text = "";
            txtCategoria.Text = "";
            txtIngredientes.Text = "";
            txtModoPreparo.Text = "";
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
                        int numeroServidos = Convert.ToInt16(txtNumeroServidos.Text);
                        int nivelDificuldade = 0;

                        string nomeReceita = txtNomeReceita.Text;
                        string tempoPreparo = mskTempoPreparo.Text;
                        string categoria = txtCategoria.Text;
                        string ingredientes = txtIngredientes.Text;
                        string modoPreparo = txtModoPreparo.Text;

                        if (rdoFacil.Checked == true)
                        {
                            nivelDificuldade = 1;
                        }
                        else
                        {
                            if (rdoMedio.Checked == true)
                            {
                                nivelDificuldade = 2;
                            }
                            else
                            {
                                if (rdoDificil.Checked == true)
                                {
                                    nivelDificuldade = 3;
                                }
                            }
                        }

                        bd.editaTudo(nomeReceita, tempoPreparo, nivelDificuldade, numeroServidos, categoria, ingredientes, modoPreparo, idReceita);
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

                    txtNumeroServidos.Text = (dataReader["numero_servidos"].ToString());
                    txtCategoria.Text = (dataReader["categoria"].ToString());
                    txtIngredientes.Text = (dataReader["ingredientes"].ToString());
                    txtModoPreparo.Text = (dataReader["modo_preparo"].ToString());
                    idReceita = (dataReader["id_receita"].ToString());

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
