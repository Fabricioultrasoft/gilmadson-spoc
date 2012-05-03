using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class CadastroFiscalizador : Form
    {
        private CadastroOrcamentocs InstanciaOrcamento = null;
        public CadastroFiscalizador(CadastroOrcamentocs Orcamento)
        {
            InitializeComponent();
            if (Orcamento != null)
            {
                InstanciaOrcamento = Orcamento;
                tabControl1.SelectedTab = tabPage2;
                SelecionarButton.Visible = true;

            }
            else
            {
                BttNovo_Click(null, null);
                try
                {
                    TxtBoxCodigo.Text = new FiscalizacaoTableAdapter().ObterSequencial().Value.ToString();
                }
                catch (Exception ex) { }

            }
        }

        private void BttIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                new FiscalizacaoTableAdapter().Insert(TxtBoxDescricao.Text);
                MessageBox.Show("Fiscal Cadastrado com sucesso.");
                tabControl1.SelectedTab = tabPage2;
                BttNovo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Inserir Unidade; " + ex.Message);
            }
        }

        private void CadastroFiscalizador_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Fiscalizacao' table. You can move, or remove it, as needed.
                try
                {
                    this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
                }
                catch (Exception ) { }

            }
            catch (Exception)
            {

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            CadastroFiscalizador_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir_Fiscal();
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



        private void Imprimir_Fiscal()
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



            e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, MargemEsquerda - 35, 142, new StringFormat());

            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, MargemEsquerda + 70, 142, new StringFormat());



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

        private void button3_Click(object sender, EventArgs e)
        {
            this.fiscalizacaoTableAdapter.FillBy(this.sCOOPDataSet.Fiscalizacao, textBox1.Text);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            TxtBoxCodigo.Text = dataGridView1.Rows[Convert.ToInt32((toolStripTextBox2.TextBox.Text)) - 1].Cells[0].Value.ToString();
            TxtBoxDescricao.Text = dataGridView1.Rows[Convert.ToInt32((toolStripTextBox2.TextBox.Text)) - 1].Cells[1].Value.ToString();
            //this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
            TxtBoxDescricao.Enabled = true;
            BttAlterar.Visible = true;
            BttIncluir.Visible = false;
        }

        private void BttAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new FiscalizacaoTableAdapter().Update(TxtBoxDescricao.Text, Convert.ToInt32(TxtBoxCodigo.Text), Convert.ToInt32(TxtBoxCodigo.Text));
                this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
                tabControl1.SelectedTab = tabPage2;
                MessageBox.Show("Alteração realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Fiscalização.\n" + ex.Message);
            }
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            TxtBoxCodigo.Text = "";
            TxtBoxDescricao.Text = "";
            CadastroFiscalizador_Load(null, null);
            BttAlterar.Visible = false;
            BttIncluir.Visible = true;
        }

        private void CadastroFiscal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new FiscalizacaoTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[0].Value));
                this.fiscalizacaoTableAdapter.Fill(this.sCOOPDataSet.Fiscalizacao);
                MessageBox.Show("Excluido com sucesso.");
            }
        }

        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            InstanciaOrcamento.FiscalComboBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[1].Value.ToString();
            InstanciaOrcamento.FiscalComboBox.Refresh();
            this.Close();
        }

    }
}
