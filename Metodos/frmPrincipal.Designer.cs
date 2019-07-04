namespace Metodos
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuValoresAleatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrir,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivoTXT,
            this.mnuValoresAleatorios});
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.Size = new System.Drawing.Size(45, 20);
            this.mnuAbrir.Text = "Abrir";
            // 
            // mnuArquivoTXT
            // 
            this.mnuArquivoTXT.Name = "mnuArquivoTXT";
            this.mnuArquivoTXT.Size = new System.Drawing.Size(213, 22);
            this.mnuArquivoTXT.Text = "Ordenar Arquivo Texto";
            this.mnuArquivoTXT.Click += new System.EventHandler(this.mnuArquivoTXT_Click);
            // 
            // mnuValoresAleatorios
            // 
            this.mnuValoresAleatorios.Name = "mnuValoresAleatorios";
            this.mnuValoresAleatorios.Size = new System.Drawing.Size(213, 22);
            this.mnuValoresAleatorios.Text = "Ordenar Valores Aleatorios";
            this.mnuValoresAleatorios.Click += new System.EventHandler(this.mnuValoresAleatorios_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Metodos.Properties.Resources.ordenados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 291);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoTXT;
        private System.Windows.Forms.ToolStripMenuItem mnuValoresAleatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
    }
}

