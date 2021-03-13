using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soRestaurante
{
    public partial class cadastroReceita : Form
    {
        public cadastroReceita()
        {
            InitializeComponent();            
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
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

            cmbNumSS.Text = " ";
            cmbCategoria.Text = " ";
            txtIngredientes.Text = "";
            txtModoPreparo.Text = "";
        }

        public void cadastro(string nome, string tempoPreparo, int dificuldade, int numeroServidos, string categoria, string ingredientes, string modoPreparo)
        {

            // Condição para verificação das opções de dificuldade de preparo

            if (rdoFacil.Checked == true)
            {
                dificuldade = 1;
            }
            else
            {
                if (rdoMedio.Checked == true)
                {
                    dificuldade = 2;
                }
                else
                {
                    if (rdoDificil.Checked == true)
                    {
                        dificuldade = 3;
                    }
                }
            }

            bd.cadastraTudo(nome, tempoPreparo, dificuldade, numeroServidos, categoria, ingredientes, modoPreparo);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNomeReceita.Text == "" || mskTempoPreparo.Text == "" || cmbNumSS.Text == "" || cmbCategoria.Text == "" || cmbNumSS.Text == " " ||
                cmbCategoria.Text == " " || txtIngredientes.Text == "" || txtModoPreparo.Text == "" || rdoFacil.Checked == false && rdoMedio.Checked == false && rdoDificil.Checked == false)
            {
                MessageBox.Show("Todos os campos deverão estar completos para o cadastro.", "Aunt Restaurant");
            }

            else
            {
                if (MessageBox.Show("Você realmente quer aplicar as alterações?", "Aunt Restaurant", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int numeroServidos;
                    numeroServidos = Convert.ToInt32(cmbNumSS.Text);

                    cadastro(txtNomeReceita.Text, mskTempoPreparo.Text, 1, numeroServidos, cmbCategoria.Text, txtIngredientes.Text, txtModoPreparo.Text);
                }
            }
        }
	}
}
