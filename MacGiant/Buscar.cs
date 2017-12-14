using System;
using System.Data;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Buscar : Form
    {
        QuerryMysql BuscaComposicao = new QuerryMysql();
        ConversorDataTable Converte = new ConversorDataTable();
        private int TipoRecebido = 0;
        DataTable Resultado = new DataTable();
        DataTable Tudo = new DataTable();

        public Buscar(int Tipo, DataTable Conteudo)
        {
            Tudo = Conteudo;
            InitializeComponent();
            ListComposicao.Columns[0].Name = "ID";
            ListComposicao.Columns[1].Name = "DESCRIÇÃO";
            ListComposicao.Columns[2].Name = "VALOR";
            TipoRecebido = Tipo;
            if (Tipo == 1)
            {
                string Valor = "";
                label1.Text = "Materia Prima";
                 Resultado = BuscaComposicao.BuscarMateriaPrimaCompleta();
                bool add = false;
                ListTipo.DataSource = Resultado;
                for (int i = 0; i < ListTipo.Rows.Count; i++)
                {
                    for (int j = 0; j < Tudo.Rows.Count; j++)
                    {
                        if (ListTipo.Rows[i].Cells["ID"].Value.ToString().Equals(Tudo.Rows[j]["ID"].ToString()))
                        {
                            ListTipo.Rows.Remove(ListTipo.Rows[i]);
                            ListComposicao.Rows.Add(Tudo.Rows[j]["ID"], Tudo.Rows[j]["DESCRIÇÃO"], Tudo.Rows[j]["VALOR"], Tudo.Rows[j]["QUANTIDADE"]);
                        }
                    }
                }

            }
            else if (Tipo == 2)
            {
                string Valor = "";
                label1.Text = "Serviços";
                 Resultado = BuscaComposicao.BuscarServicoCompleta();
                ListTipo.DataSource = Resultado;
                for (int i = 0; i < ListTipo.Rows.Count; i++)
                {
                    for (int j = 0; j < Tudo.Rows.Count; j++)
                    {
                        if (ListTipo.Rows[i].Cells["ID"].Value.ToString().Equals(Tudo.Rows[j]["IDSERVICO"].ToString()))
                        {
                            ListTipo.Rows.Remove(ListTipo.Rows[i]);
                            ListComposicao.Rows.Add(Tudo.Rows[j]["IDSERVICO"], Tudo.Rows[j]["DESCRICAOSERVICO"], Tudo.Rows[j]["VALORSERVICO"], Tudo.Rows[j]["QUANTIDADESERVICO"]);
                        }
                    }
                }
            }
            else if (Tipo == 3)
            {
                string Valor = "";
                label1.Text = "Aviamentos";
                Resultado = BuscaComposicao.BuscarAviamentoCompleta();
                ListTipo.DataSource = Resultado;
                for (int i = 0; i < ListTipo.Rows.Count; i++)
                {
                    for (int j = 0; j < Tudo.Rows.Count; j++)
                    {
                        if (ListTipo.Rows[i].Cells["ID"].Value.ToString().Equals(Tudo.Rows[j]["IDAVIAMENTO"].ToString()))
                        {
                            ListTipo.Rows.Remove(ListTipo.Rows[i]);
                            ListComposicao.Rows.Add(Tudo.Rows[j]["IDAVIAMENTO"], Tudo.Rows[j]["DESCRICAOAVIAMENTO"], Tudo.Rows[j]["VALORAVIAMENTO"], Tudo.Rows[j]["QUANTIDADEAVIAMENTO"]);
                        }
                    }
                }

            }
            else if (Tipo == 4)
            {
                string Valor = "";
                label1.Text = "Custos";
                Resultado = BuscaComposicao.BuscarCustosCompleta();
                ListTipo.DataSource = Resultado;
                for (int i = 0; i < ListTipo.Rows.Count; i++)
                {
                    for (int j = 0; j < Tudo.Rows.Count; j++)
                    {
                        if (ListTipo.Rows[i].Cells["ID"].Value.ToString().Equals(Tudo.Rows[j]["IDCUSTO"].ToString()))
                        {
                            ListTipo.Rows.Remove(ListTipo.Rows[i]);
                            ListComposicao.Rows.Add(Tudo.Rows[j]["IDCUSTO"], Tudo.Rows[j]["DESCRICAOCUSTO"], Tudo.Rows[j]["VALORCUSTO"], Tudo.Rows[j]["QUANTIDADECUSTO"]);
                        }
                    }
                }
            }
            
            
            
            

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
           if (TipoRecebido == 1)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListMateriaPrima(Padrao);
                this.Close();
            }
            else if (TipoRecebido == 2)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListServico(Padrao);
                this.Close();
            }
            if (TipoRecebido == 3)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListAviamento(Padrao);
                this.Close();
            }

            if (TipoRecebido == 4)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListCustos(Padrao);
                this.Close();
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TipoRecebido == 1)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListMateriaPrima(Padrao);
                
                this.Close();
            }
            else if (TipoRecebido == 2)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListServico(Padrao);
                this.Close();
            }
            if (TipoRecebido == 3)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListAviamento(Padrao);
                this.Close();
            }

            if (TipoRecebido == 4)
            {
                DataTable Padrao = Converte.DataGridView2DataTable(ListComposicao);
                BuscaComposicao.SetListCustos(Padrao);
                this.Close();
            }
        }

        private void ListTipo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListTipo.Rows.Count == 0)
            {

            }
            else
            {
                Quantidade Quant = new Quantidade();
                Quant.ShowDialog();
                string Quantidade = BuscaComposicao.GetQuantidade();
                if (Quantidade.Length == 0)
                {

                }
                else
                {
                    try
                    {
                        //ListComposicao.Columns.Add("quantidade");
                    }
                    catch
                    {

                    }

                    ListComposicao.Rows.Add(ListTipo.Rows[e.RowIndex].Cells["ID"].Value,ListTipo.Rows[e.RowIndex].Cells["DESCRICAO"].Value, ListTipo.Rows[e.RowIndex].Cells["VALOR"].Value,Quantidade);
                    // Quantidade
                    ListTipo.Rows.Remove(ListTipo.Rows[e.RowIndex]);
                }
            }
        }

        private void ListComposicao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Resultado.Rows.Add(ListComposicao.Rows[e.RowIndex].Cells["ID"].Value, ListComposicao.Rows[e.RowIndex].Cells["DESCRIÇÃO"].Value, ListComposicao.Rows[e.RowIndex].Cells["VALOR"].Value);
            ListComposicao.Rows.Remove(ListComposicao.Rows[e.RowIndex]);
        }
    }
}
