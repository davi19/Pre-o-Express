using System.ComponentModel;
using System.Windows.Forms;

namespace MacGiant
{
    partial class MatPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatPrima));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCadastrar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.TextCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioNao = new System.Windows.Forms.RadioButton();
            this.RadioSim = new System.Windows.Forms.RadioButton();
            this.NumericValor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextDescricao = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBusca = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValor)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sairToolStripMenuItem.Text = "Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCadastrar);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // TabCadastrar
            // 
            this.TabCadastrar.Controls.Add(this.label5);
            this.TabCadastrar.Controls.Add(this.TextCodigo);
            this.TabCadastrar.Controls.Add(this.label4);
            this.TabCadastrar.Controls.Add(this.RadioNao);
            this.TabCadastrar.Controls.Add(this.RadioSim);
            this.TabCadastrar.Controls.Add(this.NumericValor);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo:";
            // 
            // TextCodigo
            // 
            this.TextCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextCodigo.Location = new System.Drawing.Point(6, 29);
            this.TextCodigo.Name = "TextCodigo";
            this.TextCodigo.Size = new System.Drawing.Size(68, 21);
            this.TextCodigo.TabIndex = 18;
            this.TextCodigo.TextChanged += new System.EventHandler(this.TextCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alterar produtos já cadastrados ?";
            // 
            // RadioNao
            // 
            this.RadioNao.AutoSize = true;
            this.RadioNao.Location = new System.Drawing.Point(62, 128);
            this.RadioNao.Name = "RadioNao";
            this.RadioNao.Size = new System.Drawing.Size(47, 17);
            this.RadioNao.TabIndex = 12;
            this.RadioNao.TabStop = true;
            this.RadioNao.Text = "Não";
            this.RadioNao.UseVisualStyleBackColor = true;
            // 
            // RadioSim
            // 
            this.RadioSim.AutoSize = true;
            this.RadioSim.Location = new System.Drawing.Point(9, 128);
            this.RadioSim.Name = "RadioSim";
            this.RadioSim.Size = new System.Drawing.Size(47, 17);
            this.RadioSim.TabIndex = 11;
            this.RadioSim.TabStop = true;
            this.RadioSim.Text = "Sim";
            this.RadioSim.UseVisualStyleBackColor = true;
            // 
            // NumericValor
            // 
            this.NumericValor.DecimalPlaces = 2;
            this.NumericValor.Location = new System.Drawing.Point(6, 70);
            this.NumericValor.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericValor.Name = "NumericValor";
            this.NumericValor.Size = new System.Drawing.Size(215, 21);
            this.NumericValor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição:";
            // 
            // TextDescricao
            // 
            this.TextDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextDescricao.Location = new System.Drawing.Point(80, 29);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.label6);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Buscar:";
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
            // MatPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matéria Prima";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabCadastrar.ResumeLayout(false);
            this.TabCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValor)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage TabCadastrar;
        private Label label3;
        private Label label2;
        private TextBox TextDescricao;
        private Button BtnExcluir;
        private Button BtnCadastrar;
        private Button BtnSalvar;
        private NumericUpDown NumericValor;
        private Label label4;
        private RadioButton RadioNao;
        private RadioButton RadioSim;
        private Label label5;
        private TextBox TextCodigo;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button BtnBuscar;
        private Label label6;
        private TextBox TextBusca;
    }
}