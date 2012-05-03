using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
using SCOOP.DAO;

namespace SCOOP
{
    public partial class CadastroEmpreteira : Form
    {
        public CadastroEmpreteira()
        {
            InitializeComponent();
        }

        private void CadastroEmpreteira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Empreteira' table. You can move, or remove it, as needed.
            this.empreteiraTableAdapter1.Fill(this.sCOOPDataSet.Empreteira);
            ObterCodigoEmpreteira();
            comboBoxTipoPessoa.Items.Clear();
            comboBoxTipoPessoa.Items.Add("Pessoa Fisica");
            comboBoxTipoPessoa.Items.Add("Pessoa Juridica");
        }

        public void ObterCodigoEmpreteira()
        {
            string Codigo = null;
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("Select isnull(MAX(isnull(Codigo,0)),0)+1 from dbo.empreteira");
            cmd.Connection = conn;
            try
            {
                conn.Open();

                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    Codigo = Dr.GetInt32(0).ToString();
                }
                TxtBoxCodigo.Text = Codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a Obter Numero Sequencia de Empreteira! \n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBoxTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoPessoa.Text)
            {
                case "":
                    MskTxtBoxCPF.Text = "";
                    TxtBoxNome.Text = "";
                    MskTxtBoxRG.Text = "";
                    MskTxtBoxCNPJ.Text = "";
                    TxtBoxInscricaoEstadual.Text = "";
                    TxtBoxRazaoSocial.Text = "";
                    GrupoPessoaJuridica.Visible = false;
                    GrupoPessoaFisica.Visible = false;
                    break;
                case "Pessoa Fisica":
                    MskTxtBoxCNPJ.Text = "";
                    TxtBoxInscricaoEstadual.Text = "";
                    TxtBoxRazaoSocial.Text = "";
                    GrupoPessoaFisica.Visible = true;
                    GrupoPessoaJuridica.Visible = false;
                    break;
                case "Pessoa Juridica":
                    MskTxtBoxCPF.Text = "";
                    TxtBoxNome.Text = "";
                    MskTxtBoxRG.Text = "";
                    GrupoPessoaFisica.Visible = false;
                    GrupoPessoaJuridica.Visible = true;
                    break;
            }
        }

        private void GrupoEndereco_Enter(object sender, EventArgs e)
        {

        }

        private void BttCadastro_Click(object sender, EventArgs e)
        {
            if (comboBoxTipoPessoa.Text == "Pessoa Fisica")
            {
                if (MskTxtBoxCPF.Text.Replace(".", "").Replace("-", "").Trim() != "" && MskTxtBoxRG.Text != "" && TxtBoxNome.Text != "")
                {
                    if (TxtBoxLogradouro.Text != "" && TxtBoxNumero.Text != "" && TxtBoxBairro.Text != "" && TxtBoxCidade.Text != "" && ComboBoxEstado.Text != "" && mskTxtBoxCEP.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Trim() != "" && mskTxtBoxTelefone.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Trim() != "")
                    {
                        if (TxtBoxResponsavel.Text != "" && mskTxtBoxCPFResponsavel.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Trim() != "" && TxtBoxResponsavelTecnico.Text != "" && TxtBoxCREA.Text.Replace("/", "").Trim() != "")
                        {
                            if (mskTxtBoxDataRecFederal.Text.Replace("/", "").Trim() != "" && mskTxtBoxCND.Text.Replace("/", "").Trim() != "" && mskTxtBoxDataFGTS.Text.Replace("/", "").Trim() != "")
                            {
                                try
                                {
                                    new EmpreteiraTableAdapter().Insert(LimprarMaskedTexto(MskTxtBoxCPF.Text),
                                                                        LimprarMaskedTexto(MskTxtBoxRG.Text),
                                                                        TxtBoxNome.Text,
                                                                        LimprarMaskedTexto(MskTxtBoxCNPJ.Text),
                                                                        TxtBoxInscricaoEstadual.Text,
                                                                        TxtBoxLogradouro.Text,
                                                                        TxtBoxNumero.Text,
                                                                        TxtBoxCidade.Text,
                                                                        ComboBoxEstado.Text,
                                                                        LimprarMaskedTexto(mskTxtBoxCEP.Text),
                                                                        LimprarMaskedTexto(mskTxtBoxTelefone.Text),
                                                                        LimprarMaskedTexto(mskTxtBoxCelular.Text),
                                                                        LimprarMaskedTexto(mskTxtBoxFAX.Text),
                                                                        TxtBoxResponsavel.Text,
                                                                        LimprarMaskedTexto(mskTxtBoxCPFResponsavel.Text),
                                                                        TxtBoxResponsavelTecnico.Text,
                                                                        TxtBoxCREA.Text,
                                                                        TxtBoxObservacao.Text,
                                                                        Convert.ToDateTime(mskTxtBoxDataRecFederal.Text),
                                                                        Convert.ToDateTime(mskTxtBoxCND.Text),
                                                                        Convert.ToDateTime(mskTxtBoxDataFGTS.Text),
                                                                        TxtBoxBairro.Text,
                                                                        DateTime.Now,
                                                                        Settings.Default.Usuario.ToString(),
                                                                        DateTime.Now);
                                    new EmpresaTableAdapter().Insert(TxtBoxNome.Text == "" ? TxtBoxRazaoSocial.Text : TxtBoxNome.Text, Convert.ToInt32(new EmpreteiraTableAdapter().ObterEmpreteiroPorCPF(MskTxtBoxCPF.Text).Value));
                                    MessageBox.Show("Cadastro Realizado com Sucesso! ");
                                    this.empreteiraTableAdapter1.Fill(this.sCOOPDataSet.Empreteira);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro ao Cadastrar Empreteira. " + ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Falta Preencher Data Receita Federal\n Data CND \n Data FGTS");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta Preencher Responsável ou CPF Responsável \n Responsável Tecnico e CREA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta Preencher Logradouro ou Número ou Bairro ou Cidade ou Estado ou CEP ou Telefone");
                    }
                }
                else
                {
                    MessageBox.Show("Falta Preencher CPF ou RG ou Nome");
                }
            }
            else if (comboBoxTipoPessoa.Text == "Pessoa Juridica")
            {
                if (MskTxtBoxCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim() != "" && TxtBoxInscricaoEstadual.Text != "" && TxtBoxRazaoSocial.Text != "")
                {
                    if (TxtBoxLogradouro.Text != "" && TxtBoxNumero.Text != "" && TxtBoxBairro.Text != "" && TxtBoxCidade.Text != "" && ComboBoxEstado.Text != "" && mskTxtBoxCEP.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Trim() != "" && mskTxtBoxTelefone.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Trim() != "")
                    {
                        if (TxtBoxResponsavel.Text != "" && mskTxtBoxCPFResponsavel.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Trim() != "" && TxtBoxResponsavelTecnico.Text != "" && TxtBoxCREA.Text.Replace("/", "").Trim() != "")
                        {
                            if (mskTxtBoxDataRecFederal.Text.Replace("/", "").Trim() != "" && mskTxtBoxCND.Text.Replace("/", "").Trim() != "" && mskTxtBoxDataFGTS.Text.Replace("/", "").Trim() != "")
                            {
                                try
                                {
                                    new EmpreteiraTableAdapter().Insert(LimprarMaskedTexto(MskTxtBoxCPF.Text), LimprarMaskedTexto(MskTxtBoxRG.Text), TxtBoxRazaoSocial.Text, LimprarMaskedTexto(MskTxtBoxCNPJ.Text), TxtBoxInscricaoEstadual.Text, TxtBoxLogradouro.Text, TxtBoxNumero.Text, TxtBoxCidade.Text, ComboBoxEstado.Text, LimprarMaskedTexto(mskTxtBoxCEP.Text), LimprarMaskedTexto(mskTxtBoxTelefone.Text), LimprarMaskedTexto(mskTxtBoxCelular.Text), LimprarMaskedTexto(mskTxtBoxFAX.Text), TxtBoxResponsavel.Text, LimprarMaskedTexto(mskTxtBoxCPFResponsavel.Text), TxtBoxResponsavelTecnico.Text, TxtBoxCREA.Text, TxtBoxObservacao.Text, Convert.ToDateTime(mskTxtBoxDataRecFederal.Text), Convert.ToDateTime(mskTxtBoxCND.Text), Convert.ToDateTime(mskTxtBoxDataFGTS.Text), TxtBoxBairro.Text,DateTime.Now,Settings.Default.Usuario.ToString(),DateTime.Now);
                                    new EmpresaTableAdapter().Insert(TxtBoxNome.Text == "" ? TxtBoxRazaoSocial.Text : TxtBoxNome.Text, Convert.ToInt32(new EmpreteiraTableAdapter().ObterEmpreteiroPorCNPJ(MskTxtBoxCNPJ.Text).Value));                                    
                                    MessageBox.Show("Cadastro Realizado com Sucesso! ");
                                    this.empreteiraTableAdapter1.Fill(this.sCOOPDataSet.Empreteira);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro ao Cadastrar Empreteira. " + ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Falta Preencher Data Receita Federal\n Data CND \n Data FGTS");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Falta Preencher Responsável ou CPF Responsável \n Responsável Tecnico e CREA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falta Preencher Logradouro ou Número ou Bairro ou Cidade ou Estado ou CEP ou Telefone");
                    }
                }
                else
                {
                    MessageBox.Show("Falta Preencher CNPJ ou Inscrição Estadual ou Razão Social");
                }
            }
        }

        public string LimprarMaskedTexto(string texto)
        {
            if (texto.Replace(".", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("/", "").Trim() == "")
                return "";
            else
                return texto;

        }

        private void MskTxtBoxCPF_TextChanged(object sender, EventArgs e)
        {
            if (MskTxtBoxCPF.Text.Length == 14)
            {
                if (!Validacoes.ValidaCPF(MskTxtBoxCPF.Text))
                {
                    MessageBox.Show("CPF Inválido!");
                    MskTxtBoxCPF.Focus();
                }
            }
        }

        private void MskTxtBoxCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (MskTxtBoxCNPJ.Text.Length == 18)
            {
                if (!Validacoes.ValidaCNPJ(MskTxtBoxCNPJ.Text))
                {
                    MessageBox.Show("CNPJ Inválido!");
                    MskTxtBoxCNPJ.Focus();
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

        }

        public void PreencherEmpreteira(string Codigo)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos(GrupoEndereco.Controls);
            LimpaCampos(groupBox2.Controls);
            LimpaCampos(GrupoPessoaFisica.Controls);
            LimpaCampos(GrupoPessoaJuridica.Controls);
            CadastroEmpreteira_Load(null, null);
            comboBoxTipoPessoa.Text = "";
            mskTxtBoxDataFGTS.Text = "";
            mskTxtBoxDataRecFederal.Text = "";
            mskTxtBoxCND.Text = "";
            BttCadastro.Visible = true;
            BttAtulizar.Visible = false;
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.empreteiraTableAdapter1.FillBy(this.sCOOPDataSet.Empreteira, textBox2.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new EmpreteiraTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[0].Value));
                    this.empreteiraTableAdapter1.Fill(this.sCOOPDataSet.Empreteira);
                    toolStripTextBox1.TextBox.Text = "0";
                    MessageBox.Show("Empreteira Excluida com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir Empreteiro.\n" + ex.Message, "Message de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chkBoxListagem.Checked)
            {
                Imprimir_Empreteira();
            }
            else if (ChkBoxFicha.Checked)
            {

            }

        }

        #region Impression
        private string RelatorioTitulo;

        float LinhasPorPagina = 0;

        float PosicaoDaLinha = 0;

        int LinhaAtual = 0;

        int PaginaActual = 0;

        Pen CanetaDaImpressora = new Pen(Color.Black, 1);

        Font FonteNegrito = new Font("Arial", 9, FontStyle.Bold);

        Font FonteTitulo = new Font("Arial", 15, FontStyle.Bold);

        Font FonteRodape = new Font("Arial", 7);

        Font FonteNormal = new Font("Arial", 9);

        Font EspacoEntreLinhas = new Font("Arial", 15);



        private void Imprimir_Empreteira()
        {



            try
            {



                RelatorioTitulo = "Listagem Empreteira";

                System.Drawing.Printing.PrintDocument PD = new System.Drawing.Printing.PrintDocument();

                PD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Relatorio);

                PD.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.Inicio_Impressao);





                PrintPreviewDialog ColaboradoresPrintPreview = new PrintPreviewDialog();



                {



                    ColaboradoresPrintPreview.Document = PD;

                    ColaboradoresPrintPreview.WindowState = FormWindowState.Maximized;

                    ColaboradoresPrintPreview.PrintPreviewControl.Zoom = 1;

                    ColaboradoresPrintPreview.Text = RelatorioTitulo;



                    //Para imprimir sem mostrar o dialog é excluir o Showdialog, PrintPreviewControl e WindowState 



                    //e colocar : 



                    //PD.Print() 



                    ColaboradoresPrintPreview.ShowDialog();

                }





            }



            catch (Exception ex)
            {



                MessageBox.Show(ex.Message.ToString());

            }





        }





        private void Inicio_Impressao(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



            foreach (DataGridViewRow Linhas in this.dataGridView1.Rows)
            {



                //Seta a tag da coluna 0 (chave primária) para 0 



                Linhas.Cells[0].Tag = 0;

            }





            PaginaActual = 1;



        }



        private void Relatorio(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            //Agora é desenhar a gosto... 



            float MargemSuperior = e.MarginBounds.Top;

            float MargemDireita = e.MarginBounds.Right;

            float MargemInferior = e.MarginBounds.Bottom;

            float MargemEsquerda = e.MarginBounds.Left;



            LinhaAtual = 0;

            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, MargemInferior + 15, MargemDireita + 20, MargemInferior + 15);

            e.Graphics.DrawString("Impresso em " + System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, MargemDireita - 135, MargemInferior + 22, new StringFormat());

            e.Graphics.DrawString("Página : " + PaginaActual, FonteRodape, Brushes.Black, MargemEsquerda + 270, MargemInferior + 22, new StringFormat());



            e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, 60, MargemDireita + 20, 60);



            e.Graphics.DrawString(RelatorioTitulo.ToString(), FonteTitulo, Brushes.Blue, MargemEsquerda, 80, new System.Drawing.StringFormat());



            //e.Graphics.DrawString(string.Format("{0d-MM-yyyy}", DateTime.Now.ToString()), FonteNegrito, Brushes.Brown, (int) (MargemEsquerda + 430), 100, new StringFormat()); 



            SolidBrush myBrush = new SolidBrush(Color.LightGray);

            Rectangle AreaPintar2 = new Rectangle((int)(MargemEsquerda - 40), 135, (int)(MargemDireita - 40), 30);

            Region Area2 = new Region(AreaPintar2);

            e.Graphics.FillRegion(myBrush, Area2);

            e.Graphics.DrawRectangle(CanetaDaImpressora, MargemEsquerda - 40, 135, MargemDireita - 40, 30);



            e.Graphics.DrawString("Cód", FonteNegrito, Brushes.Black, MargemEsquerda - 35, 142, new StringFormat());

            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda , 142, new StringFormat());

            e.Graphics.DrawString("CPF ou CNPJ", FonteNegrito, Brushes.Black, MargemEsquerda + 250, 142, new StringFormat());

            e.Graphics.DrawString("Telefone", FonteNegrito, Brushes.Black, MargemEsquerda + 370, 142, new StringFormat());

            e.Graphics.DrawString("Celular", FonteNegrito, Brushes.Black, MargemEsquerda + 470, 142, new StringFormat());

            e.Graphics.DrawString("Fax", FonteNegrito, Brushes.Black, MargemEsquerda + 570, 142, new StringFormat());


            //Define quantas linhas terá cada folha 



            LinhasPorPagina = e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 30;



            //O principal : 



            foreach (DataGridViewRow linhas in this.dataGridView1.Rows)
            {



                while ((LinhaAtual < LinhasPorPagina && linhas.Cells[0].Tag.Equals(0)) && (LinhaAtual <= (this.dataGridView1.RowCount)))
                {



                    //Variável posição da linha é um contador, como a variável LinhaAtual 



                    PosicaoDaLinha = MargemSuperior + (LinhaAtual * EspacoEntreLinhas.GetHeight(e.Graphics));



                    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, PosicaoDaLinha + 65, MargemDireita + 20, PosicaoDaLinha + 65);

                    e.Graphics.DrawString(linhas.Cells[0].Value.ToString(), FonteNormal, Brushes.Black, (int)(MargemEsquerda - 33), (int)(PosicaoDaLinha + 70), new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[1].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[2].Value.ToString().Replace(".", "").Replace("-", "").Trim() == "" ? linhas.Cells[3].Value.ToString() : linhas.Cells[2].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 250, PosicaoDaLinha + 70, new StringFormat());

                    //e.Graphics.DrawString(linhas.Cells[3].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 250, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[12].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 370, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[13].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 470, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[14].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 570, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, PosicaoDaLinha + 65, MargemDireita + 20, PosicaoDaLinha + 65);





                    LinhaAtual += 1;



                    //Depois de desenhar os dados setar a tag para 1, para quando o next retornar não repetir, pois só irá desenhar se " linhas.Cells(0).Tag = 0" 



                    linhas.Cells[0].Tag = 1;

                }



            }



            PaginaActual += 1;



            if ((LinhaAtual > LinhasPorPagina))
            {



                e.HasMorePages = true;

            }



            else
            {



                e.HasMorePages = false;

            }
        }
        #endregion

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabPage1;
            SCOOPDataSet.EmpreteiraDataTable Dt = new EmpreteiraTableAdapter().GetDataBy2(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[0].Value.ToString()));

            if (Dt.Count > 0)
            {
                foreach (SCOOPDataSet.EmpreteiraRow linha in Dt)
                {
                    TxtBoxCodigo.Text = linha.Codigo.ToString();
                    if(String.Empty != linha.CPF.Replace(".","").Replace("-","").Trim()){
                        
                        MskTxtBoxCPF.Text = linha.CPF.ToString();
                        MskTxtBoxRG.Text = linha.RG;
                        TxtBoxNome.Text = linha.Nome;
                        comboBoxTipoPessoa.Text = "Pessoa Fisica";
                    }
                    else
                    { 
                        MskTxtBoxCNPJ.Text = linha.CNPJ;
                        TxtBoxInscricaoEstadual.Text = linha.InscricaoEstadual;
                        TxtBoxRazaoSocial.Text = linha.Nome;
                        comboBoxTipoPessoa.Text = "Pessoa Juridica";
                    }
                    comboBoxTipoPessoa_SelectedIndexChanged(null, null);
                    TxtBoxLogradouro.Text = linha.Logradouro;
                    TxtBoxNumero.Text = linha.Numero;
                    TxtBoxBairro.Text = linha.Bairro;
                    TxtBoxCidade.Text = linha.Cidade;
                    ComboBoxEstado.Text = linha.Estado;
                    mskTxtBoxCEP.Text = linha.CEP;
                    mskTxtBoxTelefone.Text = linha.Telefone;
                    mskTxtBoxCelular.Text = linha.Celular;
                    mskTxtBoxFAX.Text = linha.FAX;
                    TxtBoxResponsavel.Text = linha.Responsavel;
                    mskTxtBoxCPFResponsavel.Text = linha.CPFResponsavel;
                    TxtBoxResponsavelTecnico.Text = linha.ResponsavelTecnico;
                    TxtBoxCREA.Text = linha.CREA;
                    TxtBoxObservacao.Text = linha.Observacao;
                    mskTxtBoxDataRecFederal.Text = linha.DataReceitaFederal.ToShortDateString();
                    mskTxtBoxCND.Text = linha.DataCND.ToShortDateString();
                    mskTxtBoxDataFGTS.Text = linha.DataFGTS.ToShortDateString();
                    BttAtulizar.Visible = true;
                    BttCadastro.Visible = false;

                }
            }
        }

        private void BttAtulizar_Click(object sender, EventArgs e)
        {
            try
            {
                new EmpreteiraTableAdapter().Update(MskTxtBoxCPF.Text.Replace(".","").Replace("-","")==""?"":MskTxtBoxCPF.Text,
                                                                                  MskTxtBoxRG.Text,
                                                                                  TxtBoxNome.Text.Trim()==""?TxtBoxRazaoSocial.Text:TxtBoxNome.Text,
                                                                                  MskTxtBoxCNPJ.Text,
                                                                                  TxtBoxInscricaoEstadual.Text,
                                                                                  TxtBoxLogradouro.Text,
                                                                                  TxtBoxNumero.Text,
                                                                                  TxtBoxCidade.Text,
                                                                                  ComboBoxEstado.Text,
                                                                                  mskTxtBoxCEP.Text,
                                                                                  mskTxtBoxTelefone.Text,
                                                                                  mskTxtBoxCelular.Text,
                                                                                  mskTxtBoxFAX.Text,
                                                                                  TxtBoxResponsavel.Text,
                                                                                  mskTxtBoxCPFResponsavel.Text,
                                                                                  TxtBoxResponsavelTecnico.Text,
                                                                                  TxtBoxCREA.Text,
                                                                                  TxtBoxObservacao.Text,
                                                                                  Convert.ToDateTime(mskTxtBoxDataRecFederal.Text),
                                                                                  Convert.ToDateTime(mskTxtBoxCND.Text),
                                                                                  Convert.ToDateTime(mskTxtBoxDataFGTS.Text),
                                                                                  TxtBoxBairro.Text,
                                                                                  DateTime.Now,
                                                                                  Settings.Default.Usuario,
                                                                                  DateTime.Now,
                                                                                  Convert.ToInt32(TxtBoxCodigo.Text),
                                                                                  Convert.ToInt32(TxtBoxCodigo.Text));

                new EmpresaTableAdapter().Update(TxtBoxNome.Text==""?TxtBoxRazaoSocial.Text:TxtBoxNome.Text, Convert.ToInt32(TxtBoxCodigo.Text), (int)new EmpresaTableAdapter().ObterCodigoEmpresa(Convert.ToInt32(TxtBoxCodigo.Text)).Value,Convert.ToInt32(TxtBoxCodigo.Text));
                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Empreteira.\n"+ex.Message);
            }
        }

        private void CadastroEmpreteira_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void TxtBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!TxtBoxNumero.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.TextBox.Text != "0")
            {
                try
                {
                    if (new EmpreteiraTableAdapter().VerificarCadastroEmpreteiroPodeApagar(DateTime.Now).HasValue == true || new Orcamento_ContratadoTableAdapter().VerficarEmpreteiraJaFoiCadastrada((int)dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[0].Value).HasValue == false)
                    {
                        toolStripButton2.Visible = true;
                    }
                    else
                    {
                        toolStripButton2.Visible = false;
                    }
                }
                catch (Exception ex)
                { }
            }
        }
    }
}
