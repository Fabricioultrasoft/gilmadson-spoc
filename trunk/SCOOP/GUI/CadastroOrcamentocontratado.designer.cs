using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroOrcamentocontratado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOrcamentocontratado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.ProcessotextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ModalidadecomboBox = new System.Windows.Forms.ComboBox();
            this.BDIComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BttAtualizar = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.orcContServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSalvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOrdemServico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BttContrato = new System.Windows.Forms.Button();
            this.ContratoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskTxtDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBoxBairro = new System.Windows.Forms.TextBox();
            this.TxtBoxLogradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBoxCidade = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTxtBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DataInicioMskTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MksTxtBoxPrazo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxCGCCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxEmpreteira = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.BttCadastrarMedicao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBoxSecretaria = new System.Windows.Forms.ComboBox();
            this.secretariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxLicitado = new System.Windows.Forms.ComboBox();
            this.licitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.TxtBoxTotalOrçamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ServicodataGridView1 = new System.Windows.Forms.DataGridView();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoOrcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqOrcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BttPesquisa = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
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
            this.OrcamentoContratadodataGridView = new System.Windows.Forms.DataGridView();
            this.Sequencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Licitação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequencialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orcamentoContratadoViewDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licitadoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.LicitadoTableAdapter();
            this.secretariaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.SecretariaTableAdapter();
            this.orc_Cont_ServicoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Orc_Cont_ServicoTableAdapter();
            this.empresaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.EmpresaTableAdapter();
            this.orcamentoContratadoViewTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoContratadoViewTableAdapter();
            this.orcamentoContratadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orcamento_ContratadoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Orcamento_ContratadoTableAdapter();
            this.orcamentoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter();
            this.sCOOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcContServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicodataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoContratadodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoContratadoViewDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoContratadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSetBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(892, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.ProcessotextBox);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.ModalidadecomboBox);
            this.tabPage1.Controls.Add(this.BDIComboBox);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.BttAtualizar);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.TxtBoxTotalOrçamento);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ServicodataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Dotação";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(405, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "Processo";
            // 
            // ProcessotextBox
            // 
            this.ProcessotextBox.Location = new System.Drawing.Point(408, 233);
            this.ProcessotextBox.Name = "ProcessotextBox";
            this.ProcessotextBox.Size = new System.Drawing.Size(100, 20);
            this.ProcessotextBox.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Modalidade";
            // 
            // ModalidadecomboBox
            // 
            this.ModalidadecomboBox.FormattingEnabled = true;
            this.ModalidadecomboBox.Items.AddRange(new object[] {
            "",
            "Concorrência",
            "Tomada de Preço",
            "Convite",
            "Pregão",
            "Leilão",
            "Concurso",
            "Serviços Emergênciais"});
            this.ModalidadecomboBox.Location = new System.Drawing.Point(14, 233);
            this.ModalidadecomboBox.Name = "ModalidadecomboBox";
            this.ModalidadecomboBox.Size = new System.Drawing.Size(388, 21);
            this.ModalidadecomboBox.TabIndex = 51;
            // 
            // BDIComboBox
            // 
            this.BDIComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BDIComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BDIComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BDIComboBox.FormattingEnabled = true;
            this.BDIComboBox.Items.AddRange(new object[] {
            "",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.BDIComboBox.Location = new System.Drawing.Point(158, 622);
            this.BDIComboBox.Name = "BDIComboBox";
            this.BDIComboBox.Size = new System.Drawing.Size(121, 21);
            this.BDIComboBox.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 606);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "BDI";
            // 
            // BttAtualizar
            // 
            this.BttAtualizar.Location = new System.Drawing.Point(84, 269);
            this.BttAtualizar.Name = "BttAtualizar";
            this.BttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BttAtualizar.TabIndex = 47;
            this.BttAtualizar.Text = "Atualizar";
            this.BttAtualizar.UseVisualStyleBackColor = true;
            this.BttAtualizar.Visible = false;
            this.BttAtualizar.Click += new System.EventHandler(this.BttAtualizar_Click_1);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.orcContServicoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.ButtonSalvar});
            this.bindingNavigator1.Location = new System.Drawing.Point(14, 295);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(232, 25);
            this.bindingNavigator1.TabIndex = 46;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // orcContServicoBindingSource
            // 
            this.orcContServicoBindingSource.DataMember = "Orc_Cont_Servico";
            this.orcContServicoBindingSource.DataSource = this.sCOOPDataSet;
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
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
            // ButtonSalvar
            // 
            this.ButtonSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSalvar.Image = global::SCOOP.Properties.Resources.SaveFormDesignHH;
            this.ButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(23, 22);
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonOrdemServico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BttContrato);
            this.groupBox1.Controls.Add(this.ContratoMaskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(436, 589);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 57);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // buttonOrdemServico
            // 
            this.buttonOrdemServico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOrdemServico.Enabled = false;
            this.buttonOrdemServico.Location = new System.Drawing.Point(208, 25);
            this.buttonOrdemServico.Name = "buttonOrdemServico";
            this.buttonOrdemServico.Size = new System.Drawing.Size(103, 23);
            this.buttonOrdemServico.TabIndex = 47;
            this.buttonOrdemServico.Text = "Ordem de Serviço";
            this.buttonOrdemServico.UseVisualStyleBackColor = true;
            this.buttonOrdemServico.Visible = false;
            this.buttonOrdemServico.Click += new System.EventHandler(this.buttonOrdemServico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código do Contrato";
            // 
            // BttContrato
            // 
            this.BttContrato.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BttContrato.Location = new System.Drawing.Point(121, 24);
            this.BttContrato.Name = "BttContrato";
            this.BttContrato.Size = new System.Drawing.Size(75, 23);
            this.BttContrato.TabIndex = 46;
            this.BttContrato.Text = "Contrato";
            this.BttContrato.UseVisualStyleBackColor = true;
            this.BttContrato.Visible = false;
            this.BttContrato.Click += new System.EventHandler(this.BttContrato_Click_1);
            // 
            // ContratoMaskedTextBox
            // 
            this.ContratoMaskedTextBox.Enabled = false;
            this.ContratoMaskedTextBox.Location = new System.Drawing.Point(7, 33);
            this.ContratoMaskedTextBox.Mask = "00,00,000000/00";
            this.ContratoMaskedTextBox.Name = "ContratoMaskedTextBox";
            this.ContratoMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.ContratoMaskedTextBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.TxtBoxDescricao);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.MskTxtDataCriacao);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.TxtBoxBairro);
            this.groupBox5.Controls.Add(this.TxtBoxLogradouro);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.TxtBoxCidade);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(117, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(641, 99);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição Orçamento";
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxDescricao.Location = new System.Drawing.Point(9, 29);
            this.TxtBoxDescricao.Multiline = true;
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.Size = new System.Drawing.Size(539, 22);
            this.TxtBoxDescricao.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Data de Criação";
            // 
            // MskTxtDataCriacao
            // 
            this.MskTxtDataCriacao.Enabled = false;
            this.MskTxtDataCriacao.Location = new System.Drawing.Point(554, 31);
            this.MskTxtDataCriacao.Mask = "00/00/0000";
            this.MskTxtDataCriacao.Name = "MskTxtDataCriacao";
            this.MskTxtDataCriacao.Size = new System.Drawing.Size(75, 20);
            this.MskTxtDataCriacao.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Bairro";
            // 
            // TxtBoxBairro
            // 
            this.TxtBoxBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxBairro.Enabled = false;
            this.TxtBoxBairro.Location = new System.Drawing.Point(489, 70);
            this.TxtBoxBairro.Name = "TxtBoxBairro";
            this.TxtBoxBairro.Size = new System.Drawing.Size(146, 20);
            this.TxtBoxBairro.TabIndex = 19;
            // 
            // TxtBoxLogradouro
            // 
            this.TxtBoxLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxLogradouro.Enabled = false;
            this.TxtBoxLogradouro.Location = new System.Drawing.Point(157, 70);
            this.TxtBoxLogradouro.Name = "TxtBoxLogradouro";
            this.TxtBoxLogradouro.Size = new System.Drawing.Size(326, 20);
            this.TxtBoxLogradouro.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Logradouro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cidade";
            // 
            // TxtBoxCidade
            // 
            this.TxtBoxCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxCidade.Enabled = false;
            this.TxtBoxCidade.Location = new System.Drawing.Point(9, 70);
            this.TxtBoxCidade.Name = "TxtBoxCidade";
            this.TxtBoxCidade.Size = new System.Drawing.Size(139, 20);
            this.TxtBoxCidade.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.MskTxtBoxCodigo);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 99);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.Image = global::SCOOP.Properties.Resources.Cópia_de_Icon_Lupa;
            this.button5.Location = new System.Drawing.Point(9, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 35);
            this.button5.TabIndex = 36;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento";
            // 
            // MskTxtBoxCodigo
            // 
            this.MskTxtBoxCodigo.Enabled = false;
            this.MskTxtBoxCodigo.Location = new System.Drawing.Point(9, 29);
            this.MskTxtBoxCodigo.Mask = "0000/00";
            this.MskTxtBoxCodigo.Name = "MskTxtBoxCodigo";
            this.MskTxtBoxCodigo.Size = new System.Drawing.Size(65, 20);
            this.MskTxtBoxCodigo.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.DataInicioMskTxtBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.MksTxtBoxPrazo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TxtBoxCGCCPF);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.ComboBoxEmpreteira);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.BttCadastrarMedicao);
            this.groupBox4.Location = new System.Drawing.Point(408, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 103);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empresa contratada";
            // 
            // DataInicioMskTxtBox
            // 
            this.DataInicioMskTxtBox.Location = new System.Drawing.Point(157, 72);
            this.DataInicioMskTxtBox.Mask = "00/00/0000";
            this.DataInicioMskTxtBox.Name = "DataInicioMskTxtBox";
            this.DataInicioMskTxtBox.Size = new System.Drawing.Size(75, 20);
            this.DataInicioMskTxtBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Data Inicio";
            // 
            // MksTxtBoxPrazo
            // 
            this.MksTxtBoxPrazo.Location = new System.Drawing.Point(238, 73);
            this.MksTxtBoxPrazo.Mask = "00/00/0000";
            this.MksTxtBoxPrazo.Name = "MksTxtBoxPrazo";
            this.MksTxtBoxPrazo.Size = new System.Drawing.Size(75, 20);
            this.MksTxtBoxPrazo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Data Final da Obra";
            // 
            // TxtBoxCGCCPF
            // 
            this.TxtBoxCGCCPF.Enabled = false;
            this.TxtBoxCGCCPF.Location = new System.Drawing.Point(6, 73);
            this.TxtBoxCGCCPF.Name = "TxtBoxCGCCPF";
            this.TxtBoxCGCCPF.Size = new System.Drawing.Size(138, 20);
            this.TxtBoxCGCCPF.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "C.G.C ou CPF";
            // 
            // ComboBoxEmpreteira
            // 
            this.ComboBoxEmpreteira.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxEmpreteira.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxEmpreteira.DataSource = this.empresaBindingSource;
            this.ComboBoxEmpreteira.DisplayMember = "Descricao";
            this.ComboBoxEmpreteira.FormattingEnabled = true;
            this.ComboBoxEmpreteira.Location = new System.Drawing.Point(9, 33);
            this.ComboBoxEmpreteira.Name = "ComboBoxEmpreteira";
            this.ComboBoxEmpreteira.Size = new System.Drawing.Size(330, 21);
            this.ComboBoxEmpreteira.TabIndex = 4;
            this.ComboBoxEmpreteira.ValueMember = "CodigoEmpreteira";
            this.ComboBoxEmpreteira.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmpreteira_SelectedIndexChanged);
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Empresa";
            // 
            // BttCadastrarMedicao
            // 
            this.BttCadastrarMedicao.Location = new System.Drawing.Point(15, 245);
            this.BttCadastrarMedicao.Name = "BttCadastrarMedicao";
            this.BttCadastrarMedicao.Size = new System.Drawing.Size(75, 23);
            this.BttCadastrarMedicao.TabIndex = 14;
            this.BttCadastrarMedicao.Text = "Cadastrar";
            this.BttCadastrarMedicao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ComboBoxSecretaria);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ComboBoxLicitado);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(8, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 103);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contrato";
            // 
            // ComboBoxSecretaria
            // 
            this.ComboBoxSecretaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxSecretaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxSecretaria.DataSource = this.secretariaBindingSource;
            this.ComboBoxSecretaria.DisplayMember = "Descricao";
            this.ComboBoxSecretaria.FormattingEnabled = true;
            this.ComboBoxSecretaria.Location = new System.Drawing.Point(11, 72);
            this.ComboBoxSecretaria.Name = "ComboBoxSecretaria";
            this.ComboBoxSecretaria.Size = new System.Drawing.Size(377, 21);
            this.ComboBoxSecretaria.TabIndex = 3;
            this.ComboBoxSecretaria.ValueMember = "Codigo";
            // 
            // secretariaBindingSource
            // 
            this.secretariaBindingSource.DataMember = "Secretaria";
            this.secretariaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Secretaria";
            // 
            // ComboBoxLicitado
            // 
            this.ComboBoxLicitado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxLicitado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxLicitado.DataSource = this.licitadoBindingSource;
            this.ComboBoxLicitado.DisplayMember = "Descricao";
            this.ComboBoxLicitado.FormattingEnabled = true;
            this.ComboBoxLicitado.Location = new System.Drawing.Point(10, 32);
            this.ComboBoxLicitado.Name = "ComboBoxLicitado";
            this.ComboBoxLicitado.Size = new System.Drawing.Size(378, 21);
            this.ComboBoxLicitado.TabIndex = 2;
            this.ComboBoxLicitado.ValueMember = "Codigo";
            // 
            // licitadoBindingSource
            // 
            this.licitadoBindingSource.DataMember = "Licitado";
            this.licitadoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Licitado";
            // 
            // TxtBoxTotalOrçamento
            // 
            this.TxtBoxTotalOrçamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxTotalOrçamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxTotalOrçamento.Enabled = false;
            this.TxtBoxTotalOrçamento.Location = new System.Drawing.Point(285, 623);
            this.TxtBoxTotalOrçamento.Name = "TxtBoxTotalOrçamento";
            this.TxtBoxTotalOrçamento.Size = new System.Drawing.Size(144, 20);
            this.TxtBoxTotalOrçamento.TabIndex = 31;
            this.TxtBoxTotalOrçamento.Text = "0,00";
            this.TxtBoxTotalOrçamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxTotalOrçamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxTotalOrçamento_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 605);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total Orçamento";
            // 
            // ServicodataGridView1
            // 
            this.ServicodataGridView1.AllowUserToAddRows = false;
            this.ServicodataGridView1.AllowUserToDeleteRows = false;
            this.ServicodataGridView1.AllowUserToOrderColumns = true;
            this.ServicodataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicodataGridView1.AutoGenerateColumns = false;
            this.ServicodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServicodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicodataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialDataGridViewTextBoxColumn,
            this.codigoOrcamentoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.Descrição,
            this.seqServicoDataGridViewTextBoxColumn,
            this.seqOrcamentoDataGridViewTextBoxColumn,
            this.dtCriacaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.valorDataGridViewTextBoxColumn,
            this.Total,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.ServicodataGridView1.DataSource = this.orcContServicoBindingSource;
            this.ServicodataGridView1.Location = new System.Drawing.Point(3, 323);
            this.ServicodataGridView1.Name = "ServicodataGridView1";
            this.ServicodataGridView1.Size = new System.Drawing.Size(755, 260);
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
            // codigoOrcamentoDataGridViewTextBoxColumn
            // 
            this.codigoOrcamentoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Orcamento";
            this.codigoOrcamentoDataGridViewTextBoxColumn.HeaderText = "Codigo_Orcamento";
            this.codigoOrcamentoDataGridViewTextBoxColumn.Name = "codigoOrcamentoDataGridViewTextBoxColumn";
            this.codigoOrcamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Servico";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo_Servico";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // seqServicoDataGridViewTextBoxColumn
            // 
            this.seqServicoDataGridViewTextBoxColumn.DataPropertyName = "Seq_Servico";
            this.seqServicoDataGridViewTextBoxColumn.HeaderText = "Seq_Servico";
            this.seqServicoDataGridViewTextBoxColumn.Name = "seqServicoDataGridViewTextBoxColumn";
            this.seqServicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // seqOrcamentoDataGridViewTextBoxColumn
            // 
            this.seqOrcamentoDataGridViewTextBoxColumn.DataPropertyName = "Seq_Orcamento";
            this.seqOrcamentoDataGridViewTextBoxColumn.HeaderText = "Seq_Orcamento";
            this.seqOrcamentoDataGridViewTextBoxColumn.Name = "seqOrcamentoDataGridViewTextBoxColumn";
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // Total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BttPesquisa);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.PesquisaTextBox);
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Controls.Add(this.OrcamentoContratadodataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BttPesquisa
            // 
            this.BttPesquisa.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.BttPesquisa.Location = new System.Drawing.Point(257, 40);
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
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(8, 43);
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(243, 20);
            this.PesquisaTextBox.TabIndex = 2;
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
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 94);
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
            // OrcamentoContratadodataGridView
            // 
            this.OrcamentoContratadodataGridView.AllowUserToAddRows = false;
            this.OrcamentoContratadodataGridView.AllowUserToDeleteRows = false;
            this.OrcamentoContratadodataGridView.AllowUserToOrderColumns = true;
            this.OrcamentoContratadodataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OrcamentoContratadodataGridView.AutoGenerateColumns = false;
            this.OrcamentoContratadodataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrcamentoContratadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrcamentoContratadodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequencial,
            this.Codigo,
            this.Descricao,
            this.Logradouro,
            this.Licitação,
            this.Column1,
            this.Empresa,
            this.Bairro,
            this.Cidade,
            this.CEP,
            this.BDI,
            this.sequencialDataGridViewTextBoxColumn1,
            this.codigoDataGridViewTextBoxColumn});
            this.OrcamentoContratadodataGridView.DataSource = this.orcamentoBindingSource;
            this.OrcamentoContratadodataGridView.Location = new System.Drawing.Point(0, 122);
            this.OrcamentoContratadodataGridView.Name = "OrcamentoContratadodataGridView";
            this.OrcamentoContratadodataGridView.ReadOnly = true;
            this.OrcamentoContratadodataGridView.Size = new System.Drawing.Size(884, 425);
            this.OrcamentoContratadodataGridView.TabIndex = 0;
            this.OrcamentoContratadodataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrcamentoContratadodataGridView_DataBindingComplete);
            // 
            // Sequencial
            // 
            this.Sequencial.DataPropertyName = "Sequencial";
            this.Sequencial.HeaderText = "Sequencial";
            this.Sequencial.Name = "Sequencial";
            this.Sequencial.ReadOnly = true;
            this.Sequencial.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Logradouro
            // 
            this.Logradouro.DataPropertyName = "Logradouro";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            // 
            // Licitação
            // 
            this.Licitação.HeaderText = "Licitação";
            this.Licitação.Name = "Licitação";
            this.Licitação.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Secretaria";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "CEP";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // BDI
            // 
            this.BDI.DataPropertyName = "BDI";
            this.BDI.HeaderText = "BDI";
            this.BDI.Name = "BDI";
            this.BDI.ReadOnly = true;
            // 
            // sequencialDataGridViewTextBoxColumn1
            // 
            this.sequencialDataGridViewTextBoxColumn1.DataPropertyName = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn1.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn1.Name = "sequencialDataGridViewTextBoxColumn1";
            this.sequencialDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // orcamentoContratadoViewDataTableBindingSource
            // 
            this.orcamentoContratadoViewDataTableBindingSource.DataMember = "OrcamentoContratadoViewDataTable";
            this.orcamentoContratadoViewDataTableBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // licitadoTableAdapter
            // 
            this.licitadoTableAdapter.ClearBeforeFill = true;
            // 
            // secretariaTableAdapter
            // 
            this.secretariaTableAdapter.ClearBeforeFill = true;
            // 
            // orc_Cont_ServicoTableAdapter
            // 
            this.orc_Cont_ServicoTableAdapter.ClearBeforeFill = true;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // orcamentoContratadoViewTableAdapter
            // 
            this.orcamentoContratadoViewTableAdapter.ClearBeforeFill = true;
            // 
            // orcamentoContratadoBindingSource
            // 
            this.orcamentoContratadoBindingSource.DataMember = "Orcamento_Contratado";
            this.orcamentoContratadoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // orcamento_ContratadoTableAdapter
            // 
            this.orcamento_ContratadoTableAdapter.ClearBeforeFill = true;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // sCOOPDataSetBindingSource
            // 
            this.sCOOPDataSetBindingSource.DataSource = this.sCOOPDataSet;
            this.sCOOPDataSetBindingSource.Position = 0;
            // 
            // CadastroOrcamentocontratado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 675);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "CadastroOrcamentocontratado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Orçamento Contratado";
            this.Load += new System.EventHandler(this.CadastroOrcamentocs_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CadastroOrcamentocs_PreviewKeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcContServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicodataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoContratadodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoContratadoViewDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoContratadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox TxtBoxTotalOrçamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ServicodataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView OrcamentoContratadodataGridView;
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
        private System.Windows.Forms.TextBox PesquisaTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrcamentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox ContratoMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtBoxCGCCPF;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox ComboBoxEmpreteira;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BttCadastrarMedicao;
        public System.Windows.Forms.ComboBox ComboBoxSecretaria;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox ComboBoxLicitado;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtBoxDescricao;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox MskTxtDataCriacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBoxBairro;
        private System.Windows.Forms.TextBox TxtBoxLogradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBoxCidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox MskTxtBoxCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOrdemServico;
        private System.Windows.Forms.Button BttContrato;
        public System.Windows.Forms.MaskedTextBox MksTxtBoxPrazo;
        private System.Windows.Forms.Label label5;
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
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource licitadoBindingSource;
        private LicitadoTableAdapter licitadoTableAdapter;
        private System.Windows.Forms.BindingSource secretariaBindingSource;
        private SecretariaTableAdapter secretariaTableAdapter;
        private System.Windows.Forms.BindingSource orcContServicoBindingSource;
        private Orc_Cont_ServicoTableAdapter orc_Cont_ServicoTableAdapter;
        private System.Windows.Forms.ToolStripButton ButtonSalvar;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.MaskedTextBox DataInicioMskTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource orcamentoContratadoViewDataTableBindingSource;
        private OrcamentoContratadoViewTableAdapter orcamentoContratadoViewTableAdapter;
        private System.Windows.Forms.Button BttAtualizar;
        private System.Windows.Forms.BindingSource orcamentoContratadoBindingSource;
        private Orcamento_ContratadoTableAdapter orcamento_ContratadoTableAdapter;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private OrcamentoTableAdapter orcamentoTableAdapter;
        private System.Windows.Forms.BindingSource sCOOPDataSetBindingSource;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox BDIComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licitação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ProcessotextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ModalidadecomboBox;
        private System.Windows.Forms.Button button3;
    }
}