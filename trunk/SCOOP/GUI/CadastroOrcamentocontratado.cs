using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using SCOOP.Properties;
using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
using SCOOP.GUI;

namespace SCOOP
{
    public partial class CadastroOrcamentocontratado : Form
    {
        //private string CodigoOrcamento;
        public int tabPage = 1;
        public CadastroOrcamentocontratado(int tabPage)
        {
            InitializeComponent();
            this.tabPage = tabPage;
            if (tabPage == 1)
                this.tabControl1.SelectedTab = this.tabPage1;
            else
                this.tabControl1.SelectedTab = this.tabPage2;            

        }

        private void CadastroOrcamentocs_Load(object sender, EventArgs e)
        {
            
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Orcamento' table. You can move, or remove it, as needed.
                this.orcamentoTableAdapter.FillBy4(this.sCOOPDataSet.Orcamento);
                preencherGridViewOrcamentoContratado();
            }
            catch (Exception )
            { }

            if (this.tabPage == 1)
            {
                tabControl1.SelectedTab = tabPage1;
                tabPage = 0;
            }
            else if (this.tabPage == 2)
            {
                tabControl1.SelectedTab = tabPage2;
                tabPage = 0;
            }
            else
            {
                tabPage = 0;
            }

            #region InicializazaoOrcamento
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Empresa' table. You can move, or remove it, as needed.
                this.empresaTableAdapter.Fill(this.sCOOPDataSet.Empresa);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Secretaria' table. You can move, or remove it, as needed.
                this.secretariaTableAdapter.Fill(this.sCOOPDataSet.Secretaria);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Licitado' table. You can move, or remove it, as needed.
                this.licitadoTableAdapter.Fill(this.sCOOPDataSet.Licitado);
            }
            catch (Exception) { }
            ComboBoxEmpreteira.Text = "";
            ComboBoxLicitado.Text = "";
            ComboBoxSecretaria.Text = "";
            
            #endregion

        }

        private void TxtBoxTotalOrçamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!TxtBoxTotalOrçamento.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BttPesquisa_Click(object sender, EventArgs e)
        {
            orcamentoBindingSource.Filter = "like '%" + PesquisaTextBox.Text + "%'";
        }
        /// <summary>
        /// adicionar novo Orçamento contratado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            CadastroOrcamentocs_Load(null, null);
            button1_Click_2(null, null);
        }

        /// <summary>
        /// Editar Orçamento contratado;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try{
            //Editar Orçamento Contratado
            tabControl1.SelectedTab = tabPage1;
            SCOOPDataSet.Orcamento_ContratadoDataTable Dt = new Orcamento_ContratadoTableAdapter().GetDataBy11((int)OrcamentoContratadodataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[0].Value);
            SCOOPDataSet.OrcamentoDataTable DtOrca = null;
            foreach (SCOOPDataSet.Orcamento_ContratadoRow linha in Dt)
            {
                DtOrca = new OrcamentoTableAdapter().GetDataBy2(new OrcamentoTableAdapter().ObterCodigoOrcamento(linha.Seq_Orcamento));
                foreach(SCOOPDataSet.OrcamentoRow linhaOrca in DtOrca)
                {
                    MskTxtBoxCodigo.Text = linhaOrca.Codigo;
                    TxtBoxDescricao.Text = linhaOrca.Descricao;
                    MskTxtDataCriacao.Text = linhaOrca.Dt_criacao.ToShortDateString();
                    TxtBoxCidade.Text = linhaOrca.Cidade;
                    TxtBoxLogradouro.Text = linhaOrca.Logradouro;
                    TxtBoxBairro.Text = linhaOrca.Bairro;
                    ComboBoxLicitado.Text = new LicitadoTableAdapter().ObterDescricaoLicitacao(linha.Licitado);
                    ComboBoxSecretaria.Text = new SecretariaTableAdapter().ObterDescricaoSecretaria(linha.Secretaria);
                    ComboBoxEmpreteira.Text = new EmpresaTableAdapter().ObterDescricaoEmpresa(linha.Empresa);
                    TxtBoxCGCCPF.Text = linha.CPF_CNPJ;
                    DataInicioMskTxtBox.Text = linha.Data_Criacao.ToShortDateString();
                    MksTxtBoxPrazo.Text = linha.Data_final.ToShortDateString();
                    ContratoMaskedTextBox.Text = new ContratoTableAdapter().ObterCodigoContrato(linhaOrca.Codigo);
                    BDIComboBox.Text = linhaOrca.BDI.ToString();
                    ModalidadecomboBox.Text = linha.Modalidade;
                    ProcessotextBox.Text = linha.Processo;
                    this.orc_Cont_ServicoTableAdapter.FillBy(this.sCOOPDataSet.Orc_Cont_Servico, linhaOrca.Codigo);
                    BttContrato.Visible = true;
                    buttonOrdemServico.Visible = true;
                    buttonOrdemServico.Enabled = true;
                }
                
            }
                comboBox1_SelectedIndexChanged(null, null);
                ativarPrimeiraParteDesativarSegunda();
                button2.Enabled = false;
                BttAtualizar.Enabled = true;
                BttAtualizar.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar Orçamento Contratado.\n"+ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DesativarPrimeiraParteAtivarSegunda();
                button1.Enabled = true;
                BttAtualizar.Enabled = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form frm = new PesquisarBairro(null, this);
            //frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form frm = new PesquisarObraTipo(null, this);
        }

        /// <summary>
        /// Apaga Orçamento Contratado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Orçamento Excluido com Sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir serviço do orçamento.\n" + ex.Message);
                }
            }
        }

        private void CadastroOrcamentocs_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                bindingNavigatorAddNewItem1_Click(null, null);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem1_Click(null, null);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form frm = new PesquiarOrcamento(null, null, this);
            frm.ShowDialog();
        }
        /// <summary>
        /// Importação de Orçamento!
        /// </summary>
        /// <param name="NumeroOrcamento"></param>
        public void ImportarOrcamento(string NumeroOrcamento)
        {
            try
            {
                SCOOPDataSet.OrcamentoDataTable Dt = new OrcamentoTableAdapter().GetDataBy2(NumeroOrcamento);

                foreach (SCOOPDataSet.OrcamentoRow linha in Dt)
                {
                    MskTxtBoxCodigo.Text = linha.Codigo;
                    TxtBoxDescricao.Text = linha.Descricao;
                    MskTxtDataCriacao.Text = linha.Dt_criacao.ToShortDateString();
                    TxtBoxCidade.Text = linha.Cidade;
                    TxtBoxLogradouro.Text = linha.Logradouro;
                    TxtBoxBairro.Text = linha.Bairro;
                    BDIComboBox.Text = linha.BDI.ToString();
                }
                //MessageBox.Show("Orçamento Carregado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao carregado Orçamento!\n" + ex.Message);
            }
        }

        private void ComboBoxEmpreteira_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SCOOPDataSet.EmpreteiraDataTable Dt = new EmpreteiraTableAdapter().GetDataBy2((int)ComboBoxEmpreteira.SelectedValue);

                foreach (SCOOPDataSet.EmpreteiraRow linha in Dt)
                {

                    if (string.Empty != LimprarMaskedTexto(linha.CNPJ.Trim()) || LimprarMaskedTexto(linha.CNPJ.Trim()) != "")
                    {
                        TxtBoxCGCCPF.Text = linha.CNPJ;
                        TxtBoxCGCCPF.Visible = true;
                    }
                    else
                    {
                        TxtBoxCGCCPF.Text = linha.CPF;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Empresa.\n" + ex.Message);
            }
        }

        public string LimprarMaskedTexto(string texto)
        {
            if (texto.Replace(".", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("/", "").Trim() == "")
                return "";
            else
                return texto;

        }
        /// <summary>
        /// Cadastrar Orçamento contratado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MksTxtBoxPrazo.Text != null && MksTxtBoxPrazo.Text.Replace("/", "") != "" && DataInicioMskTxtBox.Text != null && DataInicioMskTxtBox.Text.Replace("/", "") != "")
            {
               // if (Convert.ToDateTime(MksTxtBoxPrazo.Text) >= DateTime.Now && Convert.ToDateTime(DataInicioMskTxtBox.Text) >= DateTime.Now)
               // {
                    if (MskTxtBoxCodigo.Text != "" && ComboBoxLicitado.Text != "" && ComboBoxSecretaria.Text != "" && ComboBoxEmpreteira.Text != "")
                    {
                        if (!new Orcamento_ContratadoTableAdapter().ExisteOrcamentoContratado((int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text)).HasValue)
                        {
                            #region CadastroOrcamentoContratado
                            int seq_orcamento = Convert.ToInt32(new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text));
                            try
                            {
                                new Orcamento_ContratadoTableAdapter().Insert(seq_orcamento,
                                                                              (int)ComboBoxLicitado.SelectedValue,
                                                                              (int)ComboBoxSecretaria.SelectedValue,
                                                                              new EmpresaTableAdapter().ObterCodigoEmpresa((int)ComboBoxEmpreteira.SelectedValue).Value,
                                                                              TxtBoxCGCCPF.Text,
                                                                              Convert.ToDateTime(MksTxtBoxPrazo.Text.Replace("/","") == "" ? null : MksTxtBoxPrazo.Text),
                                                                              Convert.ToDateTime(DataInicioMskTxtBox.Text.Replace("/", "") == "" ? null : DataInicioMskTxtBox.Text),
                                                                              DateTime.Now,
                                                                              Settings.Default.Usuario,
                                                                              Convert.ToDateTime(MksTxtBoxPrazo.Text),
                                                                              "N",
                                                                              Convert.ToDecimal(BDIComboBox.Text),
                                                                              ModalidadecomboBox.Text,
                                                                              ProcessotextBox.Text);
                                CarregarServicoOrc_ServicoParaOrc_Cont_Servico(MskTxtBoxCodigo.Text);
                                DesativarPrimeiraParteAtivarSegunda();
                                MessageBox.Show("Orçamento Contratado Cadastrado com Sucesso!");
                                
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(null, "Erro ao Cadastrar Orçamento Contratado!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ativarPrimeiraParteDesativarSegunda();
                            }
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show(null, "Já Existe Orçamento Contratado!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos os Campos são Obrigatórios.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataInicioMskTxtBox.Focus();
                    }
              //  }
              ////  else
              //  {
              ////      MessageBox.Show("Data Inicio e Data Final Devem Ser maior ou igual que a data de hoje.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //      DataInicioMskTxtBox.Focus();
              //  }
            }
            else
            {
                MessageBox.Show("Data Inicio e Data Final são Obrigatórias.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataInicioMskTxtBox.Focus();
            }
        }

        public void CarregarServicoOrc_ServicoParaOrc_Cont_Servico(string NumeroOrcamento)
        {
            SCOOPDataSet.Orc_ServicoDataTable Dt = new Orc_ServicoTableAdapter().GetDataBy3(NumeroOrcamento);

            try
            {
                int SequenciaOrcamentoContratado = (int)new Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text));
                foreach (SCOOPDataSet.Orc_ServicoRow linha in Dt)
                {
                    new Orc_Cont_ServicoTableAdapter().Insert(linha.Codigo_Servico, linha.Seq_Servico, MskTxtBoxCodigo.Text, SequenciaOrcamentoContratado, DateTime.Now, linha.Quantidade, linha.Valor, DateTime.Now, "Admin");
                }
                this.orc_Cont_ServicoTableAdapter.FillBy(this.sCOOPDataSet.Orc_Cont_Servico, MskTxtBoxCodigo.Text);
                PreencherTotalDataGridView();
                TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                MessageBox.Show(null, "Seriço Carregado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Serviços do Orçamento!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Salvar Orçamento Contratado Serviços;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ServicodataGridView1.RowCount; i++)
                {
                    #region AtualizandoServicoOrcamentoContratado
                    new Orc_Cont_ServicoTableAdapter().Update(ServicodataGridView1.Rows[i].Cells[2].Value.ToString(),
                                                                                        (int)ServicodataGridView1.Rows[i].Cells[4].Value,
                                                                                        ServicodataGridView1.Rows[i].Cells[1].Value.ToString(),
                                                                                        (int)ServicodataGridView1.Rows[i].Cells[5].Value,
                                                                                        Convert.ToDateTime(ServicodataGridView1.Rows[i].Cells[6].Value),
                                                                                        (decimal)ServicodataGridView1.Rows[i].Cells[7].Value,
                                                                                        (decimal)ServicodataGridView1.Rows[i].Cells[8].Value,
                                                                                        Convert.ToDateTime(ServicodataGridView1.Rows[i].Cells[10].Value),
                                                                                        Settings.Default.Usuario,
                                                                                        (int)ServicodataGridView1.Rows[i].Cells[0].Value);
                    #endregion


                }
                MessageBox.Show("Serviço Atualizado com Sucesso!");
                PreencherTotalDataGridView();
                TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                comboBox1_SelectedIndexChanged(null, null);
                if(ContratoMaskedTextBox.Text.Replace(".","").Replace("/","").Trim().Equals(""))
                    ContratoMaskedTextBox.Text = PreencherAteDoisValor(ComboBoxLicitado.SelectedValue.ToString()) + PreencherAteDoisValor(ComboBoxSecretaria.SelectedValue.ToString()) + ObterSequencialContrato() + DateTime.Now.Year.ToString().Substring(2, 2);
                groupBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                groupBox1.Enabled = false;
            }

        }

        /// <summary>
        /// Novo Orçamento Contratado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            MskTxtBoxCodigo.Text = "";
            TxtBoxDescricao.Text = "";
            TxtBoxCidade.Text = "";
            MskTxtDataCriacao.Text = "";
            TxtBoxLogradouro.Text = "";
            TxtBoxBairro.Text = "";
            ComboBoxEmpreteira.Text = "";
            ComboBoxLicitado.Text = "";
            ComboBoxSecretaria.Text = "";
            TxtBoxCGCCPF.Text = "";
            DataInicioMskTxtBox.Text = "";
            MksTxtBoxPrazo.Text = "";
            this.orc_Cont_ServicoTableAdapter.FillBy(this.sCOOPDataSet.Orc_Cont_Servico, MskTxtBoxCodigo.Text);
            BDIComboBox.Text = "";
            TxtBoxTotalOrçamento.Text = "";
            ContratoMaskedTextBox.Text = "";
            ativarPrimeiraParteDesativarSegunda();
        }

        public void PreencherTotalDataGridView()
        {
            SCOOPDataSet.ServicoDataTable Dt = null;
            for (int i = 0; i < ServicodataGridView1.RowCount; i++)
            {
                ServicodataGridView1.Rows[i].Cells[9].Value = String.Format("{0:C2}", (Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[7].Value) * Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[8].Value)));

                Dt = new ServicoTableAdapter().GetDataBy1(ServicodataGridView1.Rows[i].Cells[2].Value.ToString());

                foreach (SCOOPDataSet.ServicoRow linha in Dt)
                {
                    ServicodataGridView1.Rows[i].Cells[3].Value = linha.Descricao;
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void preencherGridViewOrcamentoContratado()
        {
            /*
            try
            {
                SCOOPDataSet.OrcamentoDataTable Dt = null;
                for (int i = 0; i < OrcamentoContratadodataGridView.RowCount; i++)
                {
                    Dt = new OrcamentoTableAdapter().GetDataBy2(new OrcamentoTableAdapter().ObterCodigoOrcamento((int)OrcamentoContratadodataGridView.Rows[i].Cells[1].Value));
                    foreach (SCOOPDataSet.OrcamentoRow linha in Dt)
                    {
                        OrcamentoContratadodataGridView.Rows[i].Cells[2].Value = linha.Codigo;
                        OrcamentoContratadodataGridView.Rows[i].Cells[3].Value = linha.Descricao;
                    }
                    OrcamentoContratadodataGridView.Rows[i].Cells[4].Value = new LicitadoTableAdapter().ObterDescricaoLicitacao((int)OrcamentoContratadodataGridView.Rows[i].Cells[7].Value).ToUpper();
                    OrcamentoContratadodataGridView.Rows[i].Cells[5].Value = new SecretariaTableAdapter().ObterDescricaoSecretaria((int)OrcamentoContratadodataGridView.Rows[i].Cells[8].Value).ToUpper();
                    OrcamentoContratadodataGridView.Rows[i].Cells[6].Value = new EmpresaTableAdapter().ObterDescricaoEmpresa((int)OrcamentoContratadodataGridView.Rows[i].Cells[9].Value).ToUpper();
                }
            }
            catch (Exception ex) { }
             * */
        }

        public string ObterSequencialContrato()
        {

            string Sequencial = new ContratoTableAdapter().ObterSequencialContrato().ToString();
            
            if (Sequencial.Length == 5)
            {
                Sequencial = "0" + Sequencial;
                return Sequencial;
            }
            else if (Sequencial.Length == 4)
            {
                Sequencial = "00" + Sequencial;
                return Sequencial;
            }
            else if (Sequencial.Length == 3)
            {
                Sequencial = "000" + Sequencial;
                return Sequencial;
            }
            else if (Sequencial.Length == 2)
            {
                Sequencial = "0000" + Sequencial;
                return Sequencial;
            }
            else if (Sequencial.Length == 1)
            {
                Sequencial = "00000" + Sequencial;
                return Sequencial;
            }
            else
            {
                return Sequencial;
            }
        }

        public string PreencherAteDoisValor(string Texto)
        {
            if (Texto.Length == 1)
            {
                Texto = "0" + Texto;
                return Texto;
            }
            else
            {
                return Texto;
            }
        }
        /// <summary>
        /// Gerando Contrato.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BttContrato_Click_1(object sender, EventArgs e)
        {
            string valor;
            try
            {
                valor = new ContratoTableAdapter().ExisteContrato(MskTxtBoxCodigo.Text).ToString();
                valor.Replace(".", "").Replace("/", "").Trim();
            }
            catch (Exception ex)
            {
                ObterSequencialContrato();
                valor = null;
            }

            if (valor == "" || valor == null)
            {
                ObterSequencialContrato();
                try
                {
                    TimeSpan Interval = Convert.ToDateTime(MksTxtBoxPrazo.Text) - Convert.ToDateTime(DataInicioMskTxtBox.Text);
                    new ContratoTableAdapter().Insert(MskTxtBoxCodigo.Text,
                                                                                          (int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text),
                                                                                          ContratoMaskedTextBox.Text,
                                                                                          "José Queiroz de Lima",
                                                                                          ComboBoxEmpreteira.Text,
                                                                                          TxtBoxCGCCPF.Text,
                                                                                          TxtBoxLogradouro.Text,
                                                                                          TxtBoxBairro.Text,
                                                                                          TxtBoxCidade.Text,
                                                                                          "PE",
                                                                                          MskTxtBoxCodigo.Text,
                                                                                          TxtBoxDescricao.Text,
                                                                                          TxtBoxLogradouro.Text,
                                                                                          TxtBoxBairro.Text,
                                                                                          TxtBoxCidade.Text,
                                                                                          new TipoOrcamentoTableAdapter().ObterDescricaoTipoOrcamento((int)new OrcamentoTableAdapter().ObterTipoObraOrcamento(MskTxtBoxCodigo.Text).Value),
                                                                                          Convert.ToDecimal(TxtBoxTotalOrçamento.Text.Replace("R", "").Replace("$", "").Replace(".", "").Trim()),
                                                                                          Convert.ToInt32(Interval.TotalDays),
                                                                                          Convert.ToDateTime(MskTxtDataCriacao.Text),
                                                                                          TxtBoxTotalOrçamento.Text.Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim());

                    Form frm = new Contrato(ContratoMaskedTextBox.Text);
                    frm.ShowDialog();
                    buttonOrdemServico.Enabled = true;
                    buttonOrdemServico.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar Contrato! " + ex.Message);
                    buttonOrdemServico.Enabled = false;
                    buttonOrdemServico.Visible = false;
                }
            }
            else
            {
                new SCOOP.DAO.SCOOPDataSetTableAdapters.ContratoTableAdapter().Delete(ContratoMaskedTextBox.Text);

                TimeSpan Interval = Convert.ToDateTime(MksTxtBoxPrazo.Text) - Convert.ToDateTime(DataInicioMskTxtBox.Text);
                new ContratoTableAdapter().Insert(MskTxtBoxCodigo.Text,
                                                                                      (int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text),
                                                                                      ContratoMaskedTextBox.Text,
                                                                                      "José Queiroz de Lima",
                                                                                      ComboBoxEmpreteira.Text,
                                                                                      TxtBoxCGCCPF.Text,
                                                                                      TxtBoxLogradouro.Text,
                                                                                      TxtBoxBairro.Text,
                                                                                      TxtBoxCidade.Text,
                                                                                      "PE",
                                                                                      MskTxtBoxCodigo.Text,
                                                                                      TxtBoxDescricao.Text,
                                                                                      TxtBoxLogradouro.Text,
                                                                                      TxtBoxBairro.Text,
                                                                                      TxtBoxCidade.Text,
                                                                                      new TipoOrcamentoTableAdapter().ObterDescricaoTipoOrcamento((int)new OrcamentoTableAdapter().ObterTipoObraOrcamento(MskTxtBoxCodigo.Text).Value),
                                                                                      Convert.ToDecimal(TxtBoxTotalOrçamento.Text.Replace("R", "").Replace("$", "").Replace(".", "").Trim()),
                                                                                      Convert.ToInt32(Interval.TotalDays),
                                                                                      Convert.ToDateTime(MskTxtDataCriacao.Text),
                                                                                      TxtBoxTotalOrçamento.Text.Replace("R", "").Replace("$", "").Replace(".", "").Replace(",", ".").Trim());


                Form frm = new Contrato(ContratoMaskedTextBox.Text);
                frm.ShowDialog();
            }
        }

        private void buttonOrdemServico_Click(object sender, EventArgs e)
        {
            if (new Orcamento_ContratadoTableAdapter().ExisteOrcamentoContratado((int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text)).HasValue)
            {
                try
                {
                    new Orcamento_ContratadoTableAdapter().AtualizarOrdemServiço("S", (int)new Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text)));
                    Form frm = new SCOOP.GUI.Relatorio("OrdemServico", MskTxtBoxCodigo.Text);
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Gerar Ordem de Serviço!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void ServicodataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PreencherTotalDataGridView();
            preencherDataGridView();
        }

        private void preencherDataGridView()
        {
            for (int i = 0; i < ServicodataGridView1.RowCount; i++)
            {
                SCOOPDataSet.ServicoDataTable Dt = new ServicoTableAdapter().GetDataBy1(ServicodataGridView1.Rows[i].Cells[2].Value.ToString());

                foreach (SCOOPDataSet.ServicoRow linha in Dt)
                {
                    ServicodataGridView1.Rows[i].Cells[3].Value = linha.Descricao;                    
                }
            }
        }

        //Preencher Dados do GridView
        private void OrcamentoContratadodataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            

            for (int i = 0; i < OrcamentoContratadodataGridView.RowCount; i++)
            {
                SCOOPDataSet.Orcamento_ContratadoDataTable Dt = new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().GetDataBy11(Convert.ToInt32(OrcamentoContratadodataGridView.Rows[i].Cells[0].Value));

                foreach (SCOOPDataSet.Orcamento_ContratadoRow linha in Dt)
                {
                    OrcamentoContratadodataGridView.Rows[i].Cells[4].Value = new SCOOP.DAO.SCOOPDataSetTableAdapters.LicitadoTableAdapter().ObterDescricaoLicitacao(linha.Licitado);
                    OrcamentoContratadodataGridView.Rows[i].Cells[5].Value = new SCOOP.DAO.SCOOPDataSetTableAdapters.SecretariaTableAdapter().ObterDescricaoSecretaria(linha.Secretaria);
                    OrcamentoContratadodataGridView.Rows[i].Cells[6].Value = new SCOOP.DAO.SCOOPDataSetTableAdapters.EmpresaTableAdapter().ObterDescricaoEmpresa(linha.Empresa);
                }
            }
        }

        //BDI
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal ValorTotalOrc = 0;
            switch (BDIComboBox.Text.Replace(",00", ""))
            {
                case "10":
                    ValorTotalOrc = Convert.ToDecimal(new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                    //new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.10)));
                    break;
                case "15":
                    ValorTotalOrc = Convert.ToDecimal(new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                    //new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.15)));
                    break;
                case "20":
                    ValorTotalOrc = Convert.ToDecimal(new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                    //new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.20)));
                    break;
                case "25":
                    ValorTotalOrc = Convert.ToDecimal(new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                    //new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.25)));
                    break;
                case "30":
                    ValorTotalOrc = Convert.ToDecimal(new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                    //new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.30)));
                    break;
                default:
                    ValorTotalOrc = Convert.ToDecimal(new Orc_Cont_ServicoTableAdapter().ObterTotalOrcamento(MskTxtBoxCodigo.Text));
                    //new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    decimal percentual = Convert.ToDecimal("0," + BDIComboBox.Text.Replace(",00", ""));
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * percentual));
                    break;
            }
        }

        private void BttAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int seq_orcamento = Convert.ToInt32(new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text));
                    new Orcamento_ContratadoTableAdapter().Update(seq_orcamento,
                                                                  (int)ComboBoxLicitado.SelectedValue,
                                                                  (int)ComboBoxSecretaria.SelectedValue,
                                                                  new EmpresaTableAdapter().ObterCodigoEmpresa((int)ComboBoxEmpreteira.SelectedValue).Value,
                                                                  TxtBoxCGCCPF.Text,
                                                                  Convert.ToDateTime(MksTxtBoxPrazo.Text.Replace("/", "") == "" ? null : MksTxtBoxPrazo.Text),
                                                                  Convert.ToDateTime(MskTxtDataCriacao.Text == "" ? null : MskTxtDataCriacao.Text),
                                                                  DateTime.Now,
                                                                  Settings.Default.Usuario,
                                                                  Convert.ToDateTime(MksTxtBoxPrazo.Text.Replace("/", "") == "" ? null : MksTxtBoxPrazo.Text),
                                                                  "N",
                                                                  Convert.ToDecimal(BDIComboBox.Text),
                                                                  ModalidadecomboBox.Text,
                                                                  ProcessotextBox.Text,
                                                                  (int)new Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado(seq_orcamento),
                                                                  seq_orcamento,
                                                                  (int)new Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado(seq_orcamento));



                    MessageBox.Show("Alteração orçamento contratado relizada com sucesso.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro na alteração do orçamento contratado.");
                }

                DesativarPrimeiraParteAtivarSegunda();
            }
            catch (Exception ex)
            {
                ativarPrimeiraParteDesativarSegunda();
            }
        }

        public void ativarPrimeiraParteDesativarSegunda()
        {
            DataInicioMskTxtBox.Enabled = true;
            MksTxtBoxPrazo.Enabled = true;
            button2.Enabled = true;
            groupBox2.Enabled = true;
            groupBox4.Enabled = true;
            bindingNavigator1.Enabled = false;
            ServicodataGridView1.Enabled = false;
            groupBox1.Enabled = false;
            BttAtualizar.Visible = false;
        }

        public void DesativarPrimeiraParteAtivarSegunda()
        {
            DataInicioMskTxtBox.Enabled = false;
            MksTxtBoxPrazo.Enabled = false;
            button2.Enabled = false;
            BttAtualizar.Enabled = true;
            groupBox2.Enabled = false;
            groupBox4.Enabled = false;
            bindingNavigator1.Enabled = true;
            ServicodataGridView1.Enabled = true;
            groupBox1.Enabled = true;
            BttContrato.Visible = true;
            buttonOrdemServico.Enabled = true;
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            Form frm = new EstornoOrcamentoContratado(OrcamentoContratadodataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text)-1].Cells[1].Value.ToString());
            frm.ShowDialog();
            this.orcamento_ContratadoTableAdapter.Fill(this.sCOOPDataSet.Orcamento_Contratado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new DotacaoOrcamentaria(MskTxtBoxCodigo.Text);
            frm.Focus();
            frm.Show();
            
        }

    }
}
