namespace soRestaurante
{
    partial class listagemDificuldade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bd_soRestauranteDataSet1 = new soRestaurante.bd_soRestauranteDataSet1();
            this.receitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receitasTableAdapter = new soRestaurante.bd_soRestauranteDataSet1TableAdapters.receitasTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graudificuldadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_soRestauranteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 72);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.graudificuldadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receitasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 490);
            this.dataGridView1.TabIndex = 5;
            // 
            // bd_soRestauranteDataSet1
            // 
            this.bd_soRestauranteDataSet1.DataSetName = "bd_soRestauranteDataSet1";
            this.bd_soRestauranteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receitasBindingSource
            // 
            this.receitasBindingSource.DataMember = "receitas";
            this.receitasBindingSource.DataSource = this.bd_soRestauranteDataSet1;
            // 
            // receitasTableAdapter
            // 
            this.receitasTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome da receita";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 220;
            // 
            // graudificuldadeDataGridViewTextBoxColumn
            // 
            this.graudificuldadeDataGridViewTextBoxColumn.DataPropertyName = "grau_dificuldade";
            this.graudificuldadeDataGridViewTextBoxColumn.HeaderText = "Grau de dificuldade";
            this.graudificuldadeDataGridViewTextBoxColumn.Name = "graudificuldadeDataGridViewTextBoxColumn";
            this.graudificuldadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.graudificuldadeDataGridViewTextBoxColumn.Width = 330;
            // 
            // listagemDificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(734, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listagemDificuldade";
            this.Text = "listagemDificuldade";
            this.Load += new System.EventHandler(this.listagemDificuldade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_soRestauranteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bd_soRestauranteDataSet1 bd_soRestauranteDataSet1;
        private System.Windows.Forms.BindingSource receitasBindingSource;
        private bd_soRestauranteDataSet1TableAdapters.receitasTableAdapter receitasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graudificuldadeDataGridViewTextBoxColumn;
    }
}