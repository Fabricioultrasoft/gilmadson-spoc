namespace SCOOP
{
    partial class Pergunta
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
            this.ChkBoxMedicao = new System.Windows.Forms.CheckBox();
            this.ChkBoxMedicaoEmBranco = new System.Windows.Forms.CheckBox();
            this.ChkBoxMedicaoValorQntEmBranco = new System.Windows.Forms.CheckBox();
            this.BttImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkBoxMedicao
            // 
            this.ChkBoxMedicao.AutoSize = true;
            this.ChkBoxMedicao.Location = new System.Drawing.Point(41, 24);
            this.ChkBoxMedicao.Name = "ChkBoxMedicao";
            this.ChkBoxMedicao.Size = new System.Drawing.Size(67, 17);
            this.ChkBoxMedicao.TabIndex = 0;
            this.ChkBoxMedicao.Text = "Medicao";
            this.ChkBoxMedicao.UseVisualStyleBackColor = true;
            this.ChkBoxMedicao.CheckedChanged += new System.EventHandler(this.ChkBoxMedicao_CheckedChanged);
            // 
            // ChkBoxMedicaoEmBranco
            // 
            this.ChkBoxMedicaoEmBranco.AutoSize = true;
            this.ChkBoxMedicaoEmBranco.Location = new System.Drawing.Point(41, 62);
            this.ChkBoxMedicaoEmBranco.Name = "ChkBoxMedicaoEmBranco";
            this.ChkBoxMedicaoEmBranco.Size = new System.Drawing.Size(148, 17);
            this.ChkBoxMedicaoEmBranco.TabIndex = 1;
            this.ChkBoxMedicaoEmBranco.Text = "Medicao Valor em Branco";
            this.ChkBoxMedicaoEmBranco.UseVisualStyleBackColor = true;
            this.ChkBoxMedicaoEmBranco.CheckedChanged += new System.EventHandler(this.ChkBoxMedicaoEmBranco_CheckedChanged);
            // 
            // ChkBoxMedicaoValorQntEmBranco
            // 
            this.ChkBoxMedicaoValorQntEmBranco.AutoSize = true;
            this.ChkBoxMedicaoValorQntEmBranco.Location = new System.Drawing.Point(41, 97);
            this.ChkBoxMedicaoValorQntEmBranco.Name = "ChkBoxMedicaoValorQntEmBranco";
            this.ChkBoxMedicaoValorQntEmBranco.Size = new System.Drawing.Size(177, 17);
            this.ChkBoxMedicaoValorQntEmBranco.TabIndex = 2;
            this.ChkBoxMedicaoValorQntEmBranco.Text = "Medição Valor e Qnt em Branco";
            this.ChkBoxMedicaoValorQntEmBranco.UseVisualStyleBackColor = true;
            this.ChkBoxMedicaoValorQntEmBranco.CheckedChanged += new System.EventHandler(this.ChkBoxMedicaoValorQntEmBranco_CheckedChanged);
            // 
            // BttImprimir
            // 
            this.BttImprimir.Location = new System.Drawing.Point(91, 154);
            this.BttImprimir.Name = "BttImprimir";
            this.BttImprimir.Size = new System.Drawing.Size(75, 23);
            this.BttImprimir.TabIndex = 3;
            this.BttImprimir.Text = "Imprimir";
            this.BttImprimir.UseVisualStyleBackColor = true;
            this.BttImprimir.Click += new System.EventHandler(this.BttImprimir_Click);
            // 
            // Pergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 227);
            this.Controls.Add(this.BttImprimir);
            this.Controls.Add(this.ChkBoxMedicaoValorQntEmBranco);
            this.Controls.Add(this.ChkBoxMedicaoEmBranco);
            this.Controls.Add(this.ChkBoxMedicao);
            this.Name = "Pergunta";
            this.Text = "Pergunta";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Pergunta_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkBoxMedicao;
        private System.Windows.Forms.CheckBox ChkBoxMedicaoEmBranco;
        private System.Windows.Forms.CheckBox ChkBoxMedicaoValorQntEmBranco;
        private System.Windows.Forms.Button BttImprimir;
    }
}