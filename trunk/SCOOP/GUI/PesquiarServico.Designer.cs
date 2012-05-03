using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP.GUI
{
    partial class PesquiarServico
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquiarServico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.BttBuscar = new System.Windows.Forms.Button();
            this.TxtBoxServico = new System.Windows.Forms.TextBox();
            this.ServicodataGridView1 = new System.Windows.Forms.DataGridView();
            this.servicoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.ServicoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrupocomboBox = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EtapacomboBox = new System.Windows.Forms.ComboBox();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AtividadeComboBox = new System.Windows.Forms.ComboBox();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.GrupoTableAdapter();
            this.etapaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.EtapaTableAdapter();
            this.atividadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.AtividadeTableAdapter();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leiSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicodataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 11;
            label2.Text = "Etapa";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(6, 58);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Serviço";
            // 
            // BttBuscar
            // 
            this.BttBuscar.Location = new System.Drawing.Point(217, 31);
            this.BttBuscar.Name = "BttBuscar";
            this.BttBuscar.Size = new System.Drawing.Size(58, 23);
            this.BttBuscar.TabIndex = 8;
            this.BttBuscar.Text = "Buscar";
            this.BttBuscar.UseVisualStyleBackColor = true;
            this.BttBuscar.Click += new System.EventHandler(this.BttBuscar_Click);
            // 
            // TxtBoxServico
            // 
            this.TxtBoxServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxServico.Location = new System.Drawing.Point(6, 35);
            this.TxtBoxServico.Name = "TxtBoxServico";
            this.TxtBoxServico.Size = new System.Drawing.Size(209, 20);
            this.TxtBoxServico.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.grupoDataGridViewTextBoxColumn,
            this.Valor,
            this.etapaDataGridViewTextBoxColumn,
            this.atividadeDataGridViewTextBoxColumn,
            this.leiSocialDataGridViewTextBoxColumn,
            this.encargoDataGridViewTextBoxColumn});
            this.ServicodataGridView1.DataSource = this.servicoBindingSource;
            this.ServicodataGridView1.Location = new System.Drawing.Point(2, 88);
            this.ServicodataGridView1.Name = "ServicodataGridView1";
            this.ServicodataGridView1.ReadOnly = true;
            this.ServicodataGridView1.Size = new System.Drawing.Size(791, 297);
            this.ServicodataGridView1.TabIndex = 6;
            this.ServicodataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ServicodataGridView1_DataBindingComplete);
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.GrupocomboBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.EtapacomboBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.AtividadeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(314, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 77);
            this.groupBox1.TabIndex = 12;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            this.grupoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // etapaDataGridViewTextBoxColumn
            // 
            this.etapaDataGridViewTextBoxColumn.DataPropertyName = "Etapa";
            this.etapaDataGridViewTextBoxColumn.HeaderText = "Etapa";
            this.etapaDataGridViewTextBoxColumn.Name = "etapaDataGridViewTextBoxColumn";
            this.etapaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atividadeDataGridViewTextBoxColumn
            // 
            this.atividadeDataGridViewTextBoxColumn.DataPropertyName = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.Name = "atividadeDataGridViewTextBoxColumn";
            this.atividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leiSocialDataGridViewTextBoxColumn
            // 
            this.leiSocialDataGridViewTextBoxColumn.DataPropertyName = "LeiSocial";
            this.leiSocialDataGridViewTextBoxColumn.HeaderText = "LeiSocial";
            this.leiSocialDataGridViewTextBoxColumn.Name = "leiSocialDataGridViewTextBoxColumn";
            this.leiSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.leiSocialDataGridViewTextBoxColumn.Visible = false;
            // 
            // encargoDataGridViewTextBoxColumn
            // 
            this.encargoDataGridViewTextBoxColumn.DataPropertyName = "Encargo";
            this.encargoDataGridViewTextBoxColumn.HeaderText = "Encargo";
            this.encargoDataGridViewTextBoxColumn.Name = "encargoDataGridViewTextBoxColumn";
            this.encargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.encargoDataGridViewTextBoxColumn.Visible = false;
            // 
            // PesquiarServico
            // 
            this.AcceptButton = this.BttBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttBuscar);
            this.Controls.Add(this.TxtBoxServico);
            this.Controls.Add(this.ServicodataGridView1);
            this.Name = "PesquiarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquiarServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquiarServico_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PesquiarServico_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicodataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttBuscar;
        private System.Windows.Forms.TextBox TxtBoxServico;
        private System.Windows.Forms.DataGridView ServicodataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GrupocomboBox;
        private System.Windows.Forms.ComboBox EtapacomboBox;
        private System.Windows.Forms.ComboBox AtividadeComboBox;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private EtapaTableAdapter etapaTableAdapter;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private AtividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leiSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargoDataGridViewTextBoxColumn;
    }
}