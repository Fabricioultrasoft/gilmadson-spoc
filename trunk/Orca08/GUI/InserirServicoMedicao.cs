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
    public partial class InserirServicoMedicao : Form
    {
        private string FOLHAATUAL = "";
        public InserirServicoMedicao(string FOLHA)
        {
            InitializeComponent();
            FOLHAATUAL = FOLHA;
            
        }

        private void detmediBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detmediBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orcaDataSet);

        }

        private void InserirServicoMedicao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orcaDataSet.Padrao' table. You can move, or remove it, as needed.
            this.padraoTableAdapter.Fill(this.orcaDataSet.Padrao);
            // TODO: This line of code loads data into the 'orcaDataSet.Detmedi' table. You can move, or remove it, as needed.
            this.detmediTableAdapter.Fill(this.orcaDataSet.Detmedi);
            cODComboBox.Text = "";
            fOLHATextBox.Text = FOLHAATUAL;
            cODATTextBox.Text = new Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter().ObterNovoNumeroCODAT().Value.ToString();
        }

        private void cODComboBox_TextChanged(object sender, EventArgs e)
        {

            if (new Orca08.DAL.OrcaDataSetTableAdapters.PadraoTableAdapter().VerificarExisteServico(cODComboBox.Text).HasValue)
            {
                Orca08.DAL.OrcaDataSet.PadraoDataTable Dt = new Orca08.DAL.OrcaDataSetTableAdapters.PadraoTableAdapter().GetDataBy(cODComboBox.Text);

                foreach (Orca08.DAL.OrcaDataSet.PadraoRow Linha in Dt)
                {
                    uNTextBox.Text = Linha.UND;
                    dESCRICAOTextBox.Text = Linha.SUMARIA;
                    //qTDETextBox.Text = Linha.QTMEDI.ToString();
                    uNITTextBox.Text = Convert.ToString(Linha.M_OBRA + Linha.MATERIAL);
                    //vtotalTextBox.Text = Convert.ToString(Linha.QTMEDI + (Linha.M_OBRA + Linha.MATERIAL));
                }
            }   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter().Insert(FOLHAATUAL,
                                                                                    (int)new Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter().ObterNovoNumeroCODAT().Value,
                                                                                    cODComboBox.Text,
                                                                                    dESCRICAOTextBox.Text,
                                                                                    uNTextBox.Text,
                                                                                    Convert.ToDouble(qTDETextBox.Text),
                                                                                    Convert.ToDouble(uNITTextBox.Text),
                                                                                    Convert.ToDouble(vtotalTextBox.Text),
                                                                                    null,
                                                                                    null,
                                                                                    null,
                                                                                    0);
                MessageBox.Show("Serviço inserido com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar serviço!\n"+ex.Message);
            }

        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qTDETextBox_TextChanged(object sender, EventArgs e)
        {
            if(qTDETextBox.Text != "")
                vtotalTextBox.Text = Convert.ToString(Convert.ToDouble(qTDETextBox.Text) * Convert.ToDouble(uNITTextBox.Text));
        }
    }
}
