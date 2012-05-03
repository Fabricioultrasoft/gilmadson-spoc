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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new CadastroInsumos("0",null,null,null);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new ListaInsumos();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroEmpreteiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroEmpreteira();
            frm.ShowDialog();
        }

        private void cadastroMediçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ListaContrato();
            frm.ShowDialog();
        }


        private void tipoDeObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroObraTipo();
            frm.ShowDialog();
        }

        private void composiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroGrupoComposicao();
            frm.ShowDialog();
        }

        private void mediçãoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroGrupoMedicao(null);
            frm.ShowDialog();
        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroFiscalizador(null);
            frm.ShowDialog();
        }

        private void cadastroServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroComposicao(null,null,null,null);
            frm.ShowDialog();
        }

        private void listarComposiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orçamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroOrcamentocs(1);
            frm.ShowDialog();
        }

        private void mediçãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroMedicao(1);
            frm.ShowDialog();
        }

        private void cadastroBairrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroBairro();
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroMedicao(2);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Form frm = new CadastroInsumos("0",null,null,null);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void consultaToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form frm = new ListaInsumos();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cadasroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroComposicao("0",null,null,null);
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new ListaServico();
            frm.ShowDialog();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroGrupoInsumos();
            frm.ShowDialog();
        }

        private void unidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroUnidade();
            frm.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Fornecedor();
            frm.ShowDialog();
        }

        private void tipoInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new CadastroTipoInsumos();
            //frm.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Desenvolvedores();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroUsuario();
            frm.ShowDialog();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroOrcamentocs(2);
            frm.ShowDialog();
        }

        private void orçamentoContratadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CadastroOrcamentocontratado(1);
            frm.ShowDialog();
        }
    }
}
