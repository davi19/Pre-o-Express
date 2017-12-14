using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace MacGiant
{
    public partial class Relatorios : Form
    {
        QuerryMysql Relatorio = new QuerryMysql();
        Pdf Gerador = new Pdf();
        int custos = 0;
        int salvar = 0;
        string NomeRelatorio;
        string ComandoCompleto ="";
        public Relatorios()
        {
            InitializeComponent();
            DataTable RelatoriosPadroes = Relatorio.BuscaRelatoriosSalvos();
            for (int i = 0; i < RelatoriosPadroes.Rows.Count; i++)
            {
                (menuStrip1.Items[2] as ToolStripMenuItem).DropDownItems.Add(RelatoriosPadroes.Rows[i][0].ToString());
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custos = 0;
            ListDisponivel.Clear();
            ListGerar.Clear();
            ListDisponivel.Items.Add("Preço de custo");
            ListDisponivel.Items.Add("Nome");
            ListDisponivel.Items.Add("Codigo");
            ListDisponivel.Items.Add("Markup");
            ListDisponivel.Items.Add("Preço de Venda - Vendedor");
            ListDisponivel.Items.Add("Preço de Venda - A prazo");
            ListDisponivel.Items.Add("Preço de Venda - A vista");
            ListDisponivel.Items.Add("Preço de Venda - Atacado");

        }

        private void custosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custos = 1;
            ListDisponivel.Clear();
            ListGerar.Clear();
            ListDisponivel.Items.Add("Listar materia prima cadastrada");
            ListDisponivel.Items.Add("Listar serviço cadastrado");
            ListDisponivel.Items.Add("Listar aviamento cadastrado");
            ListDisponivel.Items.Add("Listar custo cadastrado");

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ArrayList ComandoCompleto = new ArrayList();

            for (int i = 0; i < ListGerar.Items.Count; i++)
            {
                if (ListGerar.Items[i].Text.Equals("Preço de custo"))
                {
                    ComandoCompleto.Add("1");
                }
                else if (ListGerar.Items[i].Text.Equals("Nome"))
                {
                    ComandoCompleto.Add("SELECT nome as DESCRIÇÃO FROM produto WHERE excluido = 'N'");
                }
                else if (ListGerar.Items[i].Text.Equals("Codigo"))
                {
                    ComandoCompleto.Add("SELECT id as ID FROM produto WHERE excluido = 'N'");
                }
                else if (ListGerar.Items[i].Text.Equals("Markup"))
                {
                    ComandoCompleto.Add(" SELECT markup as MARKUP FROM produto WHERE excluido = 'N'");
                }
                else if (ListGerar.Items[i].Text.Equals("Preço de Venda - Vendedor"))
                {
                    ComandoCompleto.Add("2");
                }
                else if (ListGerar.Items[i].Text.Equals("Preço de Venda - A prazo"))
                {
                    ComandoCompleto.Add("3");
                }
                else if (ListGerar.Items[i].Text.Equals("Preço de Venda - A vista"))
                {
                    ComandoCompleto.Add("4");
                }
                 else
                if (ListGerar.Items[i].Text.Equals("Preço de Venda - Atacado"))
                {
                    ComandoCompleto.Add("5");
                }
                 else
                if (ListGerar.Items[i].Text.Equals("Listar materia prima cadastrada"))
                {
                    ComandoCompleto.Add("SELECT id as ID, descricao as DESCRICAO , valor as VALOR FROM materiaprima WHERE excluido = 'N'");
                }
                 else
                if (ListGerar.Items[i].Text.Equals("Listar serviço cadastrado"))
                {
                    ComandoCompleto.Add("SELECT id as ID,descricao as DESCRICAO , valor as VALOR FROM servico WHERE excluido = 'N'");
                }
                 else
                if (ListGerar.Items[i].Text.Equals("Listar aviamento cadastrado"))
                {
                    ComandoCompleto.Add("SELECT id as ID,descricao as DESCRICAO , valor as VALOR FROM aviamento WHERE excluido = 'N'");
                }
                 else
                if (ListGerar.Items[i].Text.Equals("Listar custo cadastrado"))
                {
                    ComandoCompleto.Add("SELECT id as ID,descricao as DESCRICAO , valor as VALOR FROM custooperacional WHERE excluido = 'N'");
                }
                 
               
            }
            if (salvar == 1)
            {
                Relatorio.SalvarRelatorio(ComandoCompleto,NomeRelatorio);
                salvar = 0;
            }
            if (ListGerar.Items.Count > 5)
            {
                DialogResult Resposta = MessageBox.Show(
                    "Muitos campos foram selecionados, portanto será gerado o relatório apenas em EXCEL para melhor visualização. Deseja continuar ?",
                    "Pergunta ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resposta.Equals(DialogResult.Yes))
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0416);
                    DataTable Resultado = Relatorio.RelatorioPersonalizado(ComandoCompleto);
                    Application ExcelApp;
                    Workbook ExcelWork;
                    Worksheet ExcelSheet;
                    object misValue = Missing.Value;

                    ExcelApp = new Application();
                    ExcelWork = ExcelApp.Workbooks.Add(misValue);

                    ExcelSheet = (Worksheet)ExcelWork.Worksheets.get_Item(1);
                    for (int j = 1; j <= Resultado.Columns.Count; j++)
                    {
                        ExcelSheet.Cells[1, j] = ListGerar.Items[j - 1].Text;

                    }

                    int linha = 2;
                    for (int i = 1; i <= Resultado.Rows.Count; i++)
                    {
                        for (int j = 1; j <= Resultado.Columns.Count; j++)
                        {
                            ExcelSheet.Cells[linha, j] = Resultado.Rows[i-1][j-1].ToString();

                        }
                        linha++;
                    }

                    string folderPath = "C:\\Relatórios\\";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    ExcelWork.SaveAs(@"C:\Relatórios\Relatório Mac Giant.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                                 XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    ExcelWork.Close(true, misValue, misValue);
                    ExcelApp.Quit();

                    liberarObjetos(ExcelSheet);
                    liberarObjetos(ExcelWork);
                    liberarObjetos(ExcelApp);
                    MessageBox.Show("Relatorio gerado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Process.Start("Explorer", "C:\\Relatórios");

                }
                else
                {
                    MessageBox.Show("Relatório cancelado, favor selecionar novos itens !", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (RadioPdf.Checked)
            {
                DataTable Resultado = Relatorio.RelatorioPersonalizado(ComandoCompleto);
                dataGridView1.DataSource = Resultado;
                Gerador.GerarPdf(dataGridView1, 2);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0416);
                DataTable Resultado = Relatorio.RelatorioPersonalizado(ComandoCompleto);
                Application ExcelApp;
                Workbook ExcelWork;
                Worksheet ExcelSheet;
                object misValue = Missing.Value;

                ExcelApp = new Application();
                ExcelWork = ExcelApp.Workbooks.Add(misValue);

                ExcelSheet = (Worksheet)ExcelWork.Worksheets.get_Item(1);

                
                   for (int j = 1; j <= Resultado.Columns.Count; j++)
                    {
                    ExcelSheet.Cells.Font.Bold = true;
                    ExcelSheet.Cells[1, j] = ListGerar.Items[j - 1].Text;

                    }

                int linha = 2;

                for (int i = 1; i <= Resultado.Rows.Count; i++)
                {
                    for (int j = 1; j <= Resultado.Columns.Count;j++)
                    {
                        ExcelSheet.Cells.Font.Bold = false;
                        ExcelSheet.Cells[linha, j] = Resultado.Rows[i-1][j-1].ToString();

                    }
                    linha++;
                }

                string folderPath = "C:\\Relatórios\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                ExcelWork.SaveAs(@"C:\Relatórios\Relatório Mac Giant.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                             XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                ExcelWork.Close(true, misValue, misValue);
                ExcelApp.Quit();

                liberarObjetos(ExcelSheet);
                liberarObjetos(ExcelWork);
                liberarObjetos(ExcelApp);
                MessageBox.Show("Relatorio gerado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Process.Start("Explorer", "C:\\Relatórios");
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (custos == 1 && ListGerar.Items.Count == 1)
            {
                MessageBox.Show("Este tipo de relatório só pode conter um tipo de parametro !","Atenção !",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                ListGerar.Items.Add(ListDisponivel.FocusedItem.Text);
                ListDisponivel.Items.Remove(ListDisponivel.FocusedItem);
            }
        }

        private void BtnRetira_Click(object sender, EventArgs e)
        {
            ListDisponivel.Items.Add(ListGerar.FocusedItem.Text);
            ListGerar.Items.Remove(ListGerar.FocusedItem);
        }

        private void liberarObjetos(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Ocorreu um erro durante a liberação do objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListGerar.Items.Count == 0)
            {
                MessageBox.Show("Favor selecionar itens para o relatório !", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                salvar = 1;
                NomeRelatorio Nome = new NomeRelatorio();
                Nome.ShowDialog();
                NomeRelatorio = Relatorio.GetNomeRelatorio();
                if (NomeRelatorio.Length == 0)
                {
                    
                }
                else
                {
                    BtnBuscar_Click(sender, e);
                }
                
            }

        }

        private void padrãoToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           ArrayList ComandoCompleto = Relatorio.RetornoQuerryRelatorioSalvo(e.ClickedItem.Text);
            if (RadioPdf.Checked)
            {
                DataTable Resultado = Relatorio.RelatorioPersonalizado(ComandoCompleto);
                dataGridView1.DataSource = Resultado;
                Gerador.GerarPdf(dataGridView1, 2);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0416);
                DataTable Resultado = Relatorio.RelatorioPersonalizado(ComandoCompleto);
                Application ExcelApp;
                Workbook ExcelWork;
                Worksheet ExcelSheet;
                object misValue = Missing.Value;

                ExcelApp = new Application();
                ExcelWork = ExcelApp.Workbooks.Add(misValue);

                ExcelSheet = (Worksheet)ExcelWork.Worksheets.get_Item(1);


                for (int j = 1; j <= Resultado.Columns.Count; j++)
                {
                    ExcelSheet.Cells.Font.Bold = true;
                    ExcelSheet.Cells[1, j] = ListGerar.Items[j - 1].Text;

                }

                int linha = 2;

                for (int i = 1; i <= Resultado.Rows.Count; i++)
                {
                    for (int j = 1; j <= Resultado.Columns.Count; j++)
                    {
                        ExcelSheet.Cells.Font.Bold = false;
                        ExcelSheet.Cells[linha, j] = Resultado.Rows[i - 1][j - 1].ToString();

                    }
                    linha++;
                }

                string folderPath = "C:\\Relatórios\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                ExcelWork.SaveAs(@"C:\Relatórios\Relatório Mac Giant.xls", XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                             XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                ExcelWork.Close(true, misValue, misValue);
                ExcelApp.Quit();

                liberarObjetos(ExcelSheet);
                liberarObjetos(ExcelWork);
                liberarObjetos(ExcelApp);
                MessageBox.Show("Relatorio gerado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Process.Start("Explorer", "C:\\Relatórios");
            }

        }

        private void excluirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluiRelatorio Excluir = new ExcluiRelatorio();
            Excluir.ShowDialog();
        }
    }
}
