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

namespace SCOOP.GUI
{
    public partial class CadastroAditivo : Form
    {
        private string CodigoOrcamento;
        public int tabPage = 1;
        public CadastroAditivo(int tabPage)
        {
            InitializeComponent();
            this.tabPage = tabPage;

        }

        private void CadastroOrcamentocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Orcamento' table. You can move, or remove it, as needed.
            this.orcamentoTableAdapter.Fill(this.sCOOPDataSet.Orcamento);
             // TODO: This line of code loads data into the 'sCOOPDataSet.Bairro' table. You can move, or remove it, as needed.
            this.bairroTableAdapter.Fill(this.sCOOPDataSet.Bairro);

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
                // TODO: This line of code loads data into the 'OrcamentoDataSet.Orcamento' table. You can move, or remove it, as needed.
                this.orcamentoTableAdapter.Fill(this.sCOOPDataSet.Orcamento);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'OrcamentoDataSet.Fiscalizacao' table. You can move, or remove it, as needed.
                this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'OrcamentoDataSet.Tipo_Orcamento' table. You can move, or remove it, as needed.
                this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
            }
            catch (Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'OrcamentoDataSet.Bairro' table. You can move, or remove it, as needed.
                this.bairroTableAdapter.Fill(this.sCOOPDataSet.Bairro);
            }
            catch (Exception) { }
            if (CodigoOrcamento == "" || CodigoOrcamento == null)
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SCOOPConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT (IDENT_CURRENT('[SCOOP].[dbo].[Orcamento]')+1)");
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
                if (TxtBoxDescricao.Text != "" && BairroComboBox.Text != "")
                {
                    try
                    {
                        //new OrcamentoTableAdapter().Insert(MskTxtBoxCodigo.Text, TxtBoxDescricao.Text, Convert.ToDateTime(MskTxtDataCriacao.Text), TxtBoxLocal.Text, BairroComboBox.Text, (int)DotacaoOrcamentariaComboBox.SelectedValue, Convert.ToInt32(TipoOrcamentoComboBox.SelectedValue), Convert.ToInt32(FiscalComboBox.SelectedValue), DateTime.Now, Convert.ToDecimal(BDIComboBox.Text == "" ? "0" : BDIComboBox.Text), "Admin",CidadeTextBox.Text,"55000-000");
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
            //Form frm = new PesquiarServico(this, null);
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//
            try
            {
                if (TxtBoxServicoQuantidade.Text != "")
                {
                    new Orc_ServicoTableAdapter().Insert(mskTxtBoxCodServico.Text.Replace(",", "."), (int)new ServicoTableAdapter().ObterSequencialServico(mskTxtBoxCodServico.Text.Replace(",", ".")).Value, MskTxtBoxCodigo.Text, (int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text), DateTime.Now, Convert.ToDecimal(TxtBoxServicoQuantidade.Text), Convert.ToDecimal(TxtBoxValorUnitario.Text.Replace("R$", "")), DateTime.Now, "Admin");
                    mskTxtBoxCodServico.Text = "";
                    TxtDescricaoServico.Text = "";
                    TxtBoxUnidadeServico.Text = "";
                    TxtBoxServicoQuantidade.Text = "";
                    TxtBoxValorUnitario.Text = "";
                    this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, MskTxtBoxCodigo.Text);
                    preencherDataGridViewServico();
                    comboBox1_SelectedIndexChanged(null, null);
                    BttContrato.Enabled = true;
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
            switch (BDIComboBox.Text.Replace(",00",""))
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
                    new OrcamentoTableAdapter().AlterarBDI(Convert.ToDecimal("0"), MskTxtBoxCodigo.Text);
                    TxtBoxTotalOrçamento.Text = String.Format("{0:C2}", ValorTotalOrc);
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
            Form frm = new Relatorio("Orcamento", MskTxtBoxCodigo.Text);
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
            SCOOPDataSet.OrcamentoDataTable Dt = new OrcamentoTableAdapter().GetDataBy2(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[1].Value.ToString());

            foreach (SCOOPDataSet.OrcamentoRow linha in Dt)
            {
                CodigoOrcamento = linha.Sequencial.ToString();
                MskTxtBoxCodigo.Text = linha.Codigo;
                TxtBoxDescricao.Text = linha.Descricao;
                MskTxtDataCriacao.Text = linha.Dt_criacao.ToShortDateString();
                TxtBoxLocal.Text = linha.Logradouro;
                try { BairroComboBox.Text = linha.Bairro; }
                catch (Exception ) { }
                try{//DotacaoOrcamentariaComboBox.Text = new DotacaoOrcamentariaTableAdapter().ObterDescricaoDotacaoOrcamentaria(linha.DotacaoOrcamentaria).ToString();
                }
                catch (Exception ex) { }
                try { //TipoOrcamentoComboBox.Text = new TipoOrcamentoTableAdapter().ObterDescricaoTipoOrcamento(linha.TipoOrcamento).ToString(); 
                }
                catch (Exception ) { }
                try { //FiscalComboBox.Text = new FiscalizacaoTableAdapter().ObterDescricaoFiscalizacao(linha.Fiscal).ToString(); 
                }
                catch (Exception ex) { }
                NumeroOrcamento = linha.Codigo;
                CidadeTextBox.Text = linha.Cidade;
                try { BDI = linha.BDI.ToString(); }
                catch (Exception ex)
                {
                    Total = new Orc_ServicoTableAdapter().TotalServicoPorOrcamento(MskTxtBoxCodigo.Text).Value.ToString();
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
             /*   new OrcamentoTableAdapter().Update(MskTxtBoxCodigo.Text.Replace(",", "."), 
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
                                                                             Convert.ToInt32(CodigoOrcamento));*/
                MessageBox.Show("Orçamento Atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar Orçamento contate o administrador.\n" + ex.Message);
            }
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            TxtBoxDescricao.Text = "";
            TxtBoxLocal.Text = "";            
            GrupoBoxServicos.Enabled = false;
            CadastroOrcamentocs_Load(null, null);
            BairroComboBox.Text = "";
            // DotacaoOrcamentariaComboBox.Text = "";
            //FiscalComboBox.Text = "";
            //TipoOrcamentoComboBox.Text = "";
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
            // frm = new PesquisarBairro(this);
            //frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form frm = new CadastroGrupoMedicao(this);
            //frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form frm = new CadastroFiscalizador(this);
            //frm.ShowDialog();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            mskTxtBoxCodServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString();
            TxtDescricaoServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[4].Value.ToString();
            TxtBoxUnidadeServico.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[5].Value.ToString();
            TxtBoxServicoQuantidade.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[6].Value.ToString();
            TxtBoxValorUnitario.Text = ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[7].Value.ToString();
            bindingNavigator1.Enabled = false;
            BttConfirma.Visible = true;
            BttCancelar.Visible = true;
        }

        private void BttConfirma_Click(object sender, EventArgs e)
        {
            new Orc_ServicoTableAdapter().Update(mskTxtBoxCodServico.Text.Replace(",", "."), 
                                                                            Convert.ToInt32(new ServicoTableAdapter().ObterSequencialServico(mskTxtBoxCodServico.Text.Replace(",", ".")).Value), 
                                                                            CodigoOrcamento, 
                                                                            (int)new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigo.Text),
                                                                            Convert.ToDateTime(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[10].Value), 
                                                                            Convert.ToDecimal(TxtBoxServicoQuantidade.Text), 
                                                                            Convert.ToDecimal(TxtBoxValorUnitario.Text), 
                                                                            DateTime.Now, 
                                                                            "Admin",
                                                                            Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)-1].Cells[0].Value),
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
            this.orc_ServicoTableAdapter.FillBy1(this.sCOOPDataSet.Orc_Servico, CodigoOrcamento);
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
                    new Orc_ServicoTableAdapter().ApagarOrcamentoTodo(CodigoOrcamento);
                    new OrcamentoTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem1.TextBox.Text) - 1].Cells[0].Value), CodigoOrcamento);
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
                                                                                   ,ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString()
                                                                                   ,Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value)
                                                                                   ,ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString()
                                                                                   ,Convert.ToInt32(ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[9].Value)
                                                                                   ,Convert.ToDateTime( ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[10].Value)
                                                                                   ,Convert.ToDecimal( ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[6].Value)
                                                                                   ,Convert.ToDecimal( ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[7].Value)
                                                                                   ,Convert.ToDateTime( ServicodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[11].Value)
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
                    TxtBoxValorUnitario.Text = string.Format("{0:C2}", new ComposicaoTableAdapter().ObterTotalServico(mskTxtBoxCodServico.Text.Replace(",", ".")).ToString());
                }
                TxtBoxServicoQuantidade.Focus();
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
            try {// this.tipoOrcamentoTableAdapter.FillBy1(this.sCOOPDataSet.TipoOrcamento, (int)DotacaoOrcamentariaComboBox.SelectedValue); 
            }
            catch (Exception ex) { }
        }
    }
}
