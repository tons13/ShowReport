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
    public partial class frmImpressao : Form
    {
        ShowReport ShowReport = new ShowReport();

        public frmImpressao()
        {
            InitializeComponent();
        }

        public void ImprimirRelatorio(string GetReportName, string Query)
        {

            ShowReport.ShowRelatorio(GetReportName, Query, crViewer);

        }

        private void frmImpressao_Load(object sender, EventArgs e)
        {
            ImprimirRelatorio("RptRelatorioEmprestimo.rpt", "Select * from ViewDevolucao where DataDevolucaoEfetiva Is Null");
        }
    
    }


}
