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
    public partial class CadastroGrupoComposicao : Form
    {
        public CadastroGrupoComposicao()
        {
            InitializeComponent();
            ObterSequencialAtividade();
        }

        private void AtividadeButton_Click(object sender, EventArgs e)
        {
            try
            {
                new EtapaTableAdapter().Insert(Convert.ToInt32(EtapaTxtBox.Text), EtapaTxtBox.Text, (int)GrupoComboBox.SelectedValue, AcrescentarZero(EtapaTxtBox.Text));
                MessageBox.Show("Grupo Cadastrado com Sucesso!");
                this.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Erro ao cadastrar Grupo");
            }
        }

        public void ObterSequencialGrupo()
        {
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("select isnull(max(codigo),0)+1 from grupo");

            cmd.Connection = conn;

            try
            {
                conn.Open();

                Dr = cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        EtapaTxtBox.Text = Dr.GetInt32(0).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum Codigo Foi retornado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Codigo Grupo" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void ObterSequencialAtividade()
        {
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            //SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('[SCOOP].[dbo].[Atividade]')+1");

            cmd.Connection = conn;

            try
            {
                conn.Open();

                AtividadeTxtBox.Text = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Codigo Grupo" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public string AcrescentarZero(string Texto)
        {
            if (Texto.Length == 3)
            {
                return Texto;
            }
            else if (Texto.Length == 2)
            {
                Texto = "0" + Texto;
                return Texto;
            }
            else if (Texto.Length == 1)
            {
                Texto = "00" + Texto;
                return Texto;
            }
            else
            {
                return Texto;
            }

        }

        private void BttCadastrar_Click_1(object sender, EventArgs e)
        {
            if (!new AtividadeTableAdapter().VerificarExisteAtividade(AtividadeDescricaoTxtBox.Text).HasValue)
            {
                try
                {
                    EtapaComboBox_SelectedIndexChanged(null, null);
                    ObterSequencialAtividade();
                    new AtividadeTableAdapter().Insert(Convert.ToInt32(AcrescentarZero(AtividadeTxtBox.Text)), AtividadeDescricaoTxtBox.Text, (int)EtapaComboBox.SelectedValue, AcrescentarZero(EtapaTxtBox.Text) + "." + AcrescentarZero(AtividadeTxtBox.Text), Convert.ToInt32(AcrescentarZero(GrupotextBox.Text)));   
                    MessageBox.Show("Atividade cadastrada com sucesso.");
                    BttNovo_Click(null, null);
                    this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
                    tabControl1.SelectedTab = tabPage2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Atividade.\n " + ex.Message);
                }
            }
            else
            {
                try
                {
                    new AtividadeTableAdapter().Update(Convert.ToInt32(AcrescentarZero(AtividadeTxtBox.Text)), AtividadeDescricaoTxtBox.Text, Convert.ToInt32(new AtividadeTableAdapter().ObterCodigoPai(Convert.ToInt32(AtividadeTxtBox.Text)).Value), AcrescentarZero(AtividadeTxtBox.Text),Convert.ToInt32(new EtapaTableAdapter().ObterCodigoPaiEtapa(Convert.ToInt32(new AtividadeTableAdapter().ObterCodigoPai(Convert.ToInt32(AtividadeTxtBox.Text)).Value)).Value), Convert.ToInt32(AtividadeTxtBox.Text), Convert.ToInt32(new AtividadeTableAdapter().ObterCodigoPai(Convert.ToInt32(AtividadeTxtBox.Text)).Value));
                    MessageBox.Show("Atividade Atualizada com sucesso.");
                    BttNovo_Click(null, null);
                    this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
                    tabControl1.SelectedTab = tabPage2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Atualizar Atividade.\n " + ex.Message);
                }
            }
        }


        private void BttVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CadastroGrupo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet1.Atividade' table. You can move, or remove it, as needed.
            this.atividadeTableAdapter.Fill(this.sCOOPDataSet1.Atividade);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Etapa' table. You can move, or remove it, as needed.
            this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
            // TODO: This line of code loads data into the 'sCOOPDataSet.Grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter1.Fill(this.sCOOPDataSet.Grupo);

            GrupoComboBox.Text = "";
            EtapaComboBox.Text = "";


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir_GrupoComposicao();
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



        private void Imprimir_GrupoComposicao()
        {



            try
            {



                RelatorioTitulo = "Listagem Grupo,Etapa e Atividade";

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



            e.Graphics.DrawString("Código+Grupo", FonteNegrito, Brushes.Black, MargemEsquerda - 35, 142, new StringFormat());

            e.Graphics.DrawString("Codigo+Etapa", FonteNegrito, Brushes.Black, MargemEsquerda + 100, 142, new StringFormat());

            e.Graphics.DrawString("Código", FonteNegrito, Brushes.Black, MargemEsquerda + 250, 142, new StringFormat());

            e.Graphics.DrawString("Atividade", FonteNegrito, Brushes.Black, MargemEsquerda + 400, 142, new StringFormat());



            //Define quantas linhas terá cada folha 



            LinhasPorPagina = e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 30;



            //O principal : 



            foreach (DataGridViewRow linhas in this.dataGridView1.Rows)
            {



                while ((LinhaAtual < LinhasPorPagina && linhas.Cells[0].Tag.Equals(0)) && (LinhaAtual <= (this.dataGridView1.Rows.Count - 1)))
                {



                    //Variável posição da linha é um contador, como a variável LinhaAtual 



                    PosicaoDaLinha = MargemSuperior + (LinhaAtual * EspacoEntreLinhas.GetHeight(e.Graphics));



                    e.Graphics.DrawLine(CanetaDaImpressora, MargemEsquerda - 40, PosicaoDaLinha + 65, MargemDireita + 20, PosicaoDaLinha + 65);

                    e.Graphics.DrawString(linhas.Cells[0].Value.ToString(), FonteNormal, Brushes.Black, (int)(MargemEsquerda - 33), (int)(PosicaoDaLinha + 70), new StringFormat());
                    e.Graphics.DrawString(linhas.Cells[1].Value.ToString().Substring(0,linhas.Cells[1].Value.ToString().Length < 14? linhas.Cells[1].Value.ToString().Length : 13), FonteNormal, Brushes.Black, MargemEsquerda - 10, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[2].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 100, PosicaoDaLinha + 50, new StringFormat());
                    e.Graphics.DrawString(linhas.Cells[3].Value.ToString().Substring(0, linhas.Cells[3].Value.ToString().Length < 25 ? linhas.Cells[3].Value.ToString().Length : 25), FonteNormal, Brushes.Black, MargemEsquerda + 130, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[4].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 330, PosicaoDaLinha + 70, new StringFormat());
                    e.Graphics.DrawString(linhas.Cells[5].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 380, PosicaoDaLinha + 70, new StringFormat());

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
            if (!new EtapaTableAdapter().VerificarExisteEtapa(EtapaComboBox.Text).HasValue)
            {
                try
                {
                    new EtapaTableAdapter().Insert(Convert.ToInt32(EtapaTxtBox.Text), EtapaComboBox.Text, (int)EtapaComboBox.SelectedValue, AcrescentarZero(EtapaTxtBox.Text));
                    EtapaComboBox_SelectedIndexChanged(null, null);
                    grupoSubCategoria.Enabled = true;
                    ObterSequencialAtividade();
                    EtapaGrupoBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Etapa.\n" + ex.Message);
                    grupoSubCategoria.Enabled = false;
                }
            }
            else
            {
                grupoSubCategoria.Enabled = true;
                EtapaComboBox_SelectedIndexChanged(null, null);
                grupoSubCategoria.Enabled = true;
                EtapaGrupoBox.Enabled = false;
                ObterSequencialAtividade();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.atividadeTableAdapter.FillBy4(sCOOPDataSet1.Atividade, textBoxPesquisa.Text);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (!new ServicoTableAdapter().VerificarExisteAtividadeServico((int)dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[4].Value).HasValue)
            {
                GrupotextBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[0].Value.ToString();
                GrupoComboBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[1].Value.ToString();
                EtapaTxtBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[2].Value.ToString();
                EtapaComboBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[3].Value.ToString();
                AtividadeTxtBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[4].Value.ToString();
                AtividadeDescricaoTxtBox.Text = dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[5].Value.ToString();
                tabControl1.SelectedTab = tabPage1;
                AtividadeButton.Enabled = false;
                EtapaButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não se pode alterar Grupo,Etapa ou Atividade depois que existe um serviço lançando com esta Categoria.");
            }
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            EtapaTxtBox.Text = "";
            EtapaComboBox.Text = "";
            AtividadeDescricaoTxtBox.Text = "";
            EtapaComboBox.Text = "";
            AtividadeTxtBox.Text = "";
            AtividadeDescricaoTxtBox.Text = "";
            AtividadeButton.Enabled = true;
            EtapaButton.Enabled = true;
            EtapaGrupoBox.Enabled = false;
            grupoSubCategoria.Enabled = false;
            GrupogroupBox.Enabled = true;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (new ServicoTableAdapter().VerificarExisteAtividadeServico((int)dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[4].Value).HasValue)
            {
                try
                {
                    if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new AtividadeTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[4].Value));
                        //new EtapaTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[2].Value), Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[0].Value), AcrescentarZero(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[2].Value.ToString()));
                        //new GrupoTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(toolStripTextBox2.TextBox.Text) - 1].Cells[0].Value));                    
                        this.atividadeTableAdapter.Fill(this.sCOOPDataSet1.Atividade);
                        MessageBox.Show("Atividade excluida com sucesso.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Procure o Adminsitrador.\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não pode excluir atividade que se já existir um serviço lançado com ele.\n");
            }
        }

        private void CadastroGrupoComposicao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void Grupobutton_Click(object sender, EventArgs e)
        {
            if (!new GrupoTableAdapter().VerificarExisteGrupo(GrupoComboBox.Text).HasValue)
            {
                try
                {
                    new GrupoTableAdapter().Insert(GrupoComboBox.Text);
                    GrupoComboBox_SelectedIndexChanged(null, null);
                    GrupogroupBox.Enabled = false;
                    EtapaGrupoBox.Enabled = true;
                    EtapaComboBox.Text = "";
                    EtapaButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar Grupo de Serviço.\n" + ex.Message);
                    EtapaGrupoBox.Enabled = false;
                }
            }
            else
            {
                this.etapaTableAdapter.FillBy(this.sCOOPDataSet.Etapa, (int)GrupoComboBox.SelectedValue);
                GrupoComboBox_SelectedIndexChanged(null, null);
                GrupogroupBox.Enabled = false;
                EtapaGrupoBox.Enabled = true;
                EtapaComboBox.Text = "";
                EtapaButton.Enabled = true;
            }
        }

        private void GrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GrupotextBox.Text = GrupoComboBox.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void EtapaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EtapaTxtBox.Text = EtapaComboBox.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        public void PreencherGridView()
        {
            //this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SCOOPDataSet.EtapaDataTable Dt = new EtapaTableAdapter().GetDataBy2(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                foreach (SCOOPDataSet.EtapaRow linha in Dt)
                {
                    SCOOPDataSet.GrupoDataTable DtGrupo = new GrupoTableAdapter().GetDataBy1(linha.Codigo_Pai);
                    foreach (SCOOPDataSet.GrupoRow LinhaGrupo in DtGrupo)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = LinhaGrupo.Codigo.ToString();
                        dataGridView1.Rows[i].Cells[1].Value = LinhaGrupo.Descricao;
                        dataGridView1.Rows[i].Cells[3].Value = linha.Descricao;
                    }
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PreencherGridView();
        }



    }
}
