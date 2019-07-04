using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    public partial class OrdenacaoTexto : Form
    {
        public OrdenacaoTexto()
        {
            InitializeComponent();
            panel1.Enabled = false;
            cmdOrdenar.Enabled = false;
        }
        private string[] aux;
        private string aux1;
        List<int> num =new List<int>();
        private int[] A;
        private MetodosOrdenacao MO = new MetodosOrdenacao();


        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdProcurar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                aux=System.IO.File.ReadAllLines(openFileDialog1.FileName);
            }

            if (aux != null)
            {
                for (int i = 0; i < aux.Count(); i++)
                {
                    List<string> str = aux[i].Split(' ').ToList();
                    for (int j = 0; j < str.Count; j++)
                    {
                        num.Add(int.Parse(str[j]));
                        lblValoresResposta.Text += (str[j] + "  ");
                    }
                }
            }
            
            A = new int[num.Count];
            for (int i = 0; i < num.Count; i++)
            {
                A[i] = num[i];
            }
            panel1.Enabled = true;
            cmdOrdenar.Enabled = true;
            num.Clear();
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            lblOrdenadosResposta.ResetText();
            if (rbSelectSort.Checked)
            {
                MO.SelectSort(A, A.Length);
                for (int i = 0; i < A.Length; i++)
                {
                    lblOrdenadosResposta.Text += (A[i].ToString() + "  ");
                    aux1 = "";
                }
            }
            if (rbBubleSort.Checked)
            {
                MO.BubleSort(A, A.Length);
                for (int i = 0; i < A.Length; i++)
                {
                    lblOrdenadosResposta.Text += (A[i].ToString() + "  ");
                    aux1 = "";
                }
            }
            if (rbShellSort.Checked)
            {
                MO.ShellSort(A, A.Length);
                for (int i = 0; i < A.Length; i++)
                {
                    lblOrdenadosResposta.Text += (A[i].ToString() + "  ");
                    aux1 = "";
                }
            }
            if (rbQuickSort.Checked)
            {
                MO.QuickSort(A, 0, A.Length - 1);
                for (int i = 0; i < A.Length; i++)
                {
                    lblOrdenadosResposta.Text += (A[i].ToString() + "  ");
                    aux1 = "";
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                aux1 += Convert.ToString(A[i]+" ");
            }
            
            Array.Clear(A,0,A.Length);
            lblValoresResposta.ResetText();
            panel1.Enabled = false;
            cmdOrdenar.Enabled = false;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {           
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                FileStream fs = new FileStream(saveFileDialog1.FileName+".txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(aux1);
                writer.Close();
                lblOrdenadosResposta.ResetText();
            }
        }
    }
}
