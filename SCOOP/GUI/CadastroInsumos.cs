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
    public partial class CadastroInsumos : Form
    {
        public string CodigoInsumo = "0";
        public string Unidade = null;
        public CadastroInsumos(string valor, string Descricao, string Unidade, string valorInsumo)
        {
            InitializeComponent();
            if (valor != "0")
            {
                CodigoInsumo = valor;
            }
            else
            {
                TxtBoxDescricao.Text = Descricao;
                ComboBoxUnidade.Text = Unidade;
                this.Unidade = Unidade;
                MslTxtBoxPreco.Text = valorInsumo;
            }
        }

        private void CadastroInsumos_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'sCOOPDataSet.Insumo' table. You can move, or remove it, as needed.
            this.insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);

            // TODO: This line of code loads data into the 'sCOOPDataSet.Unidade' table. You can move, or remove it, as needed.
            this.unidadeTableAdapter1.Fill(this.sCOOPDataSet.Unidade);

            this.tipoInsumoTableAdapter1.Fill(this.sCOOPDataSet.TipoInsumo);
            
            try
            { // TODO: This line of code loads data into the 'sCOOPDataSet.Fornecedor' table. You can move, or remove it, as needed.
                this.fornecedorTableAdapter1.Fill(this.sCOOPDataSet.Fornecedor);
                // TODO: This line of code loads data into the 'sCOOPDataSet.GrupoInsumo' table. You can move, or remove it, as needed.
                this.grupoInsumoTableAdapter1.Fill(this.sCOOPDataSet.GrupoInsumo);
            }
            catch (Exception) { }

            ComboBoxFornecedor.Text = "";
            ComboBoxGrupo.Text = "";
            ComboBoxTipoInsumo.Text = "";
            ComboBoxUnidade.Text = "";
            if (ComboBoxUnidade.Text == "")
                ComboBoxUnidade.Text = Unidade;
            if (CodigoInsumo != "0" && CodigoInsumo != null)
            {
                toolStripButton15_Click(null, null);
            }

        }

        private void BttInserir_Click(object sender, EventArgs e)
        {
            try
            {

                if (new InsumoTableAdapter().VerificarExisteInsumo(mskTxtBoxCodigo.Text).HasValue)
                {
                    MessageBox.Show("Insumo Já Cadastrado.");
                }
                else
                {
                    EncargosSociais();
                    new InsumoTableAdapter().Insert(mskTxtBoxCodigo.Text, TxtBoxDescricao.Text, ComboBoxUnidade.Text, Convert.ToInt32(ComboBoxFornecedor.SelectedValue), (int)ComboBoxTipoInsumo.SelectedValue, (int)ComboBoxGrupo.SelectedValue, Convert.ToDecimal(MslTxtBoxPreco.Text), Convert.ToDecimal(EncargosSociaisTxtBox.Text == "" ? "0" : EncargosSociaisTxtBox.Text), Convert.ToInt32(EncargosSociaisTxtBox.Text == "" ? "0" : EncargosSociaisTxtBox.Text));
                    this.insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);
                    MessageBox.Show("Insumo Cadastrado com Sucesso. Por " + Settings.Default.Usuario);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Insumo. \n" + ex.Message);
            }

        }


        void preencherTipoInsumo(string valor)
        {
            string con = Settings.Default.SCOOPConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con);
            string sql = "select * from TipoInsumo where codigo = " + valor + "";
            System.Data.SqlClient.SqlDataAdapter dAdapter = new System.Data.SqlClient.SqlDataAdapter(sql, conn);
            System.Data.SqlClient.SqlCommandBuilder cBuilder = new System.Data.SqlClient.SqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            ComboBoxTipoInsumo.DataSource = dAdapter;
            ComboBoxTipoInsumo.Update();

        }

        void preencherUnidade(string valor)
        {

            string con = Settings.Default.SCOOPConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con);
            string sql = "select * from unidade where codigo = " + valor + "";
            System.Data.SqlClient.SqlDataAdapter dAdapter = new System.Data.SqlClient.SqlDataAdapter(sql, conn);
            System.Data.SqlClient.SqlCommandBuilder cBuilder = new System.Data.SqlClient.SqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            ComboBoxUnidade.DataSource = dAdapter;
            ComboBoxUnidade.Update();


        }

        private void EncargosSociais()
        {
            if((int)ComboBoxTipoInsumo.SelectedValue == 3)
                        MslTxtBoxPreco.Text = Convert.ToString(Convert.ToDecimal(MslTxtBoxPreco.Text) * Convert.ToDecimal(1.25));
        }

        private void bttAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.insumoTableAdapter.FillBy(this.sCOOPDataSet.Insumo, TxtBoxPesquisa.Text);
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



        private void Imprimir_Insumos()
        {



            try
            {



                RelatorioTitulo = "Listagem Insumos";

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



            e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, MargemEsquerda - 35, 142, new StringFormat());

            e.Graphics.DrawString("Descricao", FonteNegrito, Brushes.Black, MargemEsquerda + 70, 142, new StringFormat());

            e.Graphics.DrawString("Und", FonteNegrito, Brushes.Black, MargemEsquerda + 200, 142, new StringFormat());

            e.Graphics.DrawString("Preço", FonteNegrito, Brushes.Black, MargemEsquerda + 300, 142, new StringFormat());

            e.Graphics.DrawString("Improdutivo", FonteNegrito, Brushes.Black, MargemEsquerda + 400, 142, new StringFormat());


            //Define quantas linhas terá cada folha 



            LinhasPorPagina = e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 30;



            //O principal : 



            foreach (DataGridViewRow linhas in this.dataGridView1.Rows)
            {



                while ((LinhaAtual < LinhasPorPagina && linhas.Cells[0].Tag.Equals(0)) && (LinhaAtual < (this.dataGridView1.Rows.Count - 1)))
                {



                    //Variável posição da linha é um contador, como a variável LinhaAtual 



                    PosicaoDaLinha = MargemSuperior + (LinhaAtual * EspacoEntreLinhas.GetHeight(e.Graphics));



                    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, PosicaoDaLinha + 65, MargemDireita + 20, PosicaoDaLinha + 65);

                    e.Graphics.DrawString(linhas.Cells[0].Value.ToString(), FonteNormal, Brushes.Black, (int)(MargemEsquerda - 33), (int)(PosicaoDaLinha + 70), new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[2].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 70, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[1].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 200, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[3].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 300, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[4].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 400, PosicaoDaLinha + 70, new StringFormat());

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

        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir_Insumos();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }


        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            SCOOPDataSet.InsumoDataTable Dt = new InsumoTableAdapter().GetDataBy(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());

            foreach (SCOOPDataSet.InsumoRow linha in Dt)
            {
                mskTxtBoxCodigo.Text = linha.Codigo;
                TxtBoxDescricao.Text = linha.Descricao;
                ComboBoxTipoInsumo.Text = new TipoInsumoTableAdapter().ObterDescricaoGrupoInsumo(linha.TipoInsumo).ToString();
                ComboBoxFornecedor.SelectedValue = linha.Fornecedor;
                ComboBoxGrupo.Text = new GrupoInsumoTableAdapter().ObterDescricaoGrupoInsumo(linha.Grupo).ToString();
                ComboBoxUnidade.Text = linha.Unidade;
                MslTxtBoxPreco.Text = Convert.ToString(linha.Preco);

            }
            tabControl1.SelectedTab = tabPage1;
            BttAlterar.Visible = true;
            BttInserir.Visible = false;
        }

        private void MslTxtBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!MslTxtBoxPreco.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            CadastroInsumos_Load(null, null);
            mskTxtBoxCodigo.Text = "";
            TxtBoxDescricao.Text = "";
            MslTxtBoxPreco.Text = "";
            ComboBoxGrupo.Enabled = true;
            BttInserir.Visible = true;
            BttAlterar.Visible = false;
        }

        private void ComboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mskTxtBoxCodigo.Text.Length != 12)
            {
                if (ComboBoxGrupo.SelectedValue != null)
                {
                    string CodigoGrupo = null;
                    if (ComboBoxGrupo.SelectedValue.ToString().Length == 2)
                        CodigoGrupo = "0" + ComboBoxGrupo.SelectedValue.ToString();
                    else if (ComboBoxGrupo.SelectedValue.ToString().Length == 1)
                        CodigoGrupo = "00" + ComboBoxGrupo.SelectedValue.ToString();
                    else
                        CodigoGrupo = ComboBoxGrupo.SelectedValue.ToString();

                    string sequencial = "0001";
                    try
                    {
                        sequencial = new InsumoTableAdapter().ObterSequencialPorGrupo(ComboBoxGrupo.SelectedValue.ToString()).ToString();
                    }
                    catch (Exception) { }
                    //string CodigoInsumo = CodigoGrupo + "," + sequencial;
                    if (sequencial.Length == 1)
                        mskTxtBoxCodigo.Text = mskTxtBoxCodigo.Text.Substring(0, 3) + CodigoGrupo + "000" + sequencial;
                    else if (sequencial.Length == 2)
                        mskTxtBoxCodigo.Text = mskTxtBoxCodigo.Text.Substring(0, 3) + CodigoGrupo + "00" + sequencial;
                    else if (sequencial.Length == 3)
                        mskTxtBoxCodigo.Text = mskTxtBoxCodigo.Text.Substring(0, 3) + CodigoGrupo + "0" + sequencial;
                    else
                    {
                        sequencial = "0001";
                        mskTxtBoxCodigo.Text = mskTxtBoxCodigo.Text.Substring(0, 3) + CodigoGrupo + sequencial;
                    }

                }
                else
                {
                    ComboBoxGrupo.Text = "";
                }
            }
        }

        private void BttAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int SEQUENCIAL = (int)new InsumoTableAdapter().ObterSequencialInsumo(mskTxtBoxCodigo.Text.Replace(",", ".")).Value;
                EncargosSociais();
                new InsumoTableAdapter().Update(mskTxtBoxCodigo.Text.Replace(",", "."), TxtBoxDescricao.Text, ComboBoxUnidade.Text.Trim(), 0, (int)ComboBoxTipoInsumo.SelectedValue, (int)ComboBoxGrupo.SelectedValue, Convert.ToDecimal(MslTxtBoxPreco.Text), 0, 0, mskTxtBoxCodigo.Text.Replace(",", "."), SEQUENCIAL);
                this.insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);
                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Insumo.\n" + ex.Message);
            }
        }

        private void ComboBoxTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxTipoInsumo.SelectedValue.ToString().Length == 3)
                {
                    mskTxtBoxCodigo.Text = ComboBoxTipoInsumo.SelectedValue.ToString() + mskTxtBoxCodigo.Text.Substring(4);
                }
                else if (ComboBoxTipoInsumo.SelectedValue.ToString().Length == 2)
                {
                    mskTxtBoxCodigo.Text = "0" + ComboBoxTipoInsumo.SelectedValue.ToString() + mskTxtBoxCodigo.Text.Substring(4);
                }
                else
                {
                    mskTxtBoxCodigo.Text = "00" + ComboBoxTipoInsumo.SelectedValue.ToString() + mskTxtBoxCodigo.Text.Substring(4);
                }
                this.grupoInsumoTableAdapter1.FillBy1(this.sCOOPDataSet.GrupoInsumo, Convert.ToInt32(ComboBoxTipoInsumo.SelectedValue));
                if (CodigoInsumo == "0" || CodigoInsumo == null)
                {
                    ComboBoxGrupo.Text = "";
                }
                if (ComboBoxTipoInsumo.Text == "PESSOAL")
                {
                    label8.Visible = true;
                    EncargosSociaisTxtBox.Visible = true;
                    EncargosSociaisTxtBox.Text = "125";
                }
                else
                {
                    label8.Visible = false;
                    EncargosSociaisTxtBox.Visible = false;
                    EncargosSociaisTxtBox.Text = "";
                }
            }
            catch (Exception) { }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            string Numero = bindingNavigatorPositionItem.TextBox.Text;
            
            if (MessageBox.Show("Apagar Registro", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new InsumoTableAdapter().Delete((int)dataGridView1.Rows[Convert.ToInt32(Numero) - 1].Cells[0].Value, dataGridView1.Rows[Convert.ToInt32(Numero) - 1].Cells[1].Value.ToString());

                    insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);

                    MessageBox.Show("Deleção Realizada com Sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro Ao deletar Insumo. " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bindingNavigatorPositionItem.TextBox.Text != "0")
            {
                if (new InsumoTableAdapter().VerificarSeJaExisteInsumoComposicao(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString()).HasValue)
                {
                    if (MessageBox.Show("Deseja Excluir?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            new InsumoTableAdapter().Delete((int)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value, dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString());
                            MessageBox.Show("Deleção Realizada com Sucesso!");
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Erro Ao deletar Insumo. " + ex.Message);
                        }
                    }
                }
            }
        }

        private void ComboBoxUnidade_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
