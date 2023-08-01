namespace TecnoPlus
{
    partial class GerenciaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciaProduto));
            this.btnremove = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnadicionarprod = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.fundo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnremove.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnremove.FlatAppearance.BorderSize = 6;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnremove.Location = new System.Drawing.Point(564, 381);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(186, 53);
            this.btnremove.TabIndex = 8;
            this.btnremove.Text = "Remover";
            this.btnremove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneditar.FlatAppearance.BorderSize = 6;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneditar.Location = new System.Drawing.Point(302, 381);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(186, 53);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnadicionarprod
            // 
            this.btnadicionarprod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnadicionarprod.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnadicionarprod.FlatAppearance.BorderSize = 6;
            this.btnadicionarprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadicionarprod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadicionarprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionarprod.Location = new System.Drawing.Point(46, 381);
            this.btnadicionarprod.Name = "btnadicionarprod";
            this.btnadicionarprod.Size = new System.Drawing.Size(186, 53);
            this.btnadicionarprod.TabIndex = 28;
            this.btnadicionarprod.Text = "Adicionar produto";
            this.btnadicionarprod.UseVisualStyleBackColor = false;
            this.btnadicionarprod.Click += new System.EventHandler(this.btnadicionarprod_Click_1);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnpesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnpesquisar.FlatAppearance.BorderSize = 0;
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpesquisar.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.Image")));
            this.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpesquisar.Location = new System.Drawing.Point(630, 64);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(148, 31);
            this.btnpesquisar.TabIndex = 29;
            this.btnpesquisar.Text = "     Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpesquisa.Location = new System.Drawing.Point(19, 64);
            this.txtpesquisa.Multiline = true;
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(595, 31);
            this.txtpesquisa.TabIndex = 30;
            this.txtpesquisa.Text = "Pesquisar";
            this.txtpesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridProduto
            // 
            this.gridProduto.BackgroundColor = System.Drawing.Color.White;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Location = new System.Drawing.Point(19, 111);
            this.gridProduto.MultiSelect = false;
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(759, 251);
            this.gridProduto.TabIndex = 31;
            this.gridProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduto_CellContentClick);
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fundo.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundo.Location = new System.Drawing.Point(-19, -1);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(830, 47);
            this.fundo.TabIndex = 153;
            this.fundo.Text = "Gerenciamento de Produtos";
            this.fundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GerenciaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fundo);
            this.Controls.Add(this.gridProduto);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnadicionarprod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "GerenciaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar - Produtos";
            this.Load += new System.EventHandler(this.GerenciaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Label fundo;
        protected System.Windows.Forms.Button btnremove;
        protected System.Windows.Forms.Button btneditar;
        protected System.Windows.Forms.Button btnadicionarprod;
    }
}