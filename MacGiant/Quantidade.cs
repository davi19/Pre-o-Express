using System;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Quantidade : Form
    {
        QuerryMysql BuscaQuantidade = new QuerryMysql();
        public Quantidade()
        {
            InitializeComponent();
            ActiveControl = TextQuantidade;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               BtnOk_Click(sender, e);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextQuantidade.Value) == 0)
            {
                MessageBox.Show("Favor inserir um valor maior que zero !", "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                BuscaQuantidade.SetQuantidade(TextQuantidade.Value.ToString());
                this.Close();
            }
            
        }

    }
}
