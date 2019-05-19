namespace loginForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFrmModernDark = new System.Windows.Forms.Button();
            this.btnFrmZuounMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrmModernDark
            // 
            this.btnFrmModernDark.Location = new System.Drawing.Point(12, 12);
            this.btnFrmModernDark.Name = "btnFrmModernDark";
            this.btnFrmModernDark.Size = new System.Drawing.Size(96, 23);
            this.btnFrmModernDark.TabIndex = 0;
            this.btnFrmModernDark.Text = "FrmModernDark";
            this.btnFrmModernDark.UseVisualStyleBackColor = true;
            this.btnFrmModernDark.Click += new System.EventHandler(this.BtnFrmModernDark_Click);
            // 
            // btnFrmZuounMenu
            // 
            this.btnFrmZuounMenu.Location = new System.Drawing.Point(12, 41);
            this.btnFrmZuounMenu.Name = "btnFrmZuounMenu";
            this.btnFrmZuounMenu.Size = new System.Drawing.Size(96, 23);
            this.btnFrmZuounMenu.TabIndex = 0;
            this.btnFrmZuounMenu.Text = "FrmZuounMenu";
            this.btnFrmZuounMenu.UseVisualStyleBackColor = true;
            this.btnFrmZuounMenu.Click += new System.EventHandler(this.BtnFrmZuounMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 194);
            this.Controls.Add(this.btnFrmZuounMenu);
            this.Controls.Add(this.btnFrmModernDark);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrmModernDark;
        private System.Windows.Forms.Button btnFrmZuounMenu;
    }
}

