using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;

namespace SCOOP.GUI
{
    public partial class EstornoOrcamentoContratado : Form
    {
        public string Orçamento;
        public EstornoOrcamentoContratado(string CodigoOrçamento)
        {
            InitializeComponent();
            Orçamento = CodigoOrçamento;
            OrcamentotextBox.Text = Orçamento;
        }
        /// <summary>
        /// Estornar Orçamento Contratado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string ExisteMedicao = "";
            try
            {
                ExisteMedicao = new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().VerificarSeExisteMedicaoOrcamentoContratado(OrcamentotextBox.Text).ToString();
            }
            catch (Exception ex)
            {
                ExisteMedicao = "";
            }
            string erro = null;
            try
            {
               
                if (ExisteMedicao == "")
                {
                   
                    try
                    {

                        new SCOOP.DAO.SCOOPDataSetTableAdapters.ContratoTableAdapter().Delete(new SCOOP.DAO.SCOOPDataSetTableAdapters.ContratoTableAdapter().ObterCodigoContrato(OrcamentotextBox.Text));
                        ContratopictureBox.Image = global::SCOOP.Properties.Resources.ok;
                        

                    }
                    catch (Exception ex)
                    {
                        ContratopictureBox.Image = global::SCOOP.Properties.Resources.errado;
                        erro = "Problema ao estornar o contrato!";
                    }
                    try
                    {
                        new SCOOP.DAO.SCOOPDataSetTableAdapters.Orc_Cont_ServicoTableAdapter().Delete(OrcamentotextBox.Text);
                        ServicopictureBox.Image = global::SCOOP.Properties.Resources.ok;
                        
                    }
                    catch (Exception ex)
                    {
                        ServicopictureBox.Image = global::SCOOP.Properties.Resources.errado;
                        erro = "\nProblema ao estornar o Serviço do orçamento contratado!";
                    }
                    try
                    {
                        new SCOOP.DAO.SCOOPDataSetTableAdapters.Dotacao_Orc_ContTableAdapter().Delete(OrcamentotextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        erro = "\nProblema ao estornar as dotações do orçamento contratado.";
                    }

                    try
                    {
                        new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().Delete((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter().ObterSequencialOrcamentoContratado((int)new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter().ObterSequencialOrcamento(OrcamentotextBox.Text)));
                        OrcamentoContratadopictureBox.Image = global::SCOOP.Properties.Resources.ok;
                        OrdemServicopictureBox.InitialImage = global::SCOOP.Properties.Resources.ok;
                    }
                    catch (Exception ex)
                    {
                        OrcamentoContratadopictureBox.Image = global::SCOOP.Properties.Resources.errado;
                        OrdemServicopictureBox.InitialImage = global::SCOOP.Properties.Resources.errado;
                        erro = "\nProblema ao estornar no orçamento contratado!";
                    }

                }
                else
                {
                    MessageBox.Show("Deve excluir todas as medições!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro\n" + ex.Message + erro);
            }
        }
    }
};