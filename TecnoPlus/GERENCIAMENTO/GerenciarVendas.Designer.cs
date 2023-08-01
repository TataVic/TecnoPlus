namespace TecnoPlus
{
    partial class GerenciarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarVendas));
            this.fundo = new System.Windows.Forms.Label();
            this.gridVenda = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnadicionarvend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fundo.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundo.Location = new System.Drawing.Point(0, -5);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(800, 47);
            this.fundo.TabIndex = 152;
            this.fundo.Text = "Gerenciamento de Vendas";
            this.fundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridVenda
            // 
            this.gridVenda.BackgroundColor = System.Drawing.Color.White;
            this.gridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenda.Location = new System.Drawing.Point(12, 101);
            this.gridVenda.MultiSelect = false;
            this.gridVenda.Name = "gridVenda";
            this.gridVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVenda.Size = new System.Drawing.Size(776, 249);
            this.gridVenda.TabIndex = 151;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneditar.FlatAppearance.BorderSize = 6;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneditar.Location = new System.Drawing.Point(305, 372);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(186, 53);
            this.btneditar.TabIndex = 146;
            this.btneditar.Text = "Editar venda";
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
            this.btnremove.Location = new System.Drawing.Point(561, 372);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(186, 53);
            this.btnremove.TabIndex = 147;
            this.btnremove.Text = "Remover";
            this.btnremove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnremove.UseVisualStyleBackColor = false;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpesquisa.Location = new System.Drawing.Point(12, 52);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(595, 31);
            this.txtpesquisa.TabIndex = 150;
            this.txtpesquisa.Text = "Pesquisar";
            this.txtpesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnpesquisar.Location = new System.Drawing.Point(629, 52);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(159, 32);
            this.btnpesquisar.TabIndex = 149;
            this.btnpesquisar.Text = "      Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnadicionarvend
            // 
            this.btnadicionarvend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnadicionarvend.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnadicionarvend.FlatAppearance.BorderSize = 6;
            this.btnadicionarvend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadicionarvend.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarvend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadicionarvend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionarvend.Location = new System.Drawing.Point(42, 373);
            this.btnadicionarvend.Name = "btnadicionarvend";
            this.btnadicionarvend.Size = new System.Drawing.Size(186, 52);
            this.btnadicionarvend.TabIndex = 148;
            this.btnadicionarvend.Text = "Adicionar venda";
            this.btnadicionarvend.UseVisualStyleBackColor = false;
            this.btnadicionarvend.Click += new System.EventHandler(this.btnadicionarvend_Click);
            // 
            // GerenciarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fundo);
            this.Controls.Add(this.gridVenda);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnadicionarvend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "GerenciarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar - Vendas";
            this.Load += new System.EventHandler(this.GerenciarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fundo;
        private System.Windows.Forms.DataGridView gridVenda;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnadicionarvend;
    }
}