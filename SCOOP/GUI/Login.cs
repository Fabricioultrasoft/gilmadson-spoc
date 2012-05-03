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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = (VerificarLogin() ? DialogResult.OK : DialogResult.None);
            if (this.DialogResult == DialogResult.None)
            {
                MessageBox.Show("Usuario ou Senha Inválidos!\n\n Verifique se o CAPS LOCK num está ativado!");
            }
        }

        public bool VerificarLogin()
        {

            SqlConnection conn = new SqlConnection(SCOOP.Properties.Settings.Default.SCOOPConnectionString);
            SqlDataReader DataReader;
            SqlCommand cmd = new SqlCommand("select * from Usuario where Nome = @Nome and senha = @senha");
            cmd.Connection = conn;
            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = TxtBoxUsername.Text.ToUpper();
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = TxtBoxSenha.Text;

            try
            {
                conn.Open();
                DataReader = cmd.ExecuteReader();

                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        Settings.Default.Usuario = DataReader.GetString(1);
                        Settings.Default.Codigo = DataReader.GetDecimal(0).ToString();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
                MessageBox.Show("Usuario não existe!");

            }
            catch (Exception e)
            {
                MessageBox.Show("Usuario e Senha Incorretos!");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Top = 200;

            this.Left = 200;

            this.Width = 300;

            this.Left = 300;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
