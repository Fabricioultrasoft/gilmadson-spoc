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
using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;


namespace SCOOP
{
    public partial class CadastroObraTipo : Form
    {
        public CadastroObraTipo()
        {
            InitializeComponent();
            ObterSequencialGrupo();
        }

        private void BttCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                new TipoOrcamentoTableAdapter().Insert(NomeTipoOrcamentoTxtBox.Text, Convert.ToInt32(CodigoDotacaotextBox.Text));
                MessageBox.Show("Tipo de Obra Cadastrado com Sucesso!");
                this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
                preencherGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Tipo de Obra");
            }
        }

        public void ObterSequencialGrupo()
        {
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            //SqlDataReader ;
            SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('Tipo_Orcamento') + 1 AS Expr1 ");

            cmd.Connection = conn;

            try
            {
                conn.Open();
                CodigoTipoOrcamentoTxtBox.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Codigo Tipo de Obra" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CadastroObraTipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.DotacaoOrcamentaria' table. You can move, or remove it, as needed.
            this.dotacaoOrcamentariaTableAdapter.Fill(this.sCOOPDataSet.DotacaoOrcamentaria);
            this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
            preencherGridView();

            DotacaoComboBox.Text = "";

            try
            {
                CodigoTipoOrcamentoTxtBox.Text = new TipoOrcamentoTableAdapter().ObterSequencialTipoOrcamento().Value.ToString();
            }
            catch (Exception )
            {

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            BttNovo_Click(null, null);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tipoOrcamentoTableAdapter.FillBy(this.sCOOPDataSet.TipoOrcamento, textBox2.Text);
            preencherGridView();
        }

        private void BttVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new TipoOrcamentoTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[2].Value), Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[0].Value));
                    MessageBox.Show("Exclusão realizada com sucesso.");
                    this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
                    preencherGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Procure o Adminsitrador.\n" + ex.Message);
            }
        }

        private void CadastroObraTipo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CodigoDotacaotextBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[0].Value.ToString();
            DotacaoComboBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[1].Value.ToString();
            CodigoTipoOrcamentoTxtBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[2].Value.ToString();
            NomeTipoOrcamentoTxtBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[3].Value.ToString();
            BttCadastrar.Visible = false;
            BttAlterar.Visible = true;
            tabControl1.SelectedTab = tabPage1;

        }

        private void BttAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new TipoOrcamentoTableAdapter().Update(NomeTipoOrcamentoTxtBox.Text, Convert.ToInt32(CodigoDotacaotextBox.Text), (int)dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[2].Value, (int)dataGridView1.Rows[Convert.ToInt32(toolStripTextBox1.TextBox.Text) - 1].Cells[0].Value);
                BttCadastrar.Visible = true;
                BttAlterar.Visible = false;
                MessageBox.Show("Atualização Realizadda com Sucessso.");
                tabControl1.SelectedTab = tabPage2;
                this.tipoOrcamentoTableAdapter.Fill(this.sCOOPDataSet.TipoOrcamento);
                preencherGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na alteração.\n" + ex.Message);
                BttCadastrar.Visible = false;
                BttAlterar.Visible = true;
            }
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            CodigoTipoOrcamentoTxtBox.Text = "";
            NomeTipoOrcamentoTxtBox.Text = "";
            ObterSequencialGrupo();
        }

        private void DotacaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DotacaoComboBox.SelectedValue != null)
                CodigoDotacaotextBox.Text = DotacaoComboBox.SelectedValue.ToString();
        }

        public void preencherGridView()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = new DotacaoOrcamentariaTableAdapter().ObterDescricaoDotacaoOrcamentaria((int)dataGridView1.Rows[i].Cells[0].Value).ToUpper();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            preencherGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imprimir_TiposOrcamento();
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



        private void Imprimir_TiposOrcamento()
        {



            try
            {



                RelatorioTitulo = "Tipos de Orçamento";

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

            e.Graphics.DrawString("Dotação Orçamentaria", FonteNegrito, Brushes.Black, MargemEsquerda + 70, 142, new StringFormat());

            e.Graphics.DrawString("Codigo", FonteNegrito, Brushes.Black, MargemEsquerda + 357, 142, new StringFormat());

            e.Graphics.DrawString("Tipo Orçamento", FonteNegrito, Brushes.Black, MargemEsquerda + 499, 142, new StringFormat());





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

                    e.Graphics.DrawString(linhas.Cells[1].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 70, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[2].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 357, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[3].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 499, PosicaoDaLinha + 70, new StringFormat()); 

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

        #endregion

        }
    }
}
