using System.ComponentModel;
using System.Windows.Forms;

namespace MacGiant
{
    partial class Buscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Conteudo = new System.Windows.Forms.Label();
            this.ListTipo = new System.Windows.Forms.DataGridView();
            this.ListComposicao = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListComposicao)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Location = new System.Drawing.Point(655, 284);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(87, 23);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Location = new System.Drawing.Point(562, 284);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(87, 23);
            this.BtnVoltar.TabIndex = 6;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Conteudo
            // 
            this.Conteudo.AutoSize = true;
            this.Conteudo.Location = new System.Drawing.Point(406, 29);
            this.Conteudo.Name = "Conteudo";
            this.Conteudo.Size = new System.Drawing.Size(62, 13);
            this.Conteudo.TabIndex = 8;
            this.Conteudo.Text = "Conteudo";
            // 
            // ListTipo
            // 
            this.ListTipo.AllowUserToAddRows = false;
            this.ListTipo.AllowUserToDeleteRows = false;
            this.ListTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListTipo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTipo.Location = new System.Drawing.Point(12, 45);
            this.ListTipo.Name = "ListTipo";
            this.ListTipo.ReadOnly = true;
            this.ListTipo.Size = new System.Drawing.Size(361, 225);
            this.ListTipo.TabIndex = 9;
            this.ListTipo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListTipo_CellContentDoubleClick);
            // 
            // ListComposicao
            // 
            this.ListComposicao.AllowUserToAddRows = false;
            this.ListComposicao.AllowUserToDeleteRows = false;
            this.ListComposicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListComposicao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListComposicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListComposicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRICAO,
            this.VALOR,
            this.QUANTIDADE});
            this.ListComposicao.Location = new System.Drawing.Point(396, 45);
            this.ListComposicao.Name = "ListComposicao";
            this.ListComposicao.ReadOnly = true;
            this.ListComposicao.Size = new System.Drawing.Size(346, 225);
            this.ListComposicao.TabIndex = 10;
            this.ListComposicao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListComposicao_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 46;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 104;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 71;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 110;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 319);
            this.ControlBox = false;
            this.Controls.Add(this.ListComposicao);
            this.Controls.Add(this.ListTipo);
            this.Controls.Add(this.Conteudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnOK);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.ListTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListComposicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnOK;
        private Button BtnVoltar;
        private Label label1;
        private Label Conteudo;
        private DataGridView ListTipo;
        private DataGridView ListComposicao;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn QUANTIDADE;
    }
}