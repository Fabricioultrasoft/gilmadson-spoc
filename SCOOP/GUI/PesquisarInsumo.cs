using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;

namespace SCOOP
{
    public partial class PesquisarInsumo : Form
    {
        CadastroComposicao InstanciaCadastroServico;
        public PesquisarInsumo(CadastroComposicao Servico)
        {
            InitializeComponent();
            InstanciaCadastroServico = Servico;
        }

        private void PesquisarInsumo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Insumo' table. You can move, or remove it, as needed.
            this.insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);
            try
            {
            }
            catch (Exception) { }

        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            string con = Settings.Default.SCOOPConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con);
            string sql = "select codigo, descricao, unidade, preco, grupo from insumo where descricao like '%" + TxtBoxPesquisar.Text + "%'";
            System.Data.SqlClient.SqlDataAdapter dAdapter = new System.Data.SqlClient.SqlDataAdapter(sql, conn);
            System.Data.SqlClient.SqlCommandBuilder cBuilder = new System.Data.SqlClient.SqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            insumoBindingSource.DataSource = dTable;
            InsumodataGridView1.DataSource = insumoBindingSource;
            dAdapter.Update(dTable);
        }

        private void InsumodataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void TxtBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InstanciaCadastroServico.CodigoInsumomaskedTextBox.Text = (string)InsumodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value;
                InstanciaCadastroServico.descricaoInsumotextBox.Text = (string)InsumodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value;
                InstanciaCadastroServico.UnidadetextBox.Text = InsumodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString();
                InstanciaCadastroServico.ValortextBox.Text = InsumodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[7].Value.ToString();
                InstanciaCadastroServico.CodigoInsumomaskedTextBox.Refresh();
                InstanciaCadastroServico.descricaoInsumotextBox.Refresh();
                InstanciaCadastroServico.UnidadetextBox.Refresh();
                InstanciaCadastroServico.ValortextBox.Refresh();

                this.Close();
            }
            catch (Exception )
            { }
        }

        private void PesquisarInsumo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BttBuscar_Click(null, null);
            }
        }
    }
}
