using System;
using System.Data;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Aviamentos : Form
    {
        QuerryMysql CadastroAviamento = new QuerryMysql();
        private string IdAviamento = "";

        public Aviamentos()
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
                    "Não podemos alterar produtos já cadastrados, pois o aviamento está sendo cadastrado neste momento ! Favor marque a opção 'NÃO'.", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (TextDescricao.Text.Length == 0 || NumericValor.Value == 0 || TextCodigo.Text.Length == 0)
            {
                MessageBox.Show(
                    "Favor preencher todos os campos do formulario !", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                CadastroAviamento.CadastrarAviamento(TextCodigo.Text, TextDescricao.Text, NumericValor.Value);
                IdAviamento = "";
                TextDescricao.Text = "";
                NumericValor.Value = 0;
                TextCodigo.Text = "";

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (IdAviamento.Length == 0)
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
                CadastroAviamento.AtualizarTabelaCompleta(IdAviamento, "AVIAMENTO", NumericValor.Value,TextCodigo.Text);
               CadastroAviamento.AtualizarAviamento(TextDescricao.Text, NumericValor.Value, IdAviamento, TextCodigo.Text);
                MessageBox.Show("Dados alterados com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                IdAviamento = "";
                TextDescricao.Text = "";
                NumericValor.Value = 0;
                TextCodigo.Text = "";
            }
            else
            {
                CadastroAviamento.AtualizarAviamento(TextDescricao.Text, NumericValor.Value,IdAviamento, TextCodigo.Text);
                MessageBox.Show("Dados alterados com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                IdAviamento = "";
                TextDescricao.Text = "";
                NumericValor.Value = 0;
                TextCodigo.Text = "";

            }
            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (IdAviamento.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult Resposta = MessageBox.Show("Você tem certeza que deseja excluir este aviamento ?",
                    "Certeza?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Resposta == DialogResult.OK)
                {
                    String Resultado = CadastroAviamento.ExcluirAviamento(IdAviamento);
                    MessageBox.Show(Resultado, "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    IdAviamento = "";
                    TextDescricao.Text = "";
                    NumericValor.Value = 0;
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
            Resultado = CadastroAviamento.BuscarAviamento(TextBusca.Text);

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
                IdAviamento = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                TextCodigo.Text = IdAviamento;
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
                Resultado = CadastroAviamento.BuscarAviamentoCodigo(TextCodigo.Text);
                TextCodigo.Text = Resultado.Rows[0]["ID"].ToString();
                decimal valor = Convert.ToDecimal(Resultado.Rows[0]["VALOR"]);
                TextDescricao.Text = Resultado.Rows[0]["DESCRIÇÃO"].ToString();
                NumericValor.Value = valor;
                IdAviamento = Resultado.Rows[0]["ID"].ToString();
            }
            catch
            {
                decimal valor = 0;
                IdAviamento ="";
                TextDescricao.Text = "";
                NumericValor.Value = valor;
            }
        }


    }
    }
