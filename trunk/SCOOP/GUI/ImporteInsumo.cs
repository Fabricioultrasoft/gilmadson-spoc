using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCOOP.GUI
{
    public partial class ImporteInsumo : Form
    {
        public static Principal FrmPrincipal;
        public ImporteInsumo(Principal principal)
        {
            FrmPrincipal = principal;
            InitializeComponent();
        }

        private void oRCA_SCOOP_MATERIALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRCA_SCOOP_MATERIALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sCOOPDataSet);

        }

        private void ImporteInsumo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCOOPDataSet.ORCA_SCOOP_MATERIAL' table. You can move, or remove it, as needed.
            this.oRCA_SCOOP_MATERIALTableAdapter.Fill(this.sCOOPDataSet.ORCA_SCOOP_MATERIAL);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.oRCA_SCOOP_MATERIALTableAdapter.FillBy(this.sCOOPDataSet.ORCA_SCOOP_MATERIAL, dESCRICAOToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                FrmPrincipal.AbreForm(new CadastroInsumos("0", oRCA_SCOOP_MATERIALDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), oRCA_SCOOP_MATERIALDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString(), oRCA_SCOOP_MATERIALDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString()));
                //Form frm = new CadastroInsumos(null, oRCA_SCOOP_MATERIALDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), oRCA_SCOOP_MATERIALDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString(), oRCA_SCOOP_MATERIALDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[3].Value.ToString());
                //frm.ShowDialog();
            }
            catch (Exception ex)
            { }
        }
    }
}
