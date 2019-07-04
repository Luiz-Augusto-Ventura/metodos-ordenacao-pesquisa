namespace Metodos
{
    partial class OrdenacaoAleatorio
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
            this.cmValoresAleatorios = new System.Windows.Forms.Button();
            this.lbRanking = new System.Windows.Forms.ListBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.lblexplicacao = new System.Windows.Forms.Label();
            this.dtTempoGasto = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmValoresAleatorios
            // 
            this.cmValoresAleatorios.Location = new System.Drawing.Point(112, 63);
            this.cmValoresAleatorios.Name = "cmValoresAleatorios";
            this.cmValoresAleatorios.Size = new System.Drawing.Size(140, 23);
            this.cmValoresAleatorios.TabIndex = 1;
            this.cmValoresAleatorios.Text = "Gerar Valores e Ordenar";
            this.cmValoresAleatorios.UseVisualStyleBackColor = true;
            this.cmValoresAleatorios.Click += new System.EventHandler(this.cmValoresAleatorios_Click);
            // 
            // lbRanking
            // 
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.Location = new System.Drawing.Point(12, 113);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(346, 108);
            this.lbRanking.TabIndex = 4;
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(140, 241);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 5;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // lblexplicacao
            // 
            this.lblexplicacao.AutoSize = true;
            this.lblexplicacao.Location = new System.Drawing.Point(21, 25);
            this.lblexplicacao.Name = "lblexplicacao";
            this.lblexplicacao.Size = new System.Drawing.Size(221, 13);
            this.lblexplicacao.TabIndex = 6;
            this.lblexplicacao.Text = "Tempo gasto por cada método de ordenação";
            // 
            // dtTempoGasto
            // 
            this.dtTempoGasto.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTempoGasto.Location = new System.Drawing.Point(249, 19);
            this.dtTempoGasto.Name = "dtTempoGasto";
            this.dtTempoGasto.Size = new System.Drawing.Size(100, 20);
            this.dtTempoGasto.TabIndex = 7;
            // 
            // OrdenacaoAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Metodos.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 292);
            this.Controls.Add(this.dtTempoGasto);
            this.Controls.Add(this.lblexplicacao);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.lbRanking);
            this.Controls.Add(this.cmValoresAleatorios);
            this.Name = "OrdenacaoAleatorio";
            this.Text = "OrdenacaoAleatorio";
            this.Load += new System.EventHandler(this.OrdenacaoAleatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmValoresAleatorios;
        private System.Windows.Forms.ListBox lbRanking;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label lblexplicacao;
        private System.Windows.Forms.DateTimePicker dtTempoGasto;
    }
}