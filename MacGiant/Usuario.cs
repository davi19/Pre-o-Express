using System;
using System.Data;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Usuario : Form
    {
        QuerryMysql CadastroUsuario = new QuerryMysql();
        private string IdUsuario = "";

        public Usuario()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextDescricao.Text.Length == 0 || TextSenha.Text.Length == 0)
            {
                MessageBox.Show(
                    "Favor preencher todos os campos do formulario !", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                CadastroUsuario.CadastrarUsuario(TextDescricao.Text, TextSenha.Text);
                MessageBox.Show("Usuário cadastrado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (IdUsuario.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
            else if (TextDescricao.Text.Length == 0 || TextSenha.Text.Length == 0)
            {
                MessageBox.Show(
                    "Favor preencher todos os campos do formulario !", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                CadastroUsuario.AtualizarUsuario(TextDescricao.Text, TextSenha.Text, IdUsuario);
                MessageBox.Show("Dados alterados com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
           
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (IdUsuario.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult Resposta = MessageBox.Show("Você tem certeza que deseja excluir este usuário ?",
                    "Certeza?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Resposta == DialogResult.OK)
                {
                    CadastroUsuario.ExcluirUsuario(IdUsuario);
                    MessageBox.Show("Usuario excluido com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
            Resultado = CadastroUsuario.BuscarUsuario(TextBusca.Text);

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
                TextDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["LOGIN"].Value.ToString();
                IdUsuario = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
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
    }
}
