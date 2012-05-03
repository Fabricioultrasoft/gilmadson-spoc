

namespace Orca08.GUI
{
    partial class Relatorios1


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
            this.TxtBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Medicao1 = new Orca08.Relatorios.Medicao1();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReciboEmpreteira1 = new Orca08.Relatorios.ReciboEmpreteira1();
            this.SolicitacaoPagamento1 = new Orca08.Relatorios.SolicitacaoPagamento1();
            this.ContratoEmpreteiro1 = new Orca08.Relatorios.ContratoEmpreteiro1();
            this.FolhaFinalTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TxtBoxValor
            // 
            this.TxtBoxValor.Location = new System.Drawing.Point(25, 73);
            this.TxtBoxValor.Name = "TxtBoxValor";
            this.TxtBoxValor.Size = new System.Drawing.Size(113, 20);
            this.TxtBoxValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 105);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(575, 283);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // FolhaFinalTxtBox
            // 
            this.FolhaFinalTxtBox.Location = new System.Drawing.Point(172, 73);
            this.FolhaFinalTxtBox.Name = "FolhaFinalTxtBox";
            this.FolhaFinalTxtBox.Size = new System.Drawing.Size(113, 20);
            this.FolhaFinalTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "até";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Medicao",
            "Contrato",
            "Recibo",
            "Solicitacao"});
            this.comboBox1.Location = new System.Drawing.Point(25, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Relatório";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(577, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(226, 242);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(154, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Relatorios1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 413);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FolhaFinalTxtBox);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxValor);
            this.Name = "Relatorios1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Imprimir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Recibo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Orca08.Relatorios.Medicao1 Medicao1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Orca08.Relatorios.ReciboEmpreteira1 ReciboEmpreteira1;
        private Orca08.Relatorios.SolicitacaoPagamento1 SolicitacaoPagamento1;
        private Orca08.Relatorios.ContratoEmpreteiro1 ContratoEmpreteiro1;
        private System.Windows.Forms.TextBox FolhaFinalTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;        
    }
}