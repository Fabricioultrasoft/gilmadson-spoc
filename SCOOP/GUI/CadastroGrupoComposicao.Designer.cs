using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroGrupoComposicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroGrupoComposicao));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GrupogroupBox = new System.Windows.Forms.GroupBox();
            this.Grupobutton = new System.Windows.Forms.Button();
            this.GrupoComboBox = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GrupotextBox = new System.Windows.Forms.TextBox();
            this.BttNovo = new System.Windows.Forms.Button();
            this.grupoSubCategoria = new System.Windows.Forms.GroupBox();
            this.AtividadeDescricaoTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AtividadeTxtBox = new System.Windows.Forms.TextBox();
            this.EtapaGrupoBox = new System.Windows.Forms.GroupBox();
            this.EtapaButton = new System.Windows.Forms.Button();
            this.EtapaComboBox = new System.Windows.Forms.ComboBox();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EtapaTxtBox = new System.Windows.Forms.TextBox();
            this.BttVoltar = new System.Windows.Forms.Button();
            this.AtividadeButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet1 = new SCOOPDataSet();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grupoTableAdapter1 = new GrupoTableAdapter();
            this.etapaTableAdapter = new EtapaTableAdapter();
            this.atividadeTableAdapter = new AtividadeTableAdapter();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GrupogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            this.grupoSubCategoria.SuspendLayout();
            this.EtapaGrupoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet1)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrupogroupBox);
            this.tabPage1.Controls.Add(this.BttNovo);
            this.tabPage1.Controls.Add(this.grupoSubCategoria);
            this.tabPage1.Controls.Add(this.EtapaGrupoBox);
            this.tabPage1.Controls.Add(this.BttVoltar);
            this.tabPage1.Controls.Add(this.AtividadeButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grupo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GrupogroupBox
            // 
            this.GrupogroupBox.Controls.Add(this.Grupobutton);
            this.GrupogroupBox.Controls.Add(this.GrupoComboBox);
            this.GrupogroupBox.Controls.Add(this.label1);
            this.GrupogroupBox.Controls.Add(this.label6);
            this.GrupogroupBox.Controls.Add(this.GrupotextBox);
            this.GrupogroupBox.Location = new System.Drawing.Point(6, 6);
            this.GrupogroupBox.Name = "GrupogroupBox";
            this.GrupogroupBox.Size = new System.Drawing.Size(460, 100);
            this.GrupogroupBox.TabIndex = 16;
            this.GrupogroupBox.TabStop = false;
            this.GrupogroupBox.Text = "Cadastro Grupo";
            // 
            // Grupobutton
            // 
            this.Grupobutton.Location = new System.Drawing.Point(6, 71);
            this.Grupobutton.Name = "Grupobutton";
            this.Grupobutton.Size = new System.Drawing.Size(75, 23);
            this.Grupobutton.TabIndex = 17;
            this.Grupobutton.Text = "Concluir";
            this.Grupobutton.UseVisualStyleBackColor = true;
            this.Grupobutton.Click += new System.EventHandler(this.Grupobutton_Click);
            // 
            // GrupoComboBox
            // 
            this.GrupoComboBox.DataSource = this.grupoBindingSource;
            this.GrupoComboBox.DisplayMember = "Descricao";
            this.GrupoComboBox.FormattingEnabled = true;
            this.GrupoComboBox.Location = new System.Drawing.Point(70, 32);
            this.GrupoComboBox.Name = "GrupoComboBox";
            this.GrupoComboBox.Size = new System.Drawing.Size(376, 21);
            this.GrupoComboBox.TabIndex = 13;
            this.GrupoComboBox.ValueMember = "Codigo";
            this.GrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.GrupoComboBox_SelectedIndexChanged);
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grupo";
            // 
            // GrupotextBox
            // 
            this.GrupotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GrupotextBox.Enabled = false;
            this.GrupotextBox.Location = new System.Drawing.Point(6, 32);
            this.GrupotextBox.Name = "GrupotextBox";
            this.GrupotextBox.Size = new System.Drawing.Size(58, 20);
            this.GrupotextBox.TabIndex = 12;
            // 
            // BttNovo
            // 
            this.BttNovo.Location = new System.Drawing.Point(232, 295);
            this.BttNovo.Name = "BttNovo";
            this.BttNovo.Size = new System.Drawing.Size(75, 23);
            this.BttNovo.TabIndex = 15;
            this.BttNovo.Text = "Novo";
            this.BttNovo.UseVisualStyleBackColor = true;
            this.BttNovo.Click += new System.EventHandler(this.BttNovo_Click);
            // 
            // grupoSubCategoria
            // 
            this.grupoSubCategoria.Controls.Add(this.AtividadeDescricaoTxtBox);
            this.grupoSubCategoria.Controls.Add(this.label3);
            this.grupoSubCategoria.Controls.Add(this.label4);
            this.grupoSubCategoria.Controls.Add(this.AtividadeTxtBox);
            this.grupoSubCategoria.Enabled = false;
            this.grupoSubCategoria.Location = new System.Drawing.Point(6, 226);
            this.grupoSubCategoria.Name = "grupoSubCategoria";
            this.grupoSubCategoria.Size = new System.Drawing.Size(460, 63);
            this.grupoSubCategoria.TabIndex = 13;
            this.grupoSubCategoria.TabStop = false;
            this.grupoSubCategoria.Text = "Cadastro Atividade";
            // 
            // AtividadeDescricaoTxtBox
            // 
            this.AtividadeDescricaoTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AtividadeDescricaoTxtBox.Location = new System.Drawing.Point(73, 32);
            this.AtividadeDescricaoTxtBox.Name = "AtividadeDescricaoTxtBox";
            this.AtividadeDescricaoTxtBox.Size = new System.Drawing.Size(376, 20);
            this.AtividadeDescricaoTxtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome Atividade";
            // 
            // AtividadeTxtBox
            // 
            this.AtividadeTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AtividadeTxtBox.Enabled = false;
            this.AtividadeTxtBox.Location = new System.Drawing.Point(6, 32);
            this.AtividadeTxtBox.Name = "AtividadeTxtBox";
            this.AtividadeTxtBox.Size = new System.Drawing.Size(58, 20);
            this.AtividadeTxtBox.TabIndex = 6;
            // 
            // EtapaGrupoBox
            // 
            this.EtapaGrupoBox.Controls.Add(this.EtapaButton);
            this.EtapaGrupoBox.Controls.Add(this.EtapaComboBox);
            this.EtapaGrupoBox.Controls.Add(this.label2);
            this.EtapaGrupoBox.Controls.Add(this.label5);
            this.EtapaGrupoBox.Controls.Add(this.EtapaTxtBox);
            this.EtapaGrupoBox.Enabled = false;
            this.EtapaGrupoBox.Location = new System.Drawing.Point(6, 127);
            this.EtapaGrupoBox.Name = "EtapaGrupoBox";
            this.EtapaGrupoBox.Size = new System.Drawing.Size(460, 93);
            this.EtapaGrupoBox.TabIndex = 12;
            this.EtapaGrupoBox.TabStop = false;
            this.EtapaGrupoBox.Text = "Cadastro Etapa";
            // 
            // EtapaButton
            // 
            this.EtapaButton.Location = new System.Drawing.Point(6, 62);
            this.EtapaButton.Name = "EtapaButton";
            this.EtapaButton.Size = new System.Drawing.Size(75, 23);
            this.EtapaButton.TabIndex = 15;
            this.EtapaButton.Text = "Concluir";
            this.EtapaButton.UseVisualStyleBackColor = true;
            this.EtapaButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EtapaComboBox
            // 
            this.EtapaComboBox.DataSource = this.etapaBindingSource;
            this.EtapaComboBox.DisplayMember = "Descricao";
            this.EtapaComboBox.FormattingEnabled = true;
            this.EtapaComboBox.Location = new System.Drawing.Point(70, 36);
            this.EtapaComboBox.Name = "EtapaComboBox";
            this.EtapaComboBox.Size = new System.Drawing.Size(376, 21);
            this.EtapaComboBox.TabIndex = 11;
            this.EtapaComboBox.ValueMember = "Codigo";
            this.EtapaComboBox.SelectedIndexChanged += new System.EventHandler(this.EtapaComboBox_SelectedIndexChanged);
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataMember = "Etapa";
            this.etapaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Etapa";
            // 
            // EtapaTxtBox
            // 
            this.EtapaTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EtapaTxtBox.Enabled = false;
            this.EtapaTxtBox.Location = new System.Drawing.Point(6, 36);
            this.EtapaTxtBox.Name = "EtapaTxtBox";
            this.EtapaTxtBox.Size = new System.Drawing.Size(58, 20);
            this.EtapaTxtBox.TabIndex = 6;
            // 
            // BttVoltar
            // 
            this.BttVoltar.Location = new System.Drawing.Point(113, 295);
            this.BttVoltar.Name = "BttVoltar";
            this.BttVoltar.Size = new System.Drawing.Size(75, 23);
            this.BttVoltar.TabIndex = 11;
            this.BttVoltar.Text = "Voltar";
            this.BttVoltar.UseVisualStyleBackColor = true;
            this.BttVoltar.Click += new System.EventHandler(this.BttVoltar_Click);
            // 
            // AtividadeButton
            // 
            this.AtividadeButton.Location = new System.Drawing.Point(6, 295);
            this.AtividadeButton.Name = "AtividadeButton";
            this.AtividadeButton.Size = new System.Drawing.Size(75, 23);
            this.AtividadeButton.TabIndex = 10;
            this.AtividadeButton.Text = "Concluir";
            this.AtividadeButton.UseVisualStyleBackColor = true;
            this.AtividadeButton.Click += new System.EventHandler(this.BttCadastrar_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxPesquisa);
            this.groupBox2.Controls.Add(this.bindingNavigator2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 70);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisa.Location = new System.Drawing.Point(6, 15);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(194, 20);
            this.textBoxPesquisa.TabIndex = 3;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.atividadeBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripSeparator6,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator7,
            this.toolStripButton15});
            this.bindingNavigator2.Location = new System.Drawing.Point(6, 38);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton11;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton14;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton13;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton12;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(284, 25);
            this.bindingNavigator2.TabIndex = 2;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "Atividade";
            this.atividadeBindingSource.DataSource = this.sCOOPDataSet1;
            // 
            // sCOOPDataSet1
            // 
            this.sCOOPDataSet1.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move first";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move next";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Add new";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Delete";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = global::SCOOP.Properties.Resources.edit1;
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Alterar";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
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
            this.Codigo,
            this.Grupo,
            this.codigoPaiDataGridViewTextBoxColumn,
            this.Atividade,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.atividadeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(466, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // grupoTableAdapter1
            // 
            this.grupoTableAdapter1.ClearBeforeFill = true;
            // 
            // etapaTableAdapter
            // 
            this.etapaTableAdapter.ClearBeforeFill = true;
            // 
            // atividadeTableAdapter
            // 
            this.atividadeTableAdapter.ClearBeforeFill = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            // 
            // codigoPaiDataGridViewTextBoxColumn
            // 
            this.codigoPaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigoPaiDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Pai";
            this.codigoPaiDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoPaiDataGridViewTextBoxColumn.Name = "codigoPaiDataGridViewTextBoxColumn";
            this.codigoPaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPaiDataGridViewTextBoxColumn.Width = 65;
            // 
            // Atividade
            // 
            this.Atividade.HeaderText = "Etapa";
            this.Atividade.Name = "Atividade";
            this.Atividade.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Atividade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // CadastroGrupoComposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "CadastroGrupoComposicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo de Composições";
            this.Load += new System.EventHandler(this.CadastroGrupo_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CadastroGrupoComposicao_PreviewKeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GrupogroupBox.ResumeLayout(false);
            this.GrupogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            this.grupoSubCategoria.ResumeLayout(false);
            this.grupoSubCategoria.PerformLayout();
            this.EtapaGrupoBox.ResumeLayout(false);
            this.EtapaGrupoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BttVoltar;
        private System.Windows.Forms.Button AtividadeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EtapaTxtBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SCOOPDataSet OrcamentoDataSet;
        private System.Windows.Forms.GroupBox EtapaGrupoBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.GroupBox grupoSubCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AtividadeDescricaoTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AtividadeTxtBox;
        private System.Windows.Forms.ComboBox EtapaComboBox;
        private AtividadeTableAdapter subcategoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriadescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.Button BttNovo;
        private System.Windows.Forms.GroupBox GrupogroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GrupotextBox;
        private System.Windows.Forms.ComboBox GrupoComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Grupobutton;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private GrupoTableAdapter grupoTableAdapter1;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private EtapaTableAdapter etapaTableAdapter;
        private SCOOPDataSet sCOOPDataSet1;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private AtividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.Button EtapaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}