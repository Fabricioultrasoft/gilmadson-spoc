namespace SCOOP.GUI
{
    partial class Relatorio
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoletimObras1 = new SCOOP.Relatorio.BoletimObras();
            this.Composicao1 = new SCOOP.Relatorio.Composicao();
            this.ContratoEmpreteiro1 = new SCOOP.Relatorio.ContratoEmpreteiro();
            this.CrystalReport11 = new SCOOP.Relatorio.CrystalReport1();
            this.Medicao1 = new SCOOP.Relatorio.Medicao();
            this.MedicaoQntValorEmBranco1 = new SCOOP.Relatorio.MedicaoQntValorEmBranco();
            this.MedicaoValorEmBranco1 = new SCOOP.Relatorio.MedicaoValorEmBranco();
            this.Orcamento1 = new SCOOP.Relatorio.Orcamento();
            this.OrdemServico1 = new SCOOP.Relatorio.OrdemServico();
            this.ReciboEmpreteira1 = new SCOOP.Relatorio.ReciboEmpreteira();
            this.Servico1 = new SCOOP.Relatorio.Servico();
            this.ServicoMedicao1 = new SCOOP.Relatorio.ServicoMedicao();
            this.SolicitacaoPagamento1 = new SCOOP.Relatorio.SolicitacaoPagamento();
            this.ServicoMedicaoTOP1 = new SCOOP.Relatorio.ServicoMedicaoTOP();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 118);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(741, 483);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxValor
            // 
            this.TxtBoxValor.Location = new System.Drawing.Point(31, 49);
            this.TxtBoxValor.Name = "TxtBoxValor";
            this.TxtBoxValor.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBoxValor;
        private System.Windows.Forms.Label label1;
        private SCOOP.Relatorio.BoletimObras BoletimObras1;
        private SCOOP.Relatorio.Composicao Composicao1;
        private SCOOP.Relatorio.ContratoEmpreteiro ContratoEmpreteiro1;
        private SCOOP.Relatorio.CrystalReport1 CrystalReport11;
        private SCOOP.Relatorio.Medicao Medicao1;
        private SCOOP.Relatorio.MedicaoQntValorEmBranco MedicaoQntValorEmBranco1;
        private SCOOP.Relatorio.MedicaoValorEmBranco MedicaoValorEmBranco1;
        private SCOOP.Relatorio.Orcamento Orcamento1;
        private SCOOP.Relatorio.OrdemServico OrdemServico1;
        private SCOOP.Relatorio.ReciboEmpreteira ReciboEmpreteira1;
        private SCOOP.Relatorio.Servico Servico1;
        private SCOOP.Relatorio.ServicoMedicao ServicoMedicao1;
        private SCOOP.Relatorio.SolicitacaoPagamento SolicitacaoPagamento1;
        private SCOOP.Relatorio.ServicoMedicaoTOP ServicoMedicaoTOP1;
    }
}