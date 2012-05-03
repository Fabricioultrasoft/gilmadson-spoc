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
    public partial class PesquisarEmpreteira : Form
    {
        private CadastroMedicao InstanciaMedicao = null;
        private CadastroOrcamentocontratado InstanciaOrcamentoContratado = null;
        public PesquisarEmpreteira(CadastroMedicao Medicao,CadastroOrcamentocontratado OrcamentoContratado)
        {
            InitializeComponent();
            InstanciaMedicao = Medicao;
            InstanciaOrcamentoContratado = OrcamentoContratado;
        }

        private void PesquisarEmpreteira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.Empreteira' table. You can move, or remove it, as needed.
            this.empreteiraTableAdapter.Fill(this.sCOOPDataSet.Empreteira);
            try
            {
            }
            catch (Exception) { }

        }

        private void BttPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.empreteiraTableAdapter.FillBy(this.sCOOPDataSet.Empreteira, TxtBoxNome.Text);
            }
            catch (Exception ) { }
        }

        private void BttSelecionar_Click(object sender, EventArgs e)
        {
            if (InstanciaMedicao == null)
            {
                //InstanciaOrcamentoContratado.em.Text = (string)dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)-1].Cells[0].Value;
                //InstanciaOrcamentoContratado.ComboBoxEmpreteiro.Refresh();
            }
            else
            {
                InstanciaMedicao.Text = Convert.ToString(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value);
                InstanciaMedicao.Refresh();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroEmpreteira();
            frm.ShowDialog();
        }

        private void PesquisarEmpreteira_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new EmpreteiraTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value));
                    MessageBox.Show("Empreteira Excluida com Sucesso","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir Empreteiro.\n"+ex.Message, "Message de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
