using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class PesquisarBairro : Form
    {
        private CadastroOrcamentocs InstancioOrcamento;
        public PesquisarBairro( CadastroOrcamentocs Orcamento)
        {
            InitializeComponent();
            InstancioOrcamento = Orcamento;


        }

        private void PesquisarGrupo_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Bairro' table. You can move, or remove it, as needed.
                this.bairroTableAdapter.Fill(this.sCOOPDataSet.Bairro);
            }
            catch (Exception ) { }

        }

        private void BttPesquisar_Click(object sender, EventArgs e)
        {
            string con = Settings.Default.SCOOPConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con);
            string sql = "select * from bairro where descricao like '%" + TxtBoxNome.Text + "%'";
            System.Data.SqlClient.SqlDataAdapter dAdapter = new System.Data.SqlClient.SqlDataAdapter(sql, conn);
            System.Data.SqlClient.SqlCommandBuilder cBuilder = new System.Data.SqlClient.SqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            bairroBindingSource.DataSource = dTable;
            dataGridView1.DataSource = bairroBindingSource;
            dAdapter.Update(dTable);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroBairro();
            frm.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new BairroTableAdapter().Delete((Int32)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value);
                    MessageBox.Show("Grupo Apagado com Sucesso!");
                    this.bairroTableAdapter.Fill(this.sCOOPDataSet.Bairro);
                }
                catch (Exception )
                {
                    MessageBox.Show("Erro deletar Grupo!");
                }
            }
        }

        private void BttSelecionar_Click(object sender, EventArgs e)
        {
            InstancioOrcamento.BairroComboBox.Text = (string)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)].Cells[1].Value;
            InstancioOrcamento.BairroComboBox.Refresh();
        }

        private void PesquisarBairro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BttPesquisar_Click(null, null);
            }
        }
    }
}
