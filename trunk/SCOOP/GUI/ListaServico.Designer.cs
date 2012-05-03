using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class ListaServico
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaServico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.BttPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BttImprimir = new System.Windows.Forms.Button();
            this.AtividadeComboBox = new System.Windows.Forms.ComboBox();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrupocomboBox = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EtapacomboBox = new System.Windows.Forms.ComboBox();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.ServicoTableAdapter();
            this.grupoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.GrupoTableAdapter();
            this.etapaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.EtapaTableAdapter();
            this.atividadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.AtividadeTableAdapter();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descricaoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(6, 55);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(51, 13);
            descricaoLabel.TabIndex = 9;
            descricaoLabel.Text = "Atividade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 11;
            label2.Text = "Etapa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 13);
            label3.TabIndex = 13;
            label3.Text = "Gupo";
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
            this.sequencialDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Valor,
            this.grupoDataGridViewTextBoxColumn,
            this.etapaDataGridViewTextBoxColumn,
            this.atividadeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn13,
            this.encargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(841, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BttPesquisar
            // 
            this.BttPesquisar.Location = new System.Drawing.Point(282, 27);
            this.BttPesquisar.Name = "BttPesquisar";
            this.BttPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BttPesquisar.TabIndex = 7;
            this.BttPesquisar.Text = "Pesquisar";
            this.BttPesquisar.UseVisualStyleBackColor = true;
            this.BttPesquisar.Click += new System.EventHandler(this.BttPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar Nome";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(3, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 5;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.servicoBindingSource;
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
            this.toolStripButton2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(1, 61);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(278, 25);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SCOOP.Properties.Resources.edit1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BttImprimir
            // 
            this.BttImprimir.Location = new System.Drawing.Point(282, 61);
            this.BttImprimir.Name = "BttImprimir";
            this.BttImprimir.Size = new System.Drawing.Size(75, 23);
            this.BttImprimir.TabIndex = 9;
            this.BttImprimir.Text = "Imprimir";
            this.BttImprimir.UseVisualStyleBackColor = true;
            this.BttImprimir.Click += new System.EventHandler(this.BttImprimir_Click);
            // 
            // AtividadeComboBox
            // 
            this.AtividadeComboBox.DataSource = this.atividadeBindingSource;
            this.AtividadeComboBox.DisplayMember = "Descricao";
            this.AtividadeComboBox.FormattingEnabled = true;
            this.AtividadeComboBox.Location = new System.Drawing.Point(63, 52);
            this.AtividadeComboBox.Name = "AtividadeComboBox";
            this.AtividadeComboBox.Size = new System.Drawing.Size(405, 21);
            this.AtividadeComboBox.TabIndex = 10;
            this.AtividadeComboBox.ValueMember = "Codigo";
            this.AtividadeComboBox.SelectedIndexChanged += new System.EventHandler(this.AtividadeComboBox_SelectedIndexChanged);
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "Atividade";
            this.atividadeBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.GrupocomboBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.EtapacomboBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.AtividadeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(363, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // GrupocomboBox
            // 
            this.GrupocomboBox.DataSource = this.grupoBindingSource;
            this.GrupocomboBox.DisplayMember = "Descricao";
            this.GrupocomboBox.FormattingEnabled = true;
            this.GrupocomboBox.Location = new System.Drawing.Point(63, 8);
            this.GrupocomboBox.Name = "GrupocomboBox";
            this.GrupocomboBox.Size = new System.Drawing.Size(405, 21);
            this.GrupocomboBox.TabIndex = 14;
            this.GrupocomboBox.ValueMember = "Codigo";
            this.GrupocomboBox.SelectedIndexChanged += new System.EventHandler(this.GrupocomboBox_SelectedIndexChanged);
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // EtapacomboBox
            // 
            this.EtapacomboBox.DataSource = this.etapaBindingSource;
            this.EtapacomboBox.DisplayMember = "Descricao";
            this.EtapacomboBox.FormattingEnabled = true;
            this.EtapacomboBox.Location = new System.Drawing.Point(63, 30);
            this.EtapacomboBox.Name = "EtapacomboBox";
            this.EtapacomboBox.Size = new System.Drawing.Size(405, 21);
            this.EtapacomboBox.TabIndex = 12;
            this.EtapacomboBox.ValueMember = "Codigo";
            this.EtapacomboBox.SelectedIndexChanged += new System.EventHandler(this.EtapacomboBox_SelectedIndexChanged);
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataMember = "Etapa";
            this.etapaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // etapaTableAdapter
            // 
            this.etapaTableAdapter.ClearBeforeFill = true;
            // 
            // atividadeTableAdapter
            // 
            this.atividadeTableAdapter.ClearBeforeFill = true;
            // 
            // sequencialDataGridViewTextBoxColumn
            // 
            this.sequencialDataGridViewTextBoxColumn.DataPropertyName = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.Name = "sequencialDataGridViewTextBoxColumn";
            this.sequencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Unidade";
            this.dataGridViewTextBoxColumn12.HeaderText = "Unidade";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Valor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoDataGridViewTextBoxColumn.Visible = false;
            // 
            // etapaDataGridViewTextBoxColumn
            // 
            this.etapaDataGridViewTextBoxColumn.DataPropertyName = "Etapa";
            this.etapaDataGridViewTextBoxColumn.HeaderText = "Etapa";
            this.etapaDataGridViewTextBoxColumn.Name = "etapaDataGridViewTextBoxColumn";
            this.etapaDataGridViewTextBoxColumn.ReadOnly = true;
            this.etapaDataGridViewTextBoxColumn.Visible = false;
            // 
            // atividadeDataGridViewTextBoxColumn
            // 
            this.atividadeDataGridViewTextBoxColumn.DataPropertyName = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.Name = "atividadeDataGridViewTextBoxColumn";
            this.atividadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.atividadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "LeiSocial";
            this.dataGridViewTextBoxColumn13.HeaderText = "LeiSocial";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // encargoDataGridViewTextBoxColumn
            // 
            this.encargoDataGridViewTextBoxColumn.DataPropertyName = "Encargo";
            this.encargoDataGridViewTextBoxColumn.HeaderText = "Encargo Social";
            this.encargoDataGridViewTextBoxColumn.Name = "encargoDataGridViewTextBoxColumn";
            this.encargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.encargoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ListaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BttImprimir);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.BttPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaServico";
            this.Load += new System.EventHandler(this.ListaServico_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ListaServico_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BttPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoSumariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leiSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button BttImprimir;
        private System.Windows.Forms.ComboBox AtividadeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltimaAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuairoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GrupocomboBox;
        private System.Windows.Forms.ComboBox EtapacomboBox;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private EtapaTableAdapter etapaTableAdapter;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private AtividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargoDataGridViewTextBoxColumn;
    }
}