using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCOOP
{
    public partial class Pergunta : Form
    {
        //public CadastroMedicao Instancia;
        public Pergunta(/*CadastroMedicao Medicao*/)
        {
            InitializeComponent();
            //Instancia = Medicao;
        }

        private void BttImprimir_Click(object sender, EventArgs e)
        {
            if (ChkBoxMedicao.Checked)
            {
                //Instancia.ImprimirMedicao("Medicao");
                this.Close();
            }
            else if (ChkBoxMedicaoEmBranco.Checked)
            {
                //Instancia.ImprimirMedicao("MedicaoEmBranco");
                this.Close();
            }
            else if (ChkBoxMedicaoValorQntEmBranco.Checked)
            {
                //Instancia.ImprimirMedicao("MedicaoValorQntEmBranco");
                this.Close();
            }
        }

        private void ChkBoxMedicao_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxMedicao.Checked)
            {
                ChkBoxMedicaoEmBranco.Checked = false;
                ChkBoxMedicaoValorQntEmBranco.Checked = false;
            }
            else
            {
                ChkBoxMedicaoEmBranco.Checked = true;
                ChkBoxMedicaoValorQntEmBranco.Checked = true;
            }

        }

        private void ChkBoxMedicaoEmBranco_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxMedicaoEmBranco.Checked)
            {
                ChkBoxMedicao.Checked = false;
                ChkBoxMedicaoValorQntEmBranco.Checked = false;
            }
            else
            {
                ChkBoxMedicao.Checked = true;
                ChkBoxMedicaoValorQntEmBranco.Checked = true;
            }
        }

        private void ChkBoxMedicaoValorQntEmBranco_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxMedicaoValorQntEmBranco.Checked)
            {
                ChkBoxMedicao.Checked = false;
                ChkBoxMedicaoEmBranco.Checked = false;
            }
            else
            {
                ChkBoxMedicao.Checked = true;
                ChkBoxMedicaoEmBranco.Checked = true;
            }
        }

        private void Pergunta_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
