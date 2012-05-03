namespace SCOOP.GUI
{
    partial class DotacaoOrcamentaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.OrgaoComboBox = new System.Windows.Forms.ComboBox();
            this.dotOrgaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCOOPDataSet = new SCOOP.DAO.SCOOPDataSet();
            this.UnidadecomboBox = new System.Windows.Forms.ComboBox();
            this.dotUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.FuncaoComboBox = new System.Windows.Forms.ComboBox();
            this.dotFuncaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SubFuncaoComboBox = new System.Windows.Forms.ComboBox();
            this.dotSubFuncaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ProgramaComboBox = new System.Windows.Forms.ComboBox();
            this.dotProgramaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ProjetoAtividadeComboBox = new System.Windows.Forms.ComboBox();
            this.dotProjetoAtividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.DespesaComboBox = new System.Windows.Forms.ComboBox();
            this.dotDespesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.FonteRecursoComboBox = new System.Windows.Forms.ComboBox();
            this.dotFonteRecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dot_OrgaoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_OrgaoTableAdapter();
            this.dot_UnidadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_UnidadeTableAdapter();
            this.dot_FuncaoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_FuncaoTableAdapter();
            this.dot_SubFuncaoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_SubFuncaoTableAdapter();
            this.dot_ProgramaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_ProgramaTableAdapter();
            this.dot_ProjetoAtividadeTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_ProjetoAtividadeTableAdapter();
            this.dot_DespesaTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_DespesaTableAdapter();
            this.dot_FonteRecursoTableAdapter = new SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_FonteRecursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dotOrgaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotFuncaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotSubFuncaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotProgramaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotProjetoAtividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotDespesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotFonteRecursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orgão";
            // 
            // OrgaoComboBox
            // 
            this.OrgaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OrgaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OrgaoComboBox.DataSource = this.dotOrgaoBindingSource;
            this.OrgaoComboBox.DisplayMember = "Descricao";
            this.OrgaoComboBox.FormattingEnabled = true;
            this.OrgaoComboBox.Location = new System.Drawing.Point(72, 24);
            this.OrgaoComboBox.Name = "OrgaoComboBox";
            this.OrgaoComboBox.Size = new System.Drawing.Size(551, 21);
            this.OrgaoComboBox.TabIndex = 1;
            this.OrgaoComboBox.ValueMember = "Sequencial";
            // 
            // dotOrgaoBindingSource
            // 
            this.dotOrgaoBindingSource.DataMember = "Dot_Orgao";
            this.dotOrgaoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // sCOOPDataSet
            // 
            this.sCOOPDataSet.DataSetName = "SCOOPDataSet";
            this.sCOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UnidadecomboBox
            // 
            this.UnidadecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UnidadecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UnidadecomboBox.DataSource = this.dotUnidadeBindingSource;
            this.UnidadecomboBox.DisplayMember = "Descricao";
            this.UnidadecomboBox.FormattingEnabled = true;
            this.UnidadecomboBox.Location = new System.Drawing.Point(83, 51);
            this.UnidadecomboBox.Name = "UnidadecomboBox";
            this.UnidadecomboBox.Size = new System.Drawing.Size(540, 21);
            this.UnidadecomboBox.TabIndex = 3;
            this.UnidadecomboBox.ValueMember = "Sequencial";
            // 
            // dotUnidadeBindingSource
            // 
            this.dotUnidadeBindingSource.DataMember = "Dot_Unidade";
            this.dotUnidadeBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidade";
            // 
            // FuncaoComboBox
            // 
            this.FuncaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FuncaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FuncaoComboBox.DataSource = this.dotFuncaoBindingSource;
            this.FuncaoComboBox.DisplayMember = "Descricao";
            this.FuncaoComboBox.FormattingEnabled = true;
            this.FuncaoComboBox.Location = new System.Drawing.Point(92, 80);
            this.FuncaoComboBox.Name = "FuncaoComboBox";
            this.FuncaoComboBox.Size = new System.Drawing.Size(531, 21);
            this.FuncaoComboBox.TabIndex = 5;
            this.FuncaoComboBox.ValueMember = "Sequencial";
            // 
            // dotFuncaoBindingSource
            // 
            this.dotFuncaoBindingSource.DataMember = "Dot_Funcao";
            this.dotFuncaoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Função";
            // 
            // SubFuncaoComboBox
            // 
            this.SubFuncaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SubFuncaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubFuncaoComboBox.DataSource = this.dotSubFuncaoBindingSource;
            this.SubFuncaoComboBox.DisplayMember = "Descricao";
            this.SubFuncaoComboBox.DropDownWidth = 800;
            this.SubFuncaoComboBox.FormattingEnabled = true;
            this.SubFuncaoComboBox.Location = new System.Drawing.Point(98, 108);
            this.SubFuncaoComboBox.Name = "SubFuncaoComboBox";
            this.SubFuncaoComboBox.Size = new System.Drawing.Size(525, 21);
            this.SubFuncaoComboBox.TabIndex = 7;
            this.SubFuncaoComboBox.ValueMember = "Sequencial";
            // 
            // dotSubFuncaoBindingSource
            // 
            this.dotSubFuncaoBindingSource.DataMember = "Dot_SubFuncao";
            this.dotSubFuncaoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SubFunção";
            // 
            // ProgramaComboBox
            // 
            this.ProgramaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProgramaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProgramaComboBox.DataSource = this.dotProgramaBindingSource;
            this.ProgramaComboBox.DisplayMember = "Descricao";
            this.ProgramaComboBox.DropDownWidth = 800;
            this.ProgramaComboBox.FormattingEnabled = true;
            this.ProgramaComboBox.Location = new System.Drawing.Point(92, 138);
            this.ProgramaComboBox.Name = "ProgramaComboBox";
            this.ProgramaComboBox.Size = new System.Drawing.Size(531, 21);
            this.ProgramaComboBox.TabIndex = 9;
            this.ProgramaComboBox.ValueMember = "Sequencial";
            // 
            // dotProgramaBindingSource
            // 
            this.dotProgramaBindingSource.DataMember = "Dot_Programa";
            this.dotProgramaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Programa";
            // 
            // ProjetoAtividadeComboBox
            // 
            this.ProjetoAtividadeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProjetoAtividadeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProjetoAtividadeComboBox.DataSource = this.dotProjetoAtividadeBindingSource;
            this.ProjetoAtividadeComboBox.DisplayMember = "Descricao";
            this.ProjetoAtividadeComboBox.DropDownWidth = 800;
            this.ProjetoAtividadeComboBox.FormattingEnabled = true;
            this.ProjetoAtividadeComboBox.Location = new System.Drawing.Point(126, 168);
            this.ProjetoAtividadeComboBox.Name = "ProjetoAtividadeComboBox";
            this.ProjetoAtividadeComboBox.Size = new System.Drawing.Size(497, 21);
            this.ProjetoAtividadeComboBox.TabIndex = 11;
            this.ProjetoAtividadeComboBox.ValueMember = "Sequencial";
            // 
            // dotProjetoAtividadeBindingSource
            // 
            this.dotProjetoAtividadeBindingSource.DataMember = "Dot_ProjetoAtividade";
            this.dotProjetoAtividadeBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Projeto/Atividade";
            // 
            // DespesaComboBox
            // 
            this.DespesaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DespesaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DespesaComboBox.DataSource = this.dotDespesaBindingSource;
            this.DespesaComboBox.DisplayMember = "Descricao";
            this.DespesaComboBox.DropDownWidth = 800;
            this.DespesaComboBox.FormattingEnabled = true;
            this.DespesaComboBox.Location = new System.Drawing.Point(83, 199);
            this.DespesaComboBox.Name = "DespesaComboBox";
            this.DespesaComboBox.Size = new System.Drawing.Size(540, 21);
            this.DespesaComboBox.TabIndex = 13;
            this.DespesaComboBox.ValueMember = "Sequencial";
            // 
            // dotDespesaBindingSource
            // 
            this.dotDespesaBindingSource.DataMember = "Dot_Despesa";
            this.dotDespesaBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Despesa";
            // 
            // FonteRecursoComboBox
            // 
            this.FonteRecursoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FonteRecursoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FonteRecursoComboBox.DataSource = this.dotFonteRecursoBindingSource;
            this.FonteRecursoComboBox.DisplayMember = "Descricao";
            this.FonteRecursoComboBox.FormattingEnabled = true;
            this.FonteRecursoComboBox.Location = new System.Drawing.Point(126, 229);
            this.FonteRecursoComboBox.Name = "FonteRecursoComboBox";
            this.FonteRecursoComboBox.Size = new System.Drawing.Size(497, 21);
            this.FonteRecursoComboBox.TabIndex = 15;
            this.FonteRecursoComboBox.ValueMember = "Sequencial";
            // 
            // dotFonteRecursoBindingSource
            // 
            this.dotFonteRecursoBindingSource.DataMember = "Dot_FonteRecurso";
            this.dotFonteRecursoBindingSource.DataSource = this.sCOOPDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fonte de Recurso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dot_OrgaoTableAdapter
            // 
            this.dot_OrgaoTableAdapter.ClearBeforeFill = true;
            // 
            // dot_UnidadeTableAdapter
            // 
            this.dot_UnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // dot_FuncaoTableAdapter
            // 
            this.dot_FuncaoTableAdapter.ClearBeforeFill = true;
            // 
            // dot_SubFuncaoTableAdapter
            // 
            this.dot_SubFuncaoTableAdapter.ClearBeforeFill = true;
            // 
            // dot_ProgramaTableAdapter
            // 
            this.dot_ProgramaTableAdapter.ClearBeforeFill = true;
            // 
            // dot_ProjetoAtividadeTableAdapter
            // 
            this.dot_ProjetoAtividadeTableAdapter.ClearBeforeFill = true;
            // 
            // dot_DespesaTableAdapter
            // 
            this.dot_DespesaTableAdapter.ClearBeforeFill = true;
            // 
            // dot_FonteRecursoTableAdapter
            // 
            this.dot_FonteRecursoTableAdapter.ClearBeforeFill = true;
            // 
            // DotacaoOrcamentaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FonteRecursoComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DespesaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProjetoAtividadeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProgramaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubFuncaoComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FuncaoComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnidadecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrgaoComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DotacaoOrcamentaria";
            this.Text = "Dotação Orçamentaria";
            this.Load += new System.EventHandler(this.DotacaoOrcamentaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dotOrgaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotFuncaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotSubFuncaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotProgramaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotProjetoAtividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotDespesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotFonteRecursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrgaoComboBox;
        private System.Windows.Forms.ComboBox UnidadecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FuncaoComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SubFuncaoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProgramaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProjetoAtividadeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DespesaComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FonteRecursoComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private SCOOP.DAO.SCOOPDataSet sCOOPDataSet;
        private System.Windows.Forms.BindingSource dotOrgaoBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_OrgaoTableAdapter dot_OrgaoTableAdapter;
        private System.Windows.Forms.BindingSource dotUnidadeBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_UnidadeTableAdapter dot_UnidadeTableAdapter;
        private System.Windows.Forms.BindingSource dotFuncaoBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_FuncaoTableAdapter dot_FuncaoTableAdapter;
        private System.Windows.Forms.BindingSource dotSubFuncaoBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_SubFuncaoTableAdapter dot_SubFuncaoTableAdapter;
        private System.Windows.Forms.BindingSource dotProgramaBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_ProgramaTableAdapter dot_ProgramaTableAdapter;
        private System.Windows.Forms.BindingSource dotProjetoAtividadeBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_ProjetoAtividadeTableAdapter dot_ProjetoAtividadeTableAdapter;
        private System.Windows.Forms.BindingSource dotDespesaBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_DespesaTableAdapter dot_DespesaTableAdapter;
        private System.Windows.Forms.BindingSource dotFonteRecursoBindingSource;
        private SCOOP.DAO.SCOOPDataSetTableAdapters.Dot_FonteRecursoTableAdapter dot_FonteRecursoTableAdapter;
    }
}