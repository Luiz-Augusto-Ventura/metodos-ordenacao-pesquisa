namespace Metodos
{
    partial class OrdenacaoTexto
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.cmdProcurar = new System.Windows.Forms.Button();
            this.lblValores = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.rbShellSort = new System.Windows.Forms.RadioButton();
            this.rbBubleSort = new System.Windows.Forms.RadioButton();
            this.rbSelectSort = new System.Windows.Forms.RadioButton();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblValoresResposta = new System.Windows.Forms.Label();
            this.lblOrdenadosResposta = new System.Windows.Forms.Label();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Documento de texto";
            this.openFileDialog1.Filter = "Documentos de texto|*.txt|Todos os arquivos|*.*";
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.BackColor = System.Drawing.Color.White;
            this.lblInformacao.ForeColor = System.Drawing.Color.Black;
            this.lblInformacao.Location = new System.Drawing.Point(66, 23);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(126, 13);
            this.lblInformacao.TabIndex = 0;
            this.lblInformacao.Text = "Encontre o arquivo texto:";
            // 
            // cmdProcurar
            // 
            this.cmdProcurar.Location = new System.Drawing.Point(212, 18);
            this.cmdProcurar.Name = "cmdProcurar";
            this.cmdProcurar.Size = new System.Drawing.Size(75, 23);
            this.cmdProcurar.TabIndex = 1;
            this.cmdProcurar.Text = "Procurar";
            this.cmdProcurar.UseVisualStyleBackColor = true;
            this.cmdProcurar.Click += new System.EventHandler(this.cmdProcurar_Click);
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(31, 62);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(45, 13);
            this.lblValores.TabIndex = 3;
            this.lblValores.Text = "Valores:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbQuickSort);
            this.panel1.Controls.Add(this.rbShellSort);
            this.panel1.Controls.Add(this.rbBubleSort);
            this.panel1.Controls.Add(this.rbSelectSort);
            this.panel1.Location = new System.Drawing.Point(146, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 99);
            this.panel1.TabIndex = 4;
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(35, 72);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(72, 17);
            this.rbQuickSort.TabIndex = 3;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbShellSort
            // 
            this.rbShellSort.AutoSize = true;
            this.rbShellSort.Location = new System.Drawing.Point(35, 49);
            this.rbShellSort.Name = "rbShellSort";
            this.rbShellSort.Size = new System.Drawing.Size(67, 17);
            this.rbShellSort.TabIndex = 2;
            this.rbShellSort.TabStop = true;
            this.rbShellSort.Text = "ShellSort";
            this.rbShellSort.UseVisualStyleBackColor = true;
            // 
            // rbBubleSort
            // 
            this.rbBubleSort.AutoSize = true;
            this.rbBubleSort.Location = new System.Drawing.Point(35, 26);
            this.rbBubleSort.Name = "rbBubleSort";
            this.rbBubleSort.Size = new System.Drawing.Size(77, 17);
            this.rbBubleSort.TabIndex = 1;
            this.rbBubleSort.TabStop = true;
            this.rbBubleSort.Text = "BubbleSort";
            this.rbBubleSort.UseVisualStyleBackColor = true;
            // 
            // rbSelectSort
            // 
            this.rbSelectSort.AutoSize = true;
            this.rbSelectSort.Location = new System.Drawing.Point(35, 3);
            this.rbSelectSort.Name = "rbSelectSort";
            this.rbSelectSort.Size = new System.Drawing.Size(88, 17);
            this.rbSelectSort.TabIndex = 0;
            this.rbSelectSort.TabStop = true;
            this.rbSelectSort.Text = "SelectionSort";
            this.rbSelectSort.UseVisualStyleBackColor = true;
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(31, 226);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(100, 13);
            this.lblOrdenado.TabIndex = 5;
            this.lblOrdenado.Text = "Valores Ordenados:";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(44, 135);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(87, 13);
            this.lblMetodo.TabIndex = 7;
            this.lblMetodo.Text = "Escolha Método:";
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(212, 257);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(75, 23);
            this.cmdFechar.TabIndex = 8;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Documento de texto";
            this.saveFileDialog1.Filter = "Documentos de texto|*.txt|Todos os arquivos|*.*";
            // 
            // lblValoresResposta
            // 
            this.lblValoresResposta.AutoSize = true;
            this.lblValoresResposta.Location = new System.Drawing.Point(122, 62);
            this.lblValoresResposta.Name = "lblValoresResposta";
            this.lblValoresResposta.Size = new System.Drawing.Size(0, 13);
            this.lblValoresResposta.TabIndex = 9;
            // 
            // lblOrdenadosResposta
            // 
            this.lblOrdenadosResposta.AutoSize = true;
            this.lblOrdenadosResposta.Location = new System.Drawing.Point(143, 226);
            this.lblOrdenadosResposta.Name = "lblOrdenadosResposta";
            this.lblOrdenadosResposta.Size = new System.Drawing.Size(0, 13);
            this.lblOrdenadosResposta.TabIndex = 10;
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Location = new System.Drawing.Point(47, 161);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdenar.TabIndex = 11;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(69, 257);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvar.TabIndex = 12;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // OrdenacaoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Metodos.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 292);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.lblOrdenadosResposta);
            this.Controls.Add(this.lblValoresResposta);
            this.Controls.Add(this.cmdFechar);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.cmdProcurar);
            this.Controls.Add(this.lblInformacao);
            this.Name = "OrdenacaoTexto";
            this.Text = "OrdenacaoTexto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Button cmdProcurar;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbShellSort;
        private System.Windows.Forms.RadioButton rbBubleSort;
        private System.Windows.Forms.RadioButton rbSelectSort;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblValoresResposta;
        private System.Windows.Forms.Label lblOrdenadosResposta;
        private System.Windows.Forms.Button cmdOrdenar;
        private System.Windows.Forms.Button cmdSalvar;
    }
}