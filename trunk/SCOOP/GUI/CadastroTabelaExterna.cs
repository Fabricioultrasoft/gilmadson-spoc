using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
using System.Data.SqlClient;
using SCOOP.Properties;

namespace SCOOP.GUI
{
    public partial class CadastroTabelaExterna : Form
    {
        private CadastroOrcamentocs CadOrcamento;
        public CadastroTabelaExterna(CadastroOrcamentocs Orcamento)
        {
            InitializeComponent();
            CadOrcamento = Orcamento;
        }

        private void CadastroTabelaExterna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Unidade' table. You can move, or remove it, as needed.
            this.unidadeTableAdapter.Fill(this.sCOOPDataSet.Unidade);
            comboBox1.Text = "";
            preencherCodigoInsumo();
            ObterSequencial();
        }

        private void preencherCodigoInsumo()
        {
            #region SequencialInsumo
            string sequencial = "0001";
            try
            {
                sequencial = new InsumoTableAdapter().ObterSequencialPorGrupo("474").ToString();
            }
            catch (Exception) { }
            //string CodigoInsumo = CodigoGrupo + "," + sequencial;
            if (sequencial.Length == 1)
                mskTxtBoxCodigo.Text = "005474" + "000" + sequencial;
            else if (sequencial.Length == 2)
                mskTxtBoxCodigo.Text = "005474" + "00" + sequencial;
            else if (sequencial.Length == 3)
                mskTxtBoxCodigo.Text = "005474" + "0" + sequencial;
            else
            {
                sequencial = "0001";
                mskTxtBoxCodigo.Text = "005474" + sequencial;
            }
            #endregion
        }

        public void ObterSequencial()
        {
            #region ObterSequencia
            string CodigoServico = null;
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            SqlDataReader Dr;
            SqlCommand cmd = new SqlCommand("select isnull(max(substring(cast(codigo as nvarchar),9,4)+1),1) from [SCOOP].[dbo].servico Where   substring(cast(codigo as nvarchar),5,3) = '169'");
            cmd.Connection = conn;
            try
            {
                conn.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    CodigoServico = Dr.GetInt32(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Obter Codigo Serviço! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (CodigoServico.Length == 1)
            {
                CodigomaskedTextBox.Text = "022169" + "000" + CodigoServico;
            }
            else if (CodigoServico.Length == 2)
            {
                CodigomaskedTextBox.Text = "022169" + "00" + CodigoServico;
            }
            else if (CodigoServico.Length == 3)
            {
                CodigomaskedTextBox.Text = "022169" + "0" + CodigoServico;
            }
            else
            {
                CodigomaskedTextBox.Text = "022169" + CodigoServico.Substring(3);
            }
            #endregion
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!PrecotextBox.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void Cadastrarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                InserirInsumo();
                if (new InsumoTableAdapter().VerificarExisteInsumo(DescricaotextBox.Text).HasValue)
                {
                    InserirServico();
                    if (new ServicoTableAdapter().VerificarExisteServico(CodigomaskedTextBox.Text.Replace(",",".")).HasValue)
                    {
                        InserirComposicao();
                        CadOrcamento.mskTxtBoxCodServico.Text = CodigomaskedTextBox.Text.Replace(",", ".");
                        CadOrcamento.TxtDescricaoServico.Text = DescricaotextBox.Text;
                        CadOrcamento.TxtBoxUnidadeServico.Text = comboBox1.Text;
                        CadOrcamento.TxtBoxValorUnitario.Text = PrecotextBox.Text.Replace(",", ".");
                        CadOrcamento.mskTxtBoxCodServico.Refresh();
                        CadOrcamento.TxtDescricaoServico.Refresh();
                        CadOrcamento.TxtBoxUnidadeServico.Refresh();
                        CadOrcamento.TxtBoxValorUnitario.Refresh();
                        MessageBox.Show("Serviço Cadastrado com Sucesso!\n/b A  TELA SERA FECHADA!/b");
                        this.Close();
                    }

                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Insumo, Servico e Composição.\n" + ex.Message);
            }
        }

        private void InserirInsumo()
        {
            try
            {
                new InsumoTableAdapter().Insert(mskTxtBoxCodigo.Text.Replace(",", "."), DescricaotextBox.Text, comboBox1.Text, 0, 5, 474, Convert.ToDecimal(PrecotextBox.Text.Replace(".", ",")), 0, 0);
                InsumopictureBox.Image = global::SCOOP.Properties.Resources.ok;
            }
            catch (Exception ex)
            {
                InsumopictureBox.Image = global::SCOOP.Properties.Resources.errado;
            }
        }

        private void InserirServico()
        {
            try
            {
                new ServicoTableAdapter().Insert(CodigomaskedTextBox.Text.Replace(",", "."), DescricaotextBox.Text, comboBox1.Text, 3, 22, 169, 0, 0);
                ServicopictureBox.Image = global::SCOOP.Properties.Resources.ok;
            }
            catch(Exception ex)
            {
                ServicopictureBox.Image = global::SCOOP.Properties.Resources.errado;
            }
        }

        private void InserirComposicao()
        {
            try
            {
                new ComposicaoTableAdapter().Insert(CodigomaskedTextBox.Text.Replace(",", "."), mskTxtBoxCodigo.Text, 1, (int)new ServicoTableAdapter().ObterSequencialServico(CodigomaskedTextBox.Text.Replace(",", ".")).Value, (int)new InsumoTableAdapter().ObterSequencialInsumo(mskTxtBoxCodigo.Text.Replace(",", ".")).Value);
                ComposicaopictureBox.Image = global::SCOOP.Properties.Resources.ok;
            }
            catch (Exception ex)
            {
                ComposicaopictureBox.Image = global::SCOOP.Properties.Resources.errado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
