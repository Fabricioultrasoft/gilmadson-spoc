using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCOOP
{
    public partial class RelatoriosServico : Form
    {
        private string Tipo;
        public RelatoriosServico(string Tipo_Relatorio,string Valor)
        {
            InitializeComponent();            
        }


        private void Recibo_Load(object sender, EventArgs e)
        {

        }

        private void Relatorios_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void GerarButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                CrystalDecisions.CrystalReports.Engine.ReportClass report = this.ServicoMedicao1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["DataInicial"];
                parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(DataInicialDTP.Value.Date.ToShortDateString());
                parm = report.ParameterFields["DataFinal"];
                parm.CurrentValues.AddValue(DataFinalDTP.Value.Date.ToShortDateString());
                report.SetDatabaseLogon("scoop", "scoop", @"pmc0091srvsipa1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else
            {
                CrystalDecisions.CrystalReports.Engine.ReportClass report = this.ServicoMedicaoTOP1;
                report.SetDatabaseLogon("scoop", "scoop", @"pmc0091srvsipa1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Visible = false;
                label2.Visible = false;
                DataFinalDTP.Visible = false;
                DataInicialDTP.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                DataFinalDTP.Visible = true;
                DataInicialDTP.Visible = true;
            }

        }
    }
}
