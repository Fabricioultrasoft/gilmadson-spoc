using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCOOP.GUI
{
    public partial class Contrato : Form
    {
        public Contrato(string Contrato)
        {
            InitializeComponent();
            TxtBoxContrato.Text = Contrato;
            if (TxtBoxContrato.Text != "")
                button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportClass report = this.ContratoEmpreteiro1;
            CrystalDecisions.Shared.ParameterField parm;
            parm = report.ParameterFields["Contrato"];
            parm.CurrentValues.Clear();
            parm.CurrentValues.AddValue(TxtBoxContrato.Text);
            report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void Contrato_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void Contrato_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
