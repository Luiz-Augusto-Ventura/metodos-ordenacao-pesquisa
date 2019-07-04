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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuValoresAleatorios_Click(object sender, EventArgs e)
        {
            OrdenacaoAleatorio OA = new OrdenacaoAleatorio();
            OA.ShowDialog();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuArquivoTXT_Click(object sender, EventArgs e)
        {
            OrdenacaoTexto OT = new OrdenacaoTexto();
            OT.ShowDialog();
        }
    }
}
