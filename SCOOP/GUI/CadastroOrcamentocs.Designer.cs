using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroOrcamentocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOrcamentocs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BttContrato = new System.Windows.Forms.Button();
            this.TxtBoxTotalOrçamento = new System.Windows.Forms.TextBox();
            this.BDIComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GrupoBoxServicos = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BttCancelar = new System.Windows.Forms.Button();
            this.BttConfirma = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.orcServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
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
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.BttImportar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtBoxUnidadeServico = new System.Windows.Forms.TextBox();
            this.LnkCodigo = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTxtBoxCodServico = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxServicoQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescricaoServico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ServicodataGridView1 = new System.Windows.Forms.DataGridView();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoOrcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqOrcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CidadeTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DotacaoOrcamentariaComboBox = new System.Windows.Forms.ComboBox();
            this.dotacaoOrcamentariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.BttNovo = new System.Windows.Forms.Button();
            this.BttAtualizar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TxtBoxLocal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MskTxtDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.BairroComboBox = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TipoOrcamentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FiscalComboBox = new System.Windows.Forms.ComboBox();
            this.fiscalizacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BttCadastrarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTxtBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BttPesquisa = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sequencialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dotacaoOrcamentariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOrcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcriacaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.BairroTableAdapter();
            this.dotacaoOrcamentariaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.DotacaoOrcamentariaTableAdapter();
            this.tipoOrcamentoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.TipoOrcamentoTableAdapter();
            this.fiscalizacaoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.FiscalizacaoTableAdapter();
            this.orc_ServicoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Orc_ServicoTableAdapter();
            this.orcamentoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GrupoBoxServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicodataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotacaoOrcamentariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalizacaoBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.BttContrato);
            this.tabPage1.Controls.Add(this.TxtBoxTotalOrçamento);
            this.tabPage1.Controls.Add(this.BDIComboBox);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.GrupoBoxServicos);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.ServicodataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(644, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 44);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B.D.I.";
            this.groupBox2.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(73, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Por Serviço";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Padrão";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BttContrato
            // 
            this.BttContrato.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BttContrato.Enabled = false;
            this.BttContrato.Location = new System.Drawing.Point(463, 512);
            this.BttContrato.Name = "BttContrato";
            this.BttContrato.Size = new System.Drawing.Size(75, 23);
            this.BttContrato.TabIndex = 33;
            this.BttContrato.Text = "Contrato";
            this.BttContrato.UseVisualStyleBackColor = true;
            this.BttContrato.Visible = false;
            // 
            // TxtBoxTotalOrçamento
            // 
            this.TxtBoxTotalOrçamento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtBoxTotalOrçamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxTotalOrçamento.Location = new System.Drawing.Point(313, 514);
            this.TxtBoxTotalOrçamento.Name = "TxtBoxTotalOrçamento";
            this.TxtBoxTotalOrçamento.Size = new System.Drawing.Size(144, 20);
            this.TxtBoxTotalOrçamento.TabIndex = 31;
            this.TxtBoxTotalOrçamento.Text = "0,00";
            this.TxtBoxTotalOrçamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxTotalOrçamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxTotalOrçamento_KeyPress);
            // 
            // BDIComboBox
            // 
            this.BDIComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BDIComboBox.FormattingEnabled = true;
            this.BDIComboBox.Items.AddRange(new object[] {
            "",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.BDIComboBox.Location = new System.Drawing.Point(186, 514);
            this.BDIComboBox.MaxLength = 2;
            this.BDIComboBox.Name = "BDIComboBox";
            this.BDIComboBox.Size = new System.Drawing.Size(121, 21);
            this.BDIComboBox.TabIndex = 32;
            this.BDIComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.BDIComboBox.TextChanged += new System.EventHandler(this.BDIComboBox_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 496);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total Orçamento";
            // 
            // GrupoBoxServicos
            // 
            this.GrupoBoxServicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupoBoxServicos.Controls.Add(this.label17);
            this.GrupoBoxServicos.Controls.Add(this.button1);
            this.GrupoBoxServicos.Controls.Add(this.BttCancelar);
            this.GrupoBoxServicos.Controls.Add(this.BttConfirma);
            this.GrupoBoxServicos.Controls.Add(this.bindingNavigator1);
            this.GrupoBoxServicos.Controls.Add(this.BttImportar);
            this.GrupoBoxServicos.Controls.Add(this.button2);
            this.GrupoBoxServicos.Controls.Add(this.TxtBoxUnidadeServico);
            this.GrupoBoxServicos.Controls.Add(this.LnkCodigo);
            this.GrupoBoxServicos.Controls.Add(this.label9);
            this.GrupoBoxServicos.Controls.Add(this.mskTxtBoxCodServico);
            this.GrupoBoxServicos.Controls.Add(this.TxtBoxValorUnitario);
            this.GrupoBoxServicos.Controls.Add(this.label7);
            this.GrupoBoxServicos.Controls.Add(this.TxtBoxServicoQuantidade);
            this.GrupoBoxServicos.Controls.Add(this.label8);
            this.GrupoBoxServicos.Controls.Add(this.label6);
            this.GrupoBoxServicos.Controls.Add(this.TxtDescricaoServico);
            this.GrupoBoxServicos.Enabled = false;
            this.GrupoBoxServicos.Location = new System.Drawing.Point(0, 228);
            this.GrupoBoxServicos.Name = "GrupoBoxServicos";
            this.GrupoBoxServicos.Size = new System.Drawing.Size(755, 115);
            this.GrupoBoxServicos.TabIndex = 28;
            this.GrupoBoxServicos.TabStop = false;
            this.GrupoBoxServicos.Text = "Serviços";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(91, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "F1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BttCancelar
            // 
            this.BttCancelar.Location = new System.Drawing.Point(392, 90);
            this.BttCancelar.Name = "BttCancelar";
            this.BttCancelar.Size = new System.Drawing.Size(75, 23);
            this.BttCancelar.TabIndex = 22;
            this.BttCancelar.Text = "Cancelar";
            this.BttCancelar.UseVisualStyleBackColor = true;
            this.BttCancelar.Visible = false;
            this.BttCancelar.Click += new System.EventHandler(this.BttCancelar_Click);
            // 
            // BttConfirma
            // 
            this.BttConfirma.Location = new System.Drawing.Point(311, 90);
            this.BttConfirma.Name = "BttConfirma";
            this.BttConfirma.Size = new System.Drawing.Size(75, 23);
            this.BttConfirma.TabIndex = 17;
            this.BttConfirma.Text = "Confirma";
            this.BttConfirma.UseVisualStyleBackColor = true;
            this.BttConfirma.Visible = false;
            this.BttConfirma.Click += new System.EventHandler(this.BttConfirma_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindingNavigator1.BindingSource = this.orcServicoBindingSource;
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
            this.bindingNavigatorEditItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(6, 86);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(302, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // orcServicoBindingSource
            // 
            this.orcServicoBindingSource.DataMember = "Orc_Servico";
            this.orcServicoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(47, 22);
            this.bindingNavigatorAddNewItem.Text = "- F5";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = global::SCOOP.Properties.Resources.edit1;
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorEditItem.Text = "toolStripButton1";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // BttImportar
            // 
            this.BttImportar.Location = new System.Drawing.Point(6, 60);
            this.BttImportar.Name = "BttImportar";
            this.BttImportar.Size = new System.Drawing.Size(75, 23);
            this.BttImportar.TabIndex = 15;
            this.BttImportar.Text = "Importar - F2";
            this.BttImportar.UseVisualStyleBackColor = true;
            this.BttImportar.Click += new System.EventHandler(this.BttImportar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.button2.Location = new System.Drawing.Point(89, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtBoxUnidadeServico
            // 
            this.TxtBoxUnidadeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxUnidadeServico.Enabled = false;
            this.TxtBoxUnidadeServico.Location = new System.Drawing.Point(523, 33);
            this.TxtBoxUnidadeServico.MaxLength = 2;
            this.TxtBoxUnidadeServico.Name = "TxtBoxUnidadeServico";
            this.TxtBoxUnidadeServico.Size = new System.Drawing.Size(39, 20);
            this.TxtBoxUnidadeServico.TabIndex = 3;
            // 
            // LnkCodigo
            // 
            this.LnkCodigo.AutoSize = true;
            this.LnkCodigo.Location = new System.Drawing.Point(6, 17);
            this.LnkCodigo.Name = "LnkCodigo";
            this.LnkCodigo.Size = new System.Drawing.Size(40, 13);
            this.LnkCodigo.TabIndex = 18;
            this.LnkCodigo.TabStop = true;
            this.LnkCodigo.Text = "Codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Unidade";
            // 
            // mskTxtBoxCodServico
            // 
            this.mskTxtBoxCodServico.Location = new System.Drawing.Point(6, 33);
            this.mskTxtBoxCodServico.Mask = "000.000.0000";
            this.mskTxtBoxCodServico.Name = "mskTxtBoxCodServico";
            this.mskTxtBoxCodServico.Size = new System.Drawing.Size(77, 20);
            this.mskTxtBoxCodServico.TabIndex = 1;
            this.mskTxtBoxCodServico.TextChanged += new System.EventHandler(this.mskTxtBoxCodServico_TextChanged);
            // 
            // TxtBoxValorUnitario
            // 
            this.TxtBoxValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxValorUnitario.Enabled = false;
            this.TxtBoxValorUnitario.Location = new System.Drawing.Point(652, 32);
            this.TxtBoxValorUnitario.Name = "TxtBoxValorUnitario";
            this.TxtBoxValorUnitario.Size = new System.Drawing.Size(67, 20);
            this.TxtBoxValorUnitario.TabIndex = 6;
            this.TxtBoxValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxValorUnitario_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor Unitário";
            // 
            // TxtBoxServicoQuantidade
            // 
            this.TxtBoxServicoQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxServicoQuantidade.Location = new System.Drawing.Point(578, 33);
            this.TxtBoxServicoQuantidade.Name = "TxtBoxServicoQuantidade";
            this.TxtBoxServicoQuantidade.Size = new System.Drawing.Size(59, 20);
            this.TxtBoxServicoQuantidade.TabIndex = 4;
            this.TxtBoxServicoQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxServicoQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxServicoQuantidade_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(575, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descrição";
            // 
            // TxtDescricaoServico
            // 
            this.TxtDescricaoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescricaoServico.Enabled = false;
            this.TxtDescricaoServico.Location = new System.Drawing.Point(119, 33);
            this.TxtDescricaoServico.Multiline = true;
            this.TxtDescricaoServico.Name = "TxtDescricaoServico";
            this.TxtDescricaoServico.Size = new System.Drawing.Size(388, 50);
            this.TxtDescricaoServico.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "BDI em %";
            // 
            // ServicodataGridView1
            // 
            this.ServicodataGridView1.AllowUserToAddRows = false;
            this.ServicodataGridView1.AllowUserToDeleteRows = false;
            this.ServicodataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicodataGridView1.AutoGenerateColumns = false;
            this.ServicodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicodataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.seqServicoDataGridViewTextBoxColumn,
            this.codigoOrcamentoDataGridViewTextBoxColumn,
            this.Descricao,
            this.Unidade,
            this.dataGridViewTextBoxColumn2,
            this.Valor,
            this.Total,
            this.seqOrcamentoDataGridViewTextBoxColumn,
            this.dtCriacaoDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.ServicodataGridView1.DataSource = this.orcServicoBindingSource;
            this.ServicodataGridView1.Location = new System.Drawing.Point(3, 347);
            this.ServicodataGridView1.Name = "ServicodataGridView1";
            this.ServicodataGridView1.ReadOnly = true;
            this.ServicodataGridView1.Size = new System.Drawing.Size(752, 142);
            this.ServicodataGridView1.TabIndex = 26;
            this.ServicodataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ServicodataGridView1_DataBindingComplete);
            // 
            // sequencialDataGridViewTextBoxColumn
            // 
            this.sequencialDataGridViewTextBoxColumn.DataPropertyName = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.Name = "sequencialDataGridViewTextBoxColumn";
            this.sequencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Servico";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo do Serviço";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // seqServicoDataGridViewTextBoxColumn
            // 
            this.seqServicoDataGridViewTextBoxColumn.DataPropertyName = "Seq_Servico";
            this.seqServicoDataGridViewTextBoxColumn.HeaderText = "Seq_Servico";
            this.seqServicoDataGridViewTextBoxColumn.Name = "seqServicoDataGridViewTextBoxColumn";
            this.seqServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.seqServicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoOrcamentoDataGridViewTextBoxColumn
            // 
            this.codigoOrcamentoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Orcamento";
            this.codigoOrcamentoDataGridViewTextBoxColumn.HeaderText = "Codigo_Orcamento";
            this.codigoOrcamentoDataGridViewTextBoxColumn.Name = "codigoOrcamentoDataGridViewTextBoxColumn";
            this.codigoOrcamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoOrcamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Unidade
            // 
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // seqOrcamentoDataGridViewTextBoxColumn
            // 
            this.seqOrcamentoDataGridViewTextBoxColumn.DataPropertyName = "Seq_Orcamento";
            this.seqOrcamentoDataGridViewTextBoxColumn.HeaderText = "Seq_Orcamento";
            this.seqOrcamentoDataGridViewTextBoxColumn.Name = "seqOrcamentoDataGridViewTextBoxColumn";
            this.seqOrcamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.seqOrcamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtCriacaoDataGridViewTextBoxColumn
            // 
            this.dtCriacaoDataGridViewTextBoxColumn.DataPropertyName = "Dt_Criacao";
            this.dtCriacaoDataGridViewTextBoxColumn.HeaderText = "Dt_Criacao";
            this.dtCriacaoDataGridViewTextBoxColumn.Name = "dtCriacaoDataGridViewTextBoxColumn";
            this.dtCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtCriacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtAlteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CidadeTextBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.DotacaoOrcamentariaComboBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.BttNovo);
            this.groupBox1.Controls.Add(this.BttAtualizar);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.TxtBoxLocal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MskTxtDataCriacao);
            this.groupBox1.Controls.Add(this.BairroComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TipoOrcamentoComboBox);
            this.groupBox1.Controls.Add(this.FiscalComboBox);
            this.groupBox1.Controls.Add(this.BttCadastrarServico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MskTxtBoxCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtBoxDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 229);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Orçamento";
            // 
            // CidadeTextBox
            // 
            this.CidadeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CidadeTextBox.Location = new System.Drawing.Point(672, 128);
            this.CidadeTextBox.Name = "CidadeTextBox";
            this.CidadeTextBox.Size = new System.Drawing.Size(80, 20);
            this.CidadeTextBox.TabIndex = 6;
            this.CidadeTextBox.Text = "CARUARU";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(670, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Cidade";
            // 
            // DotacaoOrcamentariaComboBox
            // 
            this.DotacaoOrcamentariaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DotacaoOrcamentariaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DotacaoOrcamentariaComboBox.DataSource = this.dotacaoOrcamentariaBindingSource;
            this.DotacaoOrcamentariaComboBox.DisplayMember = "Descricao";
            this.DotacaoOrcamentariaComboBox.FormattingEnabled = true;
            this.DotacaoOrcamentariaComboBox.Location = new System.Drawing.Point(13, 168);
            this.DotacaoOrcamentariaComboBox.Name = "DotacaoOrcamentariaComboBox";
            this.DotacaoOrcamentariaComboBox.Size = new System.Drawing.Size(415, 21);
            this.DotacaoOrcamentariaComboBox.TabIndex = 7;
            this.DotacaoOrcamentariaComboBox.ValueMember = "Codigo";
            this.DotacaoOrcamentariaComboBox.SelectedIndexChanged += new System.EventHandler(this.DotacaoOrcamentariaComboBox_SelectedIndexChanged);
            // 
            // dotacaoOrcamentariaBindingSource
            // 
            this.dotacaoOrcamentariaBindingSource.DataMember = "DotacaoOrcamentaria";
            this.dotacaoOrcamentariaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Dotação Orçamentario";
            // 
            // BttNovo
            // 
            this.BttNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BttNovo.Location = new System.Drawing.Point(260, 204);
            this.BttNovo.Name = "BttNovo";
            this.BttNovo.Size = new System.Drawing.Size(75, 23);
            this.BttNovo.TabIndex = 16;
            this.BttNovo.Text = "Novo";
            this.BttNovo.UseVisualStyleBackColor = true;
            this.BttNovo.Click += new System.EventHandler(this.BttNovo_Click);
            // 
            // BttAtualizar
            // 
            this.BttAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BttAtualizar.Location = new System.Drawing.Point(179, 204);
            this.BttAtualizar.Name = "BttAtualizar";
            this.BttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BttAtualizar.TabIndex = 15;
            this.BttAtualizar.Text = "Atualizar";
            this.BttAtualizar.UseVisualStyleBackColor = true;
            this.BttAtualizar.Visible = false;
            this.BttAtualizar.Click += new System.EventHandler(this.BttAtualizar_Click);
            // 
            // button6
            // 
            this.button6.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.button6.Location = new System.Drawing.Point(728, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.button5.Location = new System.Drawing.Point(648, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 24);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.button4.Location = new System.Drawing.Point(728, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 24);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtBoxLocal
            // 
            this.TxtBoxLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxLocal.Location = new System.Drawing.Point(96, 129);
            this.TxtBoxLocal.Name = "TxtBoxLocal";
            this.TxtBoxLocal.Size = new System.Drawing.Size(332, 20);
            this.TxtBoxLocal.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Logradouro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Data de Criação";
            // 
            // MskTxtDataCriacao
            // 
            this.MskTxtDataCriacao.Enabled = false;
            this.MskTxtDataCriacao.Location = new System.Drawing.Point(14, 129);
            this.MskTxtDataCriacao.Mask = "00/00/0000";
            this.MskTxtDataCriacao.Name = "MskTxtDataCriacao";
            this.MskTxtDataCriacao.Size = new System.Drawing.Size(75, 20);
            this.MskTxtDataCriacao.TabIndex = 3;
            // 
            // BairroComboBox
            // 
            this.BairroComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BairroComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BairroComboBox.DataSource = this.bairroBindingSource;
            this.BairroComboBox.DisplayMember = "Descricao";
            this.BairroComboBox.FormattingEnabled = true;
            this.BairroComboBox.Location = new System.Drawing.Point(434, 129);
            this.BairroComboBox.Name = "BairroComboBox";
            this.BairroComboBox.Size = new System.Drawing.Size(207, 21);
            this.BairroComboBox.TabIndex = 5;
            this.BairroComboBox.ValueMember = "Codigo";
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "Bairro";
            this.bairroBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bairro";
            // 
            // TipoOrcamentoComboBox
            // 
            this.TipoOrcamentoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TipoOrcamentoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TipoOrcamentoComboBox.DataSource = this.tipoOrcamentoBindingSource;
            this.TipoOrcamentoComboBox.DisplayMember = "Descricao";
            this.TipoOrcamentoComboBox.FormattingEnabled = true;
            this.TipoOrcamentoComboBox.Location = new System.Drawing.Point(434, 168);
            this.TipoOrcamentoComboBox.Name = "TipoOrcamentoComboBox";
            this.TipoOrcamentoComboBox.Size = new System.Drawing.Size(289, 21);
            this.TipoOrcamentoComboBox.TabIndex = 8;
            this.TipoOrcamentoComboBox.ValueMember = "Codigo";
            // 
            // tipoOrcamentoBindingSource
            // 
            this.tipoOrcamentoBindingSource.DataMember = "TipoOrcamento";
            this.tipoOrcamentoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // FiscalComboBox
            // 
            this.FiscalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FiscalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FiscalComboBox.DataSource = this.fiscalizacaoBindingSource;
            this.FiscalComboBox.DisplayMember = "Descricao";
            this.FiscalComboBox.FormattingEnabled = true;
            this.FiscalComboBox.Location = new System.Drawing.Point(434, 204);
            this.FiscalComboBox.Name = "FiscalComboBox";
            this.FiscalComboBox.Size = new System.Drawing.Size(288, 21);
            this.FiscalComboBox.TabIndex = 9;
            this.FiscalComboBox.ValueMember = "Codigo";
            // 
            // fiscalizacaoBindingSource
            // 
            this.fiscalizacaoBindingSource.DataMember = "Fiscalizacao";
            this.fiscalizacaoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // BttCadastrarServico
            // 
            this.BttCadastrarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BttCadastrarServico.Location = new System.Drawing.Point(98, 204);
            this.BttCadastrarServico.Name = "BttCadastrarServico";
            this.BttCadastrarServico.Size = new System.Drawing.Size(75, 23);
            this.BttCadastrarServico.TabIndex = 11;
            this.BttCadastrarServico.Text = "Cadastrar";
            this.BttCadastrarServico.UseVisualStyleBackColor = true;
            this.BttCadastrarServico.Click += new System.EventHandler(this.BttCadastrarServico_Click);
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
            // MskTxtBoxCodigo
            // 
            this.MskTxtBoxCodigo.Enabled = false;
            this.MskTxtBoxCodigo.Location = new System.Drawing.Point(14, 32);
            this.MskTxtBoxCodigo.Mask = "0000/00";
            this.MskTxtBoxCodigo.Name = "MskTxtBoxCodigo";
            this.MskTxtBoxCodigo.Size = new System.Drawing.Size(65, 20);
            this.MskTxtBoxCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição Orçamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do Fiscal";
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxDescricao.Location = new System.Drawing.Point(96, 32);
            this.TxtBoxDescricao.Multiline = true;
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.Size = new System.Drawing.Size(656, 77);
            this.TxtBoxDescricao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Orçamento";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.BttPesquisa);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BttPesquisa
            // 
            this.BttPesquisa.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.BttPesquisa.Location = new System.Drawing.Point(186, 39);
            this.BttPesquisa.Name = "BttPesquisa";
            this.BttPesquisa.Size = new System.Drawing.Size(24, 24);
            this.BttPesquisa.TabIndex = 9;
            this.BttPesquisa.UseVisualStyleBackColor = true;
            this.BttPesquisa.Click += new System.EventHandler(this.BttPesquisa_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Digite aqui sua Pesquisa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.orcamentoBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton1});
            this.bindingNavigator2.Location = new System.Drawing.Point(5, 94);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(278, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "Orcamento";
            this.orcamentoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Adicionar";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Deletar";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SCOOP.Properties.Resources.edit1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Alterar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dotacaoOrcamentariaDataGridViewTextBoxColumn,
            this.tipoOrcamentoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dtcriacaoDataGridViewTextBoxColumn1,
            this.dtAlteracaoDataGridViewTextBoxColumn1,
            this.bDIDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.orcamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // sequencialDataGridViewTextBoxColumn1
            // 
            this.sequencialDataGridViewTextBoxColumn1.DataPropertyName = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn1.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn1.Name = "sequencialDataGridViewTextBoxColumn1";
            this.sequencialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Logradouro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn7.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dotacaoOrcamentariaDataGridViewTextBoxColumn
            // 
            this.dotacaoOrcamentariaDataGridViewTextBoxColumn.DataPropertyName = "DotacaoOrcamentaria";
            this.dotacaoOrcamentariaDataGridViewTextBoxColumn.HeaderText = "DotacaoOrcamentaria";
            this.dotacaoOrcamentariaDataGridViewTextBoxColumn.Name = "dotacaoOrcamentariaDataGridViewTextBoxColumn";
            this.dotacaoOrcamentariaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoOrcamentoDataGridViewTextBoxColumn
            // 
            this.tipoOrcamentoDataGridViewTextBoxColumn.DataPropertyName = "TipoOrcamento";
            this.tipoOrcamentoDataGridViewTextBoxColumn.HeaderText = "TipoOrcamento";
            this.tipoOrcamentoDataGridViewTextBoxColumn.Name = "tipoOrcamentoDataGridViewTextBoxColumn";
            this.tipoOrcamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Fiscal";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fiscal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dtcriacaoDataGridViewTextBoxColumn1
            // 
            this.dtcriacaoDataGridViewTextBoxColumn1.DataPropertyName = "Dt_criacao";
            this.dtcriacaoDataGridViewTextBoxColumn1.HeaderText = "Dt_criacao";
            this.dtcriacaoDataGridViewTextBoxColumn1.Name = "dtcriacaoDataGridViewTextBoxColumn1";
            // 
            // dtAlteracaoDataGridViewTextBoxColumn1
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn1.DataPropertyName = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn1.HeaderText = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn1.Name = "dtAlteracaoDataGridViewTextBoxColumn1";
            this.dtAlteracaoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bDIDataGridViewTextBoxColumn
            // 
            this.bDIDataGridViewTextBoxColumn.DataPropertyName = "BDI";
            this.bDIDataGridViewTextBoxColumn.HeaderText = "BDI";
            this.bDIDataGridViewTextBoxColumn.Name = "bDIDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // dotacaoOrcamentariaTableAdapter
            // 
            this.dotacaoOrcamentariaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoOrcamentoTableAdapter
            // 
            this.tipoOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // fiscalizacaoTableAdapter
            // 
            this.fiscalizacaoTableAdapter.ClearBeforeFill = true;
            // 
            // orc_ServicoTableAdapter
            // 
            this.orc_ServicoTableAdapter.ClearBeforeFill = true;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.Location = new System.Drawing.Point(286, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "Imprimir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // CadastroOrcamentocs
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 577);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "CadastroOrcamentocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Orçamento";
            this.Load += new System.EventHandler(this.CadastroOrcamentocs_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastroOrcamentocs_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CadastroOrcamentocs_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroOrcamentocs_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GrupoBoxServicos.ResumeLayout(false);
            this.GrupoBoxServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicodataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotacaoOrcamentariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalizacaoBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BttContrato;
        public System.Windows.Forms.TextBox TxtBoxTotalOrçamento;
        private System.Windows.Forms.ComboBox BDIComboBox;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.GroupBox GrupoBoxServicos;
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
        private System.Windows.Forms.Button BttImportar;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox TxtBoxUnidadeServico;
        private System.Windows.Forms.LinkLabel LnkCodigo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox mskTxtBoxCodServico;
        public System.Windows.Forms.TextBox TxtBoxValorUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoxServicoQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtDescricaoServico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView ServicodataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox TxtBoxLocal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox MskTxtDataCriacao;
        public System.Windows.Forms.ComboBox BairroComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox TipoOrcamentoComboBox;
        private System.Windows.Forms.Button BttCadastrarServico;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox MskTxtBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtBoxDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Button BttPesquisa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button BttAtualizar;
        private System.Windows.Forms.Button BttNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrcamentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BttCancelar;
        private System.Windows.Forms.Button BttConfirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private BairroTableAdapter bairroTableAdapter;
        public System.Windows.Forms.ComboBox DotacaoOrcamentariaComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource dotacaoOrcamentariaBindingSource;
        private DotacaoOrcamentariaTableAdapter dotacaoOrcamentariaTableAdapter;
        private System.Windows.Forms.BindingSource tipoOrcamentoBindingSource;
        private TipoOrcamentoTableAdapter tipoOrcamentoTableAdapter;
        private System.Windows.Forms.BindingSource fiscalizacaoBindingSource;
        private FiscalizacaoTableAdapter fiscalizacaoTableAdapter;
        private System.Windows.Forms.BindingSource orcServicoBindingSource;
        private Orc_ServicoTableAdapter orc_ServicoTableAdapter;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private OrcamentoTableAdapter orcamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dotacaoOrcamentariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcriacaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.ComboBox FiscalComboBox;
        private System.Windows.Forms.TextBox CidadeTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button7;
    }
}