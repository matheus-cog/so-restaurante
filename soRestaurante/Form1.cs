using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace soRestaurante
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );

        public Form1()
        {         
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnlSMAlteracoes.Visible = false;
            pnlSMEstatisticas.Visible = false;
        }

        private void hideSubmenu()
        {
            if (pnlSMAlteracoes.Visible == true)
            {
                pnlSMAlteracoes.Visible = false;
            }
            if (pnlSMEstatisticas.Visible == true)
            {
                pnlSMEstatisticas.Visible = false;
            }
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            changeColorButtonToOrange(btnInicio);
            changeColorButtonToBlack(btnEdicao);
            changeColorButtonToBlack(button15);
            lblMain.Text = "Início";
            picChurrasco.Visible = true;

            if (activeForm != null)
            {
                activeForm.Close();
            }
            hideSubmenu();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            changeColorButtonToOrange(btnEdicao);
            changeColorButtonToBlack(btnInicio);
            changeColorButtonToBlack(button15);
            hideSubmenu();

            showSubmenu(pnlSMAlteracoes);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            changeColorButtonToOrange(button15);
            changeColorButtonToBlack(btnInicio);
            changeColorButtonToBlack(btnEdicao);
            hideSubmenu();

            showSubmenu(pnlSMEstatisticas);
        }

        private Form activeForm = null;

        private void openCadastroReceita(Form cadastrodReceita)
        {
            if (activeForm != null)
            {
                activeForm.Close();                
            }
            activeForm = cadastrodReceita;
            cadastrodReceita.TopLevel = false;
            cadastrodReceita.FormBorderStyle = FormBorderStyle.None;
            cadastrodReceita.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(cadastrodReceita);
            pnlMain.Tag = cadastrodReceita;
            pnlMain.BringToFront();
            pnlMain.Show();
            cadastrodReceita.Show();
        }

        private void openListagemReceitas(Form listagemdReceitas)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = listagemdReceitas;
            listagemdReceitas.TopLevel = false;
            listagemdReceitas.FormBorderStyle = FormBorderStyle.None;
            listagemdReceitas.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(listagemdReceitas);
            pnlMain.Tag = listagemdReceitas;
            pnlMain.BringToFront();
            pnlMain.Show();
            listagemdReceitas.Show();
        }

        private void openEdicaoReceita(Form edicaodReceita)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = edicaodReceita;
            edicaodReceita.TopLevel = false;
            edicaodReceita.FormBorderStyle = FormBorderStyle.None;
            edicaodReceita.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(edicaodReceita);
            pnlMain.Tag = edicaodReceita;
            pnlMain.BringToFront();
            pnlMain.Show();
            edicaodReceita.Show();
        }

        private void openRemocaoReceita(Form remocaodReceita)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = remocaodReceita;
            remocaodReceita.TopLevel = false;
            remocaodReceita.FormBorderStyle = FormBorderStyle.None;
            remocaodReceita.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(remocaodReceita);
            pnlMain.Tag = remocaodReceita;
            pnlMain.BringToFront();
            remocaodReceita.Show();
        }

        private void openListagemDificuldade(Form listagemdDificuldade)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = listagemdDificuldade;
            listagemdDificuldade.TopLevel = false;
            listagemdDificuldade.FormBorderStyle = FormBorderStyle.None;
            listagemdDificuldade.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(listagemdDificuldade);
            pnlMain.Tag = listagemdDificuldade;
            pnlMain.BringToFront();
            listagemdDificuldade.Show();
        }

        private void openListagemTempoPreparo(Form listagemdTempoPreparo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = listagemdTempoPreparo;
            listagemdTempoPreparo.TopLevel = false;
            listagemdTempoPreparo.FormBorderStyle = FormBorderStyle.None;
            listagemdTempoPreparo.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(listagemdTempoPreparo);
            pnlMain.Tag = listagemdTempoPreparo;
            pnlMain.BringToFront();
            listagemdTempoPreparo.Show();
        }

        private void openListagemCategoria(Form listagemdCategoria)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = listagemdCategoria;
            listagemdCategoria.TopLevel = false;
            listagemdCategoria.FormBorderStyle = FormBorderStyle.None;
            listagemdCategoria.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(listagemdCategoria);
            pnlMain.Tag = listagemdCategoria;
            pnlMain.BringToFront();
            listagemdCategoria.Show();
        }

        private void btnCadastroReceita_Click(object sender, EventArgs e)
        {
            openCadastroReceita(new cadastroReceita());

            lblMain.Text = "Cadastro de receitas";
            picChurrasco.Visible = false;
        }

        private void btnEdicaoReceita_Click(object sender, EventArgs e)
        {
            openEdicaoReceita(new edicaoReceita());
            lblMain.Text = "Edição de receita";
            picChurrasco.Visible = false;
        }

        private void btnDeleteReceita_Click(object sender, EventArgs e)
        {
            openRemocaoReceita(new remocaoReceita());
            lblMain.Text = "Remoção de receita";
            picChurrasco.Visible = false;
        }

        private void btnListagemReceita_Click(object sender, EventArgs e)
        {
            openListagemReceitas(new listagemReceitas());
            lblMain.Text = "Listagem de receitas";
            picChurrasco.Visible = false;
        }

        private void btnListagemPorDificultadade_Click(object sender, EventArgs e)
        {
            openListagemDificuldade(new listagemDificuldade());
            lblMain.Text = "Listagem por tempo de execução";
            picChurrasco.Visible = false;
        }

        private void btnListagemPorCategoria_Click(object sender, EventArgs e)
        {
            openListagemCategoria(new listagemCategoria());
            lblMain.Text = "Listagem por categoria";
            picChurrasco.Visible = false;
        }

        private void btnListagemPorTempoDePreparo_Click(object sender, EventArgs e)
        {
            openListagemTempoPreparo(new listagemTempoPreparo());
            lblMain.Text = "Listagem por tempo de preparo";
            picChurrasco.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void changeColorButtonToOrange(Button btnToOrange)// Troca cor do botão para laranja
        {
            btnToOrange.BackColor = Color.FromArgb(247, 88, 32);
        }

        private void changeColorButtonToBlack(Button btnToBlack) // Troca cor do botão para preto
        {
            btnToBlack.BackColor = Color.Black;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}