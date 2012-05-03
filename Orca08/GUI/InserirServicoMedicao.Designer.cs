namespace Orca08.GUI
{
    partial class InserirServicoMedicao
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
            System.Windows.Forms.Label cODATLabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label uNLabel;
            System.Windows.Forms.Label qTDELabel;
            System.Windows.Forms.Label cODLabel;
            System.Windows.Forms.Label uNITLabel;
            System.Windows.Forms.Label vtotalLabel;
            System.Windows.Forms.Label fOLHALabel;
            this.orcaDataSet = new Orca08.DAL.OrcaDataSet();
            this.detmediBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detmediTableAdapter = new Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter();
            this.tableAdapterManager = new Orca08.DAL.OrcaDataSetTableAdapters.TableAdapterManager();
            this.padraoTableAdapter = new Orca08.DAL.OrcaDataSetTableAdapters.PadraoTableAdapter();
            this.cODATTextBox = new System.Windows.Forms.TextBox();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.uNTextBox = new System.Windows.Forms.TextBox();
            this.qTDETextBox = new System.Windows.Forms.TextBox();
            this.cODComboBox = new System.Windows.Forms.ComboBox();
            this.padraoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uNITTextBox = new System.Windows.Forms.TextBox();
            this.vtotalTextBox = new System.Windows.Forms.TextBox();
            this.Badicionar = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.fOLHATextBox = new System.Windows.Forms.TextBox();
            cODATLabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            uNLabel = new System.Windows.Forms.Label();
            qTDELabel = new System.Windows.Forms.Label();
            cODLabel = new System.Windows.Forms.Label();
            uNITLabel = new System.Windows.Forms.Label();
            vtotalLabel = new System.Windows.Forms.Label();
            fOLHALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orcaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detmediBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padraoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODATLabel
            // 
            cODATLabel.AutoSize = true;
            cODATLabel.Location = new System.Drawing.Point(559, 4);
            cODATLabel.Name = "cODATLabel";
            cODATLabel.Size = new System.Drawing.Size(47, 13);
            cODATLabel.TabIndex = 1;
            cODATLabel.Text = "CODAT:";
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(12, 46);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(72, 13);
            dESCRICAOLabel.TabIndex = 5;
            dESCRICAOLabel.Text = "DESCRICAO:";
            // 
            // uNLabel
            // 
            uNLabel.AutoSize = true;
            uNLabel.Location = new System.Drawing.Point(175, 20);
            uNLabel.Name = "uNLabel";
            uNLabel.Size = new System.Drawing.Size(26, 13);
            uNLabel.TabIndex = 7;
            uNLabel.Text = "UN:";
            // 
            // qTDELabel
            // 
            qTDELabel.AutoSize = true;
            qTDELabel.Location = new System.Drawing.Point(12, 113);
            qTDELabel.Name = "qTDELabel";
            qTDELabel.Size = new System.Drawing.Size(40, 13);
            qTDELabel.TabIndex = 8;
            qTDELabel.Text = "QTDE:";
            // 
            // cODLabel
            // 
            cODLabel.AutoSize = true;
            cODLabel.Location = new System.Drawing.Point(9, 20);
            cODLabel.Name = "cODLabel";
            cODLabel.Size = new System.Drawing.Size(33, 13);
            cODLabel.TabIndex = 9;
            cODLabel.Text = "COD:";
            // 
            // uNITLabel
            // 
            uNITLabel.AutoSize = true;
            uNITLabel.Location = new System.Drawing.Point(170, 113);
            uNITLabel.Name = "uNITLabel";
            uNITLabel.Size = new System.Drawing.Size(31, 13);
            uNITLabel.TabIndex = 10;
            uNITLabel.Text = "Valor";
            // 
            // vtotalLabel
            // 
            vtotalLabel.AutoSize = true;
            vtotalLabel.Location = new System.Drawing.Point(322, 113);
            vtotalLabel.Name = "vtotalLabel";
            vtotalLabel.Size = new System.Drawing.Size(37, 13);
            vtotalLabel.TabIndex = 12;
            vtotalLabel.Text = "Vtotal:";
            // 
            // fOLHALabel
            // 
            fOLHALabel.AutoSize = true;
            fOLHALabel.Location = new System.Drawing.Point(402, 4);
            fOLHALabel.Name = "fOLHALabel";
            fOLHALabel.Size = new System.Drawing.Size(45, 13);
            fOLHALabel.TabIndex = 16;
            fOLHALabel.Text = "FOLHA:";
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
            this.tableAdapterManager.PadraoTableAdapter = this.padraoTableAdapter;
            this.tableAdapterManager.SocialTableAdapter = null;
            this.tableAdapterManager.TransitoTableAdapter = null;
            this.tableAdapterManager.TribunalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Orca08.DAL.OrcaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // padraoTableAdapter
            // 
            this.padraoTableAdapter.ClearBeforeFill = true;
            // 
            // cODATTextBox
            // 
            this.cODATTextBox.Location = new System.Drawing.Point(612, 1);
            this.cODATTextBox.Name = "cODATTextBox";
            this.cODATTextBox.Size = new System.Drawing.Size(100, 20);
            this.cODATTextBox.TabIndex = 2;
            // 
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(15, 62);
            this.dESCRICAOTextBox.Multiline = true;
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(697, 39);
            this.dESCRICAOTextBox.TabIndex = 6;
            // 
            // uNTextBox
            // 
            this.uNTextBox.Location = new System.Drawing.Point(207, 17);
            this.uNTextBox.Name = "uNTextBox";
            this.uNTextBox.Size = new System.Drawing.Size(100, 20);
            this.uNTextBox.TabIndex = 8;
            // 
            // qTDETextBox
            // 
            this.qTDETextBox.Location = new System.Drawing.Point(64, 110);
            this.qTDETextBox.Name = "qTDETextBox";
            this.qTDETextBox.Size = new System.Drawing.Size(100, 20);
            this.qTDETextBox.TabIndex = 9;
            this.qTDETextBox.TextChanged += new System.EventHandler(this.qTDETextBox_TextChanged);
            // 
            // cODComboBox
            // 
            this.cODComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cODComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cODComboBox.DataSource = this.padraoBindingSource;
            this.cODComboBox.DisplayMember = "COD";
            this.cODComboBox.FormattingEnabled = true;
            this.cODComboBox.Location = new System.Drawing.Point(48, 17);
            this.cODComboBox.Name = "cODComboBox";
            this.cODComboBox.Size = new System.Drawing.Size(121, 21);
            this.cODComboBox.TabIndex = 10;
            this.cODComboBox.ValueMember = "COD";
            this.cODComboBox.TextChanged += new System.EventHandler(this.cODComboBox_TextChanged);
            // 
            // padraoBindingSource
            // 
            this.padraoBindingSource.DataMember = "Padrao";
            this.padraoBindingSource.DataSource = this.orcaDataSet;
            // 
            // uNITTextBox
            // 
            this.uNITTextBox.Location = new System.Drawing.Point(207, 110);
            this.uNITTextBox.Name = "uNITTextBox";
            this.uNITTextBox.Size = new System.Drawing.Size(100, 20);
            this.uNITTextBox.TabIndex = 11;
            // 
            // vtotalTextBox
            // 
            this.vtotalTextBox.Location = new System.Drawing.Point(365, 110);
            this.vtotalTextBox.Name = "vtotalTextBox";
            this.vtotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.vtotalTextBox.TabIndex = 13;
            // 
            // Badicionar
            // 
            this.Badicionar.Location = new System.Drawing.Point(94, 145);
            this.Badicionar.Name = "Badicionar";
            this.Badicionar.Size = new System.Drawing.Size(75, 23);
            this.Badicionar.TabIndex = 14;
            this.Badicionar.Text = "ADICIONAR";
            this.Badicionar.UseVisualStyleBackColor = true;
            this.Badicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.Location = new System.Drawing.Point(216, 145);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(75, 23);
            this.Bcancelar.TabIndex = 15;
            this.Bcancelar.Text = "CANCELAR";
            this.Bcancelar.UseVisualStyleBackColor = true;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // fOLHATextBox
            // 
            this.fOLHATextBox.Location = new System.Drawing.Point(453, 1);
            this.fOLHATextBox.Name = "fOLHATextBox";
            this.fOLHATextBox.Size = new System.Drawing.Size(100, 20);
            this.fOLHATextBox.TabIndex = 17;
            // 
            // InserirServicoMedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 272);
            this.Controls.Add(fOLHALabel);
            this.Controls.Add(this.fOLHATextBox);
            this.Controls.Add(this.Bcancelar);
            this.Controls.Add(this.Badicionar);
            this.Controls.Add(vtotalLabel);
            this.Controls.Add(this.vtotalTextBox);
            this.Controls.Add(uNITLabel);
            this.Controls.Add(this.uNITTextBox);
            this.Controls.Add(cODLabel);
            this.Controls.Add(this.cODComboBox);
            this.Controls.Add(qTDELabel);
            this.Controls.Add(this.qTDETextBox);
            this.Controls.Add(uNLabel);
            this.Controls.Add(this.uNTextBox);
            this.Controls.Add(dESCRICAOLabel);
            this.Controls.Add(this.dESCRICAOTextBox);
            this.Controls.Add(cODATLabel);
            this.Controls.Add(this.cODATTextBox);
            this.Name = "InserirServicoMedicao";
            this.Text = "InserirServicoMedicao";
            this.Load += new System.EventHandler(this.InserirServicoMedicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orcaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detmediBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padraoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Orca08.DAL.OrcaDataSet orcaDataSet;
        private System.Windows.Forms.BindingSource detmediBindingSource;
        private Orca08.DAL.OrcaDataSetTableAdapters.DetmediTableAdapter detmediTableAdapter;
        private Orca08.DAL.OrcaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cODATTextBox;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.TextBox uNTextBox;
        private System.Windows.Forms.TextBox qTDETextBox;
        private Orca08.DAL.OrcaDataSetTableAdapters.PadraoTableAdapter padraoTableAdapter;
        private System.Windows.Forms.ComboBox cODComboBox;
        private System.Windows.Forms.BindingSource padraoBindingSource;
        private System.Windows.Forms.TextBox uNITTextBox;
        private System.Windows.Forms.TextBox vtotalTextBox;
        private System.Windows.Forms.Button Badicionar;
        private System.Windows.Forms.Button Bcancelar;
        private System.Windows.Forms.TextBox fOLHATextBox;
    }
}