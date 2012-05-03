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
    public partial class CadastroGrupoInsumos : Form
    {
        public CadastroGrupoInsumos()
        {
            InitializeComponent();
        }

        private void CadastroGrupoInsumos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.GrupoInsumo' table. You can move, or remove it, as needed.
                this.grupoInsumoTableAdapter.Fill(this.sCOOPDataSet.GrupoInsumo);
                // TODO: This line of code loads data into the 'sCOOPDataSet.TipoInsumo' table. You can move, or remove it, as needed.
                this.tipoInsumoTableAdapter.Fill(this.sCOOPDataSet.TipoInsumo);
                TipoInsumoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TipoInsumoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ) { }
            try
            {
                //MskBoxCodigo.Text = new OrcamentoDataSetTableAdapters.GrupoInsumoTableAdapter().ObterSequencial().Value.ToString();
            }
            catch (Exception ) { }
            TipoInsumoComboBox.Text = "";

        }

        private void BttInserir_Click_1(object sender, EventArgs e)
        {
            if (!new TipoInsumoTableAdapter().VerificarExisteTipoInsumo(TxtBoxDescricao.Text).HasValue)
            {
                try
                {
                    MskBoxCodigo.Text = new GrupoInsumoTableAdapter().ObterSequencial().ToString();
                    new GrupoInsumoTableAdapter().Insert(Convert.ToInt32(MskBoxCodigo.Text), TxtBoxDescricao.Text, (int)TipoInsumoComboBox.SelectedValue);
                    this.grupoInsumoTableAdapter.Fill(this.sCOOPDataSet.GrupoInsumo);
                    MessageBox.Show("Grupo Insumos Cadastrado com Sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Grupo Insumos.\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Já Existe esse tipo de grupo insumo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.grupoInsumoTableAdapter.FillBy(this.sCOOPDataSet.GrupoInsumo, TxtBoxGrupoInsumo.Text);
            }
            catch (Exception ) { }
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



        private void Imprimir_GrupoInsumo()
        {



            try
            {



                RelatorioTitulo = "Listagem Grupo de Insumo";

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

            e.Graphics.DrawString("Grupo", FonteNegrito, Brushes.Black, MargemEsquerda , 142, new StringFormat());

            e.Graphics.DrawString("Cod", FonteNegrito, Brushes.Black, MargemEsquerda + 120, 142, new StringFormat());

            e.Graphics.DrawString("Tipo Insumo", FonteNegrito, Brushes.Black, MargemEsquerda + 150, 142, new StringFormat());


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

                    e.Graphics.DrawString(linhas.Cells[1].Value.ToString().Substring(0,linhas.Cells[1].Value.ToString().Length < 16 ? linhas.Cells[1].Value.ToString().Length : 15), FonteNormal, Brushes.Black, MargemEsquerda , PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[2].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 120, PosicaoDaLinha + 70, new StringFormat());

                    e.Graphics.DrawString(linhas.Cells[3].Value.ToString(), FonteNormal, Brushes.Black, MargemEsquerda + 150, PosicaoDaLinha + 70, new StringFormat());

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
            Imprimir_GrupoInsumo();
        }

        private void BttAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            TipoInsumoComboBox.Text = "";
            TipoInsumoComboBox.Text = "";
            MskBoxCodigo.Text = "";
            TxtBoxDescricao.Text = "";
            CadastroGrupoInsumos_Load(null, null);
            BttInserir.Visible = true;
            BttAlterar.Visible = false;
            groupBox3.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void BttAlterar_Click_1(object sender, EventArgs e)
        {

            try
            {
                new GrupoInsumoTableAdapter().Update(TxtBoxDescricao.Text, (int)TipoInsumoComboBox.SelectedValue, Convert.ToInt32(MskBoxCodigo.Text), (int)TipoInsumoComboBox.SelectedValue);
                this.grupoInsumoTableAdapter.Fill(this.sCOOPDataSet.GrupoInsumo);
                MessageBox.Show("Alteração Realizando com Sucesso.");
                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Grupo de Insumo.\n" + ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            BttNovo_Click(null, null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TipoInsumoComboBox.Text = dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString();
            MskBoxCodigo.Text = dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString();
            TxtBoxDescricao.Text = dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString();
            BttAlterar.Visible = true;
            BttInserir.Visible = false;
            tabControl1.SelectedTab = tabPage1;
        }

        private void CadastroGrupoInsumos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void AdicinarButton_Click(object sender, EventArgs e)
        {
            //Form frm = new cadastro
        }

        private void MskBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!MskBoxCodigo.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "Pergunta?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new GrupoInsumoTableAdapter().Delete((int)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)-1].Cells[2].Value);
                    this.grupoInsumoTableAdapter.Fill(this.sCOOPDataSet.GrupoInsumo);
                    MessageBox.Show("Grupo de insumo apagado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar Grupo\n"+ex.Message);
                }
            }
        }

        public void preencherGridView(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            preencherGridView();
        }

        private void preencherGridView()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = new TipoInsumoTableAdapter().ObterDescricaoGrupoInsumo((int)dataGridView1.Rows[i].Cells[0].Value);
            }
        }
    }
}
