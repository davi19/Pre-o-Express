using System.ComponentModel;
using System.Windows.Forms;

namespace MacGiant
{
    partial class Usuario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCadastrar = new System.Windows.Forms.TabPage();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextDescricao = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBusca = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabCadastrar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCadastrar);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 373);
            this.tabControl1.TabIndex = 2;
            // 
            // TabCadastrar
            // 
            this.TabCadastrar.Controls.Add(this.TextSenha);
            this.TabCadastrar.Controls.Add(this.label3);
            this.TabCadastrar.Controls.Add(this.label2);
            this.TabCadastrar.Controls.Add(this.TextDescricao);
            this.TabCadastrar.Controls.Add(this.BtnExcluir);
            this.TabCadastrar.Controls.Add(this.BtnCadastrar);
            this.TabCadastrar.Controls.Add(this.BtnSalvar);
            this.TabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.TabCadastrar.Name = "TabCadastrar";
            this.TabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadastrar.Size = new System.Drawing.Size(766, 347);
            this.TabCadastrar.TabIndex = 1;
            this.TabCadastrar.Text = "Cadastrar";
            this.TabCadastrar.UseVisualStyleBackColor = true;
            // 
            // TextSenha
            // 
            this.TextSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextSenha.Location = new System.Drawing.Point(6, 70);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(215, 21);
            this.TextSenha.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login:";
            // 
            // TextDescricao
            // 
            this.TextDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextDescricao.Location = new System.Drawing.Point(6, 30);
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.Size = new System.Drawing.Size(215, 21);
            this.TextDescricao.TabIndex = 6;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Location = new System.Drawing.Point(523, 318);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Location = new System.Drawing.Point(685, 318);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Location = new System.Drawing.Point(604, 318);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 3;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TextBusca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 347);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Buscar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 288);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(448, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar:";
            // 
            // TextBusca
            // 
            this.TextBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBusca.Location = new System.Drawing.Point(6, 26);
            this.TextBusca.Name = "TextBusca";
            this.TextBusca.Size = new System.Drawing.Size(436, 21);
            this.TextBusca.TabIndex = 0;
            this.TextBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBusca_KeyPress);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 412);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.tabControl1.ResumeLayout(false);
            this.TabCadastrar.ResumeLayout(false);
            this.TabCadastrar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabCadastrar;
        private Label label3;
        private Label label2;
        private TextBox TextDescricao;
        private Button BtnExcluir;
        private Button BtnCadastrar;
        private Button BtnSalvar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TextBox TextSenha;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button BtnBuscar;
        private Label label4;
        private TextBox TextBusca;
    }
}