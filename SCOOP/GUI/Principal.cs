using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Orca08;
using SCOOP.GUI;



namespace SCOOP
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroGrupoMedicao(null));
            
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroGrupoComposicao());
            
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroGrupoMedicao(null));
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroFiscalizador(null));
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroGrupoInsumos());
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroUnidade());
        }

        private void ribbonButton10_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroEmpreteira());
        }

        private void ribbonButton13_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroBairro());
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            AbreForm(new Fornecedor());
        }

        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            AbreForm(new CadastroUsuario());
        }

        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            try
            {
                AbreForm( new CadastroInsumos("0",null,null,null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonButton18_Click(object sender, EventArgs e)
        {
            try
            {
                AbreForm( new ListaInsumos());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            AbreForm( new CadastroComposicao("0",null,null,null));
        }

        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            AbreForm( new ListaServico());
            
        }

        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            AbreForm( new CadastroOrcamentocs(1));
            
        }

        private void ribbonButton22_Click(object sender, EventArgs e)
        {
            AbreForm( new CadastroOrcamentocs(2));
        }

        private void ribbonButton23_Click(object sender, EventArgs e)
        {
            AbreForm( new CadastroOrcamentocontratado(1));
            
        }

        private void ribbonButton25_Click(object sender, EventArgs e)
        {
            AbreForm( new CadastroMedicao(1));
        }

        private void ribbonButton27_Click(object sender, EventArgs e)
        {
            AbreForm( new CadastroMedicao(2));
        }

        private void ribbonButton28_Click(object sender, EventArgs e)
        {
            AbreForm( new ListaContrato());
        }
        
        public void AbreForm(Form frm)
        {

            if (!ProcurarTab("tab" + frm.Name))
            {
                TabPage newtab = this.customTabControl1.TabPages["tab" + frm.Name];

                if (frm != null && newtab == null)
                {
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    this.customTabControl1.TabPages.Add("tab" + frm.Name, frm.Text, "");
                    this.customTabControl1.TabPages[this.customTabControl1.TabCount - 1].Controls.Add(frm);
                    this.customTabControl1.SelectedIndex = this.customTabControl1.TabCount - 1;
                    this.customTabControl1.Show();
                    frm.Show();
                }
            }
            else
            {
                this.customTabControl1.SelectedIndex = ProcurarIndexTab("tab" + frm.Name);
            }
        }

        private int ProcurarIndexTab(string Name)
        {
            for (int i = 0; i <= this.customTabControl1.TabPages.Count; i++)
            {
                try
                {
                    if (this.customTabControl1.TabPages[i].Name == Name)
                    {
                        return i;
                        break;
                    }
                }
                catch (Exception ex) { }
            }
            return this.customTabControl1.TabIndex;
        }

        private bool ProcurarTab(string Name)
        {
            for (int i = 0; i <=  this.customTabControl1.TabPages.Count; i++)
            {
                try
                {
                    if (this.customTabControl1.TabPages[i].Name == Name)
                    {
                        return true;
                        break;
                    }
                }
                catch (Exception ex) { }
            }
            return false;
        }

        private void showForm(Form formToShow)
        {

            formToShow.TopLevel = false;

            TabPage newTab = new TabPage(formToShow.Text);

            formToShow.Parent = this;

            newTab.Controls.Add(formToShow);

            formToShow.Show();

            customTabControl1.TabPages.Add(newTab);

            formToShow.StartPosition = FormStartPosition.CenterScreen;

            formToShow.Activate();

        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            if(Conteudo.Panel1Collapsed == false)
                Conteudo.Panel1Collapsed = true;
            else
                Conteudo.Panel1Collapsed = false;
        }

        private void Conteudo_Panel1_Enter(object sender, EventArgs e)
        {

        }

        private void ribbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ribbonOrbMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ribbonButton29_Click(object sender, EventArgs e)
        {
            AbreForm(new GUI.ImporteInsumo(this));
        }

        private void ribbonButton30_Click(object sender, EventArgs e)
        {
            AbreForm(new GUI.ImporteServico(this));
        }

        private void ribbonButton32_Click(object sender, EventArgs e)
        {
            AbreForm(new RelatoriosMedicao(null,null));
        }

        private void ribbonButton33_Click(object sender, EventArgs e)
        {
            AbreForm(new RelatoriosServico(null, null));
        }

        private void ribbonButton34_Click(object sender, EventArgs e)
        {
            AbreForm(new Orca08.GUI.ListaMedicao());
        }


        private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}