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
    public partial class RelatoriosMedicao : Form
    {
        private string Tipo;
        private string DotacaoFiltro, TipoObraFiltro, BairroFiltro, EmpreteiraFiltro, PeriodoFiltro = null;
        public RelatoriosMedicao(string Tipo_Relatorio, string Valor)
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportClass report = this.RelatorioMedicao1;
            this.RelatorioMedicao1.RecordSelectionFormula = "";
            if (DotacaoFiltro != null)
            {
                this.RelatorioMedicao1.RecordSelectionFormula = DotacaoFiltro;
                if (TipoObraFiltro != null)
                {
                    this.RelatorioMedicao1.RecordSelectionFormula += " and " + TipoObraFiltro;
                    if (BairroFiltro != null)
                    {
                        this.RelatorioMedicao1.RecordSelectionFormula += " and " + BairroFiltro;
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += " and " + EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                        else
                        {
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                    }
                    else
                    {
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += " and " + EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                        else
                        {
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                    }
                }
                else
                {
                    if (BairroFiltro != null)
                    {
                        this.RelatorioMedicao1.RecordSelectionFormula += " and " + BairroFiltro;
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += " and " + EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                        else
                        {
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                    }
                }
            }
            else
            {
                if (TipoObraFiltro != null)
                {
                    this.RelatorioMedicao1.RecordSelectionFormula += TipoObraFiltro;
                    if (BairroFiltro != null)
                    {
                        this.RelatorioMedicao1.RecordSelectionFormula += " and " + BairroFiltro;
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += " and " + EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                        else
                        {
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                    }
                    else
                    {
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += " and " + EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                        else
                        {
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                    }
                }
                else
                {
                    if (BairroFiltro != null)
                    {
                        this.RelatorioMedicao1.RecordSelectionFormula += BairroFiltro;
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += " and " + EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                        else
                        {
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";;
                            }
                        }
                    }
                    else
                    {
                        if (EmpreteiraFiltro != null)
                        {
                            this.RelatorioMedicao1.RecordSelectionFormula += EmpreteiraFiltro;
                            if (PeriodoFiltro != null)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula += " and {Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";
                            }
                        }
                        else
                        {
                            if (!PeriodoChkBox.Checked)
                            {
                                this.RelatorioMedicao1.RecordSelectionFormula = "{Medicao.Dt_Criacao} in DateTime (" + DtInicialdateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ") to DateTime (" + DtFinaldateTimePicker.Value.Date.ToString("yyyy,MM,dd,HH,mm,ss") + ")";

                            }
                        }
                    }
                }
            }

            this.RelatorioMedicao1.Refresh();


            CrystalDecisions.Shared.ParameterField parm;
            parm = report.ParameterFields["Filtro"];
            parm.CurrentValues.Clear();
            parm.CurrentValues.AddValue(DotacaoFiltro==""?"":"Dotação Orçamentaria" + " " + TipoObraFiltro==""?"":"Tipo Orçamento" + " " + BairroFiltro==""?"":"Bairro" + " " + EmpreteiraFiltro==""?"":"Empreteira" + " " + PeriodoFiltro==""?"":"Periodo ");
            report.SetDatabaseLogon("scoop", "scoop", @"PMC0091SRVSIPA1", "scoop", true);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();


        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Empreteira' table. You can move, or remove it, as needed.
            this.empreteiraTableAdapter.Fill(this.sCOOPDataSet.Empreteira);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Bairro' table. You can move, or remove it, as needed.
            this.bairroTableAdapter.Fill(this.sCOOPDataSet.Bairro);
            // TODO: This line of code loads data into the 'sCOOPDataSet.TipoOrcamento' table. You can move, or remove it, as needed.
            this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
            // TODO: This line of code loads data into the 'sCOOPDataSet.DotacaoOrcamentaria' table. You can move, or remove it, as needed.
            this.dotacaoOrcamentariaTableAdapter.Fill(this.sCOOPDataSet.DotacaoOrcamentaria);
            DotacaoComboBox.Text = "";
            TipoObraComboBox.Text = "";
            BairroComboBox.Text = "";
            EmpreteiraTodosComboBox.Text = "";


        }

        private void Relatorios_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void DotacaoTodasChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DotacaoTodasChkBox.Checked)
            {
                DotacaoComboBox.Visible = false;
                DotacaoComboBox.Text = "";
                DotacaoFiltro = null;
            }
            else
            {
                DotacaoComboBox.Visible = true;
            }
        }

        private void DotacaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DotacaoTodasChkBox.Checked)
            {
                DotacaoFiltro = null;
            }
            else
            {
                DotacaoFiltro = " {Orcamento.DotacaoOrcamentaria} = " + DotacaoComboBox.SelectedValue.ToString() + "";
            }
        }

        private void TipoObraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoObraTodosChkBox.Checked)
            {
                TipoObraFiltro = null;
            }
            else
            {
                TipoObraFiltro = " {Orcamento.TipoOrcamento} = " + TipoObraComboBox.SelectedValue.ToString() + "";
            }
        }

        private void TipoObraTodosChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TipoObraTodosChkBox.Checked)
            {
                TipoObraComboBox.Visible = false;
                TipoObraComboBox.Text = "";
                TipoObraFiltro = null;
            }
            else
            {
                TipoObraComboBox.Visible = true;
            }
        }

        private void BairroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BairroTodosChkBox.Checked)
            {
                BairroFiltro = null;
            }
            else
            {
                BairroFiltro = "{Orcamento.Bairro} = \"" + BairroComboBox.Text + "\"";
            }
        }

        private void BairroTodosChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BairroTodosChkBox.Checked)
            {
                BairroComboBox.Visible = false;
                BairroFiltro = null;
            }
            else
            {
                BairroComboBox.Text = "";
                BairroComboBox.Visible = true;
            }
        }

        private void EmpreteiraTodosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmpreteiraTodosChkBox.Checked)
            {
                EmpreteiraFiltro = null;
            }
            else
            {
                EmpreteiraFiltro = "{Orcamento_Contratado.Empresa} = " + EmpreteiraTodosComboBox.SelectedValue.ToString() + "";
            }
        }

        private void EmpreteiraTodosChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmpreteiraTodosChkBox.Checked)
            {
                EmpreteiraFiltro = null;
                EmpreteiraTodosComboBox.Visible = false;
                EmpreteiraTodosComboBox.Text = "";
            }
            else
            {
                EmpreteiraTodosComboBox.Visible = true;
            }
        }

        private void PeriodoChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PeriodoChkBox.Checked)
            {
                DtFinaldateTimePicker.Visible = false;
                DtInicialdateTimePicker.Visible = false;
                lblate.Visible = false;
            }
            else
            {
                DtFinaldateTimePicker.Visible = true;
                DtInicialdateTimePicker.Visible = true;
                lblate.Visible = true;
            }
        }
    }
}
