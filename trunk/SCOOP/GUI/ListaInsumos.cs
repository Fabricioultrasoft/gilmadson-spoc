using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class ListaInsumos : Form
    {
        public ListaInsumos()
        {
            InitializeComponent();
        }

        private void ListaInsumos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.GrupoInsumo' table. You can move, or remove it, as needed.
                this.grupoInsumoTableAdapter.Fill(this.sCOOPDataSet.GrupoInsumo);
                // TODO: This line of code loads data into the 'sCOOPDataSet.TipoInsumo' table. You can move, or remove it, as needed.
                this.tipoInsumoTableAdapter.Fill(this.sCOOPDataSet.TipoInsumo);
                // TODO: This line of code loads data into the 'sCOOPDataSet.Insumo' table. You can move, or remove it, as needed.
                this.insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);

                ComboBoxTipoInsumo.Text = "";
                ComboBoxGrupo.Text = "";
            }
            catch (Exception ) { }

        }

        private void BttPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.insumoTableAdapter.FillBy(this.sCOOPDataSet.Insumo, TxtBoxNome.Text);
            }
            catch (System.Exception )
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroInsumos("0",null,null,null);
            frm.ShowDialog();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string Numero = bindingNavigatorPositionItem.TextBox.Text;

            if (MessageBox.Show("Apagar Registro", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    new InsumoTableAdapter().Delete((int)InsumosdataGridView1.Rows[Convert.ToInt32(Numero) - 1].Cells[0].Value, InsumosdataGridView1.Rows[Convert.ToInt32(Numero) - 1].Cells[1].Value.ToString());

                    insumoTableAdapter.Fill(this.sCOOPDataSet.Insumo);

                    MessageBox.Show("Deleção Realizada com Sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro Ao deletar Insumo. " + ex.Message);
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroInsumos(InsumosdataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString(),null,null,null);
            frm.ShowDialog();
        }

        private void ComboBoxTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.insumoTableAdapter.FillBy1(this.sCOOPDataSet.Insumo, (int)ComboBoxTipoInsumo.SelectedValue);
                this.insumoBindingSource.RemoveFilter();
                this.grupoInsumoTableAdapter.FillBy1(this.sCOOPDataSet.GrupoInsumo, (int)ComboBoxTipoInsumo.SelectedValue);
                ComboBoxGrupo.Text = "";
            }
            catch (System.Exception )
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(ComboBoxGrupo.Text != null && ComboBoxGrupo.Text != "")
                    this.insumoBindingSource.Filter = "(Grupo = " + ComboBoxGrupo.SelectedValue.ToString() + ")";
            }
            catch (System.Exception )
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ListaInsumos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void InsumosdataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < InsumosdataGridView1.RowCount; i++)
            {
                InsumosdataGridView1.Rows[i].Cells[9].Value = InsumosdataGridView1.Rows[i].Cells[9].Value.ToString().Replace("00", "");
            }
        }


    }
}
