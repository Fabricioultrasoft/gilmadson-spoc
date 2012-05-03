using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCOOP.Properties;
using SCOOP.DAO.SCOOPDataSetTableAdapters;

namespace SCOOP
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Permissoes = null;
            string Sequencial = new OrcaUsuarioTableAdapter().ObterSequencial().ToString();
            SqlConnection conn = new SqlConnection(Settings.Default.SCOOPConnectionString);
            if (TxtBoxSenha.Text == textBoxConfirmaSenha.Text)
            {
                try
                {
                    new OrcaUsuarioTableAdapter().Insert(Sequencial, TxtBoxNome.Text, TxtBoxSenha.Text, textBoxLogin.Text, TxtBoxFuncao.Text);

                    #region [SCOOP].[dbo].Criação usuario
                    SqlCommand cmd = new SqlCommand("CREATE LOGIN [" + textBoxLogin.Text + "] WITH PASSWORD=N'" + TxtBoxSenha.Text + "', DEFAULT_DATABASE=[SCOOP], DEFAULT_LANGUAGE=[Português (Brasil)], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON");
                    cmd.Connection = conn;
                    //Criando Usuario no Banco de Dados
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "create user " + textBoxLogin.Text + " from login " + textBoxLogin.Text;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "exec sp_addrolemember 'DB_DATAREADER', '" + textBoxLogin.Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Criar Usuario no Banco de dados.\n" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    if (ConsultarcheckBox.Checked)
                    {
                        try
                        {
                            cmd.CommandText = "grant select on [SCOOP].[dbo].Bairro to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Categoria to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Contrato to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Empreteira to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Fiscalizacao to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Fornecedor to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Grupo to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].GrupoInsumo to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].GrupoMedicao to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Insumos to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Med_Servico to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Medicao to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Orc_Servico to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Orcamento to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].OrcaUsuario to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Ser_Composicao to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Servico to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].subcategoria to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Tipo_Orcamento to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].TipoInsumo to " + textBoxLogin.Text +
                                              " grant select on [SCOOP].[dbo].Unidade to " + textBoxLogin.Text;
                            conn.Open();

                            cmd.ExecuteNonQuery();
                            Permissoes = " SELECT ";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro permitir consultar no banco.\n" + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }

                    if (InserircheckBox.Checked)
                    {
                        try
                        {
                            cmd.CommandText = "grant insert on [SCOOP].[dbo].Bairro to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Categoria to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Contrato to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Empreteira to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Fiscalizacao to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Fornecedor to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Grupo to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].GrupoInsumo to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].GrupoMedicao to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Insumos to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Med_Servico to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Medicao to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Orc_Servico to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Orcamento to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].OrcaUsuario to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Ser_Composicao to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Servico to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].subcategoria to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Tipo_Orcamento to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].TipoInsumo to " + textBoxLogin.Text +
                                              " grant insert on [SCOOP].[dbo].Unidade to " + textBoxLogin.Text;
                            conn.Open();

                            cmd.ExecuteNonQuery();
                            Permissoes += " INSERT ";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro oa dar permissão de Inserir no banco.\n" + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                    if (AlterarcheckBox.Checked)
                    {
                        try
                        {
                            cmd.CommandText = "grant update on [SCOOP].[dbo].Bairro to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Categoria to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Contrato to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Empreteira to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Fiscalizacao to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Fornecedor to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Grupo to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].GrupoInsumo to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].GrupoMedicao to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Insumos to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Med_Servico to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Medicao to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Orc_Servico to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Orcamento to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].OrcaUsuario to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Ser_Composicao to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Servico to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].subcategoria to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Tipo_Orcamento to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].TipoInsumo to " + textBoxLogin.Text +
                                              " grant update on [SCOOP].[dbo].Unidade to " + textBoxLogin.Text;
                            conn.Open();

                            cmd.ExecuteNonQuery();
                            Permissoes += " UPDATE ";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro oa dar permissão de alterar no banco.\n" + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                    if (ExcluircheckBox.Checked)
                    {
                        try
                        {
                            cmd.CommandText = "grant delete on [SCOOP].[dbo].Bairro to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Categoria to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Contrato to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Empreteira to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Fiscalizacao to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Fornecedor to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Grupo to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].GrupoInsumo to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].GrupoMedicao to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Insumos to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Med_Servico to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Medicao to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Orc_Servico to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Orcamento to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].OrcaUsuario to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Ser_Composicao to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Servico to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].subcategoria to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Tipo_Orcamento to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].TipoInsumo to " + textBoxLogin.Text +
                                              " grant delete on [SCOOP].[dbo].Unidade to " + textBoxLogin.Text;
                            conn.Open();

                            cmd.ExecuteNonQuery();
                            Permissoes += " DELETE ";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro oa dar permissão de exclusão no banco.\n" + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                    #endregion
                    MessageBox.Show("Usuario Cadastrado com Sucesso.\nCom Permissões de:" + Permissoes + ".");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro a cadastrar Usuario.\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Senha não confere!\n Redigite senha.");
            }
        }



        private void ConsultarcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

    }
}


