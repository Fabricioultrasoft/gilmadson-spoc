namespace Orca08.GUI
{
    partial class ServicoMedicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicoMedicao));
            this.orcaDataSet = new Orca08.DAL.OrcaDataSet();
            this.detmediBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detmediTableAdapter = new Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter();
            this.tableAdapterManager = new Orca08.DAL.OrcaDataSetTableAdapters.TableAdapterManager();
            this.detmediBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.detmediBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.detmediDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orcaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detmediBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detmediBindingNavigator)).BeginInit();
            this.detmediBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detmediDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orcaDataSet
            // 
            this.orcaDataSet.DataSetName = "OrcaDataSet";
            this.orcaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detmediBindingSource
            // 
            this.detmediBindingSource.DataMember = "Detmedi";
            this.detmediBindingSource.DataSource = this.orcaDataSet;
            // 
            // detmediTableAdapter
            // 
            this.detmediTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CABCOMPOTableAdapter = null;
            this.tableAdapterManager.CabMediTableAdapter = null;
            this.tableAdapterManager.CaborcaTableAdapter = null;
            this.tableAdapterManager.CabOrTMPTableAdapter = null;
            this.tableAdapterManager.COMPOS_1TableAdapter = null;
            this.tableAdapterManager.COMPOT_1TableAdapter = null;
            this.tableAdapterManager.CompoTableAdapter = null;
            this.tableAdapterManager.ContasTableAdapter = null;
            this.tableAdapterManager.ContratoTableAdapter = null;
            this.tableAdapterManager.converteTableAdapter = null;
            this.tableAdapterManager.DescMediTableAdapter = null;
            this.tableAdapterManager.DetmediTableAdapter = this.detmediTableAdapter;
            this.tableAdapterManager.DetorcaTableAdapter = null;
            this.tableAdapterManager.DetOrTMPTableAdapter = null;
            this.tableAdapterManager.DotacaoTableAdapter = null;
            this.tableAdapterManager.EMPREITATableAdapter = null;
            this.tableAdapterManager.FiscalTableAdapter = null;
            this.tableAdapterManager.FunciTableAdapter = null;
            this.tableAdapterManager.GrupoTableAdapter = null;
            this.tableAdapterManager.INSUMOTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.OBRATIPOTableAdapter = null;
            this.tableAdapterManager.PadraoAuxTableAdapter = null;
            this.tableAdapterManager.PadraoTableAdapter = null;
            this.tableAdapterManager.SocialTableAdapter = null;
            this.tableAdapterManager.TransitoTableAdapter = null;
            this.tableAdapterManager.TribunalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Orca08.DAL.OrcaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detmediBindingNavigator
            // 
            this.detmediBindingNavigator.AddNewItem = null;
            this.detmediBindingNavigator.BindingSource = this.detmediBindingSource;
            this.detmediBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.detmediBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.detmediBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.detmediBindingNavigatorSaveItem});
            this.detmediBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.detmediBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.detmediBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.detmediBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.detmediBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.detmediBindingNavigator.Name = "detmediBindingNavigator";
            this.detmediBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.detmediBindingNavigator.Size = new System.Drawing.Size(703, 25);
            this.detmediBindingNavigator.TabIndex = 0;
            this.detmediBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // detmediBindingNavigatorSaveItem
            // 
            this.detmediBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detmediBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("detmediBindingNavigatorSaveItem.Image")));
            this.detmediBindingNavigatorSaveItem.Name = "detmediBindingNavigatorSaveItem";
            this.detmediBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.detmediBindingNavigatorSaveItem.Text = "Save Data";
            this.detmediBindingNavigatorSaveItem.Click += new System.EventHandler(this.detmediBindingNavigatorSaveItem_Click);
            // 
            // detmediDataGridView
            // 
            this.detmediDataGridView.AllowUserToAddRows = false;
            this.detmediDataGridView.AllowUserToOrderColumns = true;
            this.detmediDataGridView.AutoGenerateColumns = false;
            this.detmediDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detmediDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.detmediDataGridView.DataSource = this.detmediBindingSource;
            this.detmediDataGridView.Location = new System.Drawing.Point(0, 28);
            this.detmediDataGridView.Name = "detmediDataGridView";
            this.detmediDataGridView.Size = new System.Drawing.Size(703, 394);
            this.detmediDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FOLHA";
            this.dataGridViewTextBoxColumn1.HeaderText = "FOLHA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODAT";
            this.dataGridViewTextBoxColumn2.HeaderText = "CODAT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COD";
            this.dataGridViewTextBoxColumn3.HeaderText = "COD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRICAO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UN";
            this.dataGridViewTextBoxColumn5.HeaderText = "UN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QTDE";
            this.dataGridViewTextBoxColumn6.HeaderText = "QTDE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UNIT";
            this.dataGridViewTextBoxColumn7.HeaderText = "UNIT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Vtotal";
            this.dataGridViewTextBoxColumn8.HeaderText = "Vtotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ORCA";
            this.dataGridViewTextBoxColumn9.HeaderText = "ORCA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "COD99";
            this.dataGridViewTextBoxColumn10.HeaderText = "COD99";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DescMemo";
            this.dataGridViewTextBoxColumn11.HeaderText = "DescMemo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Despesa";
            this.dataGridViewTextBoxColumn12.HeaderText = "Despesa";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // ServicoMedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 434);
            this.Controls.Add(this.detmediDataGridView);
            this.Controls.Add(this.detmediBindingNavigator);
            this.Name = "ServicoMedicao";
            this.Text = "ServicoMedicao";
            this.Load += new System.EventHandler(this.ServicoMedicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orcaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detmediBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detmediBindingNavigator)).EndInit();
            this.detmediBindingNavigator.ResumeLayout(false);
            this.detmediBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detmediDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Orca08.DAL.OrcaDataSet orcaDataSet;
        private System.Windows.Forms.BindingSource detmediBindingSource;
        private Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter detmediTableAdapter;
        private Orca08.DAL.OrcaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator detmediBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton detmediBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView detmediDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}