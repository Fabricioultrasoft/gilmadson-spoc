using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SCOOP.Properties;

namespace SCOOP.GUI
{
    public partial class PesquiarOrcamentoContratado : Form
    {
        CadastroOrcamentocs InstanciaOrcamento = null;
        CadastroOrcamentocontratado InstanciaOrcamentoCadastrado = null;
        CadastroMedicao InstanciaMedicao = null;
        public PesquiarOrcamentoContratado(CadastroMedicao CadastroMedicao, CadastroOrcamentocs CadastroOrcamentocs, CadastroOrcamentocontratado CadastroOrcamentoContratado)
        {
            InitializeComponent();
            InstanciaMedicao = CadastroMedicao;
            InstanciaOrcamento = CadastroOrcamentocs;
            InstanciaOrcamentoCadastrado = CadastroOrcamentoContratado;
        }

        private void PesquiarServico_Load(object sender, EventArgs e)
        {
            

            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Orcamento' table. You can move, or remove it, as needed.
                this.orcamentoTableAdapter.FillBy3(this.sCOOPDataSet.Orcamento);
            }
            catch (Exception )
            { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InstanciaMedicao != null)
                InstanciaMedicao.ImportaOrcamento(OrcamentodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());
            if (InstanciaOrcamentoCadastrado != null)
                InstanciaOrcamentoCadastrado.ImportarOrcamento(OrcamentodataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString());

            this.Close();
        }

        private void BttBuscar_Click(object sender, EventArgs e)
        {
            orcamentoBindingSource.Filter = "Descricao like '%'+" + TxtBoxServico.Text + "'%'";            
        }

        private void PesquiarOrcamento_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BttBuscar_Click(null, null);
            }
        }

        private void OrcamentodataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < OrcamentodataGridView1.RowCount; i++)
            {
                SCOOP.DAO.SCOOPDataSet.Orcamento_ContratadoDataTable Dt = new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().GetDataBy11(Convert.ToInt32(OrcamentodataGridView1.Rows[i].Cells[1].Value));
                foreach (SCOOP.DAO.SCOOPDataSet.Orcamento_ContratadoRow linha in Dt)
                {
                    OrcamentodataGridView1.Rows[i].Cells[0].Value = linha.Sequencial.ToString();
                    OrcamentodataGridView1.Rows[i].Cells[5].Value = new SCOOP.DAO.SCOOPDataSetTableAdapters.EmpresaTableAdapter().ObterDescricaoEmpresa(linha.Empresa);
                    OrcamentodataGridView1.Rows[i].Cells[6].Value = new SCOOP.DAO.SCOOPDataSetTableAdapters.LicitadoTableAdapter().ObterDescricaoLicitacao(linha.Licitado);
                    OrcamentodataGridView1.Rows[i].Cells[7].Value = new SCOOP.DAO.SCOOPDataSetTableAdapters.SecretariaTableAdapter().ObterDescricaoSecretaria(linha.Secretaria);
                    OrcamentodataGridView1.Rows[i].Cells[8].Value = linha.Empresa;
                    OrcamentodataGridView1.Rows[i].Cells[9].Value = linha.Licitado;
                    OrcamentodataGridView1.Rows[i].Cells[10].Value = linha.Secretaria;
                    OrcamentodataGridView1.Rows[i].Cells[11].Value = linha.CPF_CNPJ;
                    OrcamentodataGridView1.Rows[i].Cells[12].Value = linha.Prazo;
                    OrcamentodataGridView1.Rows[i].Cells[13].Value = linha.Data_Criacao;
                    OrcamentodataGridView1.Rows[i].Cells[14].Value = linha.Usuario;
                    OrcamentodataGridView1.Rows[i].Cells[15].Value = linha.Data_alteracao;
                    OrcamentodataGridView1.Rows[i].Cells[16].Value = linha.OrdemServico;
                    OrcamentodataGridView1.Rows[i].Cells[17].Value = linha.Data_final;
                }
            }
        }

        private void BttLimparFiltro_Click(object sender, EventArgs e)
        {
            orcamentoBindingSource.Filter = "";
        }

    }
}
