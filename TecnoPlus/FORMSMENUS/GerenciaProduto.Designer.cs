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
            this.btnremove = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadicionarprod = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.White;
            this.btnremove.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnremove.FlatAppearance.BorderSize = 6;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnremove.Location = new System.Drawing.Point(543, 431);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(170, 44);
            this.btnremove.TabIndex = 8;
            this.btnremove.Text = "Remover";
            this.btnremove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btneditar.FlatAppearance.BorderSize = 6;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneditar.Location = new System.Drawing.Point(367, 431);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(170, 44);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 41);
            this.label3.TabIndex = 27;
            this.label3.Text = "Gerenciar produtos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnadicionarprod
            // 
            this.btnadicionarprod.BackColor = System.Drawing.Color.White;
            this.btnadicionarprod.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnadicionarprod.FlatAppearance.BorderSize = 6;
            this.btnadicionarprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadicionarprod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionarprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadicionarprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionarprod.Location = new System.Drawing.Point(191, 431);
            this.btnadicionarprod.Name = "btnadicionarprod";
            this.btnadicionarprod.Size = new System.Drawing.Size(170, 44);
            this.btnadicionarprod.TabIndex = 28;
            this.btnadicionarprod.Text = "Adicionar produto";
            this.btnadicionarprod.UseVisualStyleBackColor = false;
            this.btnadicionarprod.Click += new System.EventHandler(this.btnadicionarprod_Click_1);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.White;
            this.btnpesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnpesquisar.FlatAppearance.BorderSize = 0;
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpesquisar.Location = new System.Drawing.Point(565, 75);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(148, 31);
            this.btnpesquisar.TabIndex = 29;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(19, 74);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(540, 31);
            this.txtpesquisa.TabIndex = 30;
            // 
            // gridProduto
            // 
            this.gridProduto.BackgroundColor = System.Drawing.Color.White;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Location = new System.Drawing.Point(19, 126);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.Size = new System.Drawing.Size(694, 289);
            this.gridProduto.TabIndex = 31;
            // 
            // GerenciaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(739, 523);
            this.Controls.Add(this.gridProduto);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnadicionarprod);
            this.Controls.Add(this.label3);
            this.Name = "GerenciaProduto";
            this.Text = "GerenciaProduto";
        
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadicionarprod;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView gridProduto;
    }
}