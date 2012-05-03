using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SCOOP.Properties;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP.GUI
{
    public partial class PesquiarServico : Form
    {
        CadastroOrcamentocs InstanciaOrcamento = null;
        CadastroMedicao InstanciaMedicao = null;
        private string FiltroGrupo, FiltroEtapa, FiltroAtividade = null;
        public PesquiarServico(CadastroOrcamentocs CadastroOrcamento, CadastroMedicao CadastroMedicao)
        {
            InitializeComponent();
            if (CadastroOrcamento != null)
                InstanciaOrcamento = CadastroOrcamento;
            else
                InstanciaMedicao = CadastroMedicao;
        }

        private void PesquiarServico_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Atividade' table. You can move, or remove it, as needed.
                this.atividadeTableAdapter.Fill(this.sCOOPDataSet.Atividade);
            }
            catch (Exception ex)
            { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Etapa' table. You can move, or remove it, as needed.
                this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
            }
            catch (Exception ex)
            { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Grupo' table. You can move, or remove it, as needed.
                this.grupoTableAdapter.Fill(this.sCOOPDataSet.Grupo);
            }
            catch (Exception ex)
            { }
            try
            {   // TODO: This line of code loads data into the 'sCOOPDataSet.Servico' table. You can move, or remove it, as needed.
                //this.servicoTableAdapter.Fill(this.sCOOPDataSet.Servico);
            }
            catch (Exception ex)
            { }

            GrupocomboBox.Text = "";
            EtapacomboBox.Text = "";
            AtividadeComboBox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InstanciaOrcamento != null)
            {
                InstanciaOrcamento.mskTxtBoxCodServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString();
                InstanciaOrcamento.TxtDescricaoServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString();
                InstanciaOrcamento.TxtBoxUnidadeServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString();
                InstanciaOrcamento.TxtBoxValorUnitario.Text = String.Format("{0:C4}", Convert.ToString(new ComposicaoTableAdapter().ObterTotalServico(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString()).ToString()));
                InstanciaOrcamento.mskTxtBoxCodServico.Refresh();
                InstanciaOrcamento.TxtDescricaoServico.Refresh();
                InstanciaOrcamento.TxtBoxUnidadeServico.Refresh();
                InstanciaOrcamento.TxtBoxValorUnitario.Refresh();
                this.Close();
            }
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.servicoTableAdapter.FillBy2(this.sCOOPDataSet.Servico, TxtBoxServico.Text);
            }
            catch (Exception ) { }
        }

        private void PesquiarServico_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BttBuscar_Click(null, null);
            }
        }


        private void GrupocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (GrupocomboBox.Text != null && GrupocomboBox.Text != "")
                {
                    this.etapaTableAdapter.FillBy(this.sCOOPDataSet.Etapa, (int)GrupocomboBox.SelectedValue);
                    servicoBindingSource.RemoveFilter();
                    EtapacomboBox.Text = "";
                    AtividadeComboBox.Text = "";
                    FiltroGrupo = "(Grupo = " + GrupocomboBox.SelectedValue.ToString() + ")";
                    this.servicoBindingSource.Filter = FiltroGrupo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EtapacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EtapacomboBox.Text != null && EtapacomboBox.Text != "")
                {
                    this.atividadeTableAdapter.FillBy(this.sCOOPDataSet.Atividade, (int)EtapacomboBox.SelectedValue);
                    FiltroEtapa = " AND (Etapa = " + EtapacomboBox.SelectedValue.ToString() + ")";
                    this.servicoBindingSource.Filter = FiltroGrupo + FiltroEtapa;
                }
                AtividadeComboBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AtividadeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (AtividadeComboBox.Text != null && AtividadeComboBox.Text != "")
                {
                    FiltroAtividade = " AND (Atividade = " + AtividadeComboBox.SelectedValue.ToString() + ")";
                    this.servicoBindingSource.Filter = FiltroGrupo + FiltroEtapa + FiltroAtividade;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ServicodataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < ServicodataGridView1.RowCount; i++)
            {
                try
                {
                    ServicodataGridView1.Rows[i].Cells[5].Value = new ComposicaoTableAdapter().ObterTotalServico(ServicodataGridView1.Rows[i].Cells[1].Value.ToString()).ToString();
                }
                catch (Exception ex)
                { }
            }
        }
    }
}
