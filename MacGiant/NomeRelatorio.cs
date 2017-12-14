using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class NomeRelatorio : Form
    {
        QuerryMysql Nome = new QuerryMysql();
        public NomeRelatorio()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Nome.SetNomeRelatorio(textBox1.Text);
           this. Close();
        }
    }
}
