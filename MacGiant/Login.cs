using System;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Login : Form
    {
        QuerryMysql Logar = new QuerryMysql();

        public Login()
        {
            InitializeComponent();
            ActiveControl = TextUsuario;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            bool Ok =Logar.Login(TextUsuario.Text, TextSenha.Text);

            if (Ok == true)
            {
                Principal Prin = new Principal();
                Prin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnEntrar_Click(sender, e);
            }
        }
    }
}
