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
using Orca08.GUI;

namespace SCOOP.GUI
{
    public partial class CadastroMedicao : Form
    {
        private string CodigoMedicao;
       // private string CodigoOrcamento = "0";
       // private string NumeroFolha;
        public string OrcamentoImportado;
        public int tabpage = 1;
        public CadastroMedicao(int tabpage)
        {
            InitializeComponent();
            this.tabpage = tabpage;
        }

        private void CadastroMedicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Fiscalizacao' table. You can move, or remove it, as needed.
            this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
            ComboBoxEngFiscal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBoxEngFiscal.AutoCompleteSource = AutoCompleteSource.ListItems;
            // TODO: This line of code loads data into the 'sCOOPDataSet.Medicao' table. You can move, or remove it, as needed.
            this.medicaoTableAdapter2.Fill(this.sCOOPDataSet.Medicao);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Med_Servico' table. You can move, or remove it, as needed.
            //this.med_ServicoTableAdapter2.FillBy(this.sCOOPDataSet.Med_Servico,);
            if (this.tabpage == 1)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (this.tabpage == 2)
            {
                tabControl1.SelectedTab = tabPage2;
            }

            // TODO: This line of code loads data into the 'orcamentoDataSet1.Bairro' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'orcamentoDataSet1.Med_Servico' table. You can move, or remove it, as needed.

            ObterSequencial();

            mskTxtBoxFolhaNumero.Text = CodigoMedicao + DateTime.Now.Year.ToString().Substring(2);
        }



        public int ObterCodigoMedicao(string Medicao)
        {
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("select codigo from Medicao where NumeroFolha = '" + Medicao + "'");
            cmd.Connection = conn;
            int valor = 0;

            try
            {
                conn.Open();

                Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        valor = Dr.GetInt32(0);
                    }
                    return valor;
                }
                else
                    return valor;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar Serviço " + ex.Message);
                return valor;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ChlBoxPlanilha.Checked)
            {
                try
                {

                    new Medicao_TempTableAdapter().Delete(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());

                    new Medicao_TempTableAdapter().InserirMedicaoTemp(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());

                    Form frm = new Relatorio("BoletimMedicao", dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
                    frm.ShowDialog();


                }
                catch (Exception )
                {
                    MessageBox.Show("Erro ao gerar Boletim de Medição.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ChkBoxFolha.Checked)
            {
                Form frm = new Relatorio("Medicao", dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
                frm.ShowDialog();
            }
            else
            {
                if (tabControl1.SelectedTab == tabPage1)
                {
                    new Medicao_TempTableAdapter().Delete(MskTxtBoxCodigoOrcamento.Text);

                    new Medicao_TempTableAdapter().InserirMedicaoTemp(mskTxtBoxFolhaNumero.Text, MskTxtBoxCodigoOrcamento.Text);

                    Form frm = new Relatorio("BoletimMedicao", mskTxtBoxFolhaNumero.Text);
                    frm.ShowDialog();
                }
            }

            //Imprimir_Medicao();

        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            BttNovo_Click(null, null);
        }



        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir Serviço de Medição.\n" + ex.Message);
                }
            }
        }


        public object ValorTotalMedicao(string CodigoMedicao)
        {
            decimal valorTotal = 0;
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("select sum(total) from med_servico where Codigo_Medicao = @CodigoMedicao");
            cmd.Parameters.Add("@CodigoMedicao", SqlDbType.VarChar).Value = ObterCodigoMedicao(mskTxtBoxFolhaNumero.Text);
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
            catch (Exception )
            {
                //MessageBox.Show("Erro ao Obter Valor Total Medição! " + ex.Message);
                return valorTotal;
            }
            finally
            {
                conn.Close();
            }
        }

        private void BttVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos(groupBox1.Controls);
            LimpaCampos(GrupoBoxServicos.Controls);
            CadastroMedicao_Load(null, null);
            button3.Enabled = true;
            BttCadastrarMedicao.Enabled = true;
            BttCadastrarMedicao.Visible = true;
            bindingNavigator2.Enabled = false;
            GrupoBoxServicos.Enabled = false;
            mskTxtBoxFolhaNumero.Text = ObterSequencial();
            this.med_ServicoTableAdapter2.FillBy(this.sCOOPDataSet.Med_Servico, mskTxtBoxFolhaNumero.Text);

        }

        private void LimpaCampos(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = string.Empty;
                }
                // ... demais controles que queira limpar
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Text = string.Empty;
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = string.Empty;
                }
                //LimpaCampos(ctrl.Controls);
            }
        }


        public void ImportaOrcamento(string CodigoOrcamento)
        {

            BttNovo_Click(null, null);
            try
            {
                SCOOPDataSet.OrcamentoDataTable Dt = new OrcamentoTableAdapter().GetDataBy2(CodigoOrcamento);

                foreach (SCOOPDataSet.OrcamentoRow linha in Dt)
                {
                    MskTxtBoxCodigoOrcamento.Text = CodigoOrcamento;
                    mskTxtBoxContrato.Text = new ContratoTableAdapter().ObterCodigoContrato(CodigoOrcamento);
                    ComboBoxEngFiscal.Text = new FiscalizacaoTableAdapter().ObterDescricaoFiscalizacao(linha.Fiscal);

                }
                MessageBox.Show("Preencha os Campos Vázios.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema na importação.\n" + ex.Message);
            }

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new Med_ServicoTableAdapter().Delete(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
                    new MedicaoTableAdapter().Delete(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
                    this.medicaoTableAdapter2.Fill(this.sCOOPDataSet.Medicao);
                    MessageBox.Show("Medição Excluinda com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro à Excluinda Medição." + ex.Message);
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new PesquiarOrcamentoContratado(this, null, null);
            frm.ShowDialog();
        }

        private void ServicodataGridView1_EditModeChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Alterando Datagridview.");
            }
            catch (Exception ) { }
        }

        private void BttCadastrarMedicao_Click(object sender, EventArgs e)
        {
            try
            {
                string numero;
                try
                {
                    numero = new SCOOP.DAO.SCOOPDataSetTableAdapters.Medicao_TempTableAdapter().ObterSequencialMedicao(mskTxtBoxFolhaNumero.Text, MskTxtBoxCodigoOrcamento.Text).Value.ToString();
                }
                catch (Exception ex)
                {
                    numero = "1";
                }
                new MedicaoTableAdapter().Insert(mskTxtBoxFolhaNumero.Text,
                                                                           MskTxtBoxCodigoOrcamento.Text,
                                                                           Convert.ToInt32(new OrcamentoTableAdapter().ObterSequencialOrcamento(MskTxtBoxCodigoOrcamento.Text)),
                                                                           DateTime.Now,
                                                                           DateTime.Now,
                                                                           Settings.Default.Usuario,
                                                                           checkBox1.Checked==true?"S":new SCOOP.DAO.SCOOPDataSetTableAdapters.Medicao_TempTableAdapter().ObterSequencialMedicao(mskTxtBoxFolhaNumero.Text,MskTxtBoxCodigoOrcamento.Text).Value.ToString(),
                                                                           numero);
                try
                {
                    SCOOPDataSet.Orc_Cont_ServicoDataTable Dt = new Orc_Cont_ServicoTableAdapter().GetDataBy(MskTxtBoxCodigoOrcamento.Text);

                    foreach (SCOOPDataSet.Orc_Cont_ServicoRow linha in Dt)
                    {
                        new Med_ServicoTableAdapter().Insert(linha.Codigo_Servico,
                                                            (int)new ServicoTableAdapter().ObterSequencialServico(linha.Codigo_Servico).Value,
                                                            mskTxtBoxFolhaNumero.Text,
                                                            (int)new MedicaoTableAdapter().ObterSequencialMedicao(mskTxtBoxFolhaNumero.Text),
                                                            DateTime.Now,
                                                            Convert.ToDecimal(new Orcamento_ContratadoTableAdapter().ObterRestanteOrcamentoContratado(linha.Codigo_Orcamento, linha.Codigo_Servico, mskTxtBoxFolhaNumero.Text)),
                                                            linha.Valor,
                                                            DateTime.Now,
                                                            Settings.Default.Usuario);
                    }
                    this.med_ServicoTableAdapter2.FillBy(this.sCOOPDataSet.Med_Servico, mskTxtBoxFolhaNumero.Text);
                    PreencherGridView();
                    button3.Enabled = false;
                    BttCadastrarMedicao.Enabled = false;
                    bindingNavigator2.Enabled = true;
                    GrupoBoxServicos.Enabled = true;
                    BttRecibo.Enabled = true;
                    BttSolicitacao.Enabled = true;
                }
                catch (Exception ex)
                {
                    BttRecibo.Enabled = false;
                    BttSolicitacao.Enabled = false;
                }
                MessageBox.Show("Medição inserida com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Medição.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PreencherGridView()
        {
            SCOOPDataSet.ServicoDataTable Dt = null;
            for (int i = 0; i < ServicodataGridView1.RowCount; i++)
            {
                Dt = new ServicoTableAdapter().GetDataBy1(ServicodataGridView1.Rows[i].Cells[2].Value.ToString());

                foreach (SCOOPDataSet.ServicoRow linha in Dt)
                {
                    ServicodataGridView1.Rows[i].Cells[3].Value = linha.Descricao;
                }
                ServicodataGridView1.Rows[i].Cells[9].Value = String.Format("{0:C2}", Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[7].Value) * Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[8].Value));
            }
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < ServicodataGridView1.RowCount; i++)
                {
                    new Med_ServicoTableAdapter().Update(ServicodataGridView1.Rows[i].Cells[2].Value.ToString(),
                                                                                    (int)new ServicoTableAdapter().ObterSequencialServico(ServicodataGridView1.Rows[i].Cells[2].Value.ToString()).Value,
                                                                                    ServicodataGridView1.Rows[i].Cells[1].Value.ToString(),
                                                                                    (int)new MedicaoTableAdapter().ObterSequencialMedicao(ServicodataGridView1.Rows[i].Cells[1].Value.ToString()).Value,
                                                                                    DateTime.Now,
                                                                                    Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[7].Value.ToString()),
                                                                                    Convert.ToDecimal(ServicodataGridView1.Rows[i].Cells[8].Value.ToString()),
                                                                                    DateTime.Now,
                                                                                    Settings.Default.Usuario,
                                                                                    (int)ServicodataGridView1.Rows[i].Cells[0].Value,
                                                                                    mskTxtBoxFolhaNumero.Text,
                                                                                    (int)ServicodataGridView1.Rows[i].Cells[0].Value);

                }
                this.med_ServicoTableAdapter2.FillBy(this.sCOOPDataSet.Med_Servico, mskTxtBoxFolhaNumero.Text);
                PreencherGridView();
                MessageBox.Show("Serviços da Medição Atualizados com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Serviços da Medição.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BttRecibo_Click(object sender, EventArgs e)
        {
            Recibo(mskTxtBoxFolhaNumero.Text, MskTxtBoxCodigoOrcamento.Text);
        }

        private void Recibo(string Codigo_medicao,string Codigo_Orcamento)
        {
            string CPF = null;
            string Logradouro = null;
            string Cidade = null;
            string Estado = null;
            try
            {
                if (!new ReciboTableAdapter().ObterCodigoMedicao(Codigo_medicao).HasValue)
                {
                    SCOOPDataSet.ContratoDataTable Dt = new SCOOP.DAO.SCOOPDataSetTableAdapters.ContratoTableAdapter().GetDataBy1(Codigo_Orcamento);

                    foreach (SCOOPDataSet.ContratoRow linha in Dt)
                    {
                        CPF = linha.CGC;
                        Logradouro = linha.Logradouro;
                        Cidade = linha.Cidade;
                        Estado = linha.Estado;
                    }

                    new ReciboTableAdapter().Insert(mskTxtBoxFolhaNumero.Text,
                                                    mskTxtBoxContrato.Text,
                                                    CPF,
                                                    Logradouro,
                                                    Cidade,
                                                    Estado,
                                                    Convert.ToDecimal(new Med_ServicoTableAdapter().ObterTotalMedicaoServico(Codigo_medicao)),
                                                    Convert.ToDecimal(new Med_ServicoTableAdapter().ObterTotalMedicaoServico(Codigo_medicao)),
                                                    new MedicaoTableAdapter().ObterSequencialMedicao(Codigo_medicao));


                    Form frm = new Relatorio("Recibo", Codigo_medicao);
                    frm.ShowDialog();
                }
                else
                {
                    SCOOPDataSet.ContratoDataTable Dt = new SCOOP.DAO.SCOOPDataSetTableAdapters.ContratoTableAdapter().GetDataBy1(Codigo_medicao);

                    foreach (SCOOPDataSet.ContratoRow linha in Dt)
                    {
                        CPF = linha.CGC;
                        Logradouro = linha.Logradouro;
                        Cidade = linha.Cidade;
                        Estado = linha.Estado;
                    }

                    new ReciboTableAdapter().Update(mskTxtBoxFolhaNumero.Text,
                                                    mskTxtBoxContrato.Text,
                                                    CPF,
                                                    Logradouro,
                                                    Cidade,
                                                    Estado,
                                                    Convert.ToDecimal(new Med_ServicoTableAdapter().ObterTotalMedicaoServico(Codigo_medicao)),
                                                    Convert.ToDecimal(new Med_ServicoTableAdapter().ObterTotalMedicaoServico(Codigo_medicao)),
                                                    Convert.ToInt32(new MedicaoTableAdapter().ObterSequencialMedicao(Codigo_medicao).Value),
                                                    mskTxtBoxFolhaNumero.Text,
                                                    Convert.ToInt32(new ReciboTableAdapter().ObterSequencialRecibo(Codigo_medicao).Value.ToString()));

                    Form frm = new Relatorio("Recibo", Codigo_medicao);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void BttSolicitacao_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorio("Empenho", mskTxtBoxFolhaNumero.Text);
            frm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SCOOPDataSet.MedicaoDataTable Dt = new MedicaoTableAdapter().GetDataBy1(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());

                foreach (SCOOPDataSet.MedicaoRow linha in Dt)
                {
                    mskTxtBoxFolhaNumero.Text = linha.Codigo_Medicao;
                    MskTxtBoxCodigoOrcamento.Text = linha.Codigo_Orcamento;
                    mskTxtBoxContrato.Text = new ContratoTableAdapter().ObterCodigoContrato(linha.Codigo_Orcamento);
                    //ComboBoxEngFiscal.Text = linha.
                    this.med_ServicoTableAdapter2.FillBy(this.sCOOPDataSet.Med_Servico, linha.Codigo_Medicao);
                    tabControl1.SelectedTab = tabPage1;
                }
                bindingNavigator1.Enabled = true;
                GrupoBoxServicos.Enabled = true;
                BttCadastrarMedicao.Visible = false;
                BttRecibo.Enabled = true;
                BttSolicitacao.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar Alterar a medição.");
            }
        }

        private void ServicodataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PreencherGridView();
        }

        private void ServicodataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //ConferirValorQuantidadeOrcamento(e.RowIndex-1, e.ColumnIndex);
        }

        public void ConferirValorQuantidadeOrcamento(int Linha, int Coluna)
        {
            string erro = null;
            try
            {
                if (ServicodataGridView1.Rows[Linha].Cells[7].Value != null || ServicodataGridView1.Rows[Linha].Cells[7].Value.ToString() != "")
                {
                    try
                    {
                        decimal ValorGridView = Convert.ToDecimal(ServicodataGridView1.Rows[Linha].Cells[7].Value);
                        decimal ValorQueFalta = Convert.ToDecimal(new Orcamento_ContratadoTableAdapter().ObterRestanteOrcamentoContratado(new MedicaoTableAdapter().ObterOrcamentoMedicao(ServicodataGridView1.Rows[Linha].Cells[1].Value.ToString()), ServicodataGridView1.Rows[Linha].Cells[2].Value.ToString(), ServicodataGridView1.Rows[Linha].Cells[1].Value.ToString()));
                        if (ValorGridView > ValorQueFalta)
                        {
                            MessageBox.Show("O Serviço :" + ServicodataGridView1.Rows[Linha].Cells[3].Value.ToString() + "\n Não deve Maior que " + ValorQueFalta.ToString());
                            ServicodataGridView1.Rows[Linha].Cells[7].Value = ValorQueFalta;
                        }
                    }
                    catch (Exception ex)
                    {
                        erro = "Erro ao Obter Valor.\n" + ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(erro+"\n"+ex.Message);
            }
        }

        private void ServicodataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            ConferirValorQuantidadeOrcamento(e.RowIndex, e.ColumnIndex);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorio("Empenho", dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Recibo(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorio("Contrato", dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
            frm.ShowDialog();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string Orcamento = new MedicaoTableAdapter().ObterOrcamentoMedicao(dataGridView1.Rows[i].Cells[1].Value.ToString());
                
                SCOOPDataSet.OrcamentoDataTable Dt = new OrcamentoTableAdapter().GetDataBy2(Orcamento);

                foreach (SCOOPDataSet.OrcamentoRow linha in Dt)
                {
                    dataGridView1.Rows[i].Cells[4].Value = linha.Descricao;
                    dataGridView1.Rows[i].Cells[5].Value = linha.Logradouro;
                    dataGridView1.Rows[i].Cells[6].Value = linha.Bairro;
                }
                dataGridView1.Rows[i].Cells[7].Value = new Med_ServicoTableAdapter().ObterTotalMedicaoServico(dataGridView1.Rows[i].Cells[1].Value.ToString()).ToString();
            }
        }

        private string ObterSequencial()
        {
            try
            {
                #region Sequencial
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SCOOPConnectionString);
                SqlCommand cmd = new SqlCommand("select ISNULL(MAX(SUBSTRING(Codigo_Medicao,1,4)),0)+1 from Medicao");
                //SqlDataReader Dr;
                cmd.Connection = conn;
                try
                {

                    conn.Open();

                    CodigoMedicao = cmd.ExecuteScalar().ToString();
                    //Dr = cmd.ExecuteReader();
                    /*
                    while (Dr.Read())
                    {
                        CodigoMedicao = Dr.GetInt32(0).ToString();
                    }
                    */

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                string Aux = CodigoMedicao;
                for (int i = 3; i >= Aux.Length; i--)
                {
                    CodigoMedicao = "0" + CodigoMedicao;
                }
                #endregion

                return CodigoMedicao + "/" + DateTime.Now.Year.ToString().Substring(2);
            }
            catch (Exception ex)
            {
                return CodigoMedicao; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorios1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorios1();
            frm.Show();
        }
    }
}
