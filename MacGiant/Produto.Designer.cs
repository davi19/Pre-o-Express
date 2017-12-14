using System.ComponentModel;
using System.Windows.Forms;

namespace MacGiant
{
    partial class Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCadastrar = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioIndisponivel = new System.Windows.Forms.RadioButton();
            this.RadioDisponivel = new System.Windows.Forms.RadioButton();
            this.labelDescricaoCompleta = new System.Windows.Forms.Label();
            this.TextDescricaoCompleta = new System.Windows.Forms.TextBox();
            this.BtnComposicao = new System.Windows.Forms.Button();
            this.ListCustos = new System.Windows.Forms.DataGridView();
            this.IDCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAOCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADECUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListAviamentos = new System.Windows.Forms.DataGridView();
            this.IDAVIAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAOAVIAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORAVIAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADEAVIAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListServicos = new System.Windows.Forms.DataGridView();
            this.IDSERVICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAOSERVICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORSERVICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADESERVICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListMateriaPrima = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIÇÃO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TextCodigo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.NumericDescontoAvista = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.NumericDescontoAtacado = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.NumericDescontoAprazo = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NumericAtacado = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NumericTotal = new System.Windows.Forms.NumericUpDown();
            this.NumericMarkup = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumericVendedor = new System.Windows.Forms.NumericUpDown();
            this.NumericAprazo = new System.Windows.Forms.NumericUpDown();
            this.NumericAvista = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NumericLucro = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscarServicos = new System.Windows.Forms.Button();
            this.BtnBuscarAviamentos = new System.Windows.Forms.Button();
            this.BtnBuscarMateria = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextDescricao = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.TextBusca = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCustos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListAviamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDescontoAvista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDescontoAtacado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDescontoAprazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAtacado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMarkup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAprazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAvista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLucro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrecoCusto)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCadastrar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 373);
            this.tabControl1.TabIndex = 5;
            // 
            // TabCadastrar
            // 
            this.TabCadastrar.Controls.Add(this.label29);
            this.TabCadastrar.Controls.Add(this.label1);
            this.TabCadastrar.Controls.Add(this.RadioIndisponivel);
            this.TabCadastrar.Controls.Add(this.RadioDisponivel);
            this.TabCadastrar.Controls.Add(this.labelDescricaoCompleta);
            this.TabCadastrar.Controls.Add(this.TextDescricaoCompleta);
            this.TabCadastrar.Controls.Add(this.BtnComposicao);
            this.TabCadastrar.Controls.Add(this.ListCustos);
            this.TabCadastrar.Controls.Add(this.ListAviamentos);
            this.TabCadastrar.Controls.Add(this.ListServicos);
            this.TabCadastrar.Controls.Add(this.ListMateriaPrima);
            this.TabCadastrar.Controls.Add(this.label27);
            this.TabCadastrar.Controls.Add(this.label26);
            this.TabCadastrar.Controls.Add(this.label25);
            this.TabCadastrar.Controls.Add(this.label24);
            this.TabCadastrar.Controls.Add(this.label23);
            this.TabCadastrar.Controls.Add(this.label22);
            this.TabCadastrar.Controls.Add(this.TextCodigo);
            this.TabCadastrar.Controls.Add(this.button3);
            this.TabCadastrar.Controls.Add(this.button2);
            this.TabCadastrar.Controls.Add(this.label21);
            this.TabCadastrar.Controls.Add(this.NumericDescontoAvista);
            this.TabCadastrar.Controls.Add(this.label20);
            this.TabCadastrar.Controls.Add(this.NumericDescontoAtacado);
            this.TabCadastrar.Controls.Add(this.label19);
            this.TabCadastrar.Controls.Add(this.NumericDescontoAprazo);
            this.TabCadastrar.Controls.Add(this.label18);
            this.TabCadastrar.Controls.Add(this.label16);
            this.TabCadastrar.Controls.Add(this.NumericAtacado);
            this.TabCadastrar.Controls.Add(this.label17);
            this.TabCadastrar.Controls.Add(this.label15);
            this.TabCadastrar.Controls.Add(this.NumericTotal);
            this.TabCadastrar.Controls.Add(this.NumericMarkup);
            this.TabCadastrar.Controls.Add(this.label14);
            this.TabCadastrar.Controls.Add(this.label13);
            this.TabCadastrar.Controls.Add(this.label12);
            this.TabCadastrar.Controls.Add(this.NumericVendedor);
            this.TabCadastrar.Controls.Add(this.NumericAprazo);
            this.TabCadastrar.Controls.Add(this.NumericAvista);
            this.TabCadastrar.Controls.Add(this.label11);
            this.TabCadastrar.Controls.Add(this.label10);
            this.TabCadastrar.Controls.Add(this.label9);
            this.TabCadastrar.Controls.Add(this.button1);
            this.TabCadastrar.Controls.Add(this.label8);
            this.TabCadastrar.Controls.Add(this.NumericLucro);
            this.TabCadastrar.Controls.Add(this.label7);
            this.TabCadastrar.Controls.Add(this.BtnBuscarServicos);
            this.TabCadastrar.Controls.Add(this.BtnBuscarAviamentos);
            this.TabCadastrar.Controls.Add(this.BtnBuscarMateria);
            this.TabCadastrar.Controls.Add(this.label6);
            this.TabCadastrar.Controls.Add(this.label5);
            this.TabCadastrar.Controls.Add(this.label4);
            this.TabCadastrar.Controls.Add(this.NumericPrecoCusto);
            this.TabCadastrar.Controls.Add(this.label3);
            this.TabCadastrar.Controls.Add(this.label2);
            this.TabCadastrar.Controls.Add(this.TextDescricao);
            this.TabCadastrar.Controls.Add(this.BtnExcluir);
            this.TabCadastrar.Controls.Add(this.BtnCadastrar);
            this.TabCadastrar.Controls.Add(this.BtnSalvar);
            this.TabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.TabCadastrar.Name = "TabCadastrar";
            this.TabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadastrar.Size = new System.Drawing.Size(1173, 347);
            this.TabCadastrar.TabIndex = 1;
            this.TabCadastrar.Text = "Cadastrar";
            this.TabCadastrar.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(852, 194);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 13);
            this.label29.TabIndex = 71;
            this.label29.Text = "||";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Disponibilidade:*";
            // 
            // RadioIndisponivel
            // 
            this.RadioIndisponivel.AutoSize = true;
            this.RadioIndisponivel.Location = new System.Drawing.Point(972, 190);
            this.RadioIndisponivel.Name = "RadioIndisponivel";
            this.RadioIndisponivel.Size = new System.Drawing.Size(92, 17);
            this.RadioIndisponivel.TabIndex = 69;
            this.RadioIndisponivel.Text = "indisponível";
            this.RadioIndisponivel.UseVisualStyleBackColor = true;
            // 
            // RadioDisponivel
            // 
            this.RadioDisponivel.AutoSize = true;
            this.RadioDisponivel.Checked = true;
            this.RadioDisponivel.Location = new System.Drawing.Point(882, 190);
            this.RadioDisponivel.Name = "RadioDisponivel";
            this.RadioDisponivel.Size = new System.Drawing.Size(84, 17);
            this.RadioDisponivel.TabIndex = 68;
            this.RadioDisponivel.TabStop = true;
            this.RadioDisponivel.Text = "Disponível";
            this.RadioDisponivel.UseVisualStyleBackColor = true;
            // 
            // labelDescricaoCompleta
            // 
            this.labelDescricaoCompleta.AutoSize = true;
            this.labelDescricaoCompleta.Location = new System.Drawing.Point(354, 14);
            this.labelDescricaoCompleta.Name = "labelDescricaoCompleta";
            this.labelDescricaoCompleta.Size = new System.Drawing.Size(134, 13);
            this.labelDescricaoCompleta.TabIndex = 67;
            this.labelDescricaoCompleta.Text = "Descrição Completa:*";
            // 
            // TextDescricaoCompleta
            // 
            this.TextDescricaoCompleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextDescricaoCompleta.Location = new System.Drawing.Point(357, 30);
            this.TextDescricaoCompleta.Name = "TextDescricaoCompleta";
            this.TextDescricaoCompleta.Size = new System.Drawing.Size(489, 21);
            this.TextDescricaoCompleta.TabIndex = 2;
            // 
            // BtnComposicao
            // 
            this.BtnComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComposicao.Location = new System.Drawing.Point(852, 30);
            this.BtnComposicao.Name = "BtnComposicao";
            this.BtnComposicao.Size = new System.Drawing.Size(94, 23);
            this.BtnComposicao.TabIndex = 65;
            this.BtnComposicao.Text = "Compisição";
            this.BtnComposicao.UseVisualStyleBackColor = true;
            this.BtnComposicao.Click += new System.EventHandler(this.BtnComposicao_Click);
            // 
            // ListCustos
            // 
            this.ListCustos.AllowUserToAddRows = false;
            this.ListCustos.AllowUserToDeleteRows = false;
            this.ListCustos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCustos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCUSTO,
            this.DESCRICAOCUSTO,
            this.VALORCUSTO,
            this.QUANTIDADECUSTO});
            this.ListCustos.Location = new System.Drawing.Point(882, 74);
            this.ListCustos.Name = "ListCustos";
            this.ListCustos.ReadOnly = true;
            this.ListCustos.Size = new System.Drawing.Size(256, 97);
            this.ListCustos.TabIndex = 64;
            // 
            // IDCUSTO
            // 
            this.IDCUSTO.HeaderText = "ID";
            this.IDCUSTO.Name = "IDCUSTO";
            this.IDCUSTO.ReadOnly = true;
            // 
            // DESCRICAOCUSTO
            // 
            this.DESCRICAOCUSTO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAOCUSTO.Name = "DESCRICAOCUSTO";
            this.DESCRICAOCUSTO.ReadOnly = true;
            // 
            // VALORCUSTO
            // 
            this.VALORCUSTO.HeaderText = "VALOR";
            this.VALORCUSTO.Name = "VALORCUSTO";
            this.VALORCUSTO.ReadOnly = true;
            // 
            // QUANTIDADECUSTO
            // 
            this.QUANTIDADECUSTO.HeaderText = "QUANTIDADE";
            this.QUANTIDADECUSTO.Name = "QUANTIDADECUSTO";
            this.QUANTIDADECUSTO.ReadOnly = true;
            // 
            // ListAviamentos
            // 
            this.ListAviamentos.AllowUserToAddRows = false;
            this.ListAviamentos.AllowUserToDeleteRows = false;
            this.ListAviamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAviamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAVIAMENTO,
            this.DESCRICAOAVIAMENTO,
            this.VALORAVIAMENTO,
            this.QUANTIDADEAVIAMENTO});
            this.ListAviamentos.Location = new System.Drawing.Point(590, 74);
            this.ListAviamentos.Name = "ListAviamentos";
            this.ListAviamentos.ReadOnly = true;
            this.ListAviamentos.Size = new System.Drawing.Size(256, 97);
            this.ListAviamentos.TabIndex = 63;
            // 
            // IDAVIAMENTO
            // 
            this.IDAVIAMENTO.HeaderText = "ID";
            this.IDAVIAMENTO.Name = "IDAVIAMENTO";
            this.IDAVIAMENTO.ReadOnly = true;
            // 
            // DESCRICAOAVIAMENTO
            // 
            this.DESCRICAOAVIAMENTO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAOAVIAMENTO.Name = "DESCRICAOAVIAMENTO";
            this.DESCRICAOAVIAMENTO.ReadOnly = true;
            // 
            // VALORAVIAMENTO
            // 
            this.VALORAVIAMENTO.HeaderText = "VALOR";
            this.VALORAVIAMENTO.Name = "VALORAVIAMENTO";
            this.VALORAVIAMENTO.ReadOnly = true;
            // 
            // QUANTIDADEAVIAMENTO
            // 
            this.QUANTIDADEAVIAMENTO.HeaderText = "QUANTIDADE";
            this.QUANTIDADEAVIAMENTO.Name = "QUANTIDADEAVIAMENTO";
            this.QUANTIDADEAVIAMENTO.ReadOnly = true;
            // 
            // ListServicos
            // 
            this.ListServicos.AllowUserToAddRows = false;
            this.ListServicos.AllowUserToDeleteRows = false;
            this.ListServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSERVICO,
            this.DESCRICAOSERVICO,
            this.VALORSERVICO,
            this.QUANTIDADESERVICO});
            this.ListServicos.Location = new System.Drawing.Point(298, 74);
            this.ListServicos.Name = "ListServicos";
            this.ListServicos.ReadOnly = true;
            this.ListServicos.Size = new System.Drawing.Size(256, 97);
            this.ListServicos.TabIndex = 62;
            // 
            // IDSERVICO
            // 
            this.IDSERVICO.HeaderText = "ID";
            this.IDSERVICO.Name = "IDSERVICO";
            this.IDSERVICO.ReadOnly = true;
            // 
            // DESCRICAOSERVICO
            // 
            this.DESCRICAOSERVICO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAOSERVICO.Name = "DESCRICAOSERVICO";
            this.DESCRICAOSERVICO.ReadOnly = true;
            // 
            // VALORSERVICO
            // 
            this.VALORSERVICO.HeaderText = "VALOR";
            this.VALORSERVICO.Name = "VALORSERVICO";
            this.VALORSERVICO.ReadOnly = true;
            // 
            // QUANTIDADESERVICO
            // 
            this.QUANTIDADESERVICO.HeaderText = "QUANTIDADE";
            this.QUANTIDADESERVICO.Name = "QUANTIDADESERVICO";
            this.QUANTIDADESERVICO.ReadOnly = true;
            // 
            // ListMateriaPrima
            // 
            this.ListMateriaPrima.AllowUserToAddRows = false;
            this.ListMateriaPrima.AllowUserToDeleteRows = false;
            this.ListMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIÇÃO,
            this.VALOR,
            this.QUANTIDADE});
            this.ListMateriaPrima.Location = new System.Drawing.Point(6, 74);
            this.ListMateriaPrima.Name = "ListMateriaPrima";
            this.ListMateriaPrima.ReadOnly = true;
            this.ListMateriaPrima.Size = new System.Drawing.Size(256, 97);
            this.ListMateriaPrima.TabIndex = 61;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DESCRIÇÃO
            // 
            this.DESCRIÇÃO.HeaderText = "DESCRIÇÃO";
            this.DESCRIÇÃO.Name = "DESCRIÇÃO";
            this.DESCRIÇÃO.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(118, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "||";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(268, 192);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "||";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(567, 190);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "||";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(419, 232);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "||";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(567, 232);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "||";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Codigo:*";
            // 
            // TextCodigo
            // 
            this.TextCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextCodigo.Location = new System.Drawing.Point(14, 30);
            this.TextCodigo.Name = "TextCodigo";
            this.TextCodigo.Size = new System.Drawing.Size(98, 21);
            this.TextCodigo.TabIndex = 0;
            this.TextCodigo.TextChanged += new System.EventHandler(this.TextCodigo_TextChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1033, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 53;
            this.button3.Text = "Limpar Dados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::MacGiant.Properties.Resources.lupa2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1143, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(436, 214);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Desconto:";
            // 
            // NumericDescontoAvista
            // 
            this.NumericDescontoAvista.DecimalPlaces = 3;
            this.NumericDescontoAvista.Location = new System.Drawing.Point(439, 230);
            this.NumericDescontoAvista.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDescontoAvista.Name = "NumericDescontoAvista";
            this.NumericDescontoAvista.Size = new System.Drawing.Size(115, 21);
            this.NumericDescontoAvista.TabIndex = 50;
            this.NumericDescontoAvista.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.NumericDescontoAvista.ValueChanged += new System.EventHandler(this.NumericDescontoAvista_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(587, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Desconto:";
            // 
            // NumericDescontoAtacado
            // 
            this.NumericDescontoAtacado.DecimalPlaces = 3;
            this.NumericDescontoAtacado.Location = new System.Drawing.Point(590, 230);
            this.NumericDescontoAtacado.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDescontoAtacado.Name = "NumericDescontoAtacado";
            this.NumericDescontoAtacado.Size = new System.Drawing.Size(120, 21);
            this.NumericDescontoAtacado.TabIndex = 48;
            this.NumericDescontoAtacado.Value = new decimal(new int[] {
            215,
            0,
            0,
            196608});
            this.NumericDescontoAtacado.ValueChanged += new System.EventHandler(this.NumericDescontoAtacado_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(295, 214);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Desconto:";
            // 
            // NumericDescontoAprazo
            // 
            this.NumericDescontoAprazo.DecimalPlaces = 3;
            this.NumericDescontoAprazo.Location = new System.Drawing.Point(298, 230);
            this.NumericDescontoAprazo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDescontoAprazo.Name = "NumericDescontoAprazo";
            this.NumericDescontoAprazo.Size = new System.Drawing.Size(115, 21);
            this.NumericDescontoAprazo.TabIndex = 46;
            this.NumericDescontoAprazo.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.NumericDescontoAprazo.ValueChanged += new System.EventHandler(this.NumericDescontoAprazo_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(879, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Custos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(567, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "||";
            // 
            // NumericAtacado
            // 
            this.NumericAtacado.DecimalPlaces = 3;
            this.NumericAtacado.Location = new System.Drawing.Point(590, 273);
            this.NumericAtacado.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericAtacado.Name = "NumericAtacado";
            this.NumericAtacado.Size = new System.Drawing.Size(120, 21);
            this.NumericAtacado.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(587, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Atacado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(587, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Total:";
            // 
            // NumericTotal
            // 
            this.NumericTotal.DecimalPlaces = 2;
            this.NumericTotal.Enabled = false;
            this.NumericTotal.Location = new System.Drawing.Point(590, 190);
            this.NumericTotal.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericTotal.Name = "NumericTotal";
            this.NumericTotal.Size = new System.Drawing.Size(256, 21);
            this.NumericTotal.TabIndex = 39;
            // 
            // NumericMarkup
            // 
            this.NumericMarkup.DecimalPlaces = 3;
            this.NumericMarkup.Location = new System.Drawing.Point(6, 273);
            this.NumericMarkup.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericMarkup.Name = "NumericMarkup";
            this.NumericMarkup.Size = new System.Drawing.Size(106, 21);
            this.NumericMarkup.TabIndex = 4;
            this.NumericMarkup.ValueChanged += new System.EventHandler(this.NumericMarkup_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(419, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "||";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "||";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "||";
            // 
            // NumericVendedor
            // 
            this.NumericVendedor.DecimalPlaces = 3;
            this.NumericVendedor.Location = new System.Drawing.Point(141, 273);
            this.NumericVendedor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericVendedor.Name = "NumericVendedor";
            this.NumericVendedor.Size = new System.Drawing.Size(118, 21);
            this.NumericVendedor.TabIndex = 34;
            // 
            // NumericAprazo
            // 
            this.NumericAprazo.DecimalPlaces = 3;
            this.NumericAprazo.Location = new System.Drawing.Point(298, 273);
            this.NumericAprazo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericAprazo.Name = "NumericAprazo";
            this.NumericAprazo.Size = new System.Drawing.Size(115, 21);
            this.NumericAprazo.TabIndex = 33;
            // 
            // NumericAvista
            // 
            this.NumericAvista.DecimalPlaces = 3;
            this.NumericAvista.Location = new System.Drawing.Point(439, 274);
            this.NumericAvista.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumericAvista.Name = "NumericAvista";
            this.NumericAvista.Size = new System.Drawing.Size(115, 21);
            this.NumericAvista.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Vendedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "A prazo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "A vista:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(952, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Markup:*";
            // 
            // NumericLucro
            // 
            this.NumericLucro.DecimalPlaces = 2;
            this.NumericLucro.Location = new System.Drawing.Point(6, 190);
            this.NumericLucro.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericLucro.Name = "NumericLucro";
            this.NumericLucro.Size = new System.Drawing.Size(253, 21);
            this.NumericLucro.TabIndex = 3;
            this.NumericLucro.ValueChanged += new System.EventHandler(this.NumericLucro_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lucro:*";
            // 
            // BtnBuscarServicos
            // 
            this.BtnBuscarServicos.BackgroundImage = global::MacGiant.Properties.Resources.lupa2;
            this.BtnBuscarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarServicos.Location = new System.Drawing.Point(560, 107);
            this.BtnBuscarServicos.Name = "BtnBuscarServicos";
            this.BtnBuscarServicos.Size = new System.Drawing.Size(24, 23);
            this.BtnBuscarServicos.TabIndex = 5;
            this.BtnBuscarServicos.UseVisualStyleBackColor = true;
            this.BtnBuscarServicos.Click += new System.EventHandler(this.BtnBuscarServicos_Click);
            // 
            // BtnBuscarAviamentos
            // 
            this.BtnBuscarAviamentos.BackgroundImage = global::MacGiant.Properties.Resources.lupa2;
            this.BtnBuscarAviamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAviamentos.Location = new System.Drawing.Point(852, 107);
            this.BtnBuscarAviamentos.Name = "BtnBuscarAviamentos";
            this.BtnBuscarAviamentos.Size = new System.Drawing.Size(24, 23);
            this.BtnBuscarAviamentos.TabIndex = 6;
            this.BtnBuscarAviamentos.UseVisualStyleBackColor = true;
            this.BtnBuscarAviamentos.Click += new System.EventHandler(this.BtnBuscarAviamentos_Click);
            // 
            // BtnBuscarMateria
            // 
            this.BtnBuscarMateria.BackgroundImage = global::MacGiant.Properties.Resources.lupa2;
            this.BtnBuscarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarMateria.Location = new System.Drawing.Point(268, 107);
            this.BtnBuscarMateria.Name = "BtnBuscarMateria";
            this.BtnBuscarMateria.Size = new System.Drawing.Size(24, 23);
            this.BtnBuscarMateria.TabIndex = 19;
            this.BtnBuscarMateria.UseVisualStyleBackColor = true;
            this.BtnBuscarMateria.Click += new System.EventHandler(this.BtnBuscarMateria_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aviamentos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Serviços:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Materia Prima:";
            // 
            // NumericPrecoCusto
            // 
            this.NumericPrecoCusto.DecimalPlaces = 2;
            this.NumericPrecoCusto.Enabled = false;
            this.NumericPrecoCusto.Location = new System.Drawing.Point(298, 190);
            this.NumericPrecoCusto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumericPrecoCusto.Name = "NumericPrecoCusto";
            this.NumericPrecoCusto.Size = new System.Drawing.Size(256, 21);
            this.NumericPrecoCusto.TabIndex = 10;
            this.NumericPrecoCusto.ValueChanged += new System.EventHandler(this.NumericPrecoCusto_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço de custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição Reduzida:*";
            // 
            // TextDescricao
            // 
            this.TextDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextDescricao.Location = new System.Drawing.Point(141, 30);
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.Size = new System.Drawing.Size(210, 21);
            this.TextDescricao.TabIndex = 1;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Location = new System.Drawing.Point(930, 318);
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
            this.BtnCadastrar.Location = new System.Drawing.Point(1092, 318);
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
            this.BtnSalvar.Location = new System.Drawing.Point(1011, 318);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.TextBusca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1173, 347);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(1161, 288);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(448, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 1;
            this.label28.Text = "Buscar:";
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
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabCadastrar.ResumeLayout(false);
            this.TabCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCustos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListAviamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDescontoAvista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDescontoAtacado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDescontoAprazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAtacado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMarkup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAprazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAvista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLucro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrecoCusto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage TabCadastrar;
        private Button button1;
        private Label label8;
        private Label label7;
        private Button BtnBuscarServicos;
        private Button BtnBuscarAviamentos;
        private Button BtnBuscarMateria;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TextDescricao;
        private Button BtnExcluir;
        private Button BtnCadastrar;
        private Button BtnSalvar;
        private Label label14;
        private Label label13;
        private Label label12;
        private NumericUpDown NumericVendedor;
        private NumericUpDown NumericAprazo;
        private NumericUpDown NumericAvista;
        private Label label11;
        private Label label10;
        private Label label9;
        private NumericUpDown NumericLucro;
        private NumericUpDown NumericPrecoCusto;
        private NumericUpDown NumericMarkup;
        private Label label15;
        private NumericUpDown NumericTotal;
        private Label label16;
        private NumericUpDown NumericAtacado;
        private Label label17;
        private Label label21;
        private NumericUpDown NumericDescontoAvista;
        private Label label20;
        private NumericUpDown NumericDescontoAtacado;
        private Label label19;
        private NumericUpDown NumericDescontoAprazo;
        private Label label18;
        private Button button2;
        private Button button3;
        private Label label22;
        private TextBox TextCodigo;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label27;
        private DataGridView ListServicos;
        private DataGridView ListMateriaPrima;
        private DataGridView ListAviamentos;
        private DataGridView ListCustos;
        private DataGridViewTextBoxColumn IDCUSTO;
        private DataGridViewTextBoxColumn DESCRICAOCUSTO;
        private DataGridViewTextBoxColumn VALORCUSTO;
        private DataGridViewTextBoxColumn QUANTIDADECUSTO;
        private DataGridViewTextBoxColumn IDAVIAMENTO;
        private DataGridViewTextBoxColumn DESCRICAOAVIAMENTO;
        private DataGridViewTextBoxColumn VALORAVIAMENTO;
        private DataGridViewTextBoxColumn QUANTIDADEAVIAMENTO;
        private DataGridViewTextBoxColumn IDSERVICO;
        private DataGridViewTextBoxColumn DESCRICAOSERVICO;
        private DataGridViewTextBoxColumn VALORSERVICO;
        private DataGridViewTextBoxColumn QUANTIDADESERVICO;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DESCRIÇÃO;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn QUANTIDADE;
        private Button BtnComposicao;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label28;
        private TextBox TextBusca;
        private Label labelDescricaoCompleta;
        private TextBox TextDescricaoCompleta;
        private Label label1;
        private RadioButton RadioIndisponivel;
        private RadioButton RadioDisponivel;
        private Label label29;
    }
}