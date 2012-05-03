namespace SCOOP.GUI
{
    partial class CadastroTabelaExterna
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
            this.DescricaotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrarbutton = new System.Windows.Forms.Button();
            this.PrecotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTxtBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.CodigomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.unidadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.UnidadeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ComposicaopictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ServicopictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InsumopictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComposicaopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DescricaotextBox
            // 
            this.DescricaotextBox.Location = new System.Drawing.Point(21, 42);
            this.DescricaotextBox.Multiline = true;
            this.DescricaotextBox.Name = "DescricaotextBox";
            this.DescricaotextBox.Size = new System.Drawing.Size(453, 69);
            this.DescricaotextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descricao";
            // 
            // Cadastrarbutton
            // 
            this.Cadastrarbutton.Location = new System.Drawing.Point(132, 185);
            this.Cadastrarbutton.Name = "Cadastrarbutton";
            this.Cadastrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cadastrarbutton.TabIndex = 4;
            this.Cadastrarbutton.Text = "Cadastrar";
            this.Cadastrarbutton.UseVisualStyleBackColor = true;
            this.Cadastrarbutton.Click += new System.EventHandler(this.Cadastrarbutton_Click);
            // 
            // PrecotextBox
            // 
            this.PrecotextBox.Location = new System.Drawing.Point(185, 130);
            this.PrecotextBox.Name = "PrecotextBox";
            this.PrecotextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecotextBox.TabIndex = 3;
            this.PrecotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // mskTxtBoxCodigo
            // 
            this.mskTxtBoxCodigo.Location = new System.Drawing.Point(21, 230);
            this.mskTxtBoxCodigo.Mask = "000.000.0000";
            this.mskTxtBoxCodigo.Name = "mskTxtBoxCodigo";
            this.mskTxtBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBoxCodigo.TabIndex = 5;
            this.mskTxtBoxCodigo.Text = "005474";
            this.mskTxtBoxCodigo.Visible = false;
            // 
            // CodigomaskedTextBox
            // 
            this.CodigomaskedTextBox.Location = new System.Drawing.Point(27, 283);
            this.CodigomaskedTextBox.Mask = "000.000.0000";
            this.CodigomaskedTextBox.Name = "CodigomaskedTextBox";
            this.CodigomaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigomaskedTextBox.TabIndex = 6;
            this.CodigomaskedTextBox.Text = "022169";
            this.CodigomaskedTextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insumo";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serviço";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidade";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.unidadeBindingSource;
            this.comboBox1.DisplayMember = "Descricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Codigo";
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
            // unidadeTableAdapter
            // 
            this.unidadeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComposicaopictureBox
            // 
            this.ComposicaopictureBox.Location = new System.Drawing.Point(156, 270);
            this.ComposicaopictureBox.Name = "ComposicaopictureBox";
            this.ComposicaopictureBox.Size = new System.Drawing.Size(29, 22);
            this.ComposicaopictureBox.TabIndex = 18;
            this.ComposicaopictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Composição";
            // 
            // ServicopictureBox
            // 
            this.ServicopictureBox.Location = new System.Drawing.Point(156, 242);
            this.ServicopictureBox.Name = "ServicopictureBox";
            this.ServicopictureBox.Size = new System.Drawing.Size(29, 22);
            this.ServicopictureBox.TabIndex = 16;
            this.ServicopictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Serviço";
            // 
            // InsumopictureBox
            // 
            this.InsumopictureBox.Location = new System.Drawing.Point(156, 214);
            this.InsumopictureBox.Name = "InsumopictureBox";
            this.InsumopictureBox.Size = new System.Drawing.Size(29, 22);
            this.InsumopictureBox.TabIndex = 14;
            this.InsumopictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Insumo";
            // 
            // CadastroTabelaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.ComposicaopictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ServicopictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InsumopictureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodigomaskedTextBox);
            this.Controls.Add(this.mskTxtBoxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrecotextBox);
            this.Controls.Add(this.Cadastrarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescricaotextBox);
            this.Name = "CadastroTabelaExterna";
            this.Text = "CadastroTabelaExterna";
            this.Load += new System.EventHandler(this.CadastroTabelaExterna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComposicaopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescricaotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrarbutton;
        private System.Windows.Forms.TextBox PrecotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxCodigo;
        private System.Windows.Forms.MaskedTextBox CodigomaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private SCOOP.DAO.SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.UnidadeTableAdapter unidadeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ComposicaopictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ServicopictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox InsumopictureBox;
        private System.Windows.Forms.Label label8;
    }
}