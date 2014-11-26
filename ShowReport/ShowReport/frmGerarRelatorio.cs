using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowReport
{
    public partial class frmGerarRelatorio : Form
    {
        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void bntGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmImpressao Impressao = new frmImpressao();
            Impressao.ImprimirRelatorio("RptRelatorioEmprestimo.rpt", "Select * from ViewDevolucao where DataDevolucaoEfetiva Is Null");
            Impressao.Show();
        }
    }
}
