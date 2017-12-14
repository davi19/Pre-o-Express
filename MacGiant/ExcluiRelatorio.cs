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
    public partial class ExcluiRelatorio : Form
    {
        QuerryMysql Relatorio = new QuerryMysql();
        public ExcluiRelatorio()
        {
            InitializeComponent();
            DataTable RelatoriosPadroes = Relatorio.BuscaRelatoriosSalvos();
            for (int i = 0; i < RelatoriosPadroes.Rows.Count; i++)
            {
                ListRelatoriosSalvos.Items.Add(RelatoriosPadroes.Rows[i][0].ToString());
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Você tem certeza que deseja excluir este relatório ?",
                    "Certeza?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Resposta == DialogResult.OK)
            {
                for (int i = 0; i < ListRelatoriosSalvos.SelectedItems.Count; i++)
                {
                    Relatorio.ExcluirRelatorio(ListRelatoriosSalvos.SelectedItems[i].ToString());
                }
                MessageBox.Show("Relatório excluido com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ListRelatoriosSalvos.Items.Clear();
                DataTable RelatoriosPadroes = Relatorio.BuscaRelatoriosSalvos();
                for (int i = 0; i < RelatoriosPadroes.Rows.Count; i++)
                {
                    ListRelatoriosSalvos.Items.Add(RelatoriosPadroes.Rows[i][0].ToString());
                }

            }
            else
            {
                
            }
        }
    }
}
