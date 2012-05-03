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
using SCOOP.DAO.SCOOPDataSetTableAdapters;
using SCOOP.DAO;
using SCOOP.GUI;

namespace SCOOP
{
    public partial class CadastroOrcamentocs : Form
    {
        private string CodigoOrcamento;
        public int tabPage = 1;
        public CadastroOrcamentocs(int tabPage)
        {
            InitializeComponent();
            this.tabPage = tabPage;

        }

        private void CadastroOrcamentocs_Load(object sender, EventArgs e)
        {




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
                // TODO: This line of code loads data into the 'sCOOPDataSet.Orcamento' table. You can move, or remove it, as needed.
                this.orcamentoTableAdapter.Fill(this.sCOOPDataSet.Orcamento);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Fiscalizacao' table. You can move, or remove it, as needed.
                this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.TipoOrcamento' table. You can move, or remove it, as needed.
                //this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.DotacaoOrcamentaria' table. You can move, or remove it, as needed.
                this.dotacaoOrcamentariaTableAdapter.Fill(this.sCOOPDataSet.DotacaoOrcamentaria);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Bairro' table. You can move, or remove it, as needed.
                this.bairroTableAdapter.Fill(this.sCOOPDataSet.Bairro);
            }
            catch (Exception) { }
            if (CodigoOrcamento == "" || CodigoOrcamento == null)
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SCOOPConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(SUBSTRING([Codigo],1,4)),0)+1  FROM [scoop].[dbo].[Orcamento]");
                SqlDataReader Dr;
                cmd.Connection = conn;
                try
                {

                    conn.Open();

                    Dr = cmd.ExecuteReader();

                    while (Dr.Read())
                    {
                        CodigoOrcamento = Dr.GetValue(0).ToString();
                    }


                }
                catch (Exception ex)
                {
                    CodigoOrcamento = "0001";
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                string Aux = CodigoOrcamento;
                for (int i = 3; i >= Aux.Length; i--)
                {
                    CodigoOrcamento = "0" + CodigoOrcamento;
                }

                MskTxtBoxCodigo.Text = CodigoOrcamento + DateTime.Now.Year.ToString().Substring(2);
                BairroComboBox.Text = "";
                FiscalComboBox.Text = "";
                DotacaoOrcamentariaComboBox.Text = "";
                TipoOrcamentoComboBox.Text = "";

                if (DateTime.Now.Day.ToString().Length == 1)
                {
                    if (DateTime.Now.Month.ToString().Length == 1)
                    {
                        MskTxtDataCriacao.Text = "0" + DateTime.Now.Day.ToString() + "0" + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                    }
                    else
                    {
                        MskTxtDataCriacao.Text = "0" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                    }
                }
                else
                {
                    if (DateTime.Now.Month.ToString().Length == 1)
                    {
                        MskTxtDataCriacao.Text = DateTime.Now.Day.ToString() + "0" + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                    }
                    else
                    {
                        MskTxtDataCriacao.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
                    }
                }
            #endregion
            }
        }

        private void BttCadastrarServico_Click(object sender, EventArgs e)
        {
            string Mensagem = null;

            try
            {
                if (TxtBoxDescricao.Text != "" && BairroComboBox.Text != "" && TipoOrcamentoComboBox.Text != "")
                {
                    try
                    {
                        new OrcamentoTableAdapter().Insert(MskTxtBoxCodigo.Text, TxtBoxDescricao.Text, Convert.ToDateTime(MskTxtDataCriacao.Text), TxtBoxLocal.Text, BairroComboBox.Text, (int)DotacaoOrcamentariaComboBox.SelectedValue, Convert.ToInt32(TipoOrcamentoComboBox.SelectedValue), Convert.ToInt32(FiscalComboBox.SelectedValue), DateTime.Now, Convert.ToDecimal(BDIComboBox.Text == "" ? "0" : BDIComboBox.Text), "Admin", CidadeTextBox.Text, "55000-000");
                        GrupoBoxServicos.Enabled = true;
                        groupBox1.Enabled = false;
                        BttImportar.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar Orçamento. \n" + ex.Message);
                        BttImportar.Visible = false;
                    }
                }
                else
                {
                    if (TxtBoxDescricao.Text == "")
                        Mensagem += "Descrição Vazia! \n";
                    if (TxtBoxLocal.Text == "")
                        Mensagem += "Local Vazia! \n";
                    if (BairroComboBox.Text == "")
                        Mensagem += "Bairro Vazio! \n";
                    if (TipoOrcamentoComboBox.Text == "")
                        Mensagem += "Tipo de Orçamento Vazio! \n";
                    if (FiscalComboBox.Text == "")
                        Mensagem += "Fiscal Vazio! ";
                    MessageBox.Show(Mensagem);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Erro ao cadastrar Orçamento. " + EX.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new PesquiarServico(this, null);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtBoxServicoQuantidade.Text != "")
                {
                    new Orc_ServicoTableAdapter().Insert(mskTxtBoxCodServico.Text.Replace(",", "."), 
                                                        (int)new ServicoTableAdapter().ObterSequencialServico(mskTxtBoxCodServico.Text.Replace(",", ".")).Value, 
                                                        MskTxtBoxCodigo.Text, 
                                                        (int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text), 
                                                        DateTime.Now,
                                                        Convert.ToDecimal(TxtBoxServicoQuantidade.Text == "" ? null : TxtBoxServicoQuantidade.Text), 
                                                        Convert.ToDecimal(TxtBoxValorUnitario.Text.Replace("R$", "").Replace(".",",")), 
                                                        DateTime.Now, "Admin");
                    mskTxtBoxCodServico.Text = "";
                    TxtDescricaoServico.Text = "";
                    TxtBoxUnidadeServico.Text = "";
                    TxtBoxServicoQuantidade.Text = "";
                    TxtBoxValorUnitario.Text = "";
                    this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, MskTxtBoxCodigo.Text);
                    preencherDataGridViewServico();
                    comboBox1_SelectedIndexChanged(null, null);
                    BttContrato.Enabled = true;
                    mskTxtBoxCodServico.Focus();
                }
                else
                {
                    MessageBox.Show("Quantidade não definida! ");
                    TxtBoxServicoQuantidade.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Inserir Serviço. " + ex.Message);
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtBoxServicoQuantidade_TextChanged(object sender, EventArgs e)
        {


        }

        private void mskTxtBoxCodServico_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal ValorTotalOrc = 0;
            switch (BDIComboBox.Text.Replace(",00", ""))
            {
                case "10":
                    ValorTotalOrc = Convert.ToDecimal(ValorTotalOrcamento(MskTxtBoxCodigo.Text));
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.10)));
                    break;
                case "15":
                    ValorTotalOrc = Convert.ToDecimal(ValorTotalOrcamento(MskTxtBoxCodigo.Text));
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.15)));
                    break;
                case "20":
                    ValorTotalOrc = Convert.ToDecimal(ValorTotalOrcamento(MskTxtBoxCodigo.Text));
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.20)));
                    break;
                case "25":
                    ValorTotalOrc = Convert.ToDecimal(ValorTotalOrcamento(MskTxtBoxCodigo.Text));
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.25)));
                    break;
                case "30":
                    ValorTotalOrc = Convert.ToDecimal(ValorTotalOrcamento(MskTxtBoxCodigo.Text));
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * Convert.ToDecimal(0.30)));
                    break;
                default:
                    ValorTotalOrc = Convert.ToDecimal(ValorTotalOrcamento(MskTxtBoxCodigo.Text));
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal(BDIComboBox.Text == "" ? "0" : BDIComboBox.Text), MskTxtBoxCodigo.Text);
                    decimal percentual = Convert.ToDecimal("0,"+BDIComboBox.Text.Replace(",00",""));
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc + (ValorTotalOrc * percentual));
                    break;
            }
        }
        public object ValorTotalOrcamento(string CodigoOrcamento)
        {
            decimal valorTotal = 0;
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("select sum(Quantidade*Valor) from orc_servico where Codigo_Orcamento = @Codigo_Orcamento");
            cmd.Parameters.Add("@Codigo_Orcamento", SqlDbType.VarChar).Value = MskTxtBoxCodigo.Text.Replace(",", ".");
            cmd.Connection = conn;
            try
            {
                conn.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    valorTotal = Dr.GetDecimal(0);
                }
                return valorTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Valor Total Orçamento! " + ex.Message);
                return valorTotal;
            }
            finally
            {
                conn.Close();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new SCOOP.GUI.Relatorio("Orcamento", MskTxtBoxCodigo.Text);
            frm.ShowDialog();
        }

        private void TxtBoxValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!TxtBoxValorUnitario.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void TxtBoxServicoQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!TxtBoxServicoQuantidade.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void TxtBoxTotalOrçamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!TxtBoxTotalOrçamento.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orcamentoTableAdapter.Fill(this.sCOOPDataSet.Orcamento);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BttPesquisa_Click(object sender, EventArgs e)
        {
            this.orcamentoTableAdapter.FillBy(this.sCOOPDataSet.Orcamento, textBox1.Text);
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            CadastroOrcamentocs_Load(null, null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string NumeroOrcamento = null;
            string BDI = null;
            string Total = null;
            dotacaoOrcamentariaTableAdapter.Fill(this.sCOOPDataSet.DotacaoOrcamentaria);
            
            SCOOPDataSet.OrcamentoDataTable Dt = new OrcamentoTableAdapter().GetDataBy2(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[1].Value.ToString());

            foreach (SCOOPDataSet.OrcamentoRow linha in Dt)
            {
                CodigoOrcamento = linha.Sequencial.ToString();
                MskTxtBoxCodigo.Text = linha.Codigo;
                TxtBoxDescricao.Text = linha.Descricao;
                MskTxtDataCriacao.Text = linha.Dt_criacao.ToShortDateString();
                TxtBoxLocal.Text = linha.Logradouro;
                try { BairroComboBox.Text = linha.Bairro; }
                catch (Exception) { }
                try { DotacaoOrcamentariaComboBox.Text = new DotacaoOrcamentariaTableAdapter().ObterDescricaoDotacaoOrcamentaria(linha.DotacaoOrcamentaria); }
                catch (Exception ex) { }
                try{  tipoOrcamentoTableAdapter.FillBy1(this.sCOOPDataSet.TipoOrcamento, (int)DotacaoOrcamentariaComboBox.SelectedValue); }
                catch (Exception ex) { }
                try { TipoOrcamentoComboBox.Text = new TipoOrcamentoTableAdapter().ObterDescricaoTipoOrcamento(linha.TipoOrcamento); }
                catch (Exception) { }
                try { FiscalComboBox.Text = new FiscalizacaoTableAdapter().ObterDescricaoFiscalizacao(linha.Fiscal).ToString(); }
                catch (Exception ex) { }
                NumeroOrcamento = linha.Codigo;
                CidadeTextBox.Text = linha.Cidade;
                try
                {
                    BDIComboBox.Text = linha.BDI.ToString();
                    BDI = linha.BDI.ToString();
                }
                catch (Exception ex)
                {
                    try
                    {
                        Total = new Orc_ServicoTableAdapter().TotalServicoPorOrcamento(MskTxtBoxCodigo.Text).Value.ToString();
                    }
                    catch (Exception )
                    { }
                }

            }
            this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, NumeroOrcamento);
            preencherDataGridViewServico();
            BttAtualizar.Visible = true;
            BttContrato.Visible = false;
            BttCadastrarServico.Visible = false;
            groupBox1.Enabled = true;
            GrupoBoxServicos.Enabled = true;
            BDIComboBox.Text = BDI;
            comboBox1_SelectedIndexChanged(null, null);
            tabControl1.SelectedTab = tabPage1;

        }

        private void BttAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                new OrcamentoTableAdapter().Update(MskTxtBoxCodigo.Text.Replace(",", "."),
                                                                             TxtBoxDescricao.Text,
                                                                             Convert.ToDateTime(MskTxtDataCriacao.Text),
                                                                             TxtBoxLocal.Text,
                                                                             BairroComboBox.Text,
                                                                             (int)DotacaoOrcamentariaComboBox.SelectedValue,
                                                                             (int)TipoOrcamentoComboBox.SelectedValue,
                                                                             Convert.ToInt32(FiscalComboBox.SelectedValue),
                                                                             DateTime.Now,
                                                                             Convert.ToDecimal(BDIComboBox.Text),
                                                                             Settings.Default.Usuario,
                                                                             CidadeTextBox.Text,
                                                                             "55000-000",
                                                                             Convert.ToInt32(CodigoOrcamento),
                                                                             Convert.ToInt32(CodigoOrcamento));
                MessageBox.Show("Orçamento Atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar Orçamento contate o administrador.\n" + ex.Message);
            }
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            CodigoOrcamento = null;
            TxtBoxDescricao.Text = "";
            TxtBoxLocal.Text = "";
            GrupoBoxServicos.Enabled = false;
            CadastroOrcamentocs_Load(null, null);
            BairroComboBox.Text = "";
            DotacaoOrcamentariaComboBox.Text = "";
            FiscalComboBox.Text = "";
            TipoOrcamentoComboBox.Text = "";
            CidadeTextBox.Text = "";
            this.orc_ServicoTableAdapter.FillBy(this.sCOOPDataSet.Orc_Servico, MskTxtBoxCodigo.Text);
            preencherDataGridViewServico();
            BDIComboBox.Text = "";
            TxtBoxTotalOrçamento.Text = "";
            BttContrato.Visible = false;
            button3.Visible = false;
            BttCadastrarServico.Visible = true;
            BttAtualizar.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new PesquisarBairro(this);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroGrupoMedicao(this);
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroFiscalizador(this);
            frm.ShowDialog();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            mskTxtBoxCodServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString();
            TxtDescricaoServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[4].Value.ToString();
            TxtBoxUnidadeServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[5].Value.ToString();
            TxtBoxServicoQuantidade.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[6].Value.ToString();
            TxtBoxValorUnitario.Text = new ComposicaoTableAdapter().ObterTotalServico(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString()).ToString();
            bindingNavigator1.Enabled = false;
            BttConfirma.Visible = true;
            BttCancelar.Visible = true;
        }

        private void BttConfirma_Click(object sender, EventArgs e)
        {
            new Orc_ServicoTableAdapter().Update(mskTxtBoxCodServico.Text.Replace(",", "."),
                                                                            Convert.ToInt32(new ServicoTableAdapter().ObterSequencialServico(mskTxtBoxCodServico.Text.Replace(",", ".")).Value),
                                                                            MskTxtBoxCodigo.Text,
                                                                            (int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text),
                                                                            Convert.ToDateTime(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[10].Value),
                                                                            Convert.ToDecimal(TxtBoxServicoQuantidade.Text),
                                                                            Convert.ToDecimal(TxtBoxValorUnitario.Text),
                                                                            DateTime.Now,
                                                                            "Admin",
                                                                            Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value),
                                                                            ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(),
                                                                            Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value),
                                                                            ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString(),
                                                                            Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[9].Value),
                                                                            Convert.ToDateTime(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[10].Value),
                                                                            Convert.ToDecimal(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[6].Value),
                                                                            Convert.ToDecimal(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[7].Value),
                                                                            Convert.ToDateTime(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[11].Value),
                                                                            Convert.ToInt32(new Orc_ServicoTableAdapter().ObterSequencialOrcServico(mskTxtBoxCodServico.Text.Replace(",", "."), MskTxtBoxCodigo.Text).ToString()));
            mskTxtBoxCodServico.Text = "";
            TxtDescricaoServico.Text = "";
            TxtBoxUnidadeServico.Text = "";
            TxtBoxServicoQuantidade.Text = "";
            TxtBoxValorUnitario.Text = "";
            this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, MskTxtBoxCodigo.Text);
            preencherDataGridViewServico();
            BttConfirma.Visible = false;
            BttCancelar.Visible = false;
            bindingNavigator1.Enabled = true;
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void BttCancelar_Click(object sender, EventArgs e)
        {
            mskTxtBoxCodServico.Text = "";
            TxtDescricaoServico.Text = "";
            TxtBoxUnidadeServico.Text = "";
            TxtBoxServicoQuantidade.Text = "";
            TxtBoxValorUnitario.Text = "";
            this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, MskTxtBoxCodigo.Text);
            preencherDataGridViewServico();
            BttConfirma.Visible = false;
            BttCancelar.Visible = false;
            bindingNavigator1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Orc_ServicoTableAdapter().ApagarOrcamentoTodo(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[1].Value.ToString());
                    new OrcamentoTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[0].Value), dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[1].Value.ToString());
                    this.orcamentoTableAdapter.Fill(this.sCOOPDataSet.Orcamento);
                    MessageBox.Show("Orçamento Excluido com Sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir orçamento contate o administrador.\n" + ex.Message);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Orc_ServicoTableAdapter().Delete(Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value)
                                                                                   , ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString()
                                                                                   , Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value)
                                                                                   , ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString()
                                                                                   , Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[9].Value)
                                                                                   , Convert.ToDateTime(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[10].Value)
                                                                                   , Convert.ToDecimal(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[6].Value)
                                                                                   , Convert.ToDecimal(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[7].Value)
                                                                                   , Convert.ToDateTime(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[11].Value)
                                                                                   );
                    this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, CodigoOrcamento);
                    comboBox1_SelectedIndexChanged(null, null);
                    BttCancelar_Click(null, null);
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

        private void mskTxtBoxCodServico_TextChanged(object sender, EventArgs e)
        {
            if (mskTxtBoxCodServico.Text.Length == 12)
            {
                SCOOPDataSet.ServicoDataTable Dt = new ServicoTableAdapter().GetDataBy2(mskTxtBoxCodServico.Text.Replace(",", "."));

                foreach (SCOOPDataSet.ServicoRow linha in Dt)
                {
                    TxtDescricaoServico.Text = linha.Descricao;
                    TxtBoxUnidadeServico.Text = linha.Unidade;
                    try { TxtBoxValorUnitario.Text = string.Format("{0:C2}", new ComposicaoTableAdapter().ObterTotalServico(mskTxtBoxCodServico.Text.Replace(",", ".")).ToString()); }
                    catch (Exception)
                    {
                        TxtBoxValorUnitario.Text = "";
                    }
                }
                TxtBoxServicoQuantidade.Focus();
                if (mskTxtBoxCodServico.Text == "022.169.9999")
                {
                    TxtBoxDescricao.Enabled = true;
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem1_Click(null, null);
        }
        void preencherDataGridViewServico()
        {
            for (int i = 0; i < ServicodataGridView1.RowCount; i++)
            {
                SCOOPDataSet.ServicoDataTable Dt = new ServicoTableAdapter().GetDataBy1(ServicodataGridView1.Rows[i].Cells[1].Value.ToString().Replace(",", "."));

                foreach (SCOOPDataSet.ServicoRow linha in Dt)
                {
                    ServicodataGridView1.Rows[i].Cells[4].Value = linha.Descricao;
                    ServicodataGridView1.Rows[i].Cells[5].Value = linha.Unidade;
                    ServicodataGridView1.Rows[i].Cells[8].Value = Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[6].Value) * Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[7].Value);
                }
            }
        }

        private void DotacaoOrcamentariaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try { this.tipoOrcamentoTableAdapter.FillBy1(this.sCOOPDataSet.TipoOrcamento, (int)DotacaoOrcamentariaComboBox.SelectedValue); }
            catch (Exception ex) { }
        }

        private void BDIComboBox_TextChanged(object sender, EventArgs e)
        {
            if (BDIComboBox.Text.Length == 2)
            {
                comboBox1_SelectedIndexChanged(null, null);
            }
        }

        private void ServicodataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            preencherDataGridViewServico();
        }

        private void BttImportar_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroTabelaExterna(this);
            frm.ShowDialog();
        }

        private void CadastroOrcamentocs_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            { }

        }

        private void CadastroOrcamentocs_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    button2_Click(sender, e);
                    break;
                case Keys.F2:
                    BttImportar_Click(sender, e);
                    break;
                case Keys.F3:
                    //contabilistaToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F4:
                    //empresaToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F5:
                    button1_Click(sender, e);
                    break;
                case Keys.F6:
                    //imprimirToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F7:
                    //saldoISSToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F8:
                    //sairToolStripMenuItem_Click(sender, e);
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorios1();
            frm.Show();
        }
    }
}
