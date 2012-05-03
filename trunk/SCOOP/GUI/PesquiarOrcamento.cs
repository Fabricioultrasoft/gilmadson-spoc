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

namespace SCOOP.GUI
{
    public partial class PesquiarOrcamento : Form
    {
        CadastroOrcamentocs InstanciaOrcamento = null;
        CadastroOrcamentocontratado InstanciaOrcamentoCadastrado = null;
        CadastroMedicao InstanciaMedicao = null;
        public PesquiarOrcamento(CadastroMedicao CadastroMedicao, CadastroOrcamentocs CadastroOrcamentocs, CadastroOrcamentocontratado CadastroOrcamentoContratado)
        {
            InitializeComponent();
            InstanciaMedicao = CadastroMedicao;
            InstanciaOrcamento = CadastroOrcamentocs;
            InstanciaOrcamentoCadastrado = CadastroOrcamentoContratado;
        }

        private void PesquiarServico_Load(object sender, EventArgs e)
        {
            if (InstanciaOrcamentoCadastrado != null)
            {
                try
                {
                    // TODO: This line of code loads data into the 'orcamentoDataSet.Orcamento' table. You can move, or remove it, as needed.
                    this.orcamentoTableAdapter1.FillBy1(this.sCOOPDataSet.Orcamento);
                }
                catch (Exception )
                { }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InstanciaMedicao != null)
            {
                InstanciaMedicao.ImportaOrcamento(OrcamentodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());
                this.Close();
            }
            if (InstanciaOrcamentoCadastrado != null)
            {
                InstanciaOrcamentoCadastrado.ImportarOrcamento(OrcamentodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());
                this.Close();
            }

            this.Close();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            this.orcamentoBindingSource.Filter = "(Descricao like '%'" + TxtBoxServico.Text + "'%')";
            /*string con = Settings.Default.SCOOPConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con);
            string sql = "select * from Orcamento where descricao like '%" + TxtBoxServico.Text + "%'";
            System.Data.SqlClient.SqlDataAdapter dAdapter = new System.Data.SqlClient.SqlDataAdapter(sql, conn);
            System.Data.SqlClient.SqlCommandBuilder cBuilder = new System.Data.SqlClient.SqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            orcamentoBindingSource.DataSource = dTable;
            ServicodataGridView1.DataSource = orcamentoBindingSource;
            dAdapter.Update(dTable);*/

        }

        private void PesquiarOrcamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
