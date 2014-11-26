using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;


namespace ShowReport
{
    class ShowReport
    {

         public SqlConnection GetBibliotecaConnection()
        {
            SqlConnection con = new SqlConnection(GetBibliotecaConnectionString());
            return con;
        }


        private string GetBibliotecaConnectionString()
        {
            return "Data Source=LAB-FANTASMA;Initial Catalog=Biblioteca;Integrated Security=True";
        }


        public DataSet BuildDataSet(string sqlString, SqlConnection connection)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            using (connection)
            {
                adapter.SelectCommand = new SqlCommand(sqlString, connection);
                adapter.Fill(ds);
            }
            return ds;
        }


        private DataSet GetDataSet(String SQL)
        {
            return BuildDataSet(SQL, GetBibliotecaConnection());
        }


        public void ShowRelatorio(string GetReportName, string Query, CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer1)
        {
            ReportDocument rdoc = new ReportDocument();
            SqlConnection connection = GetBibliotecaConnection();
            object GetReportPath = Path.Combine(Application.StartupPath, "Rpt");


            rdoc.Load((GetReportPath + ("\\" + GetReportName)));

            //  Define o dataset que ser exibido no relatorio
            rdoc.SetDataSource(GetDataSet(Query));
            crViewer1.ReportSource = rdoc;
            crViewer1.Show();
        }

    }
}
