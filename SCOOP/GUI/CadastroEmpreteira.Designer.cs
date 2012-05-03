using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroEmpreteira
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpreteira));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BttAtulizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BttNovo = new System.Windows.Forms.Button();
            this.BttCadastro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrupoPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.TxtBoxInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MskTxtBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBoxObservacao = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskTxtBoxDataFGTS = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.mskTxtBoxCND = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBoxDataRecFederal = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtBoxCREA = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtBoxResponsavelTecnico = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtBoxResponsavel = new System.Windows.Forms.TextBox();
            this.mskTxtBoxCPFResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.GrupoEndereco = new System.Windows.Forms.GroupBox();
            this.TxtBoxNumero = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.mskTxtBoxFAX = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mskTxtBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskTxtBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBoxCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBoxBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBoxLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoPessoa = new System.Windows.Forms.ComboBox();
            this.GrupoPessoaFisica = new System.Windows.Forms.GroupBox();
            this.MskTxtBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskTxtBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ChkBoxFicha = new System.Windows.Forms.CheckBox();
            this.chkBoxListagem = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.empreteiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelTecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReceitaFederalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFGTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empreteiraTableAdapter1 = new SCOOP.DAO.SCOOPDataSetTableAdapters.EmpreteiraTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrupoPessoaJuridica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GrupoEndereco.SuspendLayout();
            this.GrupoPessoaFisica.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empreteiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 523);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empreteira";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BttAtulizar
            // 
            this.BttAtulizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BttAtulizar.Location = new System.Drawing.Point(172, 530);
            this.BttAtulizar.Name = "BttAtulizar";
            this.BttAtulizar.Size = new System.Drawing.Size(75, 23);
            this.BttAtulizar.TabIndex = 6;
            this.BttAtulizar.Text = "Atualizar";
            this.BttAtulizar.UseVisualStyleBackColor = true;
            this.BttAtulizar.Visible = false;
            this.BttAtulizar.Click += new System.EventHandler(this.BttAtulizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(334, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttNovo
            // 
            this.BttNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BttNovo.Location = new System.Drawing.Point(253, 530);
            this.BttNovo.Name = "BttNovo";
            this.BttNovo.Size = new System.Drawing.Size(75, 23);
            this.BttNovo.TabIndex = 4;
            this.BttNovo.Text = "Novo";
            this.BttNovo.UseVisualStyleBackColor = true;
            this.BttNovo.Click += new System.EventHandler(this.BttNovo_Click);
            // 
            // BttCadastro
            // 
            this.BttCadastro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BttCadastro.Location = new System.Drawing.Point(172, 530);
            this.BttCadastro.Name = "BttCadastro";
            this.BttCadastro.Size = new System.Drawing.Size(75, 23);
            this.BttCadastro.TabIndex = 22;
            this.BttCadastro.Text = "Cadastrar";
            this.BttCadastro.UseVisualStyleBackColor = true;
            this.BttCadastro.Click += new System.EventHandler(this.BttCadastro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.GrupoPessoaJuridica);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.GrupoEndereco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxTipoPessoa);
            this.groupBox1.Controls.Add(this.GrupoPessoaFisica);
            this.groupBox1.Controls.Add(this.TxtBoxCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 497);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // GrupoPessoaJuridica
            // 
            this.GrupoPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoPessoaJuridica.Controls.Add(this.TxtBoxInscricaoEstadual);
            this.GrupoPessoaJuridica.Controls.Add(this.label8);
            this.GrupoPessoaJuridica.Controls.Add(this.MskTxtBoxCNPJ);
            this.GrupoPessoaJuridica.Controls.Add(this.label5);
            this.GrupoPessoaJuridica.Controls.Add(this.TxtBoxRazaoSocial);
            this.GrupoPessoaJuridica.Controls.Add(this.label6);
            this.GrupoPessoaJuridica.Location = new System.Drawing.Point(9, 73);
            this.GrupoPessoaJuridica.Name = "GrupoPessoaJuridica";
            this.GrupoPessoaJuridica.Size = new System.Drawing.Size(567, 117);
            this.GrupoPessoaJuridica.TabIndex = 6;
            this.GrupoPessoaJuridica.TabStop = false;
            this.GrupoPessoaJuridica.Text = "Pessoa Juridica";
            this.GrupoPessoaJuridica.Visible = false;
            // 
            // TxtBoxInscricaoEstadual
            // 
            this.TxtBoxInscricaoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxInscricaoEstadual.Location = new System.Drawing.Point(125, 32);
            this.TxtBoxInscricaoEstadual.Name = "TxtBoxInscricaoEstadual";
            this.TxtBoxInscricaoEstadual.Size = new System.Drawing.Size(137, 20);
            this.TxtBoxInscricaoEstadual.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Inscrição Estadual";
            // 
            // MskTxtBoxCNPJ
            // 
            this.MskTxtBoxCNPJ.Location = new System.Drawing.Point(6, 32);
            this.MskTxtBoxCNPJ.Mask = "00,000,000/0000-00";
            this.MskTxtBoxCNPJ.Name = "MskTxtBoxCNPJ";
            this.MskTxtBoxCNPJ.Size = new System.Drawing.Size(108, 20);
            this.MskTxtBoxCNPJ.TabIndex = 2;
            this.MskTxtBoxCNPJ.TextChanged += new System.EventHandler(this.MskTxtBoxCNPJ_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CNPJ";
            // 
            // TxtBoxRazaoSocial
            // 
            this.TxtBoxRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxRazaoSocial.Location = new System.Drawing.Point(6, 76);
            this.TxtBoxRazaoSocial.Name = "TxtBoxRazaoSocial";
            this.TxtBoxRazaoSocial.Size = new System.Drawing.Size(316, 20);
            this.TxtBoxRazaoSocial.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Razão Social";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TxtBoxObservacao);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.TxtBoxCREA);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.TxtBoxResponsavelTecnico);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.TxtBoxResponsavel);
            this.groupBox2.Controls.Add(this.mskTxtBoxCPFResponsavel);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(9, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 185);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Adicionais";
            // 
            // TxtBoxObservacao
            // 
            this.TxtBoxObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxObservacao.Location = new System.Drawing.Point(6, 110);
            this.TxtBoxObservacao.Multiline = true;
            this.TxtBoxObservacao.Name = "TxtBoxObservacao";
            this.TxtBoxObservacao.Size = new System.Drawing.Size(332, 69);
            this.TxtBoxObservacao.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(2, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Observação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mskTxtBoxDataFGTS);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.mskTxtBoxCND);
            this.groupBox3.Controls.Add(this.mskTxtBoxDataRecFederal);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(378, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 122);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prazos";
            // 
            // mskTxtBoxDataFGTS
            // 
            this.mskTxtBoxDataFGTS.Location = new System.Drawing.Point(84, 88);
            this.mskTxtBoxDataFGTS.Mask = "00/00/0000";
            this.mskTxtBoxDataFGTS.Name = "mskTxtBoxDataFGTS";
            this.mskTxtBoxDataFGTS.Size = new System.Drawing.Size(71, 20);
            this.mskTxtBoxDataFGTS.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "FGTS";
            // 
            // mskTxtBoxCND
            // 
            this.mskTxtBoxCND.Location = new System.Drawing.Point(84, 49);
            this.mskTxtBoxCND.Mask = "00/00/0000";
            this.mskTxtBoxCND.Name = "mskTxtBoxCND";
            this.mskTxtBoxCND.Size = new System.Drawing.Size(71, 20);
            this.mskTxtBoxCND.TabIndex = 19;
            // 
            // mskTxtBoxDataRecFederal
            // 
            this.mskTxtBoxDataRecFederal.Location = new System.Drawing.Point(84, 16);
            this.mskTxtBoxDataRecFederal.Mask = "00/00/0000";
            this.mskTxtBoxDataRecFederal.Name = "mskTxtBoxDataRecFederal";
            this.mskTxtBoxDataRecFederal.Size = new System.Drawing.Size(71, 20);
            this.mskTxtBoxDataRecFederal.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Rec. Federal";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "CND";
            // 
            // TxtBoxCREA
            // 
            this.TxtBoxCREA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxCREA.Location = new System.Drawing.Point(252, 71);
            this.TxtBoxCREA.Name = "TxtBoxCREA";
            this.TxtBoxCREA.Size = new System.Drawing.Size(86, 20);
            this.TxtBoxCREA.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(252, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "CREA";
            // 
            // TxtBoxResponsavelTecnico
            // 
            this.TxtBoxResponsavelTecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxResponsavelTecnico.Location = new System.Drawing.Point(6, 71);
            this.TxtBoxResponsavelTecnico.Name = "TxtBoxResponsavelTecnico";
            this.TxtBoxResponsavelTecnico.Size = new System.Drawing.Size(240, 20);
            this.TxtBoxResponsavelTecnico.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Responsável Tecnico";
            // 
            // TxtBoxResponsavel
            // 
            this.TxtBoxResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxResponsavel.Location = new System.Drawing.Point(6, 32);
            this.TxtBoxResponsavel.Name = "TxtBoxResponsavel";
            this.TxtBoxResponsavel.Size = new System.Drawing.Size(240, 20);
            this.TxtBoxResponsavel.TabIndex = 14;
            // 
            // mskTxtBoxCPFResponsavel
            // 
            this.mskTxtBoxCPFResponsavel.Location = new System.Drawing.Point(252, 32);
            this.mskTxtBoxCPFResponsavel.Mask = "000,000,000-00";
            this.mskTxtBoxCPFResponsavel.Name = "mskTxtBoxCPFResponsavel";
            this.mskTxtBoxCPFResponsavel.Size = new System.Drawing.Size(86, 20);
            this.mskTxtBoxCPFResponsavel.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(249, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "CPF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Responsável";
            // 
            // GrupoEndereco
            // 
            this.GrupoEndereco.Controls.Add(this.TxtBoxNumero);
            this.GrupoEndereco.Controls.Add(this.label25);
            this.GrupoEndereco.Controls.Add(this.mskTxtBoxFAX);
            this.GrupoEndereco.Controls.Add(this.label16);
            this.GrupoEndereco.Controls.Add(this.mskTxtBoxCelular);
            this.GrupoEndereco.Controls.Add(this.label15);
            this.GrupoEndereco.Controls.Add(this.mskTxtBoxTelefone);
            this.GrupoEndereco.Controls.Add(this.label14);
            this.GrupoEndereco.Controls.Add(this.mskTxtBoxCEP);
            this.GrupoEndereco.Controls.Add(this.label13);
            this.GrupoEndereco.Controls.Add(this.ComboBoxEstado);
            this.GrupoEndereco.Controls.Add(this.label12);
            this.GrupoEndereco.Controls.Add(this.TxtBoxCidade);
            this.GrupoEndereco.Controls.Add(this.label11);
            this.GrupoEndereco.Controls.Add(this.TxtBoxBairro);
            this.GrupoEndereco.Controls.Add(this.label10);
            this.GrupoEndereco.Controls.Add(this.TxtBoxLogradouro);
            this.GrupoEndereco.Controls.Add(this.label9);
            this.GrupoEndereco.Location = new System.Drawing.Point(9, 196);
            this.GrupoEndereco.Name = "GrupoEndereco";
            this.GrupoEndereco.Size = new System.Drawing.Size(561, 104);
            this.GrupoEndereco.TabIndex = 7;
            this.GrupoEndereco.TabStop = false;
            this.GrupoEndereco.Text = "Endereço";
            this.GrupoEndereco.Enter += new System.EventHandler(this.GrupoEndereco_Enter);
            // 
            // TxtBoxNumero
            // 
            this.TxtBoxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxNumero.Location = new System.Drawing.Point(252, 32);
            this.TxtBoxNumero.Name = "TxtBoxNumero";
            this.TxtBoxNumero.Size = new System.Drawing.Size(125, 20);
            this.TxtBoxNumero.TabIndex = 6;
            this.TxtBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxNumero_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(249, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Numero";
            // 
            // mskTxtBoxFAX
            // 
            this.mskTxtBoxFAX.Location = new System.Drawing.Point(464, 72);
            this.mskTxtBoxFAX.Mask = "(00)0000-0000";
            this.mskTxtBoxFAX.Name = "mskTxtBoxFAX";
            this.mskTxtBoxFAX.Size = new System.Drawing.Size(85, 20);
            this.mskTxtBoxFAX.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(461, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "FAX";
            // 
            // mskTxtBoxCelular
            // 
            this.mskTxtBoxCelular.Location = new System.Drawing.Point(373, 72);
            this.mskTxtBoxCelular.Mask = "(00)0000-0000";
            this.mskTxtBoxCelular.Name = "mskTxtBoxCelular";
            this.mskTxtBoxCelular.Size = new System.Drawing.Size(85, 20);
            this.mskTxtBoxCelular.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(370, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Celular";
            // 
            // mskTxtBoxTelefone
            // 
            this.mskTxtBoxTelefone.Location = new System.Drawing.Point(282, 72);
            this.mskTxtBoxTelefone.Mask = "(00)0000-0000";
            this.mskTxtBoxTelefone.Name = "mskTxtBoxTelefone";
            this.mskTxtBoxTelefone.Size = new System.Drawing.Size(85, 20);
            this.mskTxtBoxTelefone.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(279, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Telefone";
            // 
            // mskTxtBoxCEP
            // 
            this.mskTxtBoxCEP.Location = new System.Drawing.Point(205, 71);
            this.mskTxtBoxCEP.Mask = "00000-000";
            this.mskTxtBoxCEP.Name = "mskTxtBoxCEP";
            this.mskTxtBoxCEP.Size = new System.Drawing.Size(71, 20);
            this.mskTxtBoxCEP.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "CEP";
            // 
            // ComboBoxEstado
            // 
            this.ComboBoxEstado.FormattingEnabled = true;
            this.ComboBoxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SE",
            "SC",
            "SP",
            "PA",
            "PB",
            "PE",
            "PI",
            "TO"});
            this.ComboBoxEstado.Location = new System.Drawing.Point(137, 71);
            this.ComboBoxEstado.Name = "ComboBoxEstado";
            this.ComboBoxEstado.Size = new System.Drawing.Size(50, 21);
            this.ComboBoxEstado.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Estado";
            // 
            // TxtBoxCidade
            // 
            this.TxtBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxCidade.Location = new System.Drawing.Point(6, 71);
            this.TxtBoxCidade.Name = "TxtBoxCidade";
            this.TxtBoxCidade.Size = new System.Drawing.Size(125, 20);
            this.TxtBoxCidade.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cidade";
            // 
            // TxtBoxBairro
            // 
            this.TxtBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxBairro.Location = new System.Drawing.Point(383, 32);
            this.TxtBoxBairro.Name = "TxtBoxBairro";
            this.TxtBoxBairro.Size = new System.Drawing.Size(125, 20);
            this.TxtBoxBairro.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bairro";
            // 
            // TxtBoxLogradouro
            // 
            this.TxtBoxLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxLogradouro.Location = new System.Drawing.Point(6, 32);
            this.TxtBoxLogradouro.Name = "TxtBoxLogradouro";
            this.TxtBoxLogradouro.Size = new System.Drawing.Size(240, 20);
            this.TxtBoxLogradouro.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Logradouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Pessoa";
            // 
            // comboBoxTipoPessoa
            // 
            this.comboBoxTipoPessoa.FormattingEnabled = true;
            this.comboBoxTipoPessoa.Items.AddRange(new object[] {
            "",
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.comboBoxTipoPessoa.Location = new System.Drawing.Point(75, 32);
            this.comboBoxTipoPessoa.Name = "comboBoxTipoPessoa";
            this.comboBoxTipoPessoa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoPessoa.TabIndex = 1;
            this.comboBoxTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPessoa_SelectedIndexChanged);
            // 
            // GrupoPessoaFisica
            // 
            this.GrupoPessoaFisica.Controls.Add(this.MskTxtBoxRG);
            this.GrupoPessoaFisica.Controls.Add(this.label7);
            this.GrupoPessoaFisica.Controls.Add(this.MskTxtBoxCPF);
            this.GrupoPessoaFisica.Controls.Add(this.label3);
            this.GrupoPessoaFisica.Controls.Add(this.TxtBoxNome);
            this.GrupoPessoaFisica.Controls.Add(this.label2);
            this.GrupoPessoaFisica.Location = new System.Drawing.Point(9, 73);
            this.GrupoPessoaFisica.Name = "GrupoPessoaFisica";
            this.GrupoPessoaFisica.Size = new System.Drawing.Size(561, 117);
            this.GrupoPessoaFisica.TabIndex = 4;
            this.GrupoPessoaFisica.TabStop = false;
            this.GrupoPessoaFisica.Text = "Pessoa Fisica";
            this.GrupoPessoaFisica.Visible = false;
            // 
            // MskTxtBoxRG
            // 
            this.MskTxtBoxRG.Location = new System.Drawing.Point(120, 32);
            this.MskTxtBoxRG.Mask = "00000000";
            this.MskTxtBoxRG.Name = "MskTxtBoxRG";
            this.MskTxtBoxRG.Size = new System.Drawing.Size(67, 20);
            this.MskTxtBoxRG.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "RG";
            // 
            // MskTxtBoxCPF
            // 
            this.MskTxtBoxCPF.Location = new System.Drawing.Point(6, 32);
            this.MskTxtBoxCPF.Mask = "000,000,000-00";
            this.MskTxtBoxCPF.Name = "MskTxtBoxCPF";
            this.MskTxtBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.MskTxtBoxCPF.TabIndex = 2;
            this.MskTxtBoxCPF.TextChanged += new System.EventHandler(this.MskTxtBoxCPF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxNome.Location = new System.Drawing.Point(6, 76);
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(316, 20);
            this.TxtBoxNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // TxtBoxCodigo
            // 
            this.TxtBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxCodigo.Enabled = false;
            this.TxtBoxCodigo.Location = new System.Drawing.Point(9, 32);
            this.TxtBoxCodigo.Name = "TxtBoxCodigo";
            this.TxtBoxCodigo.Size = new System.Drawing.Size(60, 20);
            this.TxtBoxCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.ChkBoxFicha);
            this.groupBox7.Controls.Add(this.chkBoxListagem);
            this.groupBox7.Location = new System.Drawing.Point(400, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(183, 70);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Impressão";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChkBoxFicha
            // 
            this.ChkBoxFicha.AutoSize = true;
            this.ChkBoxFicha.Location = new System.Drawing.Point(81, 19);
            this.ChkBoxFicha.Name = "ChkBoxFicha";
            this.ChkBoxFicha.Size = new System.Drawing.Size(52, 17);
            this.ChkBoxFicha.TabIndex = 1;
            this.ChkBoxFicha.Text = "Ficha";
            this.ChkBoxFicha.UseVisualStyleBackColor = true;
            // 
            // chkBoxListagem
            // 
            this.chkBoxListagem.AutoSize = true;
            this.chkBoxListagem.Location = new System.Drawing.Point(7, 20);
            this.chkBoxListagem.Name = "chkBoxListagem";
            this.chkBoxListagem.Size = new System.Drawing.Size(68, 17);
            this.chkBoxListagem.TabIndex = 0;
            this.chkBoxListagem.Text = "Listagem";
            this.chkBoxListagem.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.bindingNavigator1);
            this.groupBox6.Location = new System.Drawing.Point(7, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 70);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 16);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Digite aqui";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(85, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.empreteiraBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator8,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(6, 38);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(261, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator2";
            // 
            // empreteiraBindingSource
            // 
            this.empreteiraBindingSource.DataMember = "Empreteira";
            this.empreteiraBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::SCOOP.Properties.Resources.edit1;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Alterar";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(400, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 70);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Impressão";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Imprimir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(81, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ficha";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Listagem";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 70);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.rGDataGridViewTextBoxColumn,
            this.inscricaoEstadualDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.responsavelDataGridViewTextBoxColumn,
            this.cPFResponsavelDataGridViewTextBoxColumn,
            this.responsavelTecnicoDataGridViewTextBoxColumn,
            this.cREADataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.dataReceitaFederalDataGridViewTextBoxColumn,
            this.dataCNDDataGridViewTextBoxColumn,
            this.dataFGTSDataGridViewTextBoxColumn,
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empreteiraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(576, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn4.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            this.rGDataGridViewTextBoxColumn.Visible = false;
            // 
            // inscricaoEstadualDataGridViewTextBoxColumn
            // 
            this.inscricaoEstadualDataGridViewTextBoxColumn.DataPropertyName = "InscricaoEstadual";
            this.inscricaoEstadualDataGridViewTextBoxColumn.HeaderText = "InscricaoEstadual";
            this.inscricaoEstadualDataGridViewTextBoxColumn.Name = "inscricaoEstadualDataGridViewTextBoxColumn";
            this.inscricaoEstadualDataGridViewTextBoxColumn.ReadOnly = true;
            this.inscricaoEstadualDataGridViewTextBoxColumn.Visible = false;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "Logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEPDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn6.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FAX";
            this.dataGridViewTextBoxColumn7.HeaderText = "FAX";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.Name = "responsavelDataGridViewTextBoxColumn";
            this.responsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsavelDataGridViewTextBoxColumn.Visible = false;
            // 
            // cPFResponsavelDataGridViewTextBoxColumn
            // 
            this.cPFResponsavelDataGridViewTextBoxColumn.DataPropertyName = "CPFResponsavel";
            this.cPFResponsavelDataGridViewTextBoxColumn.HeaderText = "CPFResponsavel";
            this.cPFResponsavelDataGridViewTextBoxColumn.Name = "cPFResponsavelDataGridViewTextBoxColumn";
            this.cPFResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFResponsavelDataGridViewTextBoxColumn.Visible = false;
            // 
            // responsavelTecnicoDataGridViewTextBoxColumn
            // 
            this.responsavelTecnicoDataGridViewTextBoxColumn.DataPropertyName = "ResponsavelTecnico";
            this.responsavelTecnicoDataGridViewTextBoxColumn.HeaderText = "ResponsavelTecnico";
            this.responsavelTecnicoDataGridViewTextBoxColumn.Name = "responsavelTecnicoDataGridViewTextBoxColumn";
            this.responsavelTecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsavelTecnicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cREADataGridViewTextBoxColumn
            // 
            this.cREADataGridViewTextBoxColumn.DataPropertyName = "CREA";
            this.cREADataGridViewTextBoxColumn.HeaderText = "CREA";
            this.cREADataGridViewTextBoxColumn.Name = "cREADataGridViewTextBoxColumn";
            this.cREADataGridViewTextBoxColumn.ReadOnly = true;
            this.cREADataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataReceitaFederalDataGridViewTextBoxColumn
            // 
            this.dataReceitaFederalDataGridViewTextBoxColumn.DataPropertyName = "DataReceitaFederal";
            this.dataReceitaFederalDataGridViewTextBoxColumn.HeaderText = "DataReceitaFederal";
            this.dataReceitaFederalDataGridViewTextBoxColumn.Name = "dataReceitaFederalDataGridViewTextBoxColumn";
            this.dataReceitaFederalDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataReceitaFederalDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCNDDataGridViewTextBoxColumn
            // 
            this.dataCNDDataGridViewTextBoxColumn.DataPropertyName = "DataCND";
            this.dataCNDDataGridViewTextBoxColumn.HeaderText = "DataCND";
            this.dataCNDDataGridViewTextBoxColumn.Name = "dataCNDDataGridViewTextBoxColumn";
            this.dataCNDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCNDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataFGTSDataGridViewTextBoxColumn
            // 
            this.dataFGTSDataGridViewTextBoxColumn.DataPropertyName = "DataFGTS";
            this.dataFGTSDataGridViewTextBoxColumn.HeaderText = "DataFGTS";
            this.dataFGTSDataGridViewTextBoxColumn.Name = "dataFGTSDataGridViewTextBoxColumn";
            this.dataFGTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataFGTSDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataUltimaAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "Data_Ultima_Alteracao";
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn.HeaderText = "Data_Ultima_Alteracao";
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn.Name = "dataUltimaAlteracaoDataGridViewTextBoxColumn";
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataUltimaAlteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // empreteiraTableAdapter1
            // 
            this.empreteiraTableAdapter1.ClearBeforeFill = true;
            // 
            // CadastroEmpreteira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 563);
            this.Controls.Add(this.BttCadastro);
            this.Controls.Add(this.BttAtulizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BttNovo);
            this.KeyPreview = true;
            this.Name = "CadastroEmpreteira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroEmpreteira";
            this.Load += new System.EventHandler(this.CadastroEmpreteira_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CadastroEmpreteira_PreviewKeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrupoPessoaJuridica.ResumeLayout(false);
            this.GrupoPessoaJuridica.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GrupoEndereco.ResumeLayout(false);
            this.GrupoEndereco.PerformLayout();
            this.GrupoPessoaFisica.ResumeLayout(false);
            this.GrupoPessoaFisica.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empreteiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BttNovo;
        private System.Windows.Forms.Button BttCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtBoxObservacao;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxDataFGTS;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCND;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxDataRecFederal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtBoxCREA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtBoxResponsavelTecnico;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCPFResponsavel;
        private System.Windows.Forms.TextBox TxtBoxResponsavel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox GrupoEndereco;
        private System.Windows.Forms.TextBox TxtBoxNumero;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxFAX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelefone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCEP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboBoxEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBoxCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBoxBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBoxLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoPessoa;
        private System.Windows.Forms.GroupBox GrupoPessoaFisica;
        private System.Windows.Forms.GroupBox GrupoPessoaJuridica;
        private System.Windows.Forms.TextBox TxtBoxInscricaoEstadual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MskTxtBoxCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBoxRazaoSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTxtBoxRG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskTxtBoxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SCOOPDataSet OrcamentoDataSet;
        private EmpreteiraTableAdapter empreteiraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox ChkBoxFicha;
        private System.Windows.Forms.CheckBox chkBoxListagem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Button BttAtulizar;
        private System.Windows.Forms.Label label26;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource empreteiraBindingSource;
        private EmpreteiraTableAdapter empreteiraTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoEstadualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelTecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReceitaFederalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFGTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltimaAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;


    }
}