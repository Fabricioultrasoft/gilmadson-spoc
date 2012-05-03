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

namespace SCOOP.GUI
{
    public partial class PesquisarGrupo : Form
    {
        private CadastroMedicao InstanciaMedicao;
        public PesquisarGrupo(CadastroMedicao Medicao)
        {
            InitializeComponent();
            InstanciaMedicao = Medicao;
        }

        private void PesquisarGrupo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.sCOOPDataSet.Grupo);
            try
            {
            }
            catch (Exception ) { }

        }

        private void BttPesquisar_Click(object sender, EventArgs e)
        {            
            string con = Settings.Default.SCOOPConnectionString;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(con);
            string sql = "select codigo, descricao from grupo where descricao like '%" + TxtBoxNome.Text + "%'";
            System.Data.SqlClient.SqlDataAdapter dAdapter = new System.Data.SqlClient.SqlDataAdapter(sql, conn);
            System.Data.SqlClient.SqlCommandBuilder cBuilder = new System.Data.SqlClient.SqlCommandBuilder(dAdapter);
            DataTable dTable = new DataTable();
            dAdapter.Fill(dTable);
            grupoBindingSource.DataSource = dTable;
            dataGridView1.DataSource = grupoBindingSource;
            dAdapter.Update(dTable);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroGrupoComposicao();
            frm.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                new GrupoTableAdapter().Delete((int)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value);
                MessageBox.Show("Grupo Apagado com Sucesso!");
                this.grupoTableAdapter.Fill(this.sCOOPDataSet.Grupo);
            }
            catch (Exception )
            {
                MessageBox.Show("Erro deletar Grupo!");
            }
        }

        private void BttSelecionar_Click(object sender, EventArgs e)
        {
            InstanciaMedicao.GrupoBoxServicos.Text = (string)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)].Cells[1].Value;
            InstanciaMedicao.GrupoBoxServicos.Refresh();
        }

        private void PesquisarGrupo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
