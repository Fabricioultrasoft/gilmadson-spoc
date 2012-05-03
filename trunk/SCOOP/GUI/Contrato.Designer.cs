namespace SCOOP.GUI
{
    partial class Contrato
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxContrato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ContratoEmpreteiro1 = new SCOOP.Relatorio.ContratoEmpreteiro();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 75);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(721, 409);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contrato";
            // 
            // TxtBoxContrato
            // 
            this.TxtBoxContrato.Location = new System.Drawing.Point(41, 30);
            this.TxtBoxContrato.Name = "TxtBoxContrato";
            this.TxtBoxContrato.Size = new System.Drawing.Size(130, 20);
            this.TxtBoxContrato.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBoxContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Contrato";
            this.Text = "Contrato";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxContrato;
        private System.Windows.Forms.Button button1;
        private SCOOP.Relatorio.ContratoEmpreteiro ContratoEmpreteiro1;
    }
}