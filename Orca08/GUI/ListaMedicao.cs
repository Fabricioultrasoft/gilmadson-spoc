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
    public partial class ListaMedicao : Form
    {
        public ListaMedicao()
        {
            InitializeComponent();
        }

        private void ListaMedicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orcaDataSet.EMPREITA' table. You can move, or remove it, as needed.
            this.eMPREITATableAdapter.Fill(this.orcaDataSet.EMPREITA);
            // TODO: This line of code loads data into the 'orcaDataSet.CabMedi' table. You can move, or remove it, as needed.
            this.cabMediTableAdapter1.Fill(this.orcaDataSet.CabMedi);
            
        }        

        private void cabMediDataGridView_DoubleClick(object sender, EventArgs e)
        {

            Form frm = new EditMedicao(Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text), cabMediDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)-1].Cells[0].Value.ToString());
            frm.ShowDialog();
            this.cabMediTableAdapter1.Fill(this.orcaDataSet.CabMedi);

        }

        private void cabMediBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cabMediBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.orcaDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cabMediTableAdapter1.Fill(this.orcaDataSet.CabMedi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Relatorios1(/*null,cabMediDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString()*/);
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MEDICAO")
            {
                PesquisarcomboBox.DataSource = cabMediBindingSource;
                PesquisarcomboBox.DisplayMember = "FOLHA";
                PesquisarcomboBox.ValueMember = "FOLHA";
            }
            else if (comboBox1.Text == "EMPRETEIRO")
            {
                PesquisarcomboBox.DataSource = eMPREITABindingSource;
                PesquisarcomboBox.DisplayMember = "NOMEFOR";
                PesquisarcomboBox.ValueMember = "Codigo";
            }
            else if (comboBox1.Text == "DATA")
            {
                PesquisarcomboBox.DataSource = cabMediBindingSource;
                PesquisarcomboBox.DisplayMember = "DATA";
                PesquisarcomboBox.ValueMember = "DATA";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cabMediBindingSource.Filter = "";
            if (comboBox1.Text == "MEDICAO")
            {
               cabMediBindingSource.Filter = "FOLHA = '" + PesquisarcomboBox.Text + "'";
            }
            else if (comboBox1.Text == "EMPRETEIRO")
            {
                cabMediBindingSource.Filter = "CODEMPRE = " + PesquisarcomboBox.SelectedValue.ToString();
            }
            else if (comboBox1.Text == "DATA")
            {
                cabMediBindingSource.Filter = "DATA = '" + PesquisarcomboBox.Text + "'";
            }
            else
            {
                comboBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cabMediBindingSource.Filter = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar a Medição e os Serviços.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try { new DAL.OrcaDataSetTableAdapters.DetmediTableAdapter().ApagarTodosServiços(cabMediDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString()); }
                catch (Exception ex) { }
                try { new DAL.OrcaDataSetTableAdapters.CabMediTableAdapter().ApagarMedicao(cabMediDataGridView.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value.ToString()); }
                catch (Exception ex) { }
                this.cabMediTableAdapter1.Fill(this.orcaDataSet.CabMedi);
            }
        }
    }
}
