using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroGrupoMedicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroGrupoMedicao));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DotacaoOrcamentariacomboBox = new System.Windows.Forms.ComboBox();
            this.dotacaoOrcamentariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.BttAlterar = new System.Windows.Forms.Button();
            this.BttNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.BttVoltar = new System.Windows.Forms.Button();
            this.BttCadastrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BttSelecionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tipoOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigopaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DotacaoOrcamentaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOrcamentoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.TipoOrcamentoTableAdapter();
            this.dotacaoOrcamentariaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.DotacaoOrcamentariaTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotacaoOrcamentariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOrcamentoBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(403, 311);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.BttAlterar);
            this.tabPage1.Controls.Add(this.BttNovo);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.BttVoltar);
            this.tabPage1.Controls.Add(this.BttCadastrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dotação Orçamentária";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.DotacaoOrcamentariacomboBox);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro Dotação Orçamentaria";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Concluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrição Dotação ";
            // 
            // DotacaoOrcamentariacomboBox
            // 
            this.DotacaoOrcamentariacomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DotacaoOrcamentariacomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DotacaoOrcamentariacomboBox.DataSource = this.dotacaoOrcamentariaBindingSource;
            this.DotacaoOrcamentariacomboBox.DisplayMember = "Descricao";
            this.DotacaoOrcamentariacomboBox.FormattingEnabled = true;
            this.DotacaoOrcamentariacomboBox.Location = new System.Drawing.Point(6, 44);
            this.DotacaoOrcamentariacomboBox.Name = "DotacaoOrcamentariacomboBox";
            this.DotacaoOrcamentariacomboBox.Size = new System.Drawing.Size(354, 21);
            this.DotacaoOrcamentariacomboBox.TabIndex = 0;
            this.DotacaoOrcamentariacomboBox.ValueMember = "Codigo";
            // 
            // dotacaoOrcamentariaBindingSource
            // 
            this.dotacaoOrcamentariaBindingSource.DataMember = "DotacaoOrcamentaria";
            this.dotacaoOrcamentariaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BttAlterar
            // 
            this.BttAlterar.Location = new System.Drawing.Point(7, 254);
            this.BttAlterar.Name = "BttAlterar";
            this.BttAlterar.Size = new System.Drawing.Size(75, 23);
            this.BttAlterar.TabIndex = 14;
            this.BttAlterar.Text = "Alterar";
            this.BttAlterar.UseVisualStyleBackColor = true;
            this.BttAlterar.Visible = false;
            this.BttAlterar.Click += new System.EventHandler(this.BttAlterar_Click);
            // 
            // BttNovo
            // 
            this.BttNovo.Location = new System.Drawing.Point(169, 225);
            this.BttNovo.Name = "BttNovo";
            this.BttNovo.Size = new System.Drawing.Size(75, 23);
            this.BttNovo.TabIndex = 13;
            this.BttNovo.Text = "Novo";
            this.BttNovo.UseVisualStyleBackColor = true;
            this.BttNovo.Click += new System.EventHandler(this.BttNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBoxNome);
            this.groupBox1.Location = new System.Drawing.Point(7, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 101);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            // 
            // TxtBoxCodigo
            // 
            this.TxtBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxCodigo.Enabled = false;
            this.TxtBoxCodigo.Location = new System.Drawing.Point(6, 32);
            this.TxtBoxCodigo.Name = "TxtBoxCodigo";
            this.TxtBoxCodigo.Size = new System.Drawing.Size(85, 20);
            this.TxtBoxCodigo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxNome.Location = new System.Drawing.Point(6, 71);
            this.TxtBoxNome.Name = "TxtBoxNome";
            this.TxtBoxNome.Size = new System.Drawing.Size(295, 20);
            this.TxtBoxNome.TabIndex = 9;
            // 
            // BttVoltar
            // 
            this.BttVoltar.Location = new System.Drawing.Point(88, 225);
            this.BttVoltar.Name = "BttVoltar";
            this.BttVoltar.Size = new System.Drawing.Size(75, 23);
            this.BttVoltar.TabIndex = 11;
            this.BttVoltar.Text = "Voltar";
            this.BttVoltar.UseVisualStyleBackColor = true;
            this.BttVoltar.Click += new System.EventHandler(this.BttVoltar_Click);
            // 
            // BttCadastrar
            // 
            this.BttCadastrar.Location = new System.Drawing.Point(7, 225);
            this.BttCadastrar.Name = "BttCadastrar";
            this.BttCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BttCadastrar.TabIndex = 10;
            this.BttCadastrar.Text = "Cadastro";
            this.BttCadastrar.UseVisualStyleBackColor = true;
            this.BttCadastrar.Click += new System.EventHandler(this.BttCadastrar_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BttSelecionar);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.bindingNavigator2);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // BttSelecionar
            // 
            this.BttSelecionar.Location = new System.Drawing.Point(299, 38);
            this.BttSelecionar.Name = "BttSelecionar";
            this.BttSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BttSelecionar.TabIndex = 6;
            this.BttSelecionar.Text = "Selecionar";
            this.BttSelecionar.UseVisualStyleBackColor = true;
            this.BttSelecionar.Visible = false;
            this.BttSelecionar.Click += new System.EventHandler(this.BttSelecionar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 3;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.tipoOrcamentoBindingSource;
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
            this.toolStripButtonAdd,
            this.toolStripButtonDelete,
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
            // tipoOrcamentoBindingSource
            // 
            this.tipoOrcamentoBindingSource.DataMember = "TipoOrcamento";
            this.tipoOrcamentoBindingSource.DataSource = this.sCOOPDataSet;
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
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::SCOOP.Properties.Resources.novo;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButton2";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::SCOOP.Properties.Resources.delete;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton1";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButton10_Click);
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
            this.codigopaiDataGridViewTextBoxColumn,
            this.DotacaoOrcamentaria,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.tipoOrcamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(389, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // codigopaiDataGridViewTextBoxColumn
            // 
            this.codigopaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigopaiDataGridViewTextBoxColumn.DataPropertyName = "Codigo_pai";
            this.codigopaiDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigopaiDataGridViewTextBoxColumn.Name = "codigopaiDataGridViewTextBoxColumn";
            this.codigopaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigopaiDataGridViewTextBoxColumn.Width = 65;
            // 
            // DotacaoOrcamentaria
            // 
            this.DotacaoOrcamentaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DotacaoOrcamentaria.HeaderText = "Dotação Orçamentaria";
            this.DotacaoOrcamentaria.Name = "DotacaoOrcamentaria";
            this.DotacaoOrcamentaria.ReadOnly = true;
            this.DotacaoOrcamentaria.Width = 127;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo Orçamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoOrcamentoTableAdapter
            // 
            this.tipoOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // dotacaoOrcamentariaTableAdapter
            // 
            this.dotacaoOrcamentariaTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroGrupoMedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 316);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroGrupoMedicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Grupo Medição";
            this.Load += new System.EventHandler(this.CadastroGrupo_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CadastroGrupoMedicao_PreviewKeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotacaoOrcamentariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BttVoltar;
        private System.Windows.Forms.Button BttCadastrar;
        private System.Windows.Forms.TextBox TxtBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
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
        private System.Windows.Forms.Button BttNovo;
        private System.Windows.Forms.Button BttAlterar;
        private System.Windows.Forms.Button BttSelecionar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource tipoOrcamentoBindingSource;
        private TipoOrcamentoTableAdapter tipoOrcamentoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox DotacaoOrcamentariacomboBox;
        private System.Windows.Forms.BindingSource dotacaoOrcamentariaBindingSource;
        private DotacaoOrcamentariaTableAdapter dotacaoOrcamentariaTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DotacaoOrcamentaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}