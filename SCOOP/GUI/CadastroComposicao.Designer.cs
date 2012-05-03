using SCOOP.DAO;
using SCOOP.DAO.SCOOPDataSetTableAdapters;
namespace SCOOP
{
    partial class CadastroComposicao
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
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label unidadeLabel;
            System.Windows.Forms.Label leiSocialLabel;
            System.Windows.Forms.Label encargoLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroComposicao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BttAtualizar = new System.Windows.Forms.Button();
            this.NovoButton = new System.Windows.Forms.Button();
            this.encargoTextBox = new System.Windows.Forms.TextBox();
            this.CadastrarServicoButton = new System.Windows.Forms.Button();
            this.leiSocialTextBox = new System.Windows.Forms.TextBox();
            this.unidadeComboBox = new System.Windows.Forms.ComboBox();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.descricaoServicoTextBox = new System.Windows.Forms.TextBox();
            this.AtividadeComboBox = new System.Windows.Forms.ComboBox();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EtapaComboBox = new System.Windows.Forms.ComboBox();
            this.etapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoComboBox = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CodigomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.InsumogroupBox = new System.Windows.Forms.GroupBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.composicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.bindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantidadetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UnidadetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descricaoInsumotextBox = new System.Windows.Forms.TextBox();
            this.CodigoInsumomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sequencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoInsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqInsumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.ServicoTableAdapter();
            this.tableAdapterManager = new SCOOP.DAO.SCOOPDataSetTableAdapters.TableAdapterManager();
            this.composicaoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.ComposicaoTableAdapter();
            this.unidadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.UnidadeTableAdapter();
            this.grupoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.GrupoTableAdapter();
            this.etapaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.EtapaTableAdapter();
            this.atividadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.AtividadeTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalMObraEncargosTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalMaterialtxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalMObraMaterial = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            unidadeLabel = new System.Windows.Forms.Label();
            leiSocialLabel = new System.Windows.Forms.Label();
            encargoLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.InsumogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.composicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(9, 16);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(92, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 13);
            label1.TabIndex = 3;
            label1.Text = "Grupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(238, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 5;
            label2.Text = "Etapa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(439, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 7;
            label3.Text = "Atividade";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(9, 56);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(109, 13);
            descricaoLabel.TabIndex = 8;
            descricaoLabel.Text = "Descricao do Serviço";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new System.Drawing.Point(408, 57);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new System.Drawing.Size(50, 13);
            unidadeLabel.TabIndex = 10;
            unidadeLabel.Text = "Unidade:";
            // 
            // leiSocialLabel
            // 
            leiSocialLabel.AutoSize = true;
            leiSocialLabel.Location = new System.Drawing.Point(486, 57);
            leiSocialLabel.Name = "leiSocialLabel";
            leiSocialLabel.Size = new System.Drawing.Size(56, 13);
            leiSocialLabel.TabIndex = 12;
            leiSocialLabel.Text = "Lei Social:";
            leiSocialLabel.Visible = false;
            // 
            // encargoLabel
            // 
            encargoLabel.AutoSize = true;
            encargoLabel.Location = new System.Drawing.Point(595, 57);
            encargoLabel.Name = "encargoLabel";
            encargoLabel.Size = new System.Drawing.Size(50, 13);
            encargoLabel.TabIndex = 14;
            encargoLabel.Text = "Encargo:";
            encargoLabel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 13);
            label4.TabIndex = 17;
            label4.Text = "Codigo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(110, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 13);
            label5.TabIndex = 17;
            label5.Text = "Descrião de Insumo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BttAtualizar);
            this.groupBox1.Controls.Add(this.NovoButton);
            this.groupBox1.Controls.Add(encargoLabel);
            this.groupBox1.Controls.Add(this.encargoTextBox);
            this.groupBox1.Controls.Add(this.CadastrarServicoButton);
            this.groupBox1.Controls.Add(leiSocialLabel);
            this.groupBox1.Controls.Add(this.leiSocialTextBox);
            this.groupBox1.Controls.Add(unidadeLabel);
            this.groupBox1.Controls.Add(this.unidadeComboBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoServicoTextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.AtividadeComboBox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.EtapaComboBox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.GrupoComboBox);
            this.groupBox1.Controls.Add(this.CodigomaskedTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviço";
            // 
            // BttAtualizar
            // 
            this.BttAtualizar.Location = new System.Drawing.Point(85, 99);
            this.BttAtualizar.Name = "BttAtualizar";
            this.BttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BttAtualizar.TabIndex = 18;
            this.BttAtualizar.Text = "Atualizar";
            this.BttAtualizar.UseVisualStyleBackColor = true;
            this.BttAtualizar.Visible = false;
            this.BttAtualizar.Click += new System.EventHandler(this.BttAtualizar_Click);
            // 
            // NovoButton
            // 
            this.NovoButton.Location = new System.Drawing.Point(176, 99);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(75, 23);
            this.NovoButton.TabIndex = 17;
            this.NovoButton.Text = "Novo";
            this.NovoButton.UseVisualStyleBackColor = true;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // encargoTextBox
            // 
            this.encargoTextBox.Location = new System.Drawing.Point(598, 73);
            this.encargoTextBox.Name = "encargoTextBox";
            this.encargoTextBox.Size = new System.Drawing.Size(100, 20);
            this.encargoTextBox.TabIndex = 15;
            this.encargoTextBox.Text = "0";
            this.encargoTextBox.Visible = false;
            this.encargoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.encargoTextBox_KeyPress);
            // 
            // CadastrarServicoButton
            // 
            this.CadastrarServicoButton.Location = new System.Drawing.Point(95, 99);
            this.CadastrarServicoButton.Name = "CadastrarServicoButton";
            this.CadastrarServicoButton.Size = new System.Drawing.Size(75, 23);
            this.CadastrarServicoButton.TabIndex = 16;
            this.CadastrarServicoButton.Text = "Cadastrar";
            this.CadastrarServicoButton.UseVisualStyleBackColor = true;
            this.CadastrarServicoButton.Click += new System.EventHandler(this.CadastrarServicoButton_Click);
            // 
            // leiSocialTextBox
            // 
            this.leiSocialTextBox.Location = new System.Drawing.Point(489, 73);
            this.leiSocialTextBox.Name = "leiSocialTextBox";
            this.leiSocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.leiSocialTextBox.TabIndex = 13;
            this.leiSocialTextBox.Text = "0";
            this.leiSocialTextBox.Visible = false;
            this.leiSocialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leiSocialTextBox_KeyPress);
            // 
            // unidadeComboBox
            // 
            this.unidadeComboBox.DataSource = this.unidadeBindingSource;
            this.unidadeComboBox.DisplayMember = "Descricao";
            this.unidadeComboBox.FormattingEnabled = true;
            this.unidadeComboBox.Location = new System.Drawing.Point(411, 73);
            this.unidadeComboBox.Name = "unidadeComboBox";
            this.unidadeComboBox.Size = new System.Drawing.Size(69, 21);
            this.unidadeComboBox.TabIndex = 11;
            this.unidadeComboBox.ValueMember = "Codigo";
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataMember = "Unidade";
            this.unidadeBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descricaoServicoTextBox
            // 
            this.descricaoServicoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoServicoTextBox.Location = new System.Drawing.Point(12, 73);
            this.descricaoServicoTextBox.Name = "descricaoServicoTextBox";
            this.descricaoServicoTextBox.Size = new System.Drawing.Size(393, 20);
            this.descricaoServicoTextBox.TabIndex = 9;
            // 
            // AtividadeComboBox
            // 
            this.AtividadeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AtividadeComboBox.DataSource = this.atividadeBindingSource;
            this.AtividadeComboBox.DisplayMember = "Descricao";
            this.AtividadeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtividadeComboBox.FormattingEnabled = true;
            this.AtividadeComboBox.Location = new System.Drawing.Point(442, 33);
            this.AtividadeComboBox.Name = "AtividadeComboBox";
            this.AtividadeComboBox.Size = new System.Drawing.Size(256, 21);
            this.AtividadeComboBox.TabIndex = 6;
            this.AtividadeComboBox.ValueMember = "Codigo";
            this.AtividadeComboBox.SelectedIndexChanged += new System.EventHandler(this.AtividadeComboBox_SelectedIndexChanged);
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "Atividade";
            this.atividadeBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // EtapaComboBox
            // 
            this.EtapaComboBox.DataSource = this.etapaBindingSource;
            this.EtapaComboBox.DisplayMember = "Descricao";
            this.EtapaComboBox.DropDownWidth = 500;
            this.EtapaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EtapaComboBox.FormattingEnabled = true;
            this.EtapaComboBox.Location = new System.Drawing.Point(241, 33);
            this.EtapaComboBox.Name = "EtapaComboBox";
            this.EtapaComboBox.Size = new System.Drawing.Size(195, 21);
            this.EtapaComboBox.TabIndex = 4;
            this.EtapaComboBox.ValueMember = "Codigo";
            this.EtapaComboBox.SelectedIndexChanged += new System.EventHandler(this.EtapaComboBox_SelectedIndexChanged);
            // 
            // etapaBindingSource
            // 
            this.etapaBindingSource.DataMember = "Etapa";
            this.etapaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // GrupoComboBox
            // 
            this.GrupoComboBox.DataSource = this.grupoBindingSource;
            this.GrupoComboBox.DisplayMember = "Descricao";
            this.GrupoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrupoComboBox.FormattingEnabled = true;
            this.GrupoComboBox.Location = new System.Drawing.Point(95, 33);
            this.GrupoComboBox.Name = "GrupoComboBox";
            this.GrupoComboBox.Size = new System.Drawing.Size(142, 21);
            this.GrupoComboBox.TabIndex = 2;
            this.GrupoComboBox.ValueMember = "Codigo";
            this.GrupoComboBox.SelectedIndexChanged += new System.EventHandler(this.GrupoComboBox_SelectedIndexChanged);
            this.GrupoComboBox.TextChanged += new System.EventHandler(this.GrupoComboBox_TextChanged);
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // CodigomaskedTextBox
            // 
            this.CodigomaskedTextBox.Enabled = false;
            this.CodigomaskedTextBox.Location = new System.Drawing.Point(12, 33);
            this.CodigomaskedTextBox.Mask = "000,000,0000";
            this.CodigomaskedTextBox.Name = "CodigomaskedTextBox";
            this.CodigomaskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.CodigomaskedTextBox.TabIndex = 1;
            // 
            // InsumogroupBox
            // 
            this.InsumogroupBox.Controls.Add(this.CancelarButton);
            this.InsumogroupBox.Controls.Add(this.ConfirmarButton);
            this.InsumogroupBox.Controls.Add(this.bindingNavigator1);
            this.InsumogroupBox.Controls.Add(this.button1);
            this.InsumogroupBox.Controls.Add(this.ValortextBox);
            this.InsumogroupBox.Controls.Add(this.label8);
            this.InsumogroupBox.Controls.Add(this.QuantidadetextBox);
            this.InsumogroupBox.Controls.Add(this.label7);
            this.InsumogroupBox.Controls.Add(this.UnidadetextBox);
            this.InsumogroupBox.Controls.Add(this.label6);
            this.InsumogroupBox.Controls.Add(this.descricaoInsumotextBox);
            this.InsumogroupBox.Controls.Add(label5);
            this.InsumogroupBox.Controls.Add(label4);
            this.InsumogroupBox.Controls.Add(this.CodigoInsumomaskedTextBox);
            this.InsumogroupBox.Location = new System.Drawing.Point(3, 147);
            this.InsumogroupBox.Name = "InsumogroupBox";
            this.InsumogroupBox.Size = new System.Drawing.Size(705, 127);
            this.InsumogroupBox.TabIndex = 1;
            this.InsumogroupBox.TabStop = false;
            this.InsumogroupBox.Text = "Insumo";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(361, 102);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 25;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(281, 102);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarButton.TabIndex = 17;
            this.ConfirmarButton.Text = "Comfirma";
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            this.ConfirmarButton.Visible = false;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.composicaoBindingSource;
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
            this.bindingNavigatorEdit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 102);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(278, 25);
            this.bindingNavigator1.TabIndex = 24;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // composicaoBindingSource
            // 
            this.composicaoBindingSource.DataMember = "Composicao";
            this.composicaoBindingSource.DataSource = this.sCOOPDataSet;
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bindingNavigatorEdit
            // 
            this.bindingNavigatorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEdit.Image = global::SCOOP.Properties.Resources.edit1;
            this.bindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEdit.Name = "bindingNavigatorEdit";
            this.bindingNavigatorEdit.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorEdit.Text = "toolStripButton1";
            this.bindingNavigatorEdit.Click += new System.EventHandler(this.bindingNavigatorEdit_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = global::SCOOP.Properties.Resources.Icon_Lupa;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(85, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ValortextBox
            // 
            this.ValortextBox.Enabled = false;
            this.ValortextBox.Location = new System.Drawing.Point(613, 31);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(85, 20);
            this.ValortextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(611, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor";
            // 
            // QuantidadetextBox
            // 
            this.QuantidadetextBox.Location = new System.Drawing.Point(515, 31);
            this.QuantidadetextBox.Name = "QuantidadetextBox";
            this.QuantidadetextBox.Size = new System.Drawing.Size(86, 20);
            this.QuantidadetextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quantidade";
            // 
            // UnidadetextBox
            // 
            this.UnidadetextBox.Location = new System.Drawing.Point(451, 31);
            this.UnidadetextBox.Name = "UnidadetextBox";
            this.UnidadetextBox.Size = new System.Drawing.Size(58, 20);
            this.UnidadetextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Unidade";
            // 
            // descricaoInsumotextBox
            // 
            this.descricaoInsumotextBox.Location = new System.Drawing.Point(113, 32);
            this.descricaoInsumotextBox.Multiline = true;
            this.descricaoInsumotextBox.Name = "descricaoInsumotextBox";
            this.descricaoInsumotextBox.Size = new System.Drawing.Size(331, 62);
            this.descricaoInsumotextBox.TabIndex = 17;
            // 
            // CodigoInsumomaskedTextBox
            // 
            this.CodigoInsumomaskedTextBox.Location = new System.Drawing.Point(9, 32);
            this.CodigoInsumomaskedTextBox.Mask = "000,000,0000";
            this.CodigoInsumomaskedTextBox.Name = "CodigoInsumomaskedTextBox";
            this.CodigoInsumomaskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.CodigoInsumomaskedTextBox.TabIndex = 17;
            this.CodigoInsumomaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            this.CodigoInsumomaskedTextBox.TextChanged += new System.EventHandler(this.CodigoInsumomaskedTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialDataGridViewTextBoxColumn,
            this.codigoServicoDataGridViewTextBoxColumn,
            this.codigoInsumoDataGridViewTextBoxColumn,
            this.DescricaoInsumo,
            this.Unidade1,
            this.quantidadeDataGridViewTextBoxColumn,
            this.Valor,
            this.Total,
            this.seqServicoDataGridViewTextBoxColumn,
            this.seqInsumoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.composicaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 200);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // sequencialDataGridViewTextBoxColumn
            // 
            this.sequencialDataGridViewTextBoxColumn.DataPropertyName = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.HeaderText = "Sequencial";
            this.sequencialDataGridViewTextBoxColumn.Name = "sequencialDataGridViewTextBoxColumn";
            this.sequencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.sequencialDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoServicoDataGridViewTextBoxColumn
            // 
            this.codigoServicoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Servico";
            this.codigoServicoDataGridViewTextBoxColumn.HeaderText = "Codigo_Servico";
            this.codigoServicoDataGridViewTextBoxColumn.Name = "codigoServicoDataGridViewTextBoxColumn";
            this.codigoServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoServicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoInsumoDataGridViewTextBoxColumn
            // 
            this.codigoInsumoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Insumo";
            this.codigoInsumoDataGridViewTextBoxColumn.HeaderText = "Codigo_Insumo";
            this.codigoInsumoDataGridViewTextBoxColumn.Name = "codigoInsumoDataGridViewTextBoxColumn";
            this.codigoInsumoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DescricaoInsumo
            // 
            this.DescricaoInsumo.HeaderText = "Descrição";
            this.DescricaoInsumo.Name = "DescricaoInsumo";
            this.DescricaoInsumo.ReadOnly = true;
            // 
            // Unidade1
            // 
            this.Unidade1.HeaderText = "Unidade";
            this.Unidade1.Name = "Unidade1";
            this.Unidade1.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle1;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // seqServicoDataGridViewTextBoxColumn
            // 
            this.seqServicoDataGridViewTextBoxColumn.DataPropertyName = "Seq_Servico";
            this.seqServicoDataGridViewTextBoxColumn.HeaderText = "Seq_Servico";
            this.seqServicoDataGridViewTextBoxColumn.Name = "seqServicoDataGridViewTextBoxColumn";
            this.seqServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.seqServicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // seqInsumoDataGridViewTextBoxColumn
            // 
            this.seqInsumoDataGridViewTextBoxColumn.DataPropertyName = "Seq_Insumo";
            this.seqInsumoDataGridViewTextBoxColumn.HeaderText = "Seq_Insumo";
            this.seqInsumoDataGridViewTextBoxColumn.Name = "seqInsumoDataGridViewTextBoxColumn";
            this.seqInsumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.seqInsumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtividadeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BairroTableAdapter = null;
            this.tableAdapterManager.ComposicaoTableAdapter = this.composicaoTableAdapter;
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
            this.tableAdapterManager.ServicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.TipoInsumoTableAdapter = null;
            this.tableAdapterManager.TipoOrcamentoTableAdapter = null;
            this.tableAdapterManager.UnidadeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SCOOP.DAO.SCOOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // composicaoTableAdapter
            // 
            this.composicaoTableAdapter.ClearBeforeFill = true;
            // 
            // unidadeTableAdapter
            // 
            this.unidadeTableAdapter.ClearBeforeFill = true;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "M Obra e Encargos Sociais ";
            // 
            // TotalMObraEncargosTxtBox
            // 
            this.TotalMObraEncargosTxtBox.Location = new System.Drawing.Point(181, 486);
            this.TotalMObraEncargosTxtBox.Name = "TotalMObraEncargosTxtBox";
            this.TotalMObraEncargosTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TotalMObraEncargosTxtBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Material";
            // 
            // TotalMaterialtxtBox
            // 
            this.TotalMaterialtxtBox.Location = new System.Drawing.Point(339, 486);
            this.TotalMaterialtxtBox.Name = "TotalMaterialtxtBox";
            this.TotalMaterialtxtBox.Size = new System.Drawing.Size(100, 20);
            this.TotalMaterialtxtBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(451, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total";
            // 
            // TotalMObraMaterial
            // 
            this.TotalMObraMaterial.Location = new System.Drawing.Point(504, 486);
            this.TotalMObraMaterial.Name = "TotalMObraMaterial";
            this.TotalMObraMaterial.Size = new System.Drawing.Size(100, 20);
            this.TotalMObraMaterial.TabIndex = 8;
            // 
            // CadastroComposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 514);
            this.Controls.Add(this.TotalMObraMaterial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TotalMaterialtxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalMObraEncargosTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InsumogroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroComposicao";
            this.Text = "Cadastro de Composicao";
            this.Load += new System.EventHandler(this.CadastroComposicao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etapaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.InsumogroupBox.ResumeLayout(false);
            this.InsumogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.composicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private ServicoTableAdapter servicoTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox unidadeComboBox;
        private System.Windows.Forms.TextBox descricaoServicoTextBox;
        private System.Windows.Forms.ComboBox AtividadeComboBox;
        private System.Windows.Forms.ComboBox EtapaComboBox;
        private System.Windows.Forms.ComboBox GrupoComboBox;
        private System.Windows.Forms.MaskedTextBox CodigomaskedTextBox;
        private System.Windows.Forms.TextBox encargoTextBox;
        private System.Windows.Forms.TextBox leiSocialTextBox;
        private System.Windows.Forms.Button CadastrarServicoButton;
        private System.Windows.Forms.GroupBox InsumogroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComposicaoTableAdapter composicaoTableAdapter;
        private System.Windows.Forms.BindingSource composicaoBindingSource;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.Button NovoButton;
        private System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.TextBox ValortextBox;
        public System.Windows.Forms.TextBox QuantidadetextBox;
        public System.Windows.Forms.TextBox UnidadetextBox;
        public System.Windows.Forms.TextBox descricaoInsumotextBox;
        public System.Windows.Forms.MaskedTextBox CodigoInsumomaskedTextBox;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private UnidadeTableAdapter unidadeTableAdapter;
        private System.Windows.Forms.Button BttAtualizar;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.BindingSource etapaBindingSource;
        private EtapaTableAdapter etapaTableAdapter;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private AtividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TotalMObraEncargosTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalMaterialtxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TotalMObraMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoInsumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqInsumoDataGridViewTextBoxColumn;
    }
}