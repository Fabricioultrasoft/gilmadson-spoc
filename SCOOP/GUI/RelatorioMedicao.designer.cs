
using SCOOP.Relatorio;
namespace SCOOP
{
    partial class RelatoriosMedicao


    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.DotacaoComboBox = new System.Windows.Forms.ComboBox();
            this.dotacaoOrcamentariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.DotacaoTodasChkBox = new System.Windows.Forms.CheckBox();
            this.TipoObraTodosChkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoObraComboBox = new System.Windows.Forms.ComboBox();
            this.tipoOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BairroTodosChkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BairroComboBox = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpreteiraTodosChkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpreteiraTodosComboBox = new System.Windows.Forms.ComboBox();
            this.empreteiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.DtInicialdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblate = new System.Windows.Forms.Label();
            this.DtFinaldateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dotacaoOrcamentariaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.DotacaoOrcamentariaTableAdapter();
            this.tipoOrcamentoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.TipoOrcamentoTableAdapter();
            this.bairroTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.BairroTableAdapter();
            this.empreteiraTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.EmpreteiraTableAdapter();
            this.RelatorioMedicao1 = new SCOOP.Relatorio.RelatorioMedicao();
            this.PeriodoChkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dotacaoOrcamentariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empreteiraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 150);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(579, 225);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DotacaoComboBox
            // 
            this.DotacaoComboBox.DataSource = this.dotacaoOrcamentariaBindingSource;
            this.DotacaoComboBox.DisplayMember = "Descricao";
            this.DotacaoComboBox.FormattingEnabled = true;
            this.DotacaoComboBox.Location = new System.Drawing.Point(80, 9);
            this.DotacaoComboBox.Name = "DotacaoComboBox";
            this.DotacaoComboBox.Size = new System.Drawing.Size(215, 21);
            this.DotacaoComboBox.TabIndex = 4;
            this.DotacaoComboBox.ValueMember = "Codigo";
            this.DotacaoComboBox.Visible = false;
            this.DotacaoComboBox.SelectedIndexChanged += new System.EventHandler(this.DotacaoComboBox_SelectedIndexChanged);
            // 
            // dotacaoOrcamentariaBindingSource
            // 
            this.dotacaoOrcamentariaBindingSource.DataMember = "DotacaoOrcamentaria";
            this.dotacaoOrcamentariaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dotação";
            // 
            // DotacaoTodasChkBox
            // 
            this.DotacaoTodasChkBox.AutoSize = true;
            this.DotacaoTodasChkBox.Checked = true;
            this.DotacaoTodasChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DotacaoTodasChkBox.Location = new System.Drawing.Point(301, 11);
            this.DotacaoTodasChkBox.Name = "DotacaoTodasChkBox";
            this.DotacaoTodasChkBox.Size = new System.Drawing.Size(56, 17);
            this.DotacaoTodasChkBox.TabIndex = 6;
            this.DotacaoTodasChkBox.Text = "Todos";
            this.DotacaoTodasChkBox.UseVisualStyleBackColor = true;
            this.DotacaoTodasChkBox.CheckedChanged += new System.EventHandler(this.DotacaoTodasChkBox_CheckedChanged);
            // 
            // TipoObraTodosChkBox
            // 
            this.TipoObraTodosChkBox.AutoSize = true;
            this.TipoObraTodosChkBox.Checked = true;
            this.TipoObraTodosChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TipoObraTodosChkBox.Location = new System.Drawing.Point(301, 38);
            this.TipoObraTodosChkBox.Name = "TipoObraTodosChkBox";
            this.TipoObraTodosChkBox.Size = new System.Drawing.Size(56, 17);
            this.TipoObraTodosChkBox.TabIndex = 9;
            this.TipoObraTodosChkBox.Text = "Todos";
            this.TipoObraTodosChkBox.UseVisualStyleBackColor = true;
            this.TipoObraTodosChkBox.CheckedChanged += new System.EventHandler(this.TipoObraTodosChkBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo Obra";
            // 
            // TipoObraComboBox
            // 
            this.TipoObraComboBox.DataSource = this.tipoOrcamentoBindingSource;
            this.TipoObraComboBox.DisplayMember = "Descricao";
            this.TipoObraComboBox.FormattingEnabled = true;
            this.TipoObraComboBox.Location = new System.Drawing.Point(80, 36);
            this.TipoObraComboBox.Name = "TipoObraComboBox";
            this.TipoObraComboBox.Size = new System.Drawing.Size(215, 21);
            this.TipoObraComboBox.TabIndex = 7;
            this.TipoObraComboBox.ValueMember = "Codigo";
            this.TipoObraComboBox.Visible = false;
            this.TipoObraComboBox.SelectedIndexChanged += new System.EventHandler(this.TipoObraComboBox_SelectedIndexChanged);
            // 
            // tipoOrcamentoBindingSource
            // 
            this.tipoOrcamentoBindingSource.DataMember = "TipoOrcamento";
            this.tipoOrcamentoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // BairroTodosChkBox
            // 
            this.BairroTodosChkBox.AutoSize = true;
            this.BairroTodosChkBox.Checked = true;
            this.BairroTodosChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BairroTodosChkBox.Location = new System.Drawing.Point(301, 65);
            this.BairroTodosChkBox.Name = "BairroTodosChkBox";
            this.BairroTodosChkBox.Size = new System.Drawing.Size(56, 17);
            this.BairroTodosChkBox.TabIndex = 12;
            this.BairroTodosChkBox.Text = "Todos";
            this.BairroTodosChkBox.UseVisualStyleBackColor = true;
            this.BairroTodosChkBox.CheckedChanged += new System.EventHandler(this.BairroTodosChkBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bairro";
            // 
            // BairroComboBox
            // 
            this.BairroComboBox.DataSource = this.bairroBindingSource;
            this.BairroComboBox.DisplayMember = "Descricao";
            this.BairroComboBox.FormattingEnabled = true;
            this.BairroComboBox.Location = new System.Drawing.Point(80, 63);
            this.BairroComboBox.Name = "BairroComboBox";
            this.BairroComboBox.Size = new System.Drawing.Size(215, 21);
            this.BairroComboBox.TabIndex = 10;
            this.BairroComboBox.ValueMember = "Codigo";
            this.BairroComboBox.Visible = false;
            this.BairroComboBox.SelectedIndexChanged += new System.EventHandler(this.BairroComboBox_SelectedIndexChanged);
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "Bairro";
            this.bairroBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // EmpreteiraTodosChkBox
            // 
            this.EmpreteiraTodosChkBox.AutoSize = true;
            this.EmpreteiraTodosChkBox.Checked = true;
            this.EmpreteiraTodosChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EmpreteiraTodosChkBox.Location = new System.Drawing.Point(301, 92);
            this.EmpreteiraTodosChkBox.Name = "EmpreteiraTodosChkBox";
            this.EmpreteiraTodosChkBox.Size = new System.Drawing.Size(56, 17);
            this.EmpreteiraTodosChkBox.TabIndex = 15;
            this.EmpreteiraTodosChkBox.Text = "Todos";
            this.EmpreteiraTodosChkBox.UseVisualStyleBackColor = true;
            this.EmpreteiraTodosChkBox.CheckedChanged += new System.EventHandler(this.EmpreteiraTodosChkBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Empreteira";
            // 
            // EmpreteiraTodosComboBox
            // 
            this.EmpreteiraTodosComboBox.DataSource = this.empreteiraBindingSource;
            this.EmpreteiraTodosComboBox.DisplayMember = "Nome";
            this.EmpreteiraTodosComboBox.FormattingEnabled = true;
            this.EmpreteiraTodosComboBox.Location = new System.Drawing.Point(80, 90);
            this.EmpreteiraTodosComboBox.Name = "EmpreteiraTodosComboBox";
            this.EmpreteiraTodosComboBox.Size = new System.Drawing.Size(215, 21);
            this.EmpreteiraTodosComboBox.TabIndex = 13;
            this.EmpreteiraTodosComboBox.ValueMember = "Codigo";
            this.EmpreteiraTodosComboBox.Visible = false;
            this.EmpreteiraTodosComboBox.SelectedIndexChanged += new System.EventHandler(this.EmpreteiraTodosComboBox_SelectedIndexChanged);
            // 
            // empreteiraBindingSource
            // 
            this.empreteiraBindingSource.DataMember = "Empreteira";
            this.empreteiraBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Periodo";
            // 
            // DtInicialdateTimePicker
            // 
            this.DtInicialdateTimePicker.Location = new System.Drawing.Point(363, 33);
            this.DtInicialdateTimePicker.Name = "DtInicialdateTimePicker";
            this.DtInicialdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DtInicialdateTimePicker.TabIndex = 17;
            this.DtInicialdateTimePicker.Visible = false;
            // 
            // lblate
            // 
            this.lblate.AutoSize = true;
            this.lblate.Location = new System.Drawing.Point(451, 63);
            this.lblate.Name = "lblate";
            this.lblate.Size = new System.Drawing.Size(22, 13);
            this.lblate.TabIndex = 18;
            this.lblate.Text = "até";
            this.lblate.Visible = false;
            // 
            // DtFinaldateTimePicker
            // 
            this.DtFinaldateTimePicker.Location = new System.Drawing.Point(363, 83);
            this.DtFinaldateTimePicker.Name = "DtFinaldateTimePicker";
            this.DtFinaldateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DtFinaldateTimePicker.TabIndex = 19;
            this.DtFinaldateTimePicker.Visible = false;
            // 
            // dotacaoOrcamentariaTableAdapter
            // 
            this.dotacaoOrcamentariaTableAdapter.ClearBeforeFill = true;
            // 
            // tipoOrcamentoTableAdapter
            // 
            this.tipoOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // empreteiraTableAdapter
            // 
            this.empreteiraTableAdapter.ClearBeforeFill = true;
            // 
            // PeriodoChkBox
            // 
            this.PeriodoChkBox.AutoSize = true;
            this.PeriodoChkBox.Checked = true;
            this.PeriodoChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PeriodoChkBox.Location = new System.Drawing.Point(474, 8);
            this.PeriodoChkBox.Name = "PeriodoChkBox";
            this.PeriodoChkBox.Size = new System.Drawing.Size(56, 17);
            this.PeriodoChkBox.TabIndex = 20;
            this.PeriodoChkBox.Text = "Todos";
            this.PeriodoChkBox.UseVisualStyleBackColor = true;
            this.PeriodoChkBox.CheckedChanged += new System.EventHandler(this.PeriodoChkBox_CheckedChanged);
            // 
            // RelatoriosMedicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 379);
            this.Controls.Add(this.PeriodoChkBox);
            this.Controls.Add(this.DtFinaldateTimePicker);
            this.Controls.Add(this.lblate);
            this.Controls.Add(this.DtInicialdateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpreteiraTodosChkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpreteiraTodosComboBox);
            this.Controls.Add(this.BairroTodosChkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BairroComboBox);
            this.Controls.Add(this.TipoObraTodosChkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoObraComboBox);
            this.Controls.Add(this.DotacaoTodasChkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DotacaoComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "RelatoriosMedicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório Medição";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Recibo_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Relatorios_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dotacaoOrcamentariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoOrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empreteiraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private Orcamento Orcamento1;
        private Medicao Medicao1;
        private Composicao Composicao1;
        //private MedicaoQntValorEmBranco MedicaoValorQntEmBranco1;
        private MedicaoQntValorEmBranco MedicaoQntValorEmBranco1;
        private MedicaoValorEmBranco MedicaoValorEmBranco1;
        private OrdemServico OrdemServico1;
        private ReciboEmpreteira ReciboEmpreteira1;
        private SolicitacaoPagamento SolicitacaoPagamento1;
        private BoletimObras BoletimObras1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.ComboBox DotacaoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DotacaoTodasChkBox;
        private System.Windows.Forms.CheckBox TipoObraTodosChkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoObraComboBox;
        private System.Windows.Forms.CheckBox BairroTodosChkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BairroComboBox;
        private System.Windows.Forms.CheckBox EmpreteiraTodosChkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmpreteiraTodosComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtInicialdateTimePicker;
        private System.Windows.Forms.Label lblate;
        private System.Windows.Forms.DateTimePicker DtFinaldateTimePicker;
        private SCOOP.DAO.SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource dotacaoOrcamentariaBindingSource;
        private System.ComponentModel.IContainer components;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.DotacaoOrcamentariaTableAdapter dotacaoOrcamentariaTableAdapter;
        private System.Windows.Forms.BindingSource tipoOrcamentoBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.TipoOrcamentoTableAdapter tipoOrcamentoTableAdapter;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.BairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.BindingSource empreteiraBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.EmpreteiraTableAdapter empreteiraTableAdapter;
        private RelatorioMedicao RelatorioMedicao1;
        private System.Windows.Forms.CheckBox PeriodoChkBox;
    }
}