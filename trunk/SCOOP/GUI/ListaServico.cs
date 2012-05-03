using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class ListaServico : Form
    {
        private string FiltroGrupo = "";
        private string FiltroEtapa = "";
        private string FiltroAtividade = "";

        public ListaServico()
        {
            InitializeComponent();
        }

        private void ListaServico_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Atividade' table. You can move, or remove it, as needed.
                this.atividadeTableAdapter.Fill(this.sCOOPDataSet.Atividade);
                // TODO: This line of code loads data into the 'sCOOPDataSet.Etapa' table. You can move, or remove it, as needed.
                this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
                // TODO: This line of code loads data into the 'sCOOPDataSet.Grupo' table. You can move, or remove it, as needed.
                this.grupoTableAdapter.Fill(this.sCOOPDataSet.Grupo);
                // TODO: This line of code loads data into the 'sCOOPDataSet.Servico' table. You can move, or remove it, as needed.
                this.servicoTableAdapter.Fill(this.sCOOPDataSet.Servico);
            }
            catch (Exception) { }
            GrupocomboBox.Text = "";
            EtapacomboBox.Text = "";
            AtividadeComboBox.Text = "";
        }


        private void BttPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.Filter = "Descricao like '%" + textBox1.Text + "%'";
            }
            catch (System.Exception ex)
            {
                //this.servicoTableAdapter.Fill(this.sCOOPDataSet.Servico);
            }
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroComposicao(null, null, null, null);
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroComposicao(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), null, null, null);
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string erro = null;
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string Codigo = dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString();
                try
                {
                    new ComposicaoTableAdapter().ApagaComposicao(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), (int)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value);
                    new ServicoTableAdapter().Delete(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
                    this.servicoTableAdapter.Fill(this.sCOOPDataSet.Servico);
                    bindingNavigatorPositionItem.TextBox.Text = "0";
                    MessageBox.Show("Registro Apagado com Sucesso.");

                }
                catch (Exception ex)
                {
                    erro += ex.Message;
                }
                try
                {

                }
                catch (Exception ex)
                {
                    erro = ex.Message;
                    MessageBox.Show("Erro : " + erro);
                }

                //BttPesquisar_Click(null, null);
            }
        }

        private void BttImprimir_Click(object sender, EventArgs e)
        {
            Form frm = new SCOOP.GUI.Relatorio("Servico","");
            frm.ShowDialog();
        }

        private void ListaServico_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BttPesquisar_Click(null, null);
            }
        }

        private void GrupocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.etapaTableAdapter.FillBy(this.sCOOPDataSet.Etapa, (int)GrupocomboBox.SelectedValue);
                servicoBindingSource.RemoveFilter();
                EtapacomboBox.Text = "";
                AtividadeComboBox.Text = "";
                FiltroGrupo = "(Grupo = " + GrupocomboBox.SelectedValue.ToString() + ")";
                this.servicoBindingSource.Filter = FiltroGrupo;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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
                //MessageBox.Show(ex.Message);
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
            catch (System.Exception)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (bindingNavigatorPositionItem.TextBox.Text != "0")
                {
                    if (!new ComposicaoTableAdapter().VerificarSeServicoJaExisteCadastrado(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString()).HasValue)
                    {
                        toolStripButton2.Visible = true;
                    }
                    else
                    {
                        toolStripButton2.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    dataGridView1.Rows[i].Cells[4].Value = new ComposicaoTableAdapter().ObterTotalServico(dataGridView1.Rows[i].Cells[1].Value.ToString() == null ? "0" : dataGridView1.Rows[i].Cells[1].Value.ToString()).ToString();
                }
                catch (Exception ex)
                { }
            }
        }
    }
}
