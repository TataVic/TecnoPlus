namespace TecnoPlus
{
    partial class CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            this.rb_usado = new System.Windows.Forms.RadioButton();
            this.rb_novo = new System.Windows.Forms.RadioButton();
            this.num_qtd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.num_preco = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cod_barras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.num_largura = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_profundidade = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_altura = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ck_ativo = new System.Windows.Forms.CheckBox();
            this.fundo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_largura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_profundidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_usado
            // 
            this.rb_usado.AutoSize = true;
            this.rb_usado.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_usado.Location = new System.Drawing.Point(31, 56);
            this.rb_usado.Name = "rb_usado";
            this.rb_usado.Size = new System.Drawing.Size(73, 22);
            this.rb_usado.TabIndex = 1;
            this.rb_usado.TabStop = true;
            this.rb_usado.Text = "Usado";
            this.rb_usado.UseVisualStyleBackColor = true;
            // 
            // rb_novo
            // 
            this.rb_novo.AutoSize = true;
            this.rb_novo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_novo.Location = new System.Drawing.Point(31, 27);
            this.rb_novo.Name = "rb_novo";
            this.rb_novo.Size = new System.Drawing.Size(66, 22);
            this.rb_novo.TabIndex = 0;
            this.rb_novo.TabStop = true;
            this.rb_novo.Text = "Novo";
            this.rb_novo.UseVisualStyleBackColor = true;
            // 
            // num_qtd
            // 
            this.num_qtd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_qtd.Location = new System.Drawing.Point(381, 199);
            this.num_qtd.Name = "num_qtd";
            this.num_qtd.Size = new System.Drawing.Size(80, 27);
            this.num_qtd.TabIndex = 20;
            this.num_qtd.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(360, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estoque";
            // 
            // num_preco
            // 
            this.num_preco.DecimalPlaces = 2;
            this.num_preco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_preco.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_preco.Location = new System.Drawing.Point(508, 240);
            this.num_preco.Name = "num_preco";
            this.num_preco.Size = new System.Drawing.Size(133, 27);
            this.num_preco.TabIndex = 18;
            this.num_preco.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Preço unitário";
            // 
            // txt_cod_barras
            // 
            this.txt_cod_barras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cod_barras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_barras.Location = new System.Drawing.Point(289, 138);
            this.txt_cod_barras.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cod_barras.Name = "txt_cod_barras";
            this.txt_cod_barras.Size = new System.Drawing.Size(172, 27);
            this.txt_cod_barras.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Código de barras";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marca";
            // 
            // txt_marca
            // 
            this.txt_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_marca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(23, 137);
            this.txt_marca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(228, 27);
            this.txt_marca.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(23, 78);
            this.txt_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(438, 27);
            this.txt_descricao.TabIndex = 5;
            // 
            // num_largura
            // 
            this.num_largura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_largura.Location = new System.Drawing.Point(208, 262);
            this.num_largura.Name = "num_largura";
            this.num_largura.Size = new System.Drawing.Size(79, 27);
            this.num_largura.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Largura (cm)";
            // 
            // num_profundidade
            // 
            this.num_profundidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_profundidade.Location = new System.Drawing.Point(208, 196);
            this.num_profundidade.Name = "num_profundidade";
            this.num_profundidade.Size = new System.Drawing.Size(79, 27);
            this.num_profundidade.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Profundidade (cm)";
            // 
            // num_altura
            // 
            this.num_altura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_altura.Location = new System.Drawing.Point(35, 199);
            this.num_altura.Name = "num_altura";
            this.num_altura.Size = new System.Drawing.Size(79, 27);
            this.num_altura.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Altura (cm)";
            // 
            // num_peso
            // 
            this.num_peso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_peso.Location = new System.Drawing.Point(381, 262);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(80, 27);
            this.num_peso.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Peso (g)";
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsalvar.FlatAppearance.BorderSize = 6;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(335, 307);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(142, 44);
            this.btnsalvar.TabIndex = 38;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnvoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnvoltar.FlatAppearance.BorderSize = 6;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(508, 307);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(142, 44);
            this.btnvoltar.TabIndex = 39;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rb_novo);
            this.groupBox1.Controls.Add(this.rb_usado);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(508, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 91);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condição";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(16, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Novo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(109, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Usado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ck_ativo
            // 
            this.ck_ativo.AutoSize = true;
            this.ck_ativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ativo.Location = new System.Drawing.Point(526, 67);
            this.ck_ativo.Name = "ck_ativo";
            this.ck_ativo.Size = new System.Drawing.Size(69, 22);
            this.ck_ativo.TabIndex = 41;
            this.ck_ativo.Text = "Ativo";
            this.ck_ativo.UseVisualStyleBackColor = true;
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fundo.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundo.Location = new System.Drawing.Point(-68, -2);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(823, 47);
            this.fundo.TabIndex = 143;
            this.fundo.Text = "Cadastramento de Produto";
            this.fundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label10.Location = new System.Drawing.Point(15, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 110);
            this.label10.TabIndex = 144;
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(675, 367);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fundo);
            this.Controls.Add(this.ck_ativo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.num_preco);
            this.Controls.Add(this.num_qtd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_largura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_profundidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_altura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cod_barras);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(691, 406);
            this.MinimumSize = new System.Drawing.Size(691, 406);
            this.Name = "CadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar - Produto";
            this.Load += new System.EventHandler(this.CadastrarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_largura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_profundidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_usado;
        private System.Windows.Forms.RadioButton rb_novo;
        private System.Windows.Forms.NumericUpDown num_qtd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_preco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cod_barras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.NumericUpDown num_largura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_profundidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_altura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox ck_ativo;
        private System.Windows.Forms.Label fundo;
        private System.Windows.Forms.Label label10;
    }
}