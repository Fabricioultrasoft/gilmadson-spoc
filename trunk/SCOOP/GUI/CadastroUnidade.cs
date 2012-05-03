using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class CadastroUnidade : Form
    {
        public CadastroUnidade()
        {
            InitializeComponent();
        }

        private void BttIncluir_Click(object sender, EventArgs e)
        {
            try 
            {
                new UnidadeTableAdapter().Insert(TxtBoxDescricao.Text);
                MessageBox.Show("Unidade cadastrado com sucesso.");
                TxtBoxCodigo.Text = "";
                TxtBoxDescricao.Text = "";
                CadastroUnidade_Load(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Inserir Unidade;\n " + ex.Message); 
            }
        }

        private void unidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void CadastroUnidade_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Unidade' table. You can move, or remove it, as needed.
                this.unidadeTableAdapter1.Fill(this.sCOOPDataSet.Unidade);
            }
            catch (Exception ) { }
            try
            {
                TxtBoxCodigo.Text = new UnidadeTableAdapter().ObterSequencial().ToString();
            }
            catch (Exception ) { }


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            BttNovo_Click(null, null);

        }

        private void BttVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BttNovo_Click(object sender, EventArgs e)
        {
            TxtBoxCodigo.Text = "";
            TxtBoxDescricao.Text = "";
            BttIncluir.Visible = true;
            BttAlterar.Visible = false;
            CadastroUnidade_Load(null, null);

        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            TxtBoxCodigo.Text = Convert.ToString(unidadeDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value);
            TxtBoxDescricao.Text = Convert.ToString(unidadeDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value);
            tabControl1.SelectedTab = tabPage1;
            BttIncluir.Visible = false;
            BttAlterar.Visible = true;
        }

        private void BttAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new UnidadeTableAdapter().Update(TxtBoxDescricao.Text, Convert.ToInt32(TxtBoxCodigo.Text));
                tabControl1.SelectedTab = tabPage2;
                this.unidadeTableAdapter1.Fill(this.sCOOPDataSet.Unidade);
                MessageBox.Show("Unidade Alterada com sucesso.");
            }
            catch (Exception ) { }
        }

        private void pesquisarToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.unidadeTableAdapter1.FillBy(this.sCOOPDataSet.Unidade, descricaoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CadastroUnidade_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
