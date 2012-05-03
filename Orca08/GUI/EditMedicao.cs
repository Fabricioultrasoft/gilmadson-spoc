using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orca08.GUI
{
    public partial class EditMedicao : Form
    {
        private int linhaEdicao = 0;
        private string FOLHA = "";
        private int count = 1;
        private string FOLHAATUAL = ""; 
        public EditMedicao(int Linha,string Folha)
        {
            InitializeComponent();
            linhaEdicao = Linha;
            FOLHAATUAL = Folha;
        }

        private void cabMediBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            //this.Validate();
            //this.cabMediBindingSource1.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.orcaDataSet);
            
            this.cabMediTableAdapter1.Update(this.orcaDataSet.CabMedi);
            

        }

        private void EditMedicao_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'orcaDataSet.CabMedi' table. You can move, or remove it, as needed.
            this.cabMediTableAdapter1.Fill(this.orcaDataSet.CabMedi);           
            this.cabMediBindingSource1.Filter = "FOLHA = '" + FOLHAATUAL + "'";
            
        }



        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            new Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter().ALTERALLSERVICE(fOLHATextBox.Text, ANTIGONUMEROTxtBox.Text);
            this.Validate();
            this.cabMediBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.orcaDataSet);
            //this.cabMediTableAdapter1.Update(this.orcaDataSet.CabMedi);
        }

        private void BttServico_Click(object sender, EventArgs e)
        {
            Form frm = new ServicoMedicao(fOLHATextBox.Text);
            frm.Show();
        }

        private void fOLHATextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
