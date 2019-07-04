using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    public partial class OrdenacaoAleatorio : Form
    {
        public OrdenacaoAleatorio()
        {
            InitializeComponent();
        }

        private Random rdn=new Random();
        private DateTime inicio, fim;
        private TimeSpan result;
        private int[] A = new int[100000];
        private int[] aux = new int[100000];
        private int n = 100000;
        private MetodosOrdenacao MO = new MetodosOrdenacao();

        private void cmValoresAleatorios_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                A[i] = rdn.Next(1,100000);
            }   
        
            inicio = DateTime.Now;
            aux = A;
            MO.SelectSort(aux, n);
            fim = DateTime.Now;
            result = fim.Subtract(inicio);
            lbRanking.Items.Add("Método SelectSort" + "\tTempo gasto para ordenar: " + result.TotalSeconds.ToString("00:000000"));

            inicio = DateTime.Now;
            aux = A;
            MO.BubleSort(aux, n);
            fim = DateTime.Now;
            result = fim.Subtract(inicio);
            lbRanking.Items.Add("Método BubbleSort" + "\tTempo gasto para ordenar: " + result.TotalSeconds.ToString("00:000000"));

            inicio = DateTime.Now;
            aux = A;
            MO.ShellSort(aux, n);
            fim = DateTime.Now;
            result = fim.Subtract(inicio);
            lbRanking.Items.Add("Método ShellSort" + "\tTempo gasto para ordenar: " + result.TotalSeconds.ToString("00:000000"));

            inicio = DateTime.Now;
            aux = A;
            MO.QuickSort(aux, 0, n - 1);
            fim = DateTime.Now;
            result = fim.Subtract(inicio);
            lbRanking.Items.Add("Método QuickSort" + "\tTempo gasto para ordenar: " + result.TotalSeconds.ToString("00:000000"));
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrdenacaoAleatorio_Load(object sender, EventArgs e)
        {
            inicio = DateTime.Now;
        }
    }
}
