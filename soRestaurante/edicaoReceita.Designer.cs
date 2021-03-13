namespace soRestaurante
{
    partial class edicaoReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edicaoReceita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoDificil = new System.Windows.Forms.RadioButton();
            this.rdoMedio = new System.Windows.Forms.RadioButton();
            this.rdoFacil = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTempoPreparo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.txtNumeroServidos = new System.Windows.Forms.TextBox();
            this.receitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsoRestauranteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_soRestauranteDataSet = new soRestaurante.bd_soRestauranteDataSet();
            this.receitasTableAdapter = new soRestaurante.bd_soRestauranteDataSetTableAdapters.receitasTableAdapter();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.receitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoRestauranteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_soRestauranteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 72);
            this.panel1.TabIndex = 3;
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusca.BackgroundImage")));
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(346, 122);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(29, 28);
            this.btnBusca.TabIndex = 37;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome da receita";
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpa.FlatAppearance.BorderSize = 0;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(381, 122);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(29, 28);
            this.btnLimpa.TabIndex = 38;
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(647, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(566, 527);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtModoPreparo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModoPreparo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoPreparo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtModoPreparo.Location = new System.Drawing.Point(412, 384);
            this.txtModoPreparo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModoPreparo.Multiline = true;
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.Size = new System.Drawing.Size(297, 117);
            this.txtModoPreparo.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Modo de preparo";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientes.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIngredientes.Location = new System.Drawing.Point(412, 209);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(297, 117);
            this.txtIngredientes.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ingredientes";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Location = new System.Drawing.Point(381, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 345);
            this.label8.TabIndex = 47;
            this.label8.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Número de pessoas a serem servidas";
            // 
            // rdoDificil
            // 
            this.rdoDificil.AutoSize = true;
            this.rdoDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDificil.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDificil.Location = new System.Drawing.Point(140, 293);
            this.rdoDificil.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDificil.Name = "rdoDificil";
            this.rdoDificil.Size = new System.Drawing.Size(53, 18);
            this.rdoDificil.TabIndex = 52;
            this.rdoDificil.TabStop = true;
            this.rdoDificil.Text = "Difícil";
            this.rdoDificil.UseVisualStyleBackColor = true;
            // 
            // rdoMedio
            // 
            this.rdoMedio.AutoSize = true;
            this.rdoMedio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMedio.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedio.Location = new System.Drawing.Point(77, 293);
            this.rdoMedio.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMedio.Name = "rdoMedio";
            this.rdoMedio.Size = new System.Drawing.Size(55, 18);
            this.rdoMedio.TabIndex = 50;
            this.rdoMedio.TabStop = true;
            this.rdoMedio.Text = "Médio";
            this.rdoMedio.UseVisualStyleBackColor = true;
            // 
            // rdoFacil
            // 
            this.rdoFacil.AutoSize = true;
            this.rdoFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFacil.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFacil.Location = new System.Drawing.Point(22, 293);
            this.rdoFacil.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFacil.Name = "rdoFacil";
            this.rdoFacil.Size = new System.Drawing.Size(47, 18);
            this.rdoFacil.TabIndex = 49;
            this.rdoFacil.TabStop = true;
            this.rdoFacil.Text = "Fácil";
            this.rdoFacil.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nível de dificuldade";
            // 
            // mskTempoPreparo
            // 
            this.mskTempoPreparo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTempoPreparo.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTempoPreparo.Location = new System.Drawing.Point(20, 207);
            this.mskTempoPreparo.Margin = new System.Windows.Forms.Padding(4);
            this.mskTempoPreparo.Mask = "00:00:00";
            this.mskTempoPreparo.Name = "mskTempoPreparo";
            this.mskTempoPreparo.Size = new System.Drawing.Size(354, 21);
            this.mskTempoPreparo.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tempo de preparo";
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomeReceita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeReceita.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeReceita.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeReceita.Location = new System.Drawing.Point(18, 122);
            this.txtNomeReceita.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(321, 28);
            this.txtNomeReceita.TabIndex = 58;
            // 
            // txtNumeroServidos
            // 
            this.txtNumeroServidos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNumeroServidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroServidos.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroServidos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumeroServidos.Location = new System.Drawing.Point(18, 374);
            this.txtNumeroServidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroServidos.Name = "txtNumeroServidos";
            this.txtNumeroServidos.Size = new System.Drawing.Size(51, 28);
            this.txtNumeroServidos.TabIndex = 59;
            // 
            // receitasBindingSource
            // 
            this.receitasBindingSource.DataMember = "receitas";
            this.receitasBindingSource.DataSource = this.bdsoRestauranteDataSetBindingSource;
            // 
            // bdsoRestauranteDataSetBindingSource
            // 
            this.bdsoRestauranteDataSetBindingSource.DataSource = this.bd_soRestauranteDataSet;
            this.bdsoRestauranteDataSetBindingSource.Position = 0;
            // 
            // bd_soRestauranteDataSet
            // 
            this.bd_soRestauranteDataSet.DataSetName = "bd_soRestauranteDataSet";
            this.bd_soRestauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receitasTableAdapter
            // 
            this.receitasTableAdapter.ClearBeforeFill = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategoria.Location = new System.Drawing.Point(18, 460);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(321, 28);
            this.txtCategoria.TabIndex = 60;
            // 
            // edicaoReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(742, 570);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNumeroServidos);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoDificil);
            this.Controls.Add(this.rdoMedio);
            this.Controls.Add(this.rdoFacil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTempoPreparo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModoPreparo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edicaoReceita";
            this.Text = "edicaoReceita";
            ((System.ComponentModel.ISupportInitialize)(this.receitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsoRestauranteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_soRestauranteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBusca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLimpa;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoDificil;
        private System.Windows.Forms.RadioButton rdoMedio;
        private System.Windows.Forms.RadioButton rdoFacil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTempoPreparo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.TextBox txtNumeroServidos;
        private System.Windows.Forms.BindingSource bdsoRestauranteDataSetBindingSource;
        private bd_soRestauranteDataSet bd_soRestauranteDataSet;
        private System.Windows.Forms.BindingSource receitasBindingSource;
        private bd_soRestauranteDataSetTableAdapters.receitasTableAdapter receitasTableAdapter;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}