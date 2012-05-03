
using SCOOP.Relatorio;
namespace SCOOP
{
    partial class RelatoriosServico


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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GerarButton = new System.Windows.Forms.Button();
            this.DataFinalDTP = new System.Windows.Forms.DateTimePicker();
            this.DataInicialDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicoMedicao1 = new SCOOP.Relatorio.ServicoMedicao();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ServicoMedicaoTOP1 = new SCOOP.Relatorio.ServicoMedicaoTOP();
            this.groupBox1.SuspendLayout();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 80);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(577, 295);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.GerarButton);
            this.groupBox1.Controls.Add(this.DataFinalDTP);
            this.groupBox1.Controls.Add(this.DataInicialDTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // GerarButton
            // 
            this.GerarButton.Location = new System.Drawing.Point(435, 30);
            this.GerarButton.Name = "GerarButton";
            this.GerarButton.Size = new System.Drawing.Size(75, 23);
            this.GerarButton.TabIndex = 4;
            this.GerarButton.Text = "Gerar";
            this.GerarButton.UseVisualStyleBackColor = true;
            this.GerarButton.Click += new System.EventHandler(this.GerarButton_Click);
            // 
            // DataFinalDTP
            // 
            this.DataFinalDTP.Location = new System.Drawing.Point(72, 46);
            this.DataFinalDTP.Name = "DataFinalDTP";
            this.DataFinalDTP.Size = new System.Drawing.Size(226, 20);
            this.DataFinalDTP.TabIndex = 3;
            // 
            // DataInicialDTP
            // 
            this.DataInicialDTP.Location = new System.Drawing.Point(72, 10);
            this.DataInicialDTP.Name = "DataInicialDTP";
            this.DataInicialDTP.Size = new System.Drawing.Size(226, 20);
            this.DataInicialDTP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(304, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RelatoriosServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "RelatoriosServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Realação de Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Recibo_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Relatorios_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GerarButton;
        private System.Windows.Forms.DateTimePicker DataFinalDTP;
        private System.Windows.Forms.DateTimePicker DataInicialDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ServicoMedicao ServicoMedicao1;
        private System.Windows.Forms.CheckBox checkBox1;
        private ServicoMedicaoTOP ServicoMedicaoTOP1;
    }
}