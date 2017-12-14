using System.ComponentModel;
using System.Windows.Forms;

namespace MacGiant
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDisponivel = new System.Windows.Forms.ListView();
            this.ListGerar = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRetira = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RadioPdf = new System.Windows.Forms.RadioButton();
            this.RadioExcel = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.tiposToolStripMenuItem,
            this.padrãoToolStripMenuItem,
            this.excluirRelatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sairToolStripMenuItem.Text = "Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.custosToolStripMenuItem});
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tiposToolStripMenuItem.Text = "Tipos";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // custosToolStripMenuItem
            // 
            this.custosToolStripMenuItem.Name = "custosToolStripMenuItem";
            this.custosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.custosToolStripMenuItem.Text = "Custos";
            this.custosToolStripMenuItem.Click += new System.EventHandler(this.custosToolStripMenuItem_Click);
            // 
            // padrãoToolStripMenuItem
            // 
            this.padrãoToolStripMenuItem.Name = "padrãoToolStripMenuItem";
            this.padrãoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.padrãoToolStripMenuItem.Text = "Padrão";
            this.padrãoToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.padrãoToolStripMenuItem_DropDownItemClicked);
            // 
            // excluirRelatórioToolStripMenuItem
            // 
            this.excluirRelatórioToolStripMenuItem.Name = "excluirRelatórioToolStripMenuItem";
            this.excluirRelatórioToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.excluirRelatórioToolStripMenuItem.Text = "Excluir Relatório";
            this.excluirRelatórioToolStripMenuItem.Click += new System.EventHandler(this.excluirRelatórioToolStripMenuItem_Click);
            // 
            // ListDisponivel
            // 
            this.ListDisponivel.Location = new System.Drawing.Point(12, 41);
            this.ListDisponivel.Name = "ListDisponivel";
            this.ListDisponivel.Size = new System.Drawing.Size(245, 359);
            this.ListDisponivel.TabIndex = 12;
            this.ListDisponivel.UseCompatibleStateImageBehavior = false;
            this.ListDisponivel.View = System.Windows.Forms.View.List;
            // 
            // ListGerar
            // 
            this.ListGerar.Location = new System.Drawing.Point(342, 41);
            this.ListGerar.Name = "ListGerar";
            this.ListGerar.Size = new System.Drawing.Size(245, 359);
            this.ListGerar.TabIndex = 13;
            this.ListGerar.UseCompatibleStateImageBehavior = false;
            this.ListGerar.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dados a disposição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dados selecionados:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(698, 377);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(116, 23);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Gerar Relatório";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(264, 165);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(72, 23);
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = ">";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRetira
            // 
            this.BtnRetira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetira.Location = new System.Drawing.Point(264, 194);
            this.BtnRetira.Name = "BtnRetira";
            this.BtnRetira.Size = new System.Drawing.Size(72, 23);
            this.BtnRetira.TabIndex = 18;
            this.BtnRetira.Text = "<";
            this.BtnRetira.UseVisualStyleBackColor = true;
            this.BtnRetira.Click += new System.EventHandler(this.BtnRetira_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(593, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(193, 152);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Visible = false;
            // 
            // RadioPdf
            // 
            this.RadioPdf.AutoSize = true;
            this.RadioPdf.Checked = true;
            this.RadioPdf.Location = new System.Drawing.Point(593, 41);
            this.RadioPdf.Name = "RadioPdf";
            this.RadioPdf.Size = new System.Drawing.Size(47, 17);
            this.RadioPdf.TabIndex = 21;
            this.RadioPdf.TabStop = true;
            this.RadioPdf.Text = "PDF";
            this.RadioPdf.UseVisualStyleBackColor = true;
            // 
            // RadioExcel
            // 
            this.RadioExcel.AutoSize = true;
            this.RadioExcel.Location = new System.Drawing.Point(646, 41);
            this.RadioExcel.Name = "RadioExcel";
            this.RadioExcel.Size = new System.Drawing.Size(62, 17);
            this.RadioExcel.TabIndex = 22;
            this.RadioExcel.Text = "EXCEL";
            this.RadioExcel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(593, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadioExcel);
            this.Controls.Add(this.RadioPdf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnRetira);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListGerar);
            this.Controls.Add(this.ListDisponivel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ListView ListDisponivel;
        private ListView ListGerar;
        private Label label1;
        private Label label2;
        private Button BtnBuscar;
        private Button BtnAdd;
        private Button BtnRetira;
        private ToolStripMenuItem tiposToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem custosToolStripMenuItem;
        private DataGridView dataGridView1;
        private RadioButton RadioPdf;
        private RadioButton RadioExcel;
        private Button button1;
        private ToolStripMenuItem padrãoToolStripMenuItem;
        private ToolStripMenuItem excluirRelatórioToolStripMenuItem;
    }
}