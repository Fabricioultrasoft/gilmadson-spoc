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
    public partial class ServicoMedicao : Form
    {
        private string FOLHAMEDICAO = "";
        public ServicoMedicao(string FOLHA)
        {
            InitializeComponent();
            this.FOLHAMEDICAO = FOLHA;

        }

        private void detmediBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detmediBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orcaDataSet);

        }

        private void ServicoMedicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orcaDataSet.Detmedi' table. You can move, or remove it, as needed.
            this.detmediTableAdapter.FillBy(this.orcaDataSet.Detmedi,FOLHAMEDICAO);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form frm = new InserirServicoMedicao(FOLHAMEDICAO);
            frm.ShowDialog();
            this.detmediTableAdapter.FillBy(this.orcaDataSet.Detmedi, FOLHAMEDICAO);
        }
    }
}
