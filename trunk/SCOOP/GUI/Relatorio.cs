using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SCOOP.GUI
{
    public partial class Relatorio : Form
    {
        private string Tipo;
        private ConnectionInfo objConnectionInfo;
        private ReportClass report;
        private string Relatorios;
        public Relatorio(string Tipo_Relatorio,string Valor)
        {
            InitializeComponent();
            Tipo = Tipo_Relatorio;
            TxtBoxValor.Text = Valor;
            
            //if (Tipo != "")
            //    button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tipo == "Orcamento")
            {
                report =this.Orcamento1;
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                SetParameterFieldInfo("NumeroFolha", TxtBoxValor.Text, "NumeoFinalFolha", TxtBoxValor.Text);
               
            }
            else if (Tipo == "Medicao")
            {
                report = this.Medicao1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["NumeroFolha"];
                //parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "MedicaoEmBranco")
            {
                report = this.MedicaoValorEmBranco1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["NumeroFolha"];
                //parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "MedicaoValorQntEmBranco")
            {
                report = this.MedicaoQntValorEmBranco1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["NumeroFolha"];
                //parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "Composicao")
            {
                report = this.Composicao1;
                //CrystalDecisions.Shared.ParameterField parm;
                //parm = report.ParameterFields["NumeroFolha"];
                //parm.CurrentValues.Clear();
                //parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "OrdemServico")
            {
                report = this.OrdemServico1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["Codigo"];
                parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "Recibo")
            {
                report = this.ReciboEmpreteira1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["Medicao"];
                parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "Empenho")
            {
                report = this.SolicitacaoPagamento1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["Medicao"];
                parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "BoletimMedicao")
            {
                report = this.BoletimObras1;
                CrystalDecisions.Shared.ParameterField parm;
                parm = report.ParameterFields["Medicao"];
                parm.CurrentValues.Clear();
                parm.CurrentValues.AddValue(TxtBoxValor.Text);
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            else if (Tipo == "Servico")
            {
                report = this.Servico1;
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
        }
        private void SetParameterFieldInfo(String fieldName, String fieldValue, String fieldName1, String FieldValue1)
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
            parameterDiscreteValue.Value = fieldValue;
            parameterDiscreteValue1.Value = FieldValue1;
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterValues currentParameterValues1 = new ParameterValues();
            currentParameterValues.Add(parameterDiscreteValue);
            currentParameterValues1.Add(parameterDiscreteValue1);
            ParameterField parameterField = new ParameterField();
            ParameterField parameterField1 = new ParameterField();
            parameterField.Name = fieldName;
            parameterField.CurrentValues = currentParameterValues;
            parameterField1.Name = fieldName1;
            parameterField1.CurrentValues = currentParameterValues1;
            ParameterFields parameterFields = new ParameterFields();
            parameterFields.Add(parameterField);
            parameterFields.Add(parameterField1);
            crystalReportViewer1.ParameterFieldInfo = parameterFields;
        }
    }
}
