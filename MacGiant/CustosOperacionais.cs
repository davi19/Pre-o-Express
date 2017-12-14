using System;
using System.Data;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class CustosOperacionais : Form
    {
        QuerryMysql CadastroCusto = new QuerryMysql();
        private string IdCusto = "";

        public CustosOperacionais()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (RadioSim.Checked)
            {
                MessageBox.Show(
                    "Não podemos alterar produtos já cadastrados, pois o custo está sendo cadastrado neste momento ! Favor marque a opção 'NÃO'.", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (TextDescricao.Text.Length == 0 || NumericValor.Value == 0|| TextCodigo.Text.Length ==0)
            {
                MessageBox.Show(
                    "Favor preencher todos os campos do formulario !", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                CadastroCusto.CadastrarCustos(TextCodigo.Text,TextDescricao.Text, NumericValor.Value);
                
                IdCusto = "";
                TextDescricao.Text = "";
                NumericValor.Value = 0;
                TextCodigo.Text = "";
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (IdCusto.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
           else if (RadioSim.Checked == false && RadioNao.Checked == false)
            {
                MessageBox.Show(
                    "Favor responder se deseja alterar produtos ja cadastrados!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (RadioSim.Checked)
            {
                CadastroCusto.AtualizarTabelaCompleta(IdCusto, "CUSTO", NumericValor.Value,TextCodigo.Text);
               CadastroCusto.AtualizarCustos(TextDescricao.Text, NumericValor.Value, IdCusto,TextCodigo.Text);
                MessageBox.Show("Dados alterados com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                IdCusto = "";
                TextDescricao.Text = "";
                NumericValor.Value = 0;
                TextCodigo.Text = "";
            }
            else
            {
                CadastroCusto.AtualizarCustos(TextDescricao.Text, NumericValor.Value, IdCusto,TextCodigo.Text);
                MessageBox.Show("Dados alterados com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                IdCusto = "";
                TextDescricao.Text = "";
                NumericValor.Value = 0;
                TextCodigo.Text = "";
            }
            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (IdCusto.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult Resposta = MessageBox.Show("Você tem certeza que deseja excluir este custo ?",
                    "Certeza?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Resposta == DialogResult.OK)
                {
                   string Resultado = CadastroCusto.ExcluirCustos(IdCusto);
                    MessageBox.Show(Resultado, "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IdCusto = "";
                    TextDescricao.Text = "";
                    NumericValor.Value = 0;
                    TextCodigo.Text = "";
                }
                else
                {

                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable Resultado = new DataTable();
            Resultado = CadastroCusto.BuscarCustos(TextBusca.Text);

            if (Resultado.Rows.Count == 0)
            {
                MessageBox.Show("Sua pesquisa não encontrou resultados!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView1.DataSource = Resultado;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                decimal valor = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["VALOR"].Value);
                TextDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["DESCRIÇÃO"].Value.ToString();
                NumericValor.Value = valor;
                IdCusto = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                TextCodigo.Text = IdCusto;
                dataGridView1.DataSource = null;
                tabControl1.SelectedTab = TabCadastrar;
            }
        }

        private void TextBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void TextCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Resultado = new DataTable();
                Resultado = CadastroCusto.BuscarCustoCodigo(TextCodigo.Text);
                TextCodigo.Text = Resultado.Rows[0]["ID"].ToString();
                decimal valor = Convert.ToDecimal(Resultado.Rows[0]["VALOR"]);
                TextDescricao.Text = Resultado.Rows[0]["DESCRIÇÃO"].ToString();
                NumericValor.Value = valor;
                IdCusto = Resultado.Rows[0]["ID"].ToString();
            }
            catch
            {
                IdCusto = "";
                decimal valor = 0;
                TextDescricao.Text = "";
                NumericValor.Value = valor;
            }
        }
    }
}
