namespace SCOOP.GUI
{
    partial class ImporteServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImporteServico));
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.oRCA_SCOOP_MATERIALDataGridView = new System.Windows.Forms.DataGridView();
            this.cODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTMEDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALMEDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlurbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRCASCOOPSERVICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.dESCRICAOToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dESCRICAOToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new SCOOP.DAO.SCOOPDataSetTableAdapters.TableAdapterManager();
            this.oRCA_SCOOP_SERVICOTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.ORCA_SCOOP_SERVICOTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCA_SCOOP_MATERIALDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCASCOOPSERVICOBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRCA_SCOOP_MATERIALDataGridView
            // 
            this.oRCA_SCOOP_MATERIALDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oRCA_SCOOP_MATERIALDataGridView.AutoGenerateColumns = false;
            this.oRCA_SCOOP_MATERIALDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oRCA_SCOOP_MATERIALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oRCA_SCOOP_MATERIALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.sUMARIADataGridViewTextBoxColumn,
            this.uNDDataGridViewTextBoxColumn,
            this.tipoServDataGridViewTextBoxColumn,
            this.iMPDataGridViewTextBoxColumn,
            this.mOBRADataGridViewTextBoxColumn,
            this.mATERIALDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.bCIDataGridViewTextBoxColumn,
            this.lSOCIALDataGridViewTextBoxColumn,
            this.qTMEDIDataGridViewTextBoxColumn,
            this.vALMEDIDataGridViewTextBoxColumn,
            this.emlurbDataGridViewTextBoxColumn});
            this.oRCA_SCOOP_MATERIALDataGridView.DataSource = this.oRCASCOOPSERVICOBindingSource;
            this.oRCA_SCOOP_MATERIALDataGridView.Location = new System.Drawing.Point(0, 132);
            this.oRCA_SCOOP_MATERIALDataGridView.Name = "oRCA_SCOOP_MATERIALDataGridView";
            this.oRCA_SCOOP_MATERIALDataGridView.Size = new System.Drawing.Size(670, 256);
            this.oRCA_SCOOP_MATERIALDataGridView.TabIndex = 1;
            // 
            // cODDataGridViewTextBoxColumn
            // 
            this.cODDataGridViewTextBoxColumn.DataPropertyName = "COD";
            this.cODDataGridViewTextBoxColumn.HeaderText = "COD";
            this.cODDataGridViewTextBoxColumn.Name = "cODDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // sUMARIADataGridViewTextBoxColumn
            // 
            this.sUMARIADataGridViewTextBoxColumn.DataPropertyName = "SUMARIA";
            this.sUMARIADataGridViewTextBoxColumn.HeaderText = "SUMARIA";
            this.sUMARIADataGridViewTextBoxColumn.Name = "sUMARIADataGridViewTextBoxColumn";
            // 
            // uNDDataGridViewTextBoxColumn
            // 
            this.uNDDataGridViewTextBoxColumn.DataPropertyName = "UND";
            this.uNDDataGridViewTextBoxColumn.HeaderText = "UND";
            this.uNDDataGridViewTextBoxColumn.Name = "uNDDataGridViewTextBoxColumn";
            // 
            // tipoServDataGridViewTextBoxColumn
            // 
            this.tipoServDataGridViewTextBoxColumn.DataPropertyName = "TipoServ";
            this.tipoServDataGridViewTextBoxColumn.HeaderText = "TipoServ";
            this.tipoServDataGridViewTextBoxColumn.Name = "tipoServDataGridViewTextBoxColumn";
            this.tipoServDataGridViewTextBoxColumn.Visible = false;
            // 
            // iMPDataGridViewTextBoxColumn
            // 
            this.iMPDataGridViewTextBoxColumn.DataPropertyName = "IMP";
            this.iMPDataGridViewTextBoxColumn.HeaderText = "IMP";
            this.iMPDataGridViewTextBoxColumn.Name = "iMPDataGridViewTextBoxColumn";
            this.iMPDataGridViewTextBoxColumn.Visible = false;
            // 
            // mOBRADataGridViewTextBoxColumn
            // 
            this.mOBRADataGridViewTextBoxColumn.DataPropertyName = "M_OBRA";
            this.mOBRADataGridViewTextBoxColumn.HeaderText = "M_OBRA";
            this.mOBRADataGridViewTextBoxColumn.Name = "mOBRADataGridViewTextBoxColumn";
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.Visible = false;
            // 
            // bCIDataGridViewTextBoxColumn
            // 
            this.bCIDataGridViewTextBoxColumn.DataPropertyName = "BCI";
            this.bCIDataGridViewTextBoxColumn.HeaderText = "BCI";
            this.bCIDataGridViewTextBoxColumn.Name = "bCIDataGridViewTextBoxColumn";
            this.bCIDataGridViewTextBoxColumn.Visible = false;
            // 
            // lSOCIALDataGridViewTextBoxColumn
            // 
            this.lSOCIALDataGridViewTextBoxColumn.DataPropertyName = "LSOCIAL";
            this.lSOCIALDataGridViewTextBoxColumn.HeaderText = "LSOCIAL";
            this.lSOCIALDataGridViewTextBoxColumn.Name = "lSOCIALDataGridViewTextBoxColumn";
            this.lSOCIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // qTMEDIDataGridViewTextBoxColumn
            // 
            this.qTMEDIDataGridViewTextBoxColumn.DataPropertyName = "QTMEDI";
            this.qTMEDIDataGridViewTextBoxColumn.HeaderText = "QTMEDI";
            this.qTMEDIDataGridViewTextBoxColumn.Name = "qTMEDIDataGridViewTextBoxColumn";
            this.qTMEDIDataGridViewTextBoxColumn.Visible = false;
            // 
            // vALMEDIDataGridViewTextBoxColumn
            // 
            this.vALMEDIDataGridViewTextBoxColumn.DataPropertyName = "VALMEDI";
            this.vALMEDIDataGridViewTextBoxColumn.HeaderText = "VALMEDI";
            this.vALMEDIDataGridViewTextBoxColumn.Name = "vALMEDIDataGridViewTextBoxColumn";
            this.vALMEDIDataGridViewTextBoxColumn.Visible = false;
            // 
            // emlurbDataGridViewTextBoxColumn
            // 
            this.emlurbDataGridViewTextBoxColumn.DataPropertyName = "Emlurb";
            this.emlurbDataGridViewTextBoxColumn.HeaderText = "Emlurb";
            this.emlurbDataGridViewTextBoxColumn.Name = "emlurbDataGridViewTextBoxColumn";
            this.emlurbDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRCASCOOPSERVICOBindingSource
            // 
            this.oRCASCOOPSERVICOBindingSource.DataMember = "ORCA_SCOOP_SERVICO";
            this.oRCASCOOPSERVICOBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESCRICAOToolStripLabel,
            this.dESCRICAOToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 40);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(448, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // dESCRICAOToolStripLabel
            // 
            this.dESCRICAOToolStripLabel.Name = "dESCRICAOToolStripLabel";
            this.dESCRICAOToolStripLabel.Size = new System.Drawing.Size(73, 22);
            this.dESCRICAOToolStripLabel.Text = "DESCRICAO:";
            // 
            // dESCRICAOToolStripTextBox
            // 
            this.dESCRICAOToolStripTextBox.Name = "dESCRICAOToolStripTextBox";
            this.dESCRICAOToolStripTextBox.Size = new System.Drawing.Size(300, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillByToolStripButton.Text = "Pesquisar";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtividadeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BairroTableAdapter = null;
            this.tableAdapterManager.ComposicaoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContratoTableAdapter = null;
            this.tableAdapterManager.DotacaoOrcamentariaTableAdapter = null;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.EmpreteiraTableAdapter = null;
            this.tableAdapterManager.EtapaTableAdapter = null;
            this.tableAdapterManager.FiscalizacaoTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.GrupoInsumoTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.InsumoTableAdapter = null;
            this.tableAdapterManager.LicitadoTableAdapter = null;
            this.tableAdapterManager.Med_ServicoTableAdapter = null;
            this.tableAdapterManager.Medicao_TempTableAdapter = null;
            this.tableAdapterManager.MedicaoTableAdapter = null;
            this.tableAdapterManager.Orc_Cont_ServicoTableAdapter = null;
            this.tableAdapterManager.Orc_ServicoTableAdapter = null;
            this.tableAdapterManager.ORCA_SCOOP_MATERIALTableAdapter = null;
            this.tableAdapterManager.ORCA_SCOOP_SERVICOTableAdapter = null;
            this.tableAdapterManager.Orcamento_ContratadoTableAdapter = null;
            this.tableAdapterManager.OrcamentoTableAdapter = null;
            this.tableAdapterManager.OrcaUsuarioTableAdapter = null;
            this.tableAdapterManager.ReciboTableAdapter = null;
            this.tableAdapterManager.SecretariaTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.TipoInsumoTableAdapter = null;
            this.tableAdapterManager.TipoOrcamentoTableAdapter = null;
            this.tableAdapterManager.UnidadeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCOOP.DAO.SCOOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oRCA_SCOOP_SERVICOTableAdapter
            // 
            this.oRCA_SCOOP_SERVICOTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.oRCASCOOPSERVICOBindingSource;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 104);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 4;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImporteServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oRCA_SCOOP_MATERIALDataGridView);
            this.Name = "ImporteServico";
            this.Text = "ImporteServiço";
            this.Load += new System.EventHandler(this.ImporteInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCA_SCOOP_MATERIALDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRCASCOOPSERVICOBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SCOOP.DAO.SCOOPDataSet sCOOPDataSet;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView oRCA_SCOOP_MATERIALDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel dESCRICAOToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dESCRICAOToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource oRCASCOOPSERVICOBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.ORCA_SCOOP_SERVICOTableAdapter oRCA_SCOOP_SERVICOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lSOCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTMEDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALMEDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlurbDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button button2;
    }
}