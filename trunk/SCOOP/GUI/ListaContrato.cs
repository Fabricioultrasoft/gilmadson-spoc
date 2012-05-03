using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.GUI;

namespace SCOOP
{
    public partial class ListaContrato : Form
    {
        public ListaContrato()
        {
            InitializeComponent();
        }

        private void ListaServico_Load(object sender, EventArgs e)
        {
            try{
                // TODO: This line of code loads data into the 'sCOOPDataSet.Contrato' table. You can move, or remove it, as needed.
                this.contratoTableAdapter.Fill(this.sCOOPDataSet.Contrato);            }
            catch (Exception ) { }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BttPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.contratoTableAdapter.FillBy(this.sCOOPDataSet.Contrato, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = new Contrato(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text)-1].Cells[1].Value.ToString());
            frm.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void ListaContrato_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
