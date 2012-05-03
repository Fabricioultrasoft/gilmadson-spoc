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
using SCOOP.DAO.SCOOPDataSetTableAdapters;
using SCOOP.DAO;
using System.Globalization;

namespace SCOOP
{
    public partial class CadastroComposicao : Form
    {
        private string Codigo,descricao,unidade,preco = null;
        
        public CadastroComposicao(string valor,string Descricao,string Unidade,string Preco)
        {
            InitializeComponent();
            Codigo = valor;
            this.descricao = Descricao;
            this.unidade = Unidade;
            this.preco = Preco;
            GrupoComboBox.Focus();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sCOOPDataSet);

        }

        private void CadastroComposicao_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sCOOPDataSet.Unidade' table. You can move, or remove it, as needed.
                this.unidadeTableAdapter.Fill(this.sCOOPDataSet.Unidade);
                unidadeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                unidadeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                // TODO: This line of code loads data into the 'sCOOPDataSet.Composicao' table. You can move, or remove it, as needed.
                this.composicaoTableAdapter.FillBy(this.sCOOPDataSet.Composicao, CodigomaskedTextBox.Text.Replace(",", "."));
                // TODO: This line of code loads data into the 'sCOOPDataSet.Atividade' table. You can move, or remove it, as needed.
                this.atividadeTableAdapter.Fill(this.sCOOPDataSet.Atividade);
                AtividadeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                AtividadeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                // TODO: This line of code loads data into the 'sCOOPDataSet.Etapa' table. You can move, or remove it, as needed.
                this.etapaTableAdapter.Fill(this.sCOOPDataSet.Etapa);
                EtapaComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                EtapaComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                // TODO: This line of code loads data into the 'sCOOPDataSet.Grupo' table. You can move, or remove it, as needed.
                this.grupoTableAdapter.Fill(this.sCOOPDataSet.Grupo);
                GrupoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                GrupoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                // TODO: This line of code loads data into the 'sCOOPDataSet.Servico' table. You can move, or remove it, as needed.
                this.servicoTableAdapter.Fill(this.sCOOPDataSet.Servico);
            }
            catch (Exception ) { }
            GrupoComboBox.Text = "";
            EtapaComboBox.Text = "";
            AtividadeComboBox.Text = "";
            unidadeComboBox.Text = "";
            descricaoServicoTextBox.Text = descricao;
            unidadeComboBox.Text = unidade;
            ValortextBox.Text = preco;
            if (Codigo != null && Codigo != "0")
            {
                EditarComposicao();
            }

        }

        private void CadastrarServicoButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ServicoTableAdapter().Insert(CodigomaskedTextBox.Text.Replace(",", "."), descricaoServicoTextBox.Text, unidadeComboBox.Text, (int)GrupoComboBox.SelectedValue, (int)EtapaComboBox.SelectedValue, (int)AtividadeComboBox.SelectedValue, Convert.ToDecimal(leiSocialTextBox.Text == "" ? "0" : leiSocialTextBox.Text), Convert.ToDecimal(encargoTextBox.Text == "" ? "0" : encargoTextBox.Text));
                //GrupoBoxComponentes.Enabled = true;
                CadastrarServicoButton.Enabled = false;
                groupBox1.Enabled = false;
                //mskTxtBoxCodInsumo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a gravar Serviço! " + ex.Message);
                //GrupoBoxComponentes.Enabled = false;
                groupBox1.Enabled = true;

            }
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            SCOOP.DAO.SCOOPDataSet.InsumoDataTable Dt = new InsumoTableAdapter().GetDataBy(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            foreach (SCOOP.DAO.SCOOPDataSet.InsumoRow linha in Dt)
            {
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = linha.Descricao;
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = linha.Unidade;
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = linha.Preco.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[7].Value = Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value) * linha.TipoInsumo == 3 ? linha.Preco + linha.Preco * Convert.ToDecimal("1,2558") : linha.Preco);
            }

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!CodigomaskedTextBox.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
        }

        private void CodigoInsumomaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CodigoInsumomaskedTextBox.Text.Length == 12)
            {
                SCOOPDataSet.InsumoDataTable Dt = new InsumoTableAdapter().GetDataBy(CodigoInsumomaskedTextBox.Text.Replace(",", "."));

                foreach (SCOOPDataSet.InsumoRow linha in Dt)
                {
                    descricaoInsumotextBox.Text = linha.Descricao;
                    UnidadetextBox.Text = linha.Unidade;
                    ValortextBox.Text = Convert.ToString(linha.TipoInsumo == 3 ? linha.Preco + linha.Preco * Convert.ToDecimal("1,2558") : linha.Preco);
                }
                QuantidadetextBox.Focus();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (QuantidadetextBox.Text != "")
            {
                decimal Quantidade = 0;
                try
                {

                    Quantidade = Convert.ToDecimal(String.Format("{0:D4}",QuantidadetextBox.Text.Replace(".",",")));
                    new ComposicaoTableAdapter().Insert(CodigomaskedTextBox.Text.Replace(",", "."), CodigoInsumomaskedTextBox.Text.Replace(",", "."), Quantidade, Convert.ToInt32(new ServicoTableAdapter().ObterSequencialServico(CodigomaskedTextBox.Text.Replace(",", ".")).Value), Convert.ToInt32(new InsumoTableAdapter().ObterSequencialInsumo(CodigoInsumomaskedTextBox.Text.Replace(",", ".")).Value));
                    this.composicaoTableAdapter.FillBy(this.sCOOPDataSet.Composicao, CodigomaskedTextBox.Text.Replace(",", "."));
                    //Preencher_dataGridView();
                    CancelarButton_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir Composição\n" + ex.Message);
                }
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SCOOPDataSet.InsumoDataTable Dt = new InsumoTableAdapter().GetDataBy(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            foreach (SCOOPDataSet.InsumoRow linha in Dt)
            {
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = linha.Descricao;
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = linha.Unidade;
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = linha.Preco.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[7].Value = Convert.ToString(Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value) * linha.TipoInsumo == 3 ? linha.Preco+linha.Preco * Convert.ToDecimal("1,2558") : linha.Preco);
            }
        }

        private void Preencher_dataGridView()
        {
            TotalMaterialtxtBox.Text = "";
            TotalMObraEncargosTxtBox.Text = "";
            TotalMObraMaterial.Text = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SCOOPDataSet.InsumoDataTable Dt = new InsumoTableAdapter().GetDataBy(dataGridView1.Rows[i].Cells[2].Value.ToString());
                
                foreach (SCOOPDataSet.InsumoRow linha in Dt)
                {
                    dataGridView1.Rows[i].Cells[3].Value = linha.Descricao;
                    dataGridView1.Rows[i].Cells[4].Value = linha.Unidade;
                    
                    
                    if (linha.TipoInsumo == 3)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = String.Format("{0:C2}", linha.Preco+linha.Preco * Convert.ToDecimal("1,2558"));
                        dataGridView1.Rows[i].Cells[7].Value = String.Format("{0:C2}", Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) * (linha.Preco + linha.Preco * Convert.ToDecimal("1,2558")));
                        ObterTotalMObraEncargo(Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value.ToString().Replace("R$","")));
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[6].Value = String.Format("{0:C2}", linha.Preco);
                        dataGridView1.Rows[i].Cells[7].Value = String.Format("{0:C2}", Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value) * linha.Preco);
                        ObterTotalMaterial(Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value.ToString().Replace("R$", "")));
                    }
                }
            }
            TotalMObraMaterial.Text = String.Format("{0:C2}", Convert.ToDecimal(TotalMObraEncargosTxtBox.Text.Replace("R$", "") == "" ? "0" : TotalMObraEncargosTxtBox.Text.Replace("R$", "")) + Convert.ToDecimal(TotalMaterialtxtBox.Text.Replace("R$", "") == "" ? "0" : TotalMaterialtxtBox.Text.Replace("R$", "")));
        }

        public void ObterTotalMObraEncargo(decimal Valor)
        {
            TotalMObraEncargosTxtBox.Text = String.Format("{0:C2}", Convert.ToDecimal(TotalMObraEncargosTxtBox.Text.Replace("R$", "") == "" ? "0" : TotalMObraEncargosTxtBox.Text.Replace("R$", "")) + (Valor));
            
        }

        public void ObterTotalMaterial(decimal Valor)
        {
            TotalMaterialtxtBox.Text = String.Format("{0:C2}", Convert.ToDecimal(TotalMaterialtxtBox.Text.Replace("R$", "") == "" ? "0" : TotalMaterialtxtBox.Text.Replace("R$", "")) + (Valor));
        }

         private void GrupoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.etapaTableAdapter.FillBy(this.sCOOPDataSet.Etapa, new System.Nullable<int>(((int)(System.Convert.ChangeType(GrupoComboBox.SelectedValue, typeof(int))))));
                EtapaComboBox.Text = "";
                AtividadeComboBox.Text = "";
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

         private void EtapaComboBox_SelectedIndexChanged(object sender, EventArgs e)
         {
             
                 try
                 {
                     if (EtapaComboBox.SelectedValue.ToString().Length == 2)
                     {
                         CodigomaskedTextBox.Text = "0" + EtapaComboBox.SelectedValue.ToString() + CodigomaskedTextBox.Text.Substring(4);
                     }
                     else if (EtapaComboBox.SelectedValue.ToString().Length == 1)
                     {
                         CodigomaskedTextBox.Text = "00" + EtapaComboBox.SelectedValue.ToString() + CodigomaskedTextBox.Text.Substring(4);
                     }
                     else
                     {
                         CodigomaskedTextBox.Text = EtapaComboBox.SelectedValue.ToString() + CodigomaskedTextBox.Text.Substring(4);
                     }
                     this.atividadeTableAdapter.FillBy(this.sCOOPDataSet.Atividade, (int)EtapaComboBox.SelectedValue);
                     AtividadeComboBox.Text = "";
                 }
                 catch (Exception )
                 {

                 }
         }


         private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Deseja Excluir?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 try
                 {
                     new ComposicaoTableAdapter().Delete(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value), dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[1].Value.ToString(), dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[5].Value), Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[8].Value), Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[9].Value));
                     this.composicaoTableAdapter.FillBy(this.sCOOPDataSet.Composicao, CodigomaskedTextBox.Text);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Erro ao Excluir a Composicção.\n" + ex.Message);
                 }
             }
         }

         private void bindingNavigatorEdit_Click(object sender, EventArgs e)
         {
             CodigoInsumomaskedTextBox.Text = dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString();
             CodigoInsumomaskedTextBox_TextChanged(null,null);
             QuantidadetextBox.Text = dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[5].Value.ToString();
             ConfirmarButton.Visible = true;
             CancelarButton.Visible = true;
         }

         private void ConfirmarButton_Click(object sender, EventArgs e)
         {
             try
             {
                 new ComposicaoTableAdapter().Update(CodigomaskedTextBox.Text.Replace(",", "."), CodigoInsumomaskedTextBox.Text.Replace(",", "."), Convert.ToDecimal(QuantidadetextBox.Text), Convert.ToInt32(new ServicoTableAdapter().ObterSequencialServico(CodigomaskedTextBox.Text.Replace(",", ".")).Value), Convert.ToInt32(new InsumoTableAdapter().ObterSequencialInsumo(CodigoInsumomaskedTextBox.Text).Value), CodigomaskedTextBox.Text.Replace(",", "."), dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[2].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(bindingNavigatorPositionItem.TextBox.Text) - 1].Cells[0].Value));
                 this.composicaoTableAdapter.FillBy(this.sCOOPDataSet.Composicao, CodigomaskedTextBox.Text.Replace(",", "."));
                 //Preencher_dataGridView();
                 CancelarButton_Click(null, null);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao Alterar Composição.\n"+ex.Message);
             }
         }

         private void CancelarButton_Click(object sender, EventArgs e)
         {
             CodigoInsumomaskedTextBox.Text = "";
             descricaoInsumotextBox.Text = "";
             UnidadetextBox.Text = "";
             QuantidadetextBox.Text = "";
             ValortextBox.Text = "";
             ConfirmarButton.Visible = false;
             CancelarButton.Visible = false;

         }
        
         private void NovoButton_Click(object sender, EventArgs e)
         {
             //Serviço zerando
             CodigomaskedTextBox.Text = "";
             GrupoComboBox.Text = "";
             EtapaComboBox.Text = "";
             AtividadeComboBox.Text = "";
             descricaoServicoTextBox.Text = "";
             unidadeComboBox.Text = "";
             leiSocialTextBox.Text = "";
             encargoTextBox.Text = "";
             CadastrarServicoButton.Visible = true;
             BttAtualizar.Visible = false;

             //Insumo
             CodigoInsumomaskedTextBox.Text = "";
             descricaoInsumotextBox.Text = "";
             UnidadetextBox.Text = "";
             QuantidadetextBox.Text = "";
             ValortextBox.Text = "";
             try
             {
                 //gridview
                 this.composicaoTableAdapter.FillBy(this.sCOOPDataSet.Composicao, CodigomaskedTextBox.Text);
             }
             catch (Exception ) { }
         }

         private void AtividadeComboBox_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                 if (CodigomaskedTextBox.Text.Length != 12)
                 {
                     if (AtividadeComboBox.SelectedValue.ToString().Length == 2)
                     {
                         CodigomaskedTextBox.Text = CodigomaskedTextBox.Text.Substring(0, 4) + "0" + AtividadeComboBox.SelectedValue.ToString() + CodigomaskedTextBox.Text.Substring(6);
                         ObterSequencial("0" + AtividadeComboBox.SelectedValue.ToString());
                     }
                     else if (AtividadeComboBox.SelectedValue.ToString().Length == 1)
                     {
                         CodigomaskedTextBox.Text = CodigomaskedTextBox.Text.Substring(0, 4) + "00" + AtividadeComboBox.SelectedValue.ToString() + CodigomaskedTextBox.Text.Substring(6);
                         ObterSequencial("00" + AtividadeComboBox.SelectedValue.ToString());
                     }
                     else
                     {
                         CodigomaskedTextBox.Text = CodigomaskedTextBox.Text.Substring(0, 4) + AtividadeComboBox.SelectedValue.ToString() + CodigomaskedTextBox.Text.Substring(6);
                         ObterSequencial(AtividadeComboBox.SelectedValue.ToString());
                     }
                 }

             }
             catch (Exception )
             { }
         }

         public void ObterSequencial(string tipo)
         {
             #region ObterSequencia
             string CodigoServico = null;
             SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
             SqlDataReader Dr;
             SqlCommand cmd = new SqlCommand("select isnull(max(substring(cast(codigo as nvarchar),9,4)+1),1) from [SCOOP].[dbo].servico Where   substring(cast(codigo as nvarchar),5,3) = '" + tipo + "'");
             cmd.Connection = conn;
             try
             {
                 conn.Open();
                 Dr = cmd.ExecuteReader();
                 while (Dr.Read())
                 {
                     CodigoServico = Dr.GetInt32(0).ToString();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao Obter Codigo Serviço! " + ex.Message);
             }
             finally
             {
                 conn.Close();
             }
             //comboBox2_SelectedIndexChanged(null, null);
             //comboBox3_SelectedIndexChanged(null, null);
             if (CodigoServico.Length == 1)
             {
                 CodigomaskedTextBox.Text = CodigomaskedTextBox.Text.Substring(0,8) + "000" + CodigoServico;
             }
             else if (CodigoServico.Length == 2)
             {
                 CodigomaskedTextBox.Text = CodigomaskedTextBox.Text.Substring(0, 8) + "00" + CodigoServico;
             }
             else if (CodigoServico.Length == 3)
             {
                 CodigomaskedTextBox.Text = CodigomaskedTextBox.Text.Substring(0, 8) + "0" + CodigoServico;
             }
             else
             {
                 CodigomaskedTextBox.Text = CodigomaskedTextBox.Text + CodigoServico.Substring(3);
             }
             #endregion
         }

         private void leiSocialTextBox_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!leiSocialTextBox.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
         }

         private void encargoTextBox_KeyPress(object sender, KeyPressEventArgs e)
         {
             if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8)) { e.KeyChar = (Char)0; } else { if (e.KeyChar == '.' || e.KeyChar == ',') { if (!encargoTextBox.Text.Contains(",")) { e.KeyChar = ','; } else { e.KeyChar = (Char)0; } } }
         }

         private void button1_Click(object sender, EventArgs e)
         {
             Form frm = new PesquisarInsumo(this);
             frm.ShowDialog();
         }

         public void EditarComposicao()
         {
             if (Codigo != null)
             {
                 try
                 {
                     SCOOPDataSet.ServicoDataTable Dt = new ServicoTableAdapter().GetDataBy1(Codigo);

                     foreach (SCOOPDataSet.ServicoRow linha in Dt)
                     {
                         CodigomaskedTextBox.Text = linha.Codigo.Replace(".", "");
                         GrupoComboBox.Text = new GrupoTableAdapter().ObterDescricao(linha.Grupo);
                         EtapaComboBox.Text = new EtapaTableAdapter().ObterDescricao(linha.Etapa);
                         AtividadeComboBox.Text = new AtividadeTableAdapter().ObterDescricao(linha.Atividade,linha.Etapa).ToString();
                         descricaoServicoTextBox.Text = linha.Descricao;
                         unidadeComboBox.Text = linha.Unidade;
                         leiSocialTextBox.Text = linha.LeiSocial.ToString();
                         encargoTextBox.Text = linha.Encargo.ToString();
                         this.composicaoTableAdapter.FillBy(this.sCOOPDataSet.Composicao, linha.Codigo);
                     }
                     //groupBox1.Enabled = false;
                     CadastrarServicoButton.Visible = false;
                     BttAtualizar.Visible = true;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Erro ao carregar serviço e composição.\n"+ex.Message);
                 }
             }
         }

         private void BttAtualizar_Click(object sender, EventArgs e)
         {
             try
             {
                 //new ServicoTableAdapter().Update(CodigomaskedTextBox.Text, descricaoServicoTextBox.Text, unidadeComboBox.Text, (int)GrupoComboBox.SelectedValue, (int)EtapaComboBox.SelectedValue, (int)AtividadeComboBox.SelectedValue, Convert.ToDecimal(leiSocialTextBox.Text), Convert.ToDecimal(encargoTextBox.Text), CodigomaskedTextBox.Text, (int)new ServicoTableAdapter().ObterSequencialServico(CodigomaskedTextBox.Text).Value);

                 MessageBox.Show("Serviço atualizado com sucesso.");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao atualziar serviço.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
         {
             Preencher_dataGridView();
         }

         private void GrupoComboBox_TextChanged(object sender, EventArgs e)
         {
             //if(this.GrupoComboBox)
         }

    }
}
