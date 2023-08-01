namespace TecnoPlus
{
    partial class GerenciarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarUsuario));
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnadicionarusu = new System.Windows.Forms.Button();
            this.fundo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsuario
            // 
            this.gridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.gridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuario.Location = new System.Drawing.Point(24, 111);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.Size = new System.Drawing.Size(764, 248);
            this.gridUsuario.TabIndex = 45;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneditar.FlatAppearance.BorderSize = 6;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneditar.Location = new System.Drawing.Point(309, 374);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(186, 53);
            this.btneditar.TabIndex = 39;
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
            this.btnremove.Location = new System.Drawing.Point(561, 374);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(186, 53);
            this.btnremove.TabIndex = 40;
            this.btnremove.Text = "Remover";
            this.btnremove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtpesquisa.Location = new System.Drawing.Point(24, 62);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(595, 31);
            this.txtpesquisa.TabIndex = 44;
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
            this.btnpesquisar.Location = new System.Drawing.Point(640, 62);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(148, 31);
            this.btnpesquisar.TabIndex = 43;
            this.btnpesquisar.Text = "     Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnadicionarusu
            // 
            this.btnadicionarusu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnadicionarusu.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnadicionarusu.FlatAppearance.BorderSize = 6;
            this.btnadicionarusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadicionarusu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarusu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadicionarusu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionarusu.Location = new System.Drawing.Point(48, 374);
            this.btnadicionarusu.Name = "btnadicionarusu";
            this.btnadicionarusu.Size = new System.Drawing.Size(186, 53);
            this.btnadicionarusu.TabIndex = 42;
            this.btnadicionarusu.Text = "Adicionar usuário";
            this.btnadicionarusu.UseVisualStyleBackColor = false;
            this.btnadicionarusu.Click += new System.EventHandler(this.btnadicionarusu_Click_1);
            // 
            // fundo
            // 
            this.fundo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fundo.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundo.Location = new System.Drawing.Point(-14, -1);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(830, 47);
            this.fundo.TabIndex = 154;
            this.fundo.Text = "Gerenciamento de Usuários";
            this.fundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fundo);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnadicionarusu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "GerenciarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar - Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnadicionarusu;
        private System.Windows.Forms.Label fundo;
    }
}