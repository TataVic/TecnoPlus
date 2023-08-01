namespace TecnoPlus
{
    partial class GerenciarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarClientes));
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnadicionarcli = new System.Windows.Forms.Button();
            this.fundo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(12, 105);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(759, 260);
            this.gridClientes.TabIndex = 38;
            this.gridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneditar.FlatAppearance.BorderSize = 6;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneditar.Location = new System.Drawing.Point(309, 379);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(186, 53);
            this.btneditar.TabIndex = 32;
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnremove.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnremove.FlatAppearance.BorderSize = 6;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnremove.Location = new System.Drawing.Point(569, 379);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(186, 53);
            this.btnremove.TabIndex = 33;
            this.btnremove.Text = "Remover";
            this.btnremove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpesquisa.Location = new System.Drawing.Point(12, 55);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(595, 31);
            this.txtpesquisa.TabIndex = 37;
            this.txtpesquisa.Text = "Pesquisar";
            this.txtpesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnpesquisar.FlatAppearance.BorderSize = 0;
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpesquisar.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.Image")));
            this.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpesquisar.Location = new System.Drawing.Point(623, 55);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(148, 31);
            this.btnpesquisar.TabIndex = 36;
            this.btnpesquisar.Text = "      Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnadicionarcli
            // 
            this.btnadicionarcli.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnadicionarcli.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnadicionarcli.FlatAppearance.BorderSize = 6;
            this.btnadicionarcli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadicionarcli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarcli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadicionarcli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionarcli.Location = new System.Drawing.Point(52, 379);
            this.btnadicionarcli.Name = "btnadicionarcli";
            this.btnadicionarcli.Size = new System.Drawing.Size(186, 53);
            this.btnadicionarcli.TabIndex = 35;
            this.btnadicionarcli.Text = "Adicionar cliente";
            this.btnadicionarcli.UseVisualStyleBackColor = false;
            this.btnadicionarcli.Click += new System.EventHandler(this.btnadicionarcli_Click);
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fundo.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundo.Location = new System.Drawing.Point(-15, -4);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(830, 47);
            this.fundo.TabIndex = 154;
            this.fundo.Text = "Gerenciamento de Clientes";
            this.fundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GerenciarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fundo);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnadicionarcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "GerenciarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar - Clientes";
            this.Load += new System.EventHandler(this.GerenciarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnadicionarcli;
        private System.Windows.Forms.Label fundo;
    }
}