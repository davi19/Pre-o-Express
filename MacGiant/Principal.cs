using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text = "Preço Express " + fvi.FileVersion;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void matériaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatPrima Prima = new MatPrima();
            Prima.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicos servicos = new Servicos();
            servicos.ShowDialog();
        }

        private void aviamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aviamentos aviamento = new Aviamentos();
            aviamento.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
                usuario.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ShowDialog();
        }

        private void custosOperacionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustosOperacionais custosoperacionais = new CustosOperacionais();
            custosoperacionais.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos grupos = new Grupos();
            grupos.ShowDialog();
        }
    }
}
