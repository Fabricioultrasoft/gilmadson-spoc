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
using System.Drawing.Printing;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class CadastroBairro
        : Form
    {
        public CadastroBairro()
        {
            InitializeComponent();
            ObterSequencialGrupo();
        }

        private void BttCadastrar_Click(object sender, EventArgs e)
        {
            if (new BairroTableAdapter().VerificarExisteBairro(Convert.ToInt32(TxtBoxCodigo.Text)).HasValue)
            {
                try
                {
                    new BairroTableAdapter().Update(TxtBoxNome.Text, Convert.ToInt32(TxtBoxCodigo.Text));
                    this.bairroTableAdapter1.Fill(this.sCOOPDataSet.Bairro);
                    MessageBox.Show("Alteração realizada com sucesso.");
                    tabControl1.SelectedTab = tabPage2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro a atualizar Bairro.\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    new BairroTableAdapter().Insert(TxtBoxNome.Text);
                    MessageBox.Show("Bairro Cadastrad com Sucesso!");
                    this.bairroTableAdapter1.Fill(this.sCOOPDataSet.Bairro);
                    tabControl1.SelectedTab = tabPage2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Bairro.\n" + ex.Message);
                }
            }
        }

        public void ObterSequencialGrupo()
        {
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("select isnull(max(codigo),0)+1 from Bairro");

            cmd.Connection = conn;

            try
            {
                conn.Open();

                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        TxtBoxCodigo.Text = Dr.GetInt32(0).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum Codigo Foi retornado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Codigo Bairro" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CadastroBairro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Bairro' table. You can move, or remove it, as needed.
            this.bairroTableAdapter1.Fill(this.sCOOPDataSet.Bairro);



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Continuar?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    new BairroTableAdapter().Delete(Convert.ToInt32(TxtBoxCodigo.Text));

                this.bairroTableAdapter1.Fill(this.sCOOPDataSet.Bairro);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a excluir bairro.\n" + ex.Message);
            }

        }

        private void BttVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bairroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            TxtBoxCodigo.Text = bairroDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString();
            TxtBoxNome.Text = bairroDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString();
        }

        private void BttAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new BairroTableAdapter().Update(TxtBoxNome.Text, Convert.ToInt32(TxtBoxCodigo.Text));
                MessageBox.Show("Bairro Alterado com Sucesso");
                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception )
            {
                MessageBox.Show("Erro ao Tentar alterar Bairro");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bairroTableAdapter1.FillBy(this.sCOOPDataSet.Bairro, textBox1.Text);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            tabControl1.TabIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir_Bairros();


        }

        //Metodos de impressão
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



        private void Imprimir_Bairros()
        {



            try
            {



                RelatorioTitulo = "Bairros";

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



            foreach (DataGridViewRow Linhas in this.bairroDataGridView.Rows)
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

            e.Graphics.DrawString("Descrição", FonteNegrito, Brushes.Black, MargemEsquerda + 70, 142, new StringFormat());

            //e.Graphics.DrawString("Material", FonteNegrito, Brushes.Black, MargemEsquerda + 357, 142, new StringFormat()); 





            //Define quantas linhas terá cada folha 



            LinhasPorPagina = e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 30;



            //O principal : 



            foreach (DataGridViewRow linhas in this.bairroDataGridView.Rows)
            {



                while ((LinhaAtual < LinhasPorPagina && linhas.Cells[0].Tag.Equals(0)) && (LinhaAtual < (this.bairroDataGridView.Rows.Count - 1)))
                {



                    //Variável posição da linha é um contador, como a variável LinhaAtual 



                    PosicaoDaLinha = MargemSuperior + (LinhaAtual * EspacoEntreLinhas.GetHeight(e.Graphics));



                    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, PosicaoDaLinha + 65, MargemDireita + 20, PosicaoDaLinha + 65);

                    e.Graphics.DrawString(linhas.Cells[0].Value.ToString(), FonteNormal, Brushes.Black, (int)(MargemEsquerda - 33), (int)(PosicaoDaLinha + 70), new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[1].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 70, PosicaoDaLinha + 70, new StringFormat());

                    //e.Graphics.DrawString(linhas.Cells[2].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 357, PosicaoDaLinha + 70, new StringFormat()); 

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

        private void CadastroBairro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new BairroTableAdapter().Delete((int)bairroDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value);
                    MessageBox.Show("Excluindo do sucesso.");
                    this.bairroTableAdapter1.Fill(this.sCOOPDataSet.Bairro);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void bairroDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }


    }
}
