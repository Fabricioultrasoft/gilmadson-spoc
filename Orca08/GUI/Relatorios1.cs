using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Web;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Orca08.GUI
{
    public partial class Relatorios1 : Form
    {
        //The thread
        Thread st;
        //The delegate instance
        Progress p;
        //The delegate class
        public delegate void Progress();
        private ConnectionInfo objConnectionInfo;
        private ReportClass report;
        private string Relatorio = null;
        public Relatorios1()
        {
            InitializeComponent();
            //report = new CrystalDecisions.CrystalReports.Engine.ReportClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (comboBox1.Text != "")
                showCrystalReport();

            // Set Minimum to 1 to represent the first file being copied.
            progressBar1.Minimum = 1;
            // Set Maximum to the total number of Users created.
            progressBar1.Maximum = 100;
            // Set the initial value of the ProgressBar.
            progressBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each user is being created.
            progressBar1.Step = 1;

            // Loop through all files to copy.
            for (int i = 1; i <= 100; i++)
            {
                progressBar1.PerformStep();                
            }

            if (report.IsLoaded)
            {
                crystalReportViewer1.Refresh();               
            }
            
            // st.Start();
            progressBar1.Visible = false;
            //button1.Enabled = false;
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            st = new Thread(new ThreadStart(load));
            
            p = new Progress(Perform);
        }

        //The method that will be pointed by  the delegate instance
        public void Perform()
        {
            for (int i = 0; i <= 100; i = i + 1)
            {
                progressBar1.Increment(i);
                statusStrip1.Text = progressBar1.Value.ToString() + "%omplete"; Thread.Sleep(10);
            }
            MessageBox.Show("processo concluido!");

        }

        //The thread method
        public void load()
        {
            Relatorios1 form = this;
            form.Invoke(p);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Relatorio = comboBox1.Text;
        }

        public void showCrystalReport()
        {
            
           
            
            if (Relatorio == "Medicao")
            {
                report = this.Medicao1;                
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "Orca");
                crystalReportViewer1.ReportSource = report;
                SetParameterFieldInfo("FOLHA", TxtBoxValor.Text, "FOLHAFINAL", FolhaFinalTxtBox.Text);
               
            }
            else if (Relatorio == "Contrato")
            {
                report = this.ContratoEmpreteiro1;
                SetParameterFieldInfo("Contrato", TxtBoxValor.Text, "ContratoFinal", FolhaFinalTxtBox.Text);                
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "Orca");
                crystalReportViewer1.ReportSource = report;
                
            }
            else if (Relatorio == "Recibo")
            {
                report = this.ReciboEmpreteira1;
                SetParameterFieldInfo("Medicao", TxtBoxValor.Text, "MedicaoFinal", FolhaFinalTxtBox.Text);                
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "Orca");
                crystalReportViewer1.ReportSource = report;
               
            }
            else if (Relatorio == "Solicitacao")
            {
                report = this.SolicitacaoPagamento1;
                SetParameterFieldInfo("Medicao", TxtBoxValor.Text, "MedicaoFinal", FolhaFinalTxtBox.Text);                
                report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "Orca");
                crystalReportViewer1.ReportSource = report;
                
            }
            else
            {
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }



        }

        private void SetParameterFieldInfo(String fieldName, String fieldValue,String fieldName1,String FieldValue1)
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

        /// <summary>
        /// Sets Database Settings
        /// </summary>
        private void setDatabaseSettings()
        {
            objConnectionInfo = new ConnectionInfo();

            objConnectionInfo.ServerName = "ServerName";
            objConnectionInfo.DatabaseName = "DBName";
            objConnectionInfo.UserID = "UserId";
            objConnectionInfo.Password = "Password";
        }


    }
}
