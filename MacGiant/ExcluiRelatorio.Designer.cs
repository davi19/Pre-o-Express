namespace MacGiant
{
    partial class ExcluiRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluiRelatorio));
            this.ListRelatoriosSalvos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListRelatoriosSalvos
            // 
            this.ListRelatoriosSalvos.FormattingEnabled = true;
            this.ListRelatoriosSalvos.Location = new System.Drawing.Point(12, 35);
            this.ListRelatoriosSalvos.Name = "ListRelatoriosSalvos";
            this.ListRelatoriosSalvos.Size = new System.Drawing.Size(319, 274);
            this.ListRelatoriosSalvos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o relatório que deseja excluir:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(256, 323);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(175, 323);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // ExcluiRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 358);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListRelatoriosSalvos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluiRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Relatório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListRelatoriosSalvos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnVoltar;
    }
}