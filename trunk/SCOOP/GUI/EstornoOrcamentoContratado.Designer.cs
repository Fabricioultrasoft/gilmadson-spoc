﻿namespace SCOOP.GUI
{
    partial class EstornoOrcamentoContratado
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
            this.OrcamentotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdemServicopictureBox = new System.Windows.Forms.PictureBox();
            this.ContratopictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServicopictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrcamentoContratadopictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoContratadopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrcamentotextBox
            // 
            this.OrcamentotextBox.Location = new System.Drawing.Point(79, 41);
            this.OrcamentotextBox.Name = "OrcamentotextBox";
            this.OrcamentotextBox.Size = new System.Drawing.Size(100, 20);
            this.OrcamentotextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orçamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Estornar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordem Serviço";
            // 
            // OrdemServicopictureBox
            // 
            this.OrdemServicopictureBox.Location = new System.Drawing.Point(69, 200);
            this.OrdemServicopictureBox.Name = "OrdemServicopictureBox";
            this.OrdemServicopictureBox.Size = new System.Drawing.Size(29, 22);
            this.OrdemServicopictureBox.TabIndex = 4;
            this.OrdemServicopictureBox.TabStop = false;
            // 
            // ContratopictureBox
            // 
            this.ContratopictureBox.Location = new System.Drawing.Point(69, 116);
            this.ContratopictureBox.Name = "ContratopictureBox";
            this.ContratopictureBox.Size = new System.Drawing.Size(29, 22);
            this.ContratopictureBox.TabIndex = 6;
            this.ContratopictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contrato";
            // 
            // ServicopictureBox
            // 
            this.ServicopictureBox.Location = new System.Drawing.Point(69, 144);
            this.ServicopictureBox.Name = "ServicopictureBox";
            this.ServicopictureBox.Size = new System.Drawing.Size(29, 22);
            this.ServicopictureBox.TabIndex = 8;
            this.ServicopictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serviço do Orçamento Contratado";
            // 
            // OrcamentoContratadopictureBox
            // 
            this.OrcamentoContratadopictureBox.Location = new System.Drawing.Point(69, 172);
            this.OrcamentoContratadopictureBox.Name = "OrcamentoContratadopictureBox";
            this.OrcamentoContratadopictureBox.Size = new System.Drawing.Size(29, 22);
            this.OrcamentoContratadopictureBox.TabIndex = 10;
            this.OrcamentoContratadopictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Orçamento Contratado";
            // 
            // EstornoOrcamentoContratado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OrcamentoContratadopictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ServicopictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContratopictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdemServicopictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrcamentotextBox);
            this.Name = "EstornoOrcamentoContratado";
            this.Text = "EstornoOrcamentoContratado";
            ((System.ComponentModel.ISupportInitialize)(this.OrdemServicopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrcamentoContratadopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrcamentotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox OrdemServicopictureBox;
        private System.Windows.Forms.PictureBox ContratopictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ServicopictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox OrcamentoContratadopictureBox;
        private System.Windows.Forms.Label label5;
    }
}