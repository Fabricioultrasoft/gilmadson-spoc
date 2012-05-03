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
    public partial class DotacaoOrcamentaria : Form
    {
        private string orcamento = null;
        public DotacaoOrcamentaria(string Orcamento)
        {
            this.orcamento = Orcamento;
            InitializeComponent();
        }

        private void DotacaoOrcamentaria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_FonteRecurso' table. You can move, or remove it, as needed.
            this.dot_FonteRecursoTableAdapter.Fill(this.sCOOPDataSet.Dot_FonteRecurso);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_Despesa' table. You can move, or remove it, as needed.
            this.dot_DespesaTableAdapter.Fill(this.sCOOPDataSet.Dot_Despesa);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_ProjetoAtividade' table. You can move, or remove it, as needed.
            this.dot_ProjetoAtividadeTableAdapter.Fill(this.sCOOPDataSet.Dot_ProjetoAtividade);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_Programa' table. You can move, or remove it, as needed.
            this.dot_ProgramaTableAdapter.Fill(this.sCOOPDataSet.Dot_Programa);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_SubFuncao' table. You can move, or remove it, as needed.
            this.dot_SubFuncaoTableAdapter.Fill(this.sCOOPDataSet.Dot_SubFuncao);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_Funcao' table. You can move, or remove it, as needed.
            this.dot_FuncaoTableAdapter.Fill(this.sCOOPDataSet.Dot_Funcao);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_Unidade' table. You can move, or remove it, as needed.
            this.dot_UnidadeTableAdapter.Fill(this.sCOOPDataSet.Dot_Unidade);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Dot_Orgao' table. You can move, or remove it, as needed.
            this.dot_OrgaoTableAdapter.Fill(this.sCOOPDataSet.Dot_Orgao);



            if (new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().VerificarSeExisteDotacaoOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter().ObterSequencialOrcamento(this.orcamento))).HasValue)
            {
                try
                {
                    SCOOP.DAO.SCOOPDataSet.Dotacao_Orc_ContDataTable dt = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().GetDataBy1(this.orcamento);

                    foreach (SCOOP.DAO.SCOOPDataSet.Dotacao_Orc_ContRow linha in dt)
                    {

                        OrgaoComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_OrgaoTableAdapter().ObterDescricaoOrgao(linha.Orgao);
                        UnidadecomboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_UnidadeTableAdapter().ObterDescricaoUnidade(linha.Unidade);
                        FuncaoComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_FuncaoTableAdapter().ObterDescricaoFuncao(linha.Funcao);
                        SubFuncaoComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_SubFuncaoTableAdapter().ObterDescricaoSubFuncao(linha.SubFuncao);
                        ProgramaComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_ProgramaTableAdapter().ObterDescricaoPrograma(linha.Programa);
                        ProjetoAtividadeComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_ProjetoAtividadeTableAdapter().ObterDescricaoProjetoAtividade(linha.Projeto_Atividade);
                        DespesaComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_DespesaTableAdapter().ObterDescricaoDespesa(linha.Despesa);
                        FonteRecursoComboBox.Text = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_FonteRecursoTableAdapter().ObterDescricaoFonteRecurso(linha.FonteRecurso);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aviso :" + ex);
                    OrgaoComboBox.Text = "";
                    UnidadecomboBox.Text = "";
                    FuncaoComboBox.Text = "";
                    SubFuncaoComboBox.Text = "";
                    ProgramaComboBox.Text = "";
                    ProjetoAtividadeComboBox.Text = "";
                    DespesaComboBox.Text = "";
                    FonteRecursoComboBox.Text = "";
                }
            }
            else
            {
                OrgaoComboBox.Text = "";
                UnidadecomboBox.Text = "";
                FuncaoComboBox.Text = "";
                SubFuncaoComboBox.Text = "";
                ProgramaComboBox.Text = "";
                ProjetoAtividadeComboBox.Text = "";
                DespesaComboBox.Text = "";
                FonteRecursoComboBox.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().VerificarSeExisteDotacaoOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter().ObterSequencialOrcamento(this.orcamento))).HasValue)
            {
                try
                {
                    new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().Delete(this.orcamento);
                    new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().Insert((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter().ObterSequencialOrcamento(this.orcamento)),
                                                                                                   this.orcamento,
                                                                                                   (int)OrgaoComboBox.SelectedValue,
                                                                                                   (int)UnidadecomboBox.SelectedValue,
                                                                                                   (int)FuncaoComboBox.SelectedValue,
                                                                                                   (int)SubFuncaoComboBox.SelectedValue,
                                                                                                   (int)ProgramaComboBox.SelectedValue,
                                                                                                   (int)ProjetoAtividadeComboBox.SelectedValue,
                                                                                                   (int)DespesaComboBox.SelectedValue,
                                                                                                   (int)FonteRecursoComboBox.SelectedValue);
                    MessageBox.Show("Dotação Alterada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { }
            }
            else
            {
                new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().Insert((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter().ObterSequencialOrcamento(this.orcamento)),
                                                                                                   this.orcamento,
                                                                                                   (int)OrgaoComboBox.SelectedValue,
                                                                                                   (int)UnidadecomboBox.SelectedValue,
                                                                                                   (int)FuncaoComboBox.SelectedValue,
                                                                                                   (int)SubFuncaoComboBox.SelectedValue,
                                                                                                   (int)ProgramaComboBox.SelectedValue,
                                                                                                   (int)ProjetoAtividadeComboBox.SelectedValue,
                                                                                                   (int)DespesaComboBox.SelectedValue,
                                                                                                   (int)FonteRecursoComboBox.SelectedValue);
                MessageBox.Show("Dotação Cadastrada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
