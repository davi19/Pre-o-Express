using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MacGiant
{
    public partial class Produto : Form
    {
        private QuerryMysql CadastroProduto = new QuerryMysql();
        ConversorDataTable Conversor= new ConversorDataTable();
        private decimal ValorTotal = 0;
        private string IdProduto = "";
        private ListView AuxMateriaPrima = new ListView();
        private ListView AuxServico = new ListView();
        private ListView AuxAviamento = new ListView();
        private ListView AuxCustos = new ListView();
        private int click = 0;

        public Produto()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarMateria_Click(object sender, EventArgs e)
        {
           DataTable Padrao = Conversor.DataGridView2DataTable(ListMateriaPrima);
            Buscar BuscaMat = new Buscar(1, Padrao);
            BuscaMat.ShowDialog();
            ListMateriaPrima.DataSource = null;
            DataTable Resultado = CadastroProduto.GetMateriaPrima();
            if (Resultado.Rows.Count == 0)
            {
                ListMateriaPrima.Rows.Clear();
            }
            else
            {
                ListMateriaPrima.Rows.Clear();
                for (int i = 0; i < Resultado.Rows.Count; i++)
                {
                    ListMateriaPrima.Rows.Add(Resultado.Rows[i]["ID"].ToString(),
                        Resultado.Rows[i]["DESCRIÇÃO"].ToString(),
                        Resultado.Rows[i]["VALOR"].ToString(), Resultado.Rows[i]["QUANTIDADE"].ToString());
                }
            }
            NumericPrecoCusto_ValueChanged(sender, e);

        }

        private void BtnBuscarServicos_Click(object sender, EventArgs e)
        {
            DataTable Padrao = Conversor.DataGridView2DataTable(ListServicos);
            Buscar BuscaServico = new Buscar(2, Padrao);
            BuscaServico.ShowDialog();
            ListServicos.DataSource = null;
            DataTable Resultado = CadastroProduto.GetServico();
            if (Resultado.Rows.Count == 0)
            {
                ListServicos.Rows.Clear();
            }
            else
            {
                ListServicos.Rows.Clear();
                for (int i = 0; i < Resultado.Rows.Count; i++)
            {
                ListServicos.Rows.Add(Resultado.Rows[i]["ID"].ToString(), Resultado.Rows[i]["DESCRIÇÃO"].ToString(),
                    Resultado.Rows[i]["VALOR"].ToString(), Resultado.Rows[i]["QUANTIDADE"].ToString());
            }

            }
            NumericPrecoCusto_ValueChanged(sender, e);
        }

        private void BtnBuscarAviamentos_Click(object sender, EventArgs e)
        {
            DataTable Padrao = Conversor.DataGridView2DataTable(ListAviamentos);
            Buscar BuscaAviamento = new Buscar(3,Padrao);
            BuscaAviamento.ShowDialog();
            ListAviamentos.DataSource = null;
            DataTable Resultado = CadastroProduto.GetAviamento();
            if (Resultado.Rows.Count == 0)
            {
                ListAviamentos.Rows.Clear();
       
            }
            else
            {
                ListAviamentos.Rows.Clear();
                for (int i = 0; i < Resultado.Rows.Count; i++)
                {
                    ListAviamentos.Rows.Add(Resultado.Rows[i]["ID"].ToString(),
                        Resultado.Rows[i]["DESCRIÇÃO"].ToString(),
                        Resultado.Rows[i]["VALOR"].ToString(), Resultado.Rows[i]["QUANTIDADE"].ToString());
                }
            }
            NumericPrecoCusto_ValueChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable Padrao = Conversor.DataGridView2DataTable(ListCustos);
            Buscar BuscaCustos = new Buscar(4, Padrao);
            BuscaCustos.ShowDialog();
            DataTable Resultado = CadastroProduto.GetCustos();
            if (Resultado.Rows.Count == 0)
            {
                ListCustos.Rows.Clear();
            }
            else
            {
                ListCustos.Rows.Clear();
                for (int i = 0; i < Resultado.Rows.Count; i++)
                {
                    ListCustos.Rows.Add(Resultado.Rows[i]["ID"].ToString(), Resultado.Rows[i]["DESCRIÇÃO"].ToString(),
                        Resultado.Rows[i]["VALOR"].ToString(), Resultado.Rows[i]["QUANTIDADE"].ToString());
                }
            }
            NumericPrecoCusto_ValueChanged(sender, e);
        }

        private void NumericMarkup_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal MarkupTotal = NumericTotal.Value/NumericMarkup.Value;
                NumericVendedor.Value = MarkupTotal;
                NumericAprazo.Value = MarkupTotal - (MarkupTotal*NumericDescontoAprazo.Value);
                NumericAvista.Value = MarkupTotal - (MarkupTotal*NumericDescontoAvista.Value);
                NumericAtacado.Value = MarkupTotal - (MarkupTotal*NumericDescontoAtacado.Value);
            }
            catch
            {

            }
        }

        private void NumericLucro_ValueChanged(object sender, EventArgs e)
        {
            NumericTotal.Value = NumericLucro.Value + NumericPrecoCusto.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListAviamentos.DataSource = null;
            ListMateriaPrima.DataSource = null;
            ListServicos.DataSource = null;
            ListCustos.DataSource = null;
            NumericPrecoCusto.Value = 0;
            NumericAprazo.Value = 0;
            NumericTotal.Value = 0;
            NumericLucro.Value = 0;
            NumericMarkup.Value = 0;
            IdProduto = "";
            TextDescricao.Text = "";
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextDescricao.Text.Length == 0 || NumericLucro.Value == 0 || NumericMarkup.Value == 0||TextCodigo.Text.Length ==0 || TextDescricaoCompleta.Text.Length==0)
            {
                MessageBox.Show("Favor preencher todo os campos marcados com '*' !", "Erro !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (ListAviamentos.Rows.Count == 0 && ListCustos.Rows.Count == 0 && ListMateriaPrima.Rows.Count == 0 &&
                ListServicos.Rows.Count == 0)
            {
                MessageBox.Show("Favor colocar a composição do produto !", "Erro !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DataTable MatPrima = Conversor.DataGridView2DataTable(ListMateriaPrima);
                DataTable Servicos = Conversor.DataGridView2DataTable(ListServicos);
                DataTable Aviamento = Conversor.DataGridView2DataTable(ListAviamentos);
                DataTable Custo = Conversor.DataGridView2DataTable(ListCustos);
                string Disponivel = "";
                if (RadioDisponivel.Checked)
                {
                    Disponivel = "S";
                }
                else
                {
                    Disponivel = "N";
                }
                CadastroProduto.CadastrarProduto(TextDescricaoCompleta.Text,Disponivel,TextDescricao.Text, NumericMarkup.Value,NumericDescontoAprazo.Value,
                    NumericDescontoAvista.Value, NumericDescontoAtacado.Value, NumericLucro.Value, MatPrima,
                    Servicos, Aviamento, Custo,TextCodigo.Text);
                MessageBox.Show("Produto cadastrado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ListAviamentos.Rows.Clear();
                ListMateriaPrima.Rows.Clear();
                ListServicos.Rows.Clear();
                ListCustos.Rows.Clear();
                NumericPrecoCusto.Value = 0;
                NumericAprazo.Value = 0;
                NumericTotal.Value = 0;
                NumericLucro.Value = 0;
                NumericMarkup.Value = 0;
                TextDescricao.Text = "";
                TextCodigo.Text = "";
                TextDescricaoCompleta.Text = "";
                RadioDisponivel.Checked = true;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable Resultado = new DataTable();
            Resultado = CadastroProduto.BuscarProduto(TextBusca.Text);
            if (Resultado.Rows.Count == 0)
            {
                MessageBox.Show("Sua busca não retornou nenhum resultado !", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView1.DataSource = Resultado;
            }


        }

        private void TextBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListAviamentos.DataSource = null;
            ListCustos.DataSource = null;
            ListMateriaPrima.DataSource = null;
            ListServicos.DataSource = null;
            TextCodigo.Text = "";
            click = 1;
            DataTable Resultado= new DataTable();
           Resultado = CadastroProduto.RetornaComposicao(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            for (int i = 0; i < Resultado.Rows.Count; i++)
            {
                if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("1"))
                {
                    AuxAviamento.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                    ListAviamentos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString() ,  Resultado.Rows[i]["tipo"].ToString() , Resultado.Rows[i]["valor"].ToString() , Resultado.Rows[i]["quantidade"].ToString());
                }
                else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("3"))
                {
                    AuxMateriaPrima.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                    ListMateriaPrima.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(),Resultado.Rows[i]["tipo"].ToString() , Resultado.Rows[i]["valor"].ToString() , Resultado.Rows[i]["quantidade"].ToString());
                }
                else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("4"))
                {
                    AuxServico.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                    ListServicos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString() , Resultado.Rows[i]["tipo"].ToString() , Resultado.Rows[i]["valor"].ToString() , Resultado.Rows[i]["quantidade"].ToString());
                }
                else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("5"))
                {
                    AuxCustos.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                    ListCustos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString() , Resultado.Rows[i]["tipo"].ToString() , Resultado.Rows[i]["valor"].ToString() , Resultado.Rows[i]["quantidade"].ToString());
                }
                
            }
                DataTable Resultado2 = new DataTable();
            Resultado2 = CadastroProduto.RetornaProduto(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            NumericTotal.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            NumericDescontoAprazo.Value = Convert.ToDecimal(Resultado2.Rows[0]["descontoprazo"].ToString());
            NumericDescontoAvista.Value = Convert.ToDecimal(Resultado2.Rows[0]["descontoavista"].ToString());
            NumericDescontoAtacado.Value = Convert.ToDecimal(Resultado2.Rows[0]["descontoatacado"].ToString());
            NumericMarkup.Value = Convert.ToDecimal(Resultado2.Rows[0]["markup"].ToString());
            NumericLucro.Value = Convert.ToDecimal(Resultado2.Rows[0]["lucro"].ToString());
            IdProduto = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            DataTable Resultado3 = new DataTable();
            Resultado3 = CadastroProduto.RetornaPrecoCusto(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            NumericPrecoCusto.Value = Convert.ToDecimal(Resultado3.Rows[0]["precocusto"].ToString());
            TextDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TextCodigo.Text = IdProduto;
            dataGridView1.DataSource = null;
            NumericTotal.Value = NumericPrecoCusto.Value + NumericLucro.Value;
            TextDescricaoCompleta.Text = Resultado2.Rows[0]["descricaocompleta"].ToString();
            if (Resultado2.Rows[0]["disponivel"].ToString().Equals("S"))
            {
                RadioDisponivel.Checked = true;
            }
            else
            {
                RadioIndisponivel.Checked = true;
            }
            tabControl1.SelectedTab = TabCadastrar;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TextDescricao.Text.Length == 0 || NumericLucro.Value == 0 || NumericMarkup.Value == 0||TextCodigo.Text.Length == 0 || TextDescricaoCompleta.Text.Length==0)
            {
                MessageBox.Show("Favor preencher todo os campos marcados com '*' !", "Erro !", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           else if (IdProduto.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                for (int i = 0; i < ListMateriaPrima.Rows.Count; i++)

                {


                    for (int j = 0; j < AuxMateriaPrima.Items.Count; j++)
                    {
                        try
                        {
                            
                            if (ListMateriaPrima.Rows[i].Cells["ID"].Value.ToString().Contains(AuxMateriaPrima.Items[j].Text))
                            {
                                AuxMateriaPrima.Items[j].Remove();
                            }
                            else
                            {

                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString());
                        }
                    }


                }
                //servico
                for (int i = 0; i < ListServicos.Rows.Count; i++)

                {


                    for (int j = 0; j < AuxServico.Items.Count; j++)
                    { 
                        
                        try
                        {
                            if (ListServicos.Rows[i].Cells["IDSERVICO"].Value.ToString().Contains(AuxServico.Items[j].Text))
                            {
                                AuxServico.Items[j].Remove();
                            }
                            else
                            {

                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString());
                        }
                    }


                }
                // aviamenos
                for (int i = 0; i < ListAviamentos.Rows.Count; i++)

                {


                    for (int j = 0; j < AuxAviamento.Items.Count; j++)
                    {
                        
                        try
                        {
                            if (ListAviamentos.Rows[i].Cells["IDAVIAMENTO"].Value.ToString().Contains(AuxAviamento.Items[j].Text))
                            {
                                AuxAviamento.Items[j].Remove();
                            }
                            else
                            {

                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString());
                        }
                    }


                }
                //Custos
                for (int i = 0; i < ListCustos.Rows.Count; i++)

                {


                    for (int j = 0; j < AuxCustos.Items.Count; j++)
                    {
                       
                        try
                        {
                            if (ListCustos.Rows[i].Cells["IDCUSTO"].Value.ToString().Contains(AuxCustos.Items[j].Text))
                            {
                                AuxCustos.Items[j].Remove();
                            }
                            else
                            {

                            }
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show(f.ToString());
                        }
                    }


                }
                DataTable MatPrima = Conversor.DataGridView2DataTable(ListMateriaPrima);
                DataTable Servicos = Conversor.DataGridView2DataTable(ListServicos);
                DataTable Aviamento = Conversor.DataGridView2DataTable(ListAviamentos);
                DataTable Custo = Conversor.DataGridView2DataTable(ListCustos);
                string Disponivel = "";
                if (RadioDisponivel.Checked)
                {
                    Disponivel = "S";
                }
                else
                {
                    Disponivel = "N";
                }
                CadastroProduto.AtualizarProduto(TextDescricaoCompleta.Text,Disponivel,TextDescricao.Text, NumericMarkup.Value, NumericDescontoAprazo.Value,
                    NumericDescontoAvista.Value, NumericDescontoAtacado.Value, NumericLucro.Value, MatPrima,
                    Servicos, Aviamento, Custo, IdProduto, AuxAviamento, AuxCustos, AuxMateriaPrima,
                    AuxServico,TextCodigo.Text);
                MessageBox.Show("Dados atualizados com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ListAviamentos.Rows.Clear();
                ListMateriaPrima.Rows.Clear();
                ListServicos.Rows.Clear();
                ListCustos.Rows.Clear();
                NumericPrecoCusto.Value = 0;
                NumericAprazo.Value = 0;
                NumericTotal.Value = 0;
                NumericLucro.Value = 0;
                NumericMarkup.Value = 0;
                TextDescricao.Text = "";
                IdProduto = "";
                TextCodigo.Text = "";
                TextDescricaoCompleta.Text = "";
                RadioDisponivel.Checked = true;
            }
        }

        private void NumericPrecoCusto_ValueChanged(object sender, EventArgs e)
        {

            ValorTotal = 0;
            for (int i = 0; i < ListMateriaPrima.Rows.Count; i++)
            {
                ValorTotal = ValorTotal +
                             (Convert.ToDecimal(
                                 Convert.ToDecimal(ListMateriaPrima.Rows[i].Cells["VALOR"].Value.ToString())*
                                 Convert.ToDecimal(ListMateriaPrima.Rows[i].Cells["QUANTIDADE"].Value.ToString())));

            }
            for (int i = 0; i < ListServicos.Rows.Count; i++)
            {

                
                ValorTotal = ValorTotal + (Convert.ToDecimal(
                                 Convert.ToDecimal(ListServicos.Rows[i].Cells["VALORSERVICO"].Value.ToString()) *
                                 Convert.ToDecimal(ListServicos.Rows[i].Cells["QUANTIDADESERVICO"].Value.ToString())));

            }
            for (int i = 0; i < ListAviamentos.Rows.Count; i++)
            {

               
                ValorTotal = ValorTotal + (Convert.ToDecimal(
                                 Convert.ToDecimal(ListAviamentos.Rows[i].Cells["VALORAVIAMENTO"].Value.ToString()) *
                                 Convert.ToDecimal(ListAviamentos.Rows[i].Cells["QUANTIDADEAVIAMENTO"].Value.ToString())));

            }
            for (int i = 0; i < ListCustos.Rows.Count; i++)
            {

                
                ValorTotal = ValorTotal + (Convert.ToDecimal(
                                 Convert.ToDecimal(ListCustos.Rows[i].Cells["VALORCUSTO"].Value.ToString()) *
                                 Convert.ToDecimal(ListCustos.Rows[i].Cells["QUANTIDADECUSTO"].Value.ToString())));

            }
            NumericPrecoCusto.Value = ValorTotal;
            NumericTotal.Value = NumericLucro.Value + NumericPrecoCusto.Value;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (IdProduto.Length == 0)
            {
                MessageBox.Show(
                    "Favor realizar uma pesquisa!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult Resposta = MessageBox.Show("Você tem certeza que deseja excluir este produto ?",
                    "Certeza?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Resposta == DialogResult.OK)
                {
                    CadastroProduto.ExcluirProduto(IdProduto);
                    MessageBox.Show("Produto excluida com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ListAviamentos.Rows.Clear();
                    ListMateriaPrima.Rows.Clear();
                    ListServicos.Rows.Clear();
                    ListCustos.Rows.Clear();
                    NumericPrecoCusto.Value = 0;
                    NumericAprazo.Value = 0;
                    NumericTotal.Value = 0;
                    NumericLucro.Value = 0;
                    TextDescricao.Text = "";
                    IdProduto = "";
                    TextCodigo.Text = "";
                }
                else
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdProduto = "";
            MessageBox.Show("Produto copiado e pronto para o cadastro !", "Sucesso !", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void NumericDescontoAprazo_ValueChanged(object sender, EventArgs e)
        {
            decimal Desonto = NumericVendedor.Value*NumericDescontoAprazo.Value;
            NumericAprazo.Value = NumericVendedor.Value - Desonto;
        }

        private void NumericDescontoAvista_ValueChanged(object sender, EventArgs e)
        {
            decimal Desonto = NumericVendedor.Value*NumericDescontoAvista.Value;
            NumericAvista.Value = NumericVendedor.Value - Desonto;
        }

        private void NumericDescontoAtacado_ValueChanged(object sender, EventArgs e)
        {
            decimal Desonto = NumericVendedor.Value*NumericDescontoAtacado.Value;
            NumericAtacado.Value = NumericVendedor.Value - Desonto;
        }

        private void TextCodigo_TextChanged(object sender, EventArgs e)
        {
            if (click == 0)
            {
               try
               {
                        DataTable Resultado2 = new DataTable();
                    Resultado2 = CadastroProduto.BuscarProdutoCodigo(TextCodigo.Text);
                    DataTable Resultado = new DataTable();
                    Resultado = CadastroProduto.RetornaComposicao(Resultado2.Rows[0]["ID"].ToString());
                    for (int i = 0; i < Resultado.Rows.Count; i++)
                    {
                        if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("1"))
                        {
                            AuxAviamento.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                            ListAviamentos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                        }
                        else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("3"))
                        {
                            AuxMateriaPrima.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                            ListMateriaPrima.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                        }
                        else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("4"))
                        {
                            AuxServico.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                            ListServicos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                        }
                        else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("5"))
                        {
                            AuxCustos.Items.Add(Resultado.Rows[i]["idcomposicao"].ToString());
                            ListCustos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                        }

                    }
                    DataTable Resultado5 = new DataTable();
                    Resultado5 = CadastroProduto.RetornaProduto(Resultado2.Rows[0]["ID"].ToString());
                IdProduto = Resultado2.Rows[0]["ID"].ToString();
                    NumericTotal.Value = Convert.ToDecimal(Resultado2.Rows[0]["TOTAL"].ToString());
                    NumericDescontoAprazo.Value = Convert.ToDecimal(Resultado5.Rows[0]["descontoprazo"].ToString());
                    NumericMarkup.Value = Convert.ToDecimal(Resultado5.Rows[0]["markup"].ToString());
                    NumericDescontoAvista.Value = Convert.ToDecimal(Resultado5.Rows[0]["descontoavista"].ToString());
                    NumericDescontoAtacado.Value = Convert.ToDecimal(Resultado5.Rows[0]["descontoatacado"].ToString());
                    NumericLucro.Value = Convert.ToDecimal(Resultado2.Rows[0]["lucro"].ToString());
                    DataTable Resultado3 = new DataTable();
                    Resultado3 = CadastroProduto.RetornaPrecoCusto(Resultado2.Rows[0]["ID"].ToString());
                    NumericPrecoCusto.Value = Convert.ToDecimal(Resultado3.Rows[0]["precocusto"].ToString());
                    TextDescricao.Text = Resultado2.Rows[0]["DESCRIÇÃO"].ToString();
                    NumericTotal.Value = NumericPrecoCusto.Value + NumericLucro.Value;
                   TextDescricaoCompleta.Text = Resultado5.Rows[0]["descricaocompleta"].ToString();
                   if (Resultado5.Rows[0]["disponivel"].ToString().Equals("S"))
                   {
                       RadioDisponivel.Checked = true;
                   }
                   else
                   {
                       RadioIndisponivel.Checked = true;
                   }
               }
                catch
                {
                    ListAviamentos.Rows.Clear();
                    ListMateriaPrima.Rows.Clear();
                    ListServicos.Rows.Clear();
                    ListCustos.Rows.Clear();
                    NumericPrecoCusto.Value = 0;
                    NumericAprazo.Value = 0;
                    NumericTotal.Value = 0;
                    NumericLucro.Value = 0;
                    NumericMarkup.Value = 0;
                    NumericVendedor.Value = 0;
                    NumericAvista.Value = 0;
                    NumericAtacado.Value = 0;
                    TextDescricao.Text = "";
                }
            }
        else
            {
                click = 0;
            }
                
            }

        private void BtnComposicao_Click(object sender, EventArgs e)
        {
            if (TextCodigo.Text.Length == 0)
            {
                MessageBox.Show("Favor realizar alguma consulta!", "Atenção !", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else
            {
                Composicao composicao = new Composicao(TextCodigo.Text);
                composicao.ShowDialog();
            }
            
        }
    }


    }
        
    
