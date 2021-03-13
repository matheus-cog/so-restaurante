namespace soRestaurante
{
    partial class cadastroReceita
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.mskTempoPreparo = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoFacil = new System.Windows.Forms.RadioButton();
            this.rdoMedio = new System.Windows.Forms.RadioButton();
            this.rdoDificil = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumSS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da receita";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 89);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo de preparo";
            // 
            // mskTempoPreparo
            // 
            this.mskTempoPreparo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTempoPreparo.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTempoPreparo.Location = new System.Drawing.Point(20, 214);
            this.mskTempoPreparo.Margin = new System.Windows.Forms.Padding(4);
            this.mskTempoPreparo.Mask = "00:00:00";
            this.mskTempoPreparo.Name = "mskTempoPreparo";
            this.mskTempoPreparo.Size = new System.Drawing.Size(391, 21);
            this.mskTempoPreparo.TabIndex = 2;
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
            this.txtNomeReceita.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nível de dificuldade";
            // 
            // rdoFacil
            // 
            this.rdoFacil.AutoSize = true;
            this.rdoFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFacil.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFacil.Location = new System.Drawing.Point(22, 300);
            this.rdoFacil.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFacil.Name = "rdoFacil";
            this.rdoFacil.Size = new System.Drawing.Size(47, 18);
            this.rdoFacil.TabIndex = 3;
            this.rdoFacil.TabStop = true;
            this.rdoFacil.Text = "Fácil";
            this.rdoFacil.UseVisualStyleBackColor = true;
            // 
            // rdoMedio
            // 
            this.rdoMedio.AutoSize = true;
            this.rdoMedio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMedio.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedio.Location = new System.Drawing.Point(77, 300);
            this.rdoMedio.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMedio.Name = "rdoMedio";
            this.rdoMedio.Size = new System.Drawing.Size(55, 18);
            this.rdoMedio.TabIndex = 4;
            this.rdoMedio.TabStop = true;
            this.rdoMedio.Text = "Médio";
            this.rdoMedio.UseVisualStyleBackColor = true;
            // 
            // rdoDificil
            // 
            this.rdoDificil.AutoSize = true;
            this.rdoDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDificil.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDificil.Location = new System.Drawing.Point(140, 300);
            this.rdoDificil.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDificil.Name = "rdoDificil";
            this.rdoDificil.Size = new System.Drawing.Size(53, 18);
            this.rdoDificil.TabIndex = 5;
            this.rdoDificil.TabStop = true;
            this.rdoDificil.Text = "Difícil";
            this.rdoDificil.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número de pessoas a serem servidas";
            // 
            // cmbNumSS
            // 
            this.cmbNumSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNumSS.FormattingEnabled = true;
            this.cmbNumSS.Items.AddRange(new object[] {
            " ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumSS.Location = new System.Drawing.Point(20, 380);
            this.cmbNumSS.Name = "cmbNumSS";
            this.cmbNumSS.Size = new System.Drawing.Size(47, 24);
            this.cmbNumSS.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Alimento infantil",
            "Suplementos",
            "Bebidas",
            "Biscoitos, bolos e bolachas",
            "Carnes",
            "Congelados",
            "Conservas",
            "Doces, balas, chocolates e cia",
            "Farinhas, cereais e complementos",
            "Fast-food, aperitivos e petiscos",
            "Frios e embutidos",
            "Frutas",
            "Legumes, verduras e grãos",
            "Manteiga, óleos e cia",
            "Massas",
            "Molhos, caldos e condimentos",
            "Ovos, leite, queijo e cia",
            "Pães",
            "Sopas & cremes",
            " "});
            this.cmbCategoria.Location = new System.Drawing.Point(18, 466);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(321, 24);
            this.cmbCategoria.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(647, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(566, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(88)))), ((int)(((byte)(32)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(485, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ingredientes";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredientes.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIngredientes.Location = new System.Drawing.Point(399, 122);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(310, 117);
            this.txtIngredientes.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Modo de preparo";
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtModoPreparo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModoPreparo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoPreparo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtModoPreparo.Location = new System.Drawing.Point(399, 300);
            this.txtModoPreparo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModoPreparo.Multiline = true;
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.Size = new System.Drawing.Size(298, 117);
            this.txtModoPreparo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Location = new System.Drawing.Point(372, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 402);
            this.label8.TabIndex = 22;
            this.label8.Text = "label8";
            // 
            // cadastroReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(734, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModoPreparo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNumSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoDificil);
            this.Controls.Add(this.rdoMedio);
            this.Controls.Add(this.rdoFacil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.mskTempoPreparo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadastroReceita";
            this.Text = "cadastroReceita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTempoPreparo;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoFacil;
        private System.Windows.Forms.RadioButton rdoMedio;
        private System.Windows.Forms.RadioButton rdoDificil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNumSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Label label8;
    }
}