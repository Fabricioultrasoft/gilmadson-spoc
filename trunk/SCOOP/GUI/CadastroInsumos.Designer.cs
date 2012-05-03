using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroInsumos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BttNovo = new System.Windows.Forms.Button();
            this.BttAlterar = new System.Windows.Forms.Button();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.BttInserir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EncargosSociaisTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MslTxtBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.ComboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.grupoInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.ComboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxUnidade = new System.Windows.Forms.ComboBox();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxTipoInsumo = new System.Windows.Forms.ComboBox();
            this.tipoInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTxtBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.insumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigationEdit = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leisSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoInsumoTableAdapter1 = new SCOOP.DAO.SCOOPDataSetTableAdapters.TipoInsumoTableAdapter();
            this.grupoInsumoTableAdapter1 = new SCOOP.DAO.SCOOPDataSetTableAdapters.GrupoInsumoTableAdapter();
            this.unidadeTableAdapter1 = new SCOOP.DAO.SCOOPDataSetTableAdapters.UnidadeTableAdapter();
            this.fornecedorTableAdapter1 = new SCOOP.DAO.SCOOPDataSetTableAdapters.FornecedorTableAdapter();
            this.insumoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.InsumoTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoInsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInsumoBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 263);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.BttNovo);
            this.tabPage1.Controls.Add(this.BttAlterar);
            this.tabPage1.Controls.Add(this.bttVoltar);
            this.tabPage1.Controls.Add(this.BttInserir);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insumos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BttNovo
            // 
            this.BttNovo.Location = new System.Drawing.Point(235, 182);
            this.BttNovo.Name = "BttNovo";
            this.BttNovo.Size = new System.Drawing.Size(75, 23);
            this.BttNovo.TabIndex = 10;
            this.BttNovo.Text = "Novo";
            this.BttNovo.UseVisualStyleBackColor = true;
            this.BttNovo.Visible = false;
            this.BttNovo.Click += new System.EventHandler(this.BttNovo_Click);
            // 
            // BttAlterar
            // 
            this.BttAlterar.Location = new System.Drawing.Point(73, 182);
            this.BttAlterar.Name = "BttAlterar";
            this.BttAlterar.Size = new System.Drawing.Size(75, 23);
            this.BttAlterar.TabIndex = 9;
            this.BttAlterar.Text = "Alterar";
            this.BttAlterar.UseVisualStyleBackColor = true;
            this.BttAlterar.Visible = false;
            this.BttAlterar.Click += new System.EventHandler(this.BttAlterar_Click_1);
            // 
            // bttVoltar
            // 
            this.bttVoltar.Location = new System.Drawing.Point(154, 182);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttVoltar.TabIndex = 8;
            this.bttVoltar.Text = "Voltar";
            this.bttVoltar.UseVisualStyleBackColor = true;
            this.bttVoltar.Click += new System.EventHandler(this.bttAlterar_Click);
            // 
            // BttInserir
            // 
            this.BttInserir.Location = new System.Drawing.Point(73, 182);
            this.BttInserir.Name = "BttInserir";
            this.BttInserir.Size = new System.Drawing.Size(75, 23);
            this.BttInserir.TabIndex = 7;
            this.BttInserir.Text = "Inserir";
            this.BttInserir.UseVisualStyleBackColor = true;
            this.BttInserir.Click += new System.EventHandler(this.BttInserir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.EncargosSociaisTxtBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MslTxtBoxPreco);
            this.groupBox1.Controls.Add(this.ComboBoxGrupo);
            this.groupBox1.Controls.Add(this.ComboBoxFornecedor);
            this.groupBox1.Controls.Add(this.ComboBoxUnidade);
            this.groupBox1.Controls.Add(this.ComboBoxTipoInsumo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTxtBoxCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insumo";
            // 
            // EncargosSociaisTxtBox
            // 
            this.EncargosSociaisTxtBox.Location = new System.Drawing.Point(257, 102);
            this.EncargosSociaisTxtBox.Name = "EncargosSociaisTxtBox";
            this.EncargosSociaisTxtBox.Size = new System.Drawing.Size(78, 20);
            this.EncargosSociaisTxtBox.TabIndex = 19;
            this.EncargosSociaisTxtBox.Visible = false;
            this.EncargosSociaisTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MslTxtBoxPreco_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "EncargosSociais %";
            this.label8.Visible = false;
            // 
            // MslTxtBoxPreco
            // 
            this.MslTxtBoxPreco.Location = new System.Drawing.Point(67, 124);
            this.MslTxtBoxPreco.Name = "MslTxtBoxPreco";
            this.MslTxtBoxPreco.Size = new System.Drawing.Size(81, 20);
            this.MslTxtBoxPreco.TabIndex = 17;
            this.MslTxtBoxPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MslTxtBoxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MslTxtBoxPreco_KeyPress);
            // 
            // ComboBoxGrupo
            // 
            this.ComboBoxGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGrupo.DataSource = this.grupoInsumoBindingSource;
            this.ComboBoxGrupo.DisplayMember = "Descricao";
            this.ComboBoxGrupo.FormattingEnabled = true;
            this.ComboBoxGrupo.Location = new System.Drawing.Point(327, 25);
            this.ComboBoxGrupo.Name = "ComboBoxGrupo";
            this.ComboBoxGrupo.Size = new System.Drawing.Size(218, 21);
            this.ComboBoxGrupo.TabIndex = 16;
            this.ComboBoxGrupo.ValueMember = "Codigo";
            this.ComboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGrupo_SelectedIndexChanged);
            // 
            // grupoInsumoBindingSource
            // 
            this.grupoInsumoBindingSource.DataMember = "GrupoInsumo";
            this.grupoInsumoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboBoxFornecedor
            // 
            this.ComboBoxFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxFornecedor.DataSource = this.fornecedorBindingSource;
            this.ComboBoxFornecedor.DisplayMember = "Nome";
            this.ComboBoxFornecedor.FormattingEnabled = true;
            this.ComboBoxFornecedor.Location = new System.Drawing.Point(155, 125);
            this.ComboBoxFornecedor.Name = "ComboBoxFornecedor";
            this.ComboBoxFornecedor.Size = new System.Drawing.Size(390, 21);
            this.ComboBoxFornecedor.TabIndex = 15;
            this.ComboBoxFornecedor.ValueMember = "Codigo";
            this.ComboBoxFornecedor.Visible = false;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // ComboBoxUnidade
            // 
            this.ComboBoxUnidade.DataSource = this.unidadeBindingSource;
            this.ComboBoxUnidade.DisplayMember = "Descricao";
            this.ComboBoxUnidade.FormattingEnabled = true;
            this.ComboBoxUnidade.Location = new System.Drawing.Point(67, 99);
            this.ComboBoxUnidade.Name = "ComboBoxUnidade";
            this.ComboBoxUnidade.Size = new System.Drawing.Size(81, 21);
            this.ComboBoxUnidade.TabIndex = 14;
            this.ComboBoxUnidade.ValueMember = "Codigo";
            this.ComboBoxUnidade.TextChanged += new System.EventHandler(this.ComboBoxUnidade_TextChanged);
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataMember = "Unidade";
            this.unidadeBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // ComboBoxTipoInsumo
            // 
            this.ComboBoxTipoInsumo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxTipoInsumo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboBoxTipoInsumo.DataSource = this.tipoInsumoBindingSource;
            this.ComboBoxTipoInsumo.DisplayMember = "Nome";
            this.ComboBoxTipoInsumo.FormattingEnabled = true;
            this.ComboBoxTipoInsumo.Location = new System.Drawing.Point(150, 25);
            this.ComboBoxTipoInsumo.Name = "ComboBoxTipoInsumo";
            this.ComboBoxTipoInsumo.Size = new System.Drawing.Size(174, 21);
            this.ComboBoxTipoInsumo.TabIndex = 13;
            this.ComboBoxTipoInsumo.ValueMember = "Codigo";
            this.ComboBoxTipoInsumo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipoInsumo_SelectedIndexChanged);
            // 
            // tipoInsumoBindingSource
            // 
            this.tipoInsumoBindingSource.DataMember = "TipoInsumo";
            this.tipoInsumoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grupo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fornecedor";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxDescricao.Location = new System.Drawing.Point(67, 54);
            this.TxtBoxDescricao.Multiline = true;
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.Size = new System.Drawing.Size(478, 39);
            this.TxtBoxDescricao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // mskTxtBoxCodigo
            // 
            this.mskTxtBoxCodigo.Enabled = false;
            this.mskTxtBoxCodigo.Location = new System.Drawing.Point(67, 26);
            this.mskTxtBoxCodigo.Mask = "000,000,0000";
            this.mskTxtBoxCodigo.Name = "mskTxtBoxCodigo";
            this.mskTxtBoxCodigo.Size = new System.Drawing.Size(81, 20);
            this.mskTxtBoxCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.TxtBoxPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.insumoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.BindingNavigationEdit});
            this.bindingNavigator1.Location = new System.Drawing.Point(6, 39);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(278, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // insumoBindingSource
            // 
            this.insumoBindingSource.DataMember = "Insumo";
            this.insumoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // BindingNavigationEdit
            // 
            this.BindingNavigationEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigationEdit.Image = global::SCOOP.Properties.Resources.edit1;
            this.BindingNavigationEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BindingNavigationEdit.Name = "BindingNavigationEdit";
            this.BindingNavigationEdit.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigationEdit.Text = "Editar";
            this.BindingNavigationEdit.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxPesquisa
            // 
            this.TxtBoxPesquisa.Location = new System.Drawing.Point(6, 15);
            this.TxtBoxPesquisa.Name = "TxtBoxPesquisa";
            this.TxtBoxPesquisa.Size = new System.Drawing.Size(281, 20);
            this.TxtBoxPesquisa.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.leisSocialDataGridViewTextBoxColumn,
            this.encargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.insumoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // sequencialDataGridViewTextBoxColumn
            // 
            this.sequencialDataGridViewTextBoxColumn.DataPropertyName = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.Name = "sequencialDataGridViewTextBoxColumn";
            this.sequencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn.Visible = false;
            this.sequencialDataGridViewTextBoxColumn.Width = 85;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 72;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fornecedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 86;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TipoInsumo";
            this.dataGridViewTextBoxColumn5.HeaderText = "TipoInsumo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 87;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Grupo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 61;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // leisSocialDataGridViewTextBoxColumn
            // 
            this.leisSocialDataGridViewTextBoxColumn.DataPropertyName = "leisSocial";
            dataGridViewCellStyle2.Format = "C2";
            this.leisSocialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.leisSocialDataGridViewTextBoxColumn.HeaderText = "leisSocial";
            this.leisSocialDataGridViewTextBoxColumn.Name = "leisSocialDataGridViewTextBoxColumn";
            this.leisSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.leisSocialDataGridViewTextBoxColumn.Width = 76;
            // 
            // encargoDataGridViewTextBoxColumn
            // 
            this.encargoDataGridViewTextBoxColumn.DataPropertyName = "Encargo";
            dataGridViewCellStyle3.Format = "C2";
            this.encargoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.encargoDataGridViewTextBoxColumn.HeaderText = "Encargo";
            this.encargoDataGridViewTextBoxColumn.Name = "encargoDataGridViewTextBoxColumn";
            this.encargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.encargoDataGridViewTextBoxColumn.Width = 72;
            // 
            // tipoInsumoTableAdapter1
            // 
            this.tipoInsumoTableAdapter1.ClearBeforeFill = true;
            // 
            // grupoInsumoTableAdapter1
            // 
            this.grupoInsumoTableAdapter1.ClearBeforeFill = true;
            // 
            // unidadeTableAdapter1
            // 
            this.unidadeTableAdapter1.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter1
            // 
            this.fornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // insumoTableAdapter
            // 
            this.insumoTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "CadastroInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroInsumos";
            this.Load += new System.EventHandler(this.CadastroInsumos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoInsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoInsumoBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttVoltar;
        private System.Windows.Forms.Button BttInserir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MslTxtBoxPreco;
        private System.Windows.Forms.ComboBox ComboBoxGrupo;
        private System.Windows.Forms.ComboBox ComboBoxFornecedor;
        private System.Windows.Forms.ComboBox ComboBoxUnidade;
        private System.Windows.Forms.ComboBox ComboBoxTipoInsumo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBoxPesquisa;
         private System.Windows.Forms.Button BttNovo;
        private System.Windows.Forms.Button BttAlterar;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource tipoInsumoBindingSource;
        private TipoInsumoTableAdapter tipoInsumoTableAdapter1;
        private System.Windows.Forms.BindingSource grupoInsumoBindingSource;
        private GrupoInsumoTableAdapter grupoInsumoTableAdapter1;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private UnidadeTableAdapter unidadeTableAdapter1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private FornecedorTableAdapter fornecedorTableAdapter1;
        private System.Windows.Forms.BindingSource insumoBindingSource;
        private InsumoTableAdapter insumoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn leisSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton BindingNavigationEdit;
        private System.Windows.Forms.TextBox EncargosSociaisTxtBox;
        private System.Windows.Forms.Label label8;
    }
}