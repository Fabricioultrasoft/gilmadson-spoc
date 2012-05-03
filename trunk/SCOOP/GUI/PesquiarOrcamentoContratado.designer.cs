using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP.GUI
{
    partial class PesquiarOrcamentoContratado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquiarOrcamentoContratado));
            this.button1 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.BttBuscar = new System.Windows.Forms.Button();
            this.TxtBoxServico = new System.Windows.Forms.TextBox();
            this.OrcamentodataGridView1 = new System.Windows.Forms.DataGridView();
            this.BttLimparFiltro = new System.Windows.Forms.Button();
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.orcamentoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.OrcamentoTableAdapter();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seq_Orcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Licitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secretaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodLicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSecretaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRAZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdemServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentodataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.orcamentoBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 46);
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
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Serviço";
            // 
            // BttBuscar
            // 
            this.BttBuscar.Location = new System.Drawing.Point(213, 21);
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
            this.TxtBoxServico.Location = new System.Drawing.Point(2, 23);
            this.TxtBoxServico.Name = "TxtBoxServico";
            this.TxtBoxServico.Size = new System.Drawing.Size(209, 20);
            this.TxtBoxServico.TabIndex = 7;
            // 
            // OrcamentodataGridView1
            // 
            this.OrcamentodataGridView1.AllowUserToAddRows = false;
            this.OrcamentodataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OrcamentodataGridView1.AutoGenerateColumns = false;
            this.OrcamentodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrcamentodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrcamentodataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialDataGridViewTextBoxColumn,
            this.Seq_Orcamento,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Empresa,
            this.Licitada,
            this.Secretaria,
            this.CodigoEmpresa,
            this.CodLicitada,
            this.CodSecretaria,
            this.CPF_CNPJ,
            this.PRAZO,
            this.dtcriacaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.OrdemServico,
            this.Data_Final});
            this.OrcamentodataGridView1.DataSource = this.orcamentoBindingSource;
            this.OrcamentodataGridView1.Location = new System.Drawing.Point(2, 74);
            this.OrcamentodataGridView1.Name = "OrcamentodataGridView1";
            this.OrcamentodataGridView1.Size = new System.Drawing.Size(630, 253);
            this.OrcamentodataGridView1.TabIndex = 6;
            this.OrcamentodataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OrcamentodataGridView1_DataBindingComplete);
            // 
            // BttLimparFiltro
            // 
            this.BttLimparFiltro.Location = new System.Drawing.Point(294, 48);
            this.BttLimparFiltro.Name = "BttLimparFiltro";
            this.BttLimparFiltro.Size = new System.Drawing.Size(75, 23);
            this.BttLimparFiltro.TabIndex = 12;
            this.BttLimparFiltro.Text = "Limpar Filtro";
            this.BttLimparFiltro.UseVisualStyleBackColor = true;
            this.BttLimparFiltro.Click += new System.EventHandler(this.BttLimparFiltro_Click);
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "Orcamento";
            this.orcamentoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // sequencialDataGridViewTextBoxColumn
            // 
            this.sequencialDataGridViewTextBoxColumn.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.Name = "sequencialDataGridViewTextBoxColumn";
            this.sequencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn.Visible = false;
            // 
            // Seq_Orcamento
            // 
            this.Seq_Orcamento.DataPropertyName = "Sequencial";
            this.Seq_Orcamento.HeaderText = "Seq_Orcamento";
            this.Seq_Orcamento.Name = "Seq_Orcamento";
            this.Seq_Orcamento.ReadOnly = true;
            this.Seq_Orcamento.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Orçamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao da Obra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Logradouro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // Licitada
            // 
            this.Licitada.HeaderText = "Licitada";
            this.Licitada.Name = "Licitada";
            // 
            // Secretaria
            // 
            this.Secretaria.HeaderText = "Secretaria";
            this.Secretaria.Name = "Secretaria";
            this.Secretaria.Visible = false;
            // 
            // CodigoEmpresa
            // 
            this.CodigoEmpresa.HeaderText = "Empresa";
            this.CodigoEmpresa.Name = "CodigoEmpresa";
            this.CodigoEmpresa.Visible = false;
            // 
            // CodLicitada
            // 
            this.CodLicitada.HeaderText = "Licitada";
            this.CodLicitada.Name = "CodLicitada";
            this.CodLicitada.Visible = false;
            // 
            // CodSecretaria
            // 
            this.CodSecretaria.HeaderText = "Secretaria";
            this.CodSecretaria.Name = "CodSecretaria";
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.HeaderText = "CPF_CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            // 
            // PRAZO
            // 
            this.PRAZO.HeaderText = "Prazo";
            this.PRAZO.Name = "PRAZO";
            // 
            // dtcriacaoDataGridViewTextBoxColumn
            // 
            this.dtcriacaoDataGridViewTextBoxColumn.HeaderText = "Dt_criacao";
            this.dtcriacaoDataGridViewTextBoxColumn.Name = "dtcriacaoDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "Dt_Alteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // OrdemServico
            // 
            this.OrdemServico.HeaderText = "OrdemServico";
            this.OrdemServico.Name = "OrdemServico";
            this.OrdemServico.Visible = false;
            // 
            // Data_Final
            // 
            this.Data_Final.HeaderText = "Data_Final";
            this.Data_Final.Name = "Data_Final";
            // 
            // PesquiarOrcamentoContratado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 339);
            this.Controls.Add(this.BttLimparFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttBuscar);
            this.Controls.Add(this.TxtBoxServico);
            this.Controls.Add(this.OrcamentodataGridView1);
            this.Name = "PesquiarOrcamentoContratado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquiar Orçamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquiarServico_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PesquiarOrcamento_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentodataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView OrcamentodataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoriaDataGridViewTextBoxColumn;       
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private OrcamentoTableAdapter orcamentoTableAdapter;
        private System.Windows.Forms.Button BttLimparFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seq_Orcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodLicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSecretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRAZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdemServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Final;
    }
}