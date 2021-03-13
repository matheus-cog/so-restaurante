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
    public partial class listagemDificuldade : Form
    {
        public listagemDificuldade()
        {
            InitializeComponent();
        }

        private void listagemDificuldade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_soRestauranteDataSet1.receitas' table. You can move, or remove it, as needed.
            this.receitasTableAdapter.Fill(this.bd_soRestauranteDataSet1.receitas);

        }
    }
}
