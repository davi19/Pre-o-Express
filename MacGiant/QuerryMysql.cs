using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MacGiant
{
    class QuerryMysql
    {
        static string ChaveInicial = "wiJ736rOqnlKJNZFArgh6w==";
        static string ChaveFinal = Criptografias.Decrypt(ChaveInicial);
        //192.168.0.19
        static MySqlConnection Com = new MySqlConnection("Server =192.168.0.19; Database=macgiant;Uid=root;Pwd=chinchila@acida12244819;");
        static DataTable MateriaPrima = new DataTable();
        static DataTable Servico = new DataTable();
        static DataTable Aviamento = new DataTable();
        static DataTable Custos = new DataTable();
        static string Quantidade = "";
        static string NomeRelatorio = "";



        public bool Login(string Usuario, string Senha)
        {
            Com.Open();
            MySqlCommand SelectLogin = new MySqlCommand("SELECT * from usuario WHERE login = @usuario AND senha = MD5(@senha)",Com);
            SelectLogin.Parameters.Add("@usuario", Usuario);
            SelectLogin.Parameters.Add("@senha", Senha);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(SelectLogin);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            if (ResultadoCompleto.Rows.Count == 1)
            {
                Com.Close();
                return true;
            }
            Com.Close();
            return false;
        }

        public void CadastrarMatPrima(string Descricao, Decimal Valor,string Id)
        {
            try
            {
                Com.Open();
                MySqlCommand Insert =
                    new MySqlCommand("INSERT INTO materiaprima (id,descricao,valor) VALUES(@id,@descricao, @valor)", Com);
                Insert.Parameters.Add("@descricao", Descricao);
                Insert.Parameters.Add("@valor", Valor);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Matéria prima cadastrada com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Com.Close();
            }
            catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscarMatPrima(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM materiaprima WHERE descricao LIKE '%"+Busca+"%' AND excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarMatPrimaCodigo(string Busca)
        {
            DataTable ResultadoCompleto = new DataTable();
            try
            {
                Com.Open();
                MySqlCommand Select =
                    new MySqlCommand(
                        "SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM materiaprima WHERE id=@id AND excluido = 'N' ;",
                        Com);
                Select.Parameters.Add("@id", Busca);
                MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
                Resultado.Fill(ResultadoCompleto);
                Com.Close();
                return ResultadoCompleto;
            }
            catch
            {
                return ResultadoCompleto;
            }
        }

        public void AtualizarMatPrima(string Descricao, Decimal Valor,string Id,string NovaId)
        {
            try
            {
                Com.Open();
                MySqlCommand Insert =
                    new MySqlCommand(
                        "UPDATE materiaprima set id = @idnova ,descricao = @descricao, valor = @valor WHERE id =@id",
                        Com);
                Insert.Parameters.Add("@descricao", Descricao);
                Insert.Parameters.Add("@valor", Valor);
                Insert.Parameters.Add("@id", Id);
                Insert.Parameters.Add("@idnova", NovaId);
                Insert.ExecuteNonQuery();
                Com.Close();
            }
            catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ExcluirMatPrima(string Id)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" +Id + "' AND idtipocomposicao = 3;", Com);
            MySqlDataReader Resultado = Select.ExecuteReader();
            if (Resultado.HasRows)
            {
                Resultado.Close();
                Com.Close();
                return "Existem produtos cadastrados com esta Matéria prima, favor altera-los para que possa excluir está materia prima";
            }
            else
            {
                Resultado.Close();
                MySqlCommand Insert = new MySqlCommand("UPDATE materiaprima set excluido = 'S' WHERE id =@id", Com);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                Com.Close();
                return "Matéria prima excluida com sucesso !";
            }
        }

        public void CadastrarServicos(string Descricao, Decimal Valor,string id)
        {
            try
            {
                Com.Open();
                MySqlCommand Insert =
                    new MySqlCommand("INSERT INTO servico (id,descricao,valor) VALUES(@id,@descricao, @valor)", Com);
                Insert.Parameters.Add("@descricao", Descricao);
                Insert.Parameters.Add("@valor", Valor);
                Insert.Parameters.Add("@id", id);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Serviço cadastrado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Com.Close();
            }
            catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscarServico(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM servico WHERE descricao LIKE '%" + Busca + "%' AND excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarServicoCodigo(string Busca)
        {
            DataTable ResultadoCompleto = new DataTable();
            try
            {
                Com.Open();
                MySqlCommand Select =
                    new MySqlCommand(
                        "SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM servico WHERE id=@id AND excluido = 'N' ;",
                        Com);
                Select.Parameters.Add("@id", Busca);
                MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
                Resultado.Fill(ResultadoCompleto);
                Com.Close();
                return ResultadoCompleto;
            }
            catch
            {
                return ResultadoCompleto;
            }
        }

        public void AtualizarServico(string Descricao, Decimal Valor, string Id,string IdNova)
        {
            try
            {
                Com.Open();
                MySqlCommand Insert =
                    new MySqlCommand(
                        "UPDATE servico set id =@novaid,descricao = @descricao, valor = @valor WHERE id =@id", Com);
                Insert.Parameters.Add("@descricao", Descricao);
                Insert.Parameters.Add("@valor", Valor);
                Insert.Parameters.Add("@id", Id);
                Insert.Parameters.Add("@novaid", IdNova);
                Insert.ExecuteNonQuery();
                Com.Close();
            }
            catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ExcluirServico(string Id)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" + Id + "' AND idtipocomposicao = 4;", Com);
            MySqlDataReader Resultado = Select.ExecuteReader();
            if (Resultado.HasRows)
            {
                Resultado.Close();
                Com.Close();
                return
                    "Existem produtos cadastrados com este serviço, favor altera-los para que possa excluir este serviço";
            }
            else
            {
                Resultado.Close();
                MySqlCommand Insert = new MySqlCommand("UPDATE servico set excluido = 'S' WHERE id =@id", Com);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                Com.Close();
               return "Serviço excluido com sucesso !";
            }
        }

        public void CadastrarAviamento(string Id,string Descricao, Decimal Valor)
        {
            try
            {
                Com.Open();
                MySqlCommand Insert =
                    new MySqlCommand("INSERT INTO aviamento (id,descricao,valor) VALUES(@id,@descricao, @valor)", Com);
                Insert.Parameters.Add("@descricao", Descricao);
                Insert.Parameters.Add("@valor", Valor);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Aviamento cadastrado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Com.Close();
            }
           catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public DataTable BuscarAviamento(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM aviamento WHERE descricao LIKE '%" + Busca + "%' AND excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarAviamentoCodigo(string Busca)
        {
            DataTable ResultadoCompleto = new DataTable();
            try
            {
                Com.Open();
                MySqlCommand Select =
                    new MySqlCommand(
                        "SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM aviamento WHERE id=@id AND excluido = 'N' ;",
                        Com);
                Select.Parameters.Add("@id", Busca);
                MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
                Resultado.Fill(ResultadoCompleto);
                Com.Close();
                return ResultadoCompleto;
            }
            catch
            {
                return ResultadoCompleto;
            }
        }

        public void AtualizarAviamento(string Descricao, Decimal Valor, string Id, String NovaId)
        {
            try
            {
            Com.Open();
            MySqlCommand Insert =
                new MySqlCommand(
                    "UPDATE aviamento set id =@idnova, descricao = @descricao, valor = @valor WHERE id =@id", Com);
            Insert.Parameters.Add("@descricao", Descricao);
            Insert.Parameters.Add("@valor", Valor);
            Insert.Parameters.Add("@id", Id);
            Insert.Parameters.Add("@idnova", NovaId);
            Insert.ExecuteNonQuery();
            Com.Close();
        }
          catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        public string  ExcluirAviamento(string Id)
        {

            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" + Id + "' AND idtipocomposicao = 1;", Com);
            MySqlDataReader Resultado = Select.ExecuteReader();
            if (Resultado.HasRows)
            {
                Resultado.Close();
                Com.Close();
                return
                    "Existem produtos cadastrados com este aviamento, favor altera-los para que possa excluir este aviamento";
            }
            else
            {
                Resultado.Close();
                MySqlCommand Insert = new MySqlCommand("UPDATE aviamento set excluido = 'S' WHERE id =@id", Com);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                Com.Close();
                return "Aviamento excluido com sucesso !";
            }
        }

        public void CadastrarCustos(string Id,string Descricao, Decimal Valor)
        {
            try
            {
                Com.Open();
                MySqlCommand Insert =
                    new MySqlCommand(
                        "INSERT INTO custooperacional (id,descricao,valor) VALUES(@id,@descricao, @valor)", Com);
                Insert.Parameters.Add("@descricao", Descricao);
                Insert.Parameters.Add("@valor", Valor);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                MessageBox.Show("Custo cadastrado com sucesso !", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Com.Close();
            }
            catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscarCustos(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM custooperacional WHERE descricao LIKE '%" + Busca + "%' AND excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarCustoCodigo(string Busca)
        {
            DataTable ResultadoCompleto = new DataTable();
            try
            {
                Com.Open();
                MySqlCommand Select =
                    new MySqlCommand(
                        "SELECT id as ID, descricao as DESCRIÇÃO, valor as VALOR FROM custooperacional WHERE id=@id AND excluido = 'N' ;",
                        Com);
                Select.Parameters.Add("@id", Busca);
                MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
                Resultado.Fill(ResultadoCompleto);
                Com.Close();
                return ResultadoCompleto;
            }
            catch
            {
                return ResultadoCompleto;
            }
        }

        public void AtualizarCustos(string Descricao, Decimal Valor, string Id,string IdNova)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("UPDATE custooperacional set id = @idnova,descricao = @descricao, valor = @valor WHERE id =@id", Com);
            Insert.Parameters.Add("@descricao", Descricao);
            Insert.Parameters.Add("@valor", Valor);
            Insert.Parameters.Add("@id", Id);
            Insert.Parameters.Add("@idnova", IdNova);
            Insert.ExecuteNonQuery();
            Com.Close();
        }

        public string ExcluirCustos(string Id)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" + Id + "' AND idtipocomposicao = 5;", Com);
            MySqlDataReader Resultado = Select.ExecuteReader();
            if (Resultado.HasRows)
            {
                Resultado.Close();
                Com.Close();
                return
                    "Existem produtos cadastrados com este custo, favor altera-los para que possa excluir este custo";
            }
            else
            {
                Resultado.Close();
                MySqlCommand Insert = new MySqlCommand("UPDATE custooperacional set excluido = 'S' WHERE id =@id", Com);
                Insert.Parameters.Add("@id", Id);
                Insert.ExecuteNonQuery();
                Com.Close();
                return "Custo excluido com sucesso !";
            }
        }

        public void CadastrarProduto(string DescricaoCompleta,string Disponivel,string Nome, Decimal Markup,Decimal DescontoPrazo, Decimal DescontoAvista, Decimal DescontoAtacado, Decimal Lucro, DataTable ListMateriaPrima, DataTable ListServicos, DataTable ListAviamentos, DataTable ListCustos,string IdProduto)
        {
            Com.Open();
            try
            {
                MySqlCommand Insert = new MySqlCommand("INSERT INTO produto (id,nome,markup,descontoprazo,descontoavista,descontoatacado,lucro,descricaocompleta,disponivel) VALUES(@id,@nome,@markup,@descontoprazo,@descontoavista,@descontoatacado,@lucro,@descricaocompleta,@disponivel)", Com);
                Insert.Parameters.Add("@nome", Nome);
                Insert.Parameters.Add("@markup", Markup);
                Insert.Parameters.Add("@descontoprazo", DescontoPrazo);
                Insert.Parameters.Add("@descontoavista", DescontoAvista);
                Insert.Parameters.Add("@descontoatacado", DescontoAtacado);
                Insert.Parameters.Add("@lucro", Lucro);
                Insert.Parameters.Add("@id", IdProduto);
                Insert.Parameters.Add("@descricaocompleta", DescricaoCompleta);
                Insert.Parameters.Add("@disponivel", Disponivel);
                Insert.ExecuteNonQuery();

                for (int i = 0; i < ListAviamentos.Rows.Count; i++)
                {

                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,1,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListAviamentos.Rows[i]["IDAVIAMENTO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListAviamentos.Rows[i]["VALORAVIAMENTO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListAviamentos.Rows[i]["QUANTIDADEAVIAMENTO"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                }
                for (int i = 0; i < ListServicos.Rows.Count; i++)
                {
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,4,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListServicos.Rows[i]["IDSERVICO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListServicos.Rows[i]["VALORSERVICO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListServicos.Rows[i]["QUANTIDADESERVICO"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                }
                for (int i = 0; i < ListCustos.Rows.Count; i++)
                {
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,5,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListCustos.Rows[i]["IDCUSTO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListCustos.Rows[i]["VALORCUSTO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListCustos.Rows[i]["QUANTIDADECUSTO"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                }
                for (int i = 0; i < ListMateriaPrima.Rows.Count; i++)
                {
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUE(@idproduto,@idcomposicao,@valor,3,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListMateriaPrima.Rows[i]["ID"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListMateriaPrima.Rows[i]["VALOR"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListMateriaPrima.Rows[i]["QUANTIDADE"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                }
                Com.Close();
            }
            catch
            {
                Com.Close();
                MessageBox.Show("Codigo já cadastrado !", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscarProduto(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, nome as DESCRIÇÃO, lucro as LUCRO FROM produto WHERE excluido = 'N'AND( nome LIKE '%" + Busca + "%' OR id LIKE '%" + Busca + "%');", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            ResultadoCompleto.Columns.Add("TOTAL");
            for (int i = 0; i < ResultadoCompleto.Rows.Count; i++)
            {
                try
                {
                    MySqlCommand Select2 =
                        new MySqlCommand(
                            " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                            ResultadoCompleto.Rows[i]["ID"].ToString() + "' ;", Com);
                    MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                    DataTable ResultadoCompleto2 = new DataTable();
                    Resultado2.Fill(ResultadoCompleto2);
                    decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                    Convert.ToDecimal(ResultadoCompleto.Rows[i]["LUCRO"].ToString());
                    ResultadoCompleto.Rows[i]["TOTAL"] = preco;
                }
                catch { }

            }
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarProdutoCodigo(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, nome as DESCRIÇÃO, lucro as LUCRO FROM produto WHERE excluido = 'N'AND  id=@id;", Com);
            Select.Parameters.Add("@id", Busca);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            ResultadoCompleto.Columns.Add("TOTAL");
            for (int i = 0; i < ResultadoCompleto.Rows.Count; i++)
            {
                try
                {
                    MySqlCommand Select2 =
                        new MySqlCommand(
                            " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                            ResultadoCompleto.Rows[i]["ID"].ToString() + "' ;", Com);
                    MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                    DataTable ResultadoCompleto2 = new DataTable();
                    Resultado2.Fill(ResultadoCompleto2);
                    decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                    Convert.ToDecimal(ResultadoCompleto.Rows[i]["LUCRO"].ToString());
                    ResultadoCompleto.Rows[i]["TOTAL"] = preco;

                }
                catch
                {
                    Com.Close();
                }

            }
            Com.Close();
            return ResultadoCompleto;
        }

        public void AtualizarProduto(string DescricaoCompleta,string Disponivel,string Nome, Decimal Markup,Decimal DescontoPrazo, Decimal DescontoAvista, Decimal DescontoAtacado, Decimal Lucro,DataTable ListMateriaPrima, DataTable ListServicos, DataTable ListAviamentos, DataTable ListCustos, string IdProduto,ListView AuxAviamento,ListView AuxCustos, ListView AuxMateriaPrima,ListView AuxServico,string NovaId)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("UPDATE produto set id =@novaid, nome = @nome, markup =@markup,descontoprazo =@descontoprazo,descontoavista =@descontoavista,descontoatacado =@descontoatacado,lucro =@lucro, descricaocompleta=@descricaocompleta, disponivel=@disponivel WHERE id = @id", Com);
            Insert.Parameters.Add("@nome", Nome);
            Insert.Parameters.Add("@markup", Markup);
            Insert.Parameters.Add("@descontoprazo", DescontoPrazo);
            Insert.Parameters.Add("@descontoavista", DescontoAvista);
            Insert.Parameters.Add("@descontoatacado", DescontoAtacado);
            Insert.Parameters.Add("@lucro", Lucro);
            Insert.Parameters.Add("@id", IdProduto);
            Insert.Parameters.Add("@novaid", NovaId);
            Insert.Parameters.Add("@descricaocompleta", DescricaoCompleta);
            Insert.Parameters.Add("@disponivel", Disponivel);
            Insert.ExecuteNonQuery();
            Com.Close();
            for (int i = 0; i < ListAviamentos.Rows.Count; i++)
            {
                Com.Open();
                MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='"+ ListAviamentos.Rows[i]["IDAVIAMENTO"].ToString() + "' AND idtipocomposicao = 1 AND idproduto ='"+ IdProduto + "';",Com);
                MySqlDataReader Resultado = Select.ExecuteReader();
                if (Resultado.HasRows)
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao = new MySqlCommand("UPdate composicao set idproduto =@novaid,valor =@valor,quantidade=@quantidade WHERE idproduto =@idproduto AND idtipocomposicao = 1 AND idcomposicao =@idcomposicao", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListAviamentos.Rows[i]["IDAVIAMENTO"].ToString());
                    InsertComposicao.Parameters.Add("@valor",Convert.ToDecimal(ListAviamentos.Rows[i]["VALORAVIAMENTO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListAviamentos.Rows[i]["QUANTIDADEAVIAMENTO"].ToString()));
                    InsertComposicao.Parameters.Add("@novaid", NovaId);
                    InsertComposicao.ExecuteNonQuery();
                }
                else
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,1,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListAviamentos.Rows[i]["IDAVIAMENTO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListAviamentos.Rows[i]["VALORAVIAMENTO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListAviamentos.Rows[i]["QUANTIDADEAVIAMENTO"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                }
                Com.Close();
            }
            for (int i = 0; i < ListServicos.Rows.Count; i++)
            {
                Com.Open();
                MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" + ListServicos.Rows[i]["IDSERVICO"].ToString() + "' AND idtipocomposicao = 4 AND idproduto ='" + IdProduto+"'; ", Com);
                MySqlDataReader Resultado = Select.ExecuteReader();
                if (Resultado.HasRows)
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao = new MySqlCommand("UPdate composicao set idproduto=@novaid,valor =@valor,quantidade=@quantidade WHERE idproduto =@idproduto AND idtipocomposicao =4 AND idcomposicao =@idcomposicao",
                            Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListServicos.Rows[i]["IDSERVICO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListServicos.Rows[i]["VALORSERVICO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListServicos.Rows[i]["QUANTIDADESERVICO"].ToString()));
                    InsertComposicao.Parameters.Add("@novaid", NovaId);
                    InsertComposicao.ExecuteNonQuery();

                }
                else
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,4,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListServicos.Rows[i]["IDSERVICO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListServicos.Rows[i]["VALORSERVICO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListServicos.Rows[i]["QUANTIDADESERVICO"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                  
                    
                }
                Com.Close();
            }
            for (int i = 0; i < ListCustos.Rows.Count; i++)
            {
                Com.Open();
                MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" + ListCustos.Rows[i]["IDCUSTO"].ToString() + "' AND idtipocomposicao = 5 AND idproduto ='" + IdProduto+"'; ", Com);
                MySqlDataReader Resultado = Select.ExecuteReader();
                if (Resultado.HasRows)
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao =
                        new MySqlCommand(
                            "UPdate composicao set idproduto =@novaid,valor =@valor,quantidade=@quantidade WHERE idproduto =@idproduto AND idtipocomposicao = 5 AND idcomposicao =@idcomposicao ",
                            Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListCustos.Rows[i]["IDCUSTO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListCustos.Rows[i]["VALORCUSTO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListCustos.Rows[i]["QUANTIDADECUSTO"].ToString()));
                    InsertComposicao.Parameters.Add("@novaid", NovaId);
                    InsertComposicao.ExecuteNonQuery();

                 
                }
                else
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,5,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListCustos.Rows[i]["IDCUSTO"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListCustos.Rows[i]["VALORCUSTO"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListCustos.Rows[i]["QUANTIDADECUSTO"].ToString()));
                    
                    InsertComposicao.ExecuteNonQuery();

                }
                Com.Close();

            }
            for (int i = 0; i < ListMateriaPrima.Rows.Count; i++)
            {
                Com.Open();
                MySqlCommand Select = new MySqlCommand("SELECT * FROM composicao WHERE idcomposicao ='" + ListMateriaPrima.Rows[i]["ID"].ToString() + "' AND idtipocomposicao = 3 AND idproduto = '"+ IdProduto+"'; ", Com);
                MySqlDataReader Resultado = Select.ExecuteReader();
                if (Resultado.HasRows)
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao =
                        new MySqlCommand(
                            "UPdate composicao set idproduto=@novaid, valor =@valor,quantidade=@quantidade WHERE idproduto =@idproduto AND idtipocomposicao =3 AND idcomposicao =@idcomposicao",
                            Com);
                    InsertComposicao.Parameters.Add("@idproduto", IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListMateriaPrima.Rows[i]["ID"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListMateriaPrima.Rows[i]["VALOR"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListMateriaPrima.Rows[i]["QUANTIDADE"].ToString()));
                    InsertComposicao.Parameters.Add("@novaid", NovaId);
                    InsertComposicao.ExecuteNonQuery();
                }
                else
                {
                    Resultado.Close();
                    MySqlCommand InsertComposicao = new MySqlCommand("INSERT INTO composicao (idproduto,idcomposicao,valor,idtipocomposicao,quantidade) VALUES(@idproduto,@idcomposicao,@valor,3,@quantidade)", Com);
                    InsertComposicao.Parameters.Add("@idproduto",IdProduto);
                    InsertComposicao.Parameters.Add("@idcomposicao", ListMateriaPrima.Rows[i]["ID"].ToString());
                    InsertComposicao.Parameters.Add("@valor", Convert.ToDecimal(ListMateriaPrima.Rows[i]["VALOR"].ToString()));
                    InsertComposicao.Parameters.Add("@quantidade", Convert.ToDecimal(ListMateriaPrima.Rows[i]["QUANTIDADE"].ToString()));
                    InsertComposicao.ExecuteNonQuery();
                }
                Com.Close();
            }
            Com.Open();
            for (int i = 0; i < AuxAviamento.Items.Count;i++)
            {
                ArrayList Dados = new ArrayList((AuxAviamento.Items[i].Text.Split('|').ToArray()));
                MySqlCommand InsertComposicao = new MySqlCommand("DELETE FROM composicao WHERE idcomposicao = @idcomposicao AND idtipocomposicao = 1 AND idproduto ='" + IdProduto+"'", Com);
                InsertComposicao.Parameters.Add("@idcomposicao", Dados[0].ToString());
                InsertComposicao.ExecuteNonQuery();
                Dados.Clear();
            }
            for (int i = 0; i < AuxCustos.Items.Count; i++)
            {
                ArrayList Dados = new ArrayList((AuxCustos.Items[i].Text.Split('|').ToArray()));
                MySqlCommand InsertComposicao = new MySqlCommand("DELETE  FROM composicao WHERE idcomposicao =@idcomposicao AND idtipocomposicao =5 AND idproduto ='" + IdProduto + "'", Com);
                InsertComposicao.Parameters.Add("@idcomposicao", Dados[0].ToString());
                InsertComposicao.ExecuteNonQuery();
                Dados.Clear();
            }
            for (int i = 0; i < AuxMateriaPrima.Items.Count; i++)
            {
                ArrayList Dados = new ArrayList((AuxMateriaPrima.Items[i].Text.Split('|').ToArray()));
                MySqlCommand InsertComposicao = new MySqlCommand("DELETE  FROM composicao WHERE idcomposicao =@idcomposicao AND idtipocomposicao =3 AND idproduto ='" + IdProduto + "'", Com);
                InsertComposicao.Parameters.Add("@idcomposicao", Dados[0].ToString());
                InsertComposicao.ExecuteNonQuery();
                Dados.Clear();
            }
            for (int i = 0; i < AuxServico.Items.Count; i++)
            {
                ArrayList Dados = new ArrayList((AuxServico.Items[i].Text.Split('|').ToArray()));
                MySqlCommand InsertComposicao = new MySqlCommand("DELETE  FROM composicao WHERE idcomposicao =@idcomposicao AND idtipocomposicao =4 AND idproduto ='" + IdProduto + "'", Com);
                InsertComposicao.Parameters.Add("@idcomposicao", Dados[0].ToString());
                InsertComposicao.ExecuteNonQuery();
                Dados.Clear();
            }

            Com.Close();
        }

        public void ExcluirProduto(string Id)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("UPDATE produto set excluido = 'S' WHERE id =@id", Com);
            Insert.Parameters.Add("@id", Id);
            Insert.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaComposicao(string IdProduto)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("Select a.idproduto, a.idcomposicao, a.valor,a.quantidade ,a.idtipocomposicao,  case WHEN(a.idtipocomposicao = 4) THEN(select c.descricao from servico c WHERE a.idcomposicao = c.id) WHEN(a.idtipocomposicao = 3) THEN(select d.descricao from materiaprima d WHERE a.idcomposicao = d.id) WHEN(a.idtipocomposicao = 1) THEN(select b.descricao from aviamento b WHERE a.idcomposicao = b.id) WHEN(a.idtipocomposicao = 5) THEN(select e.descricao from custooperacional e WHERE a.idcomposicao = e.id) END as tipo FROM composicao a WHERE a.idproduto = @id ", Com);
            Insert.Parameters.Add("@id", IdProduto);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Insert);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable RetornaProduto(string IdProduto)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("Select * FROM produto WHERE id = @id ", Com);
            Insert.Parameters.Add("@id", IdProduto);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Insert);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable RetornaPrecoCusto(string IdProduto)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("Select SUM((valor*quantidade)) as precocusto FROM composicao WHERE idproduto = @id ", Com);
            Insert.Parameters.Add("@id", IdProduto);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Insert);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public void AtualizarTabelaCompleta(string IdComposicao, string TipoComposicao,decimal Valor, string IdComposicaoNova)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id FROM tipocomposicao WHERE descricao = @descricao",Com);
            Select.Parameters.Add("@descricao", TipoComposicao);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoTipo = new DataTable();
            Resultado.Fill(ResultadoTipo);
            MySqlCommand Update = new MySqlCommand("UPDATE composicao SET idcomposicao = @novaid ,valor = @valor WHERE idcomposicao = @idcomposicao AND idtipocomposicao = @idtipocomposicao",Com);
            Update.Parameters.Add("@valor", Valor);
            Update.Parameters.Add("@idcomposicao", IdComposicao);
            Update.Parameters.Add("novaid", IdComposicaoNova);
            Update.Parameters.Add("@idtipocomposicao", ResultadoTipo.Rows[0]["id"].ToString());
            Update.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastrarUsuario(String Login, String Senha)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("INSERT INTO usuario (login, senha) VALUES(@login,MD5(@senha))",Com);
            Insert.Parameters.Add("@login", Login);
            Insert.Parameters.Add("@senha", Senha);
            Insert.ExecuteNonQuery();
            Com.Close();
        }

        public void AtualizarUsuario(string Login, string Senha, string Id)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("UPDATE usuario set Login = @login, Senha = MD5(@senha) WHERE id =@id", Com);
            Insert.Parameters.Add("@login", Login);
            Insert.Parameters.Add("@senha", Senha);
            Insert.Parameters.Add("@id", Id);
            Insert.ExecuteNonQuery();
            Com.Close();
        }

        public void ExcluirUsuario(string Id)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("UPDATE usuario set excluido = 'S' WHERE id =@id", Com);
            Insert.Parameters.Add("@id", Id);
            Insert.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscarUsuario(string Busca)
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, login as LOGIN FROM usuario WHERE login LIKE '%" + Busca + "%' AND excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarMateriaPrimaCompleta()
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT ID,DESCRICAO,VALOR FROM materiaprima WHERE excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarServicoCompleta()
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT ID,DESCRICAO,VALOR FROM servico WHERE excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarAviamentoCompleta()
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT ID,DESCRICAO,VALOR FROM aviamento WHERE excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable BuscarCustosCompleta()
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT ID,DESCRICAO,VALOR FROM custooperacional WHERE excluido = 'N' ;", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            Com.Close();
            return ResultadoCompleto;
        }

        public void SetListMateriaPrima(DataTable MateriaSelecionada)
        {
            MateriaPrima.Clear();
            MateriaPrima = MateriaSelecionada;
        }

        public void SetListServico(DataTable ServicoSelecionado)
        {
            Servico.Clear();
            Servico = ServicoSelecionado;
        }

        public void SetListAviamento(DataTable AviamentoSelecionado)
        {
            Aviamento.Clear();
            Aviamento = AviamentoSelecionado;
        }

        public void SetListCustos(DataTable CustoSelecionado)
        {
            Custos.Clear();
            Custos = CustoSelecionado;
        }

        public DataTable GetMateriaPrima()
        {
            return MateriaPrima;
        }

        public DataTable GetServico()
        {
            return Servico;
        }

        public DataTable GetAviamento()
        {
            return Aviamento;
        }

        public DataTable GetCustos()
        {
            return Custos;
        }

        public void SetQuantidade(string Quant)
        {
            Quantidade = Quant;
        }

        public string GetQuantidade()
        {
            String quantidade = Quantidade;
            Quantidade = "";
            return quantidade;
        }

        public DataTable RelatorioPadrao1()
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, nome as DESCRIÇÃO, lucro as LUCRO FROM produto WHERE excluido = 'N'", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            ResultadoCompleto.Columns.Add("TOTAL");
            for (int i = 0; i < ResultadoCompleto.Rows.Count; i++)
            {
                try
                {
                    MySqlCommand Select2 =
                        new MySqlCommand(
                            " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                            ResultadoCompleto.Rows[i]["ID"].ToString() + "' ;", Com);
                    MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                    DataTable ResultadoCompleto2 = new DataTable();
                    Resultado2.Fill(ResultadoCompleto2);
                    decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                    Convert.ToDecimal(ResultadoCompleto.Rows[i]["LUCRO"].ToString());
                    ResultadoCompleto.Rows[i]["TOTAL"] = preco;
                }
                catch { }

            }
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable RelatorioPadrao2()
        {
            Com.Open();
            MySqlCommand Select = new MySqlCommand("SELECT id as ID, nome as DESCRIÇÃO, lucro as LUCRO,markup as VENDEDOR, descontoprazo as 'A PRAZO',descontoavista 'A VISTA',descontoatacado 'ATACADO' FROM produto WHERE excluido = 'N'", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            ResultadoCompleto.Columns.Add("TOTAL");
            for (int i = 0; i < ResultadoCompleto.Rows.Count; i++)
            {
                try
                {
                    MySqlCommand Select2 =
                        new MySqlCommand(
                            " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                            ResultadoCompleto.Rows[i]["ID"].ToString() + "' ;", Com);
                    MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                    DataTable ResultadoCompleto2 = new DataTable();
                    Resultado2.Fill(ResultadoCompleto2);
                    decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                    Convert.ToDecimal(ResultadoCompleto.Rows[i]["LUCRO"].ToString());
                    ResultadoCompleto.Rows[i]["TOTAL"] = preco;
                }
                catch { }

            }
            Com.Close();
            return ResultadoCompleto;
        }

        public DataTable RelatorioPersonalizado(ArrayList Querrys)
        {
            DataTable ResultadoCompleto = new DataTable();
            for (int i = 0; i < Querrys.Count; i++)
            {
                if (Querrys[i].Equals("1"))
                {
                    ResultadoCompleto.Columns.Add("PREÇO CUSTO");
                    MySqlCommand Select = new MySqlCommand("SELECT lucro as LUCRO, id as ID FROM produto WHERE excluido = 'N'", Com);
                    MySqlDataAdapter Resultado1 = new MySqlDataAdapter(Select);
                    DataTable Resultado = new DataTable();
                    Resultado1.Fill(Resultado);
                    Resultado.Columns.Add("TOTAL");
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {
                        if (ResultadoCompleto.Rows.Count != Resultado.Rows.Count)
                        {
                            for (int k = 0; k < Resultado.Rows.Count; k++)
                            {
                                ResultadoCompleto.Rows.Add();
                            }
                        }
                        try
                        {
                            MySqlCommand Select2 =
                                new MySqlCommand(
                                    " select SUM(a.valor*a.quantidade) as 'PREÇO CUSTO' FROM composicao a WHERE a.idproduto ='" +
                                    Resultado.Rows[j]["ID"].ToString() + "' ;", Com);
                            MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                            DataTable ResultadoCompleto2 = new DataTable();
                            Resultado2.Fill(ResultadoCompleto2);
                            decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                            Convert.ToDecimal(Resultado.Rows[j]["LUCRO"].ToString());
                            ResultadoCompleto.Rows[j]["PREÇO CUSTO"] = preco;
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }

                    }
                }
                else if (Querrys[i].Equals("2"))
                {
                    ResultadoCompleto.Columns.Add("VENDEDOR");
                    MySqlCommand Select = new MySqlCommand("SELECT markup as VENDEDOR, lucro as LUCRO, id as ID FROM produto WHERE excluido = 'N'", Com);
                    MySqlDataAdapter Resultado1 = new MySqlDataAdapter(Select);
                    DataTable Resultado = new DataTable();
                    Resultado1.Fill(Resultado);
                    Resultado.Columns.Add("TOTAL");
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {
                        

                        try
                        {
                            MySqlCommand Select2 =
                                new MySqlCommand(
                                    " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                                    Resultado.Rows[j]["ID"].ToString() + "' ;", Com);
                            MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                            DataTable ResultadoCompleto2 = new DataTable();
                            Resultado2.Fill(ResultadoCompleto2);
                            decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                            Convert.ToDecimal(Resultado.Rows[j]["LUCRO"].ToString());
                            Resultado.Rows[j]["TOTAL"] = preco;
                        }
                        catch { }

                    }

                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {
                        if (ResultadoCompleto.Rows.Count != Resultado.Rows.Count)
                        {
                            for (int k = 0; k < Resultado.Rows.Count; k++)
                            {
                                ResultadoCompleto.Rows.Add();
                            }
                        }
                        ResultadoCompleto.Rows[j]["VENDEDOR"] = String.Format("{0:0.00}", Convert.ToDecimal(Resultado.Rows[j]["TOTAL"].ToString()) / Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()));
                    }
                }
                else if (Querrys[i].Equals("3"))
                {
                    ResultadoCompleto.Columns.Add("A PRAZO");
                    MySqlCommand Select = new MySqlCommand("SELECT descontoprazo as 'A PRAZO', markup as VENDEDOR,lucro as LUCRO, id as ID  FROM produto WHERE excluido = 'N'", Com);
                    MySqlDataAdapter Resultado1 = new MySqlDataAdapter(Select);
                    DataTable Resultado = new DataTable();
                    Resultado1.Fill(Resultado);
                    Resultado.Columns.Add("TOTAL");
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {

                        try
                        {
                            MySqlCommand Select2 =
                                new MySqlCommand(
                                    " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                                    Resultado.Rows[j]["ID"].ToString() + "' ;", Com);
                            MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                            DataTable ResultadoCompleto2 = new DataTable();
                            Resultado2.Fill(ResultadoCompleto2);
                            decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                            Convert.ToDecimal(Resultado.Rows[j]["LUCRO"].ToString());
                            Resultado.Rows[j]["TOTAL"] = preco;
                        }
                        catch { }

                    }
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {
                        
                        if (ResultadoCompleto.Rows.Count != Resultado.Rows.Count)
                        {
                            for (int k = 0; k < Resultado.Rows.Count; k++)
                            {
                                ResultadoCompleto.Rows.Add();
                            }
                        }
                  
                        Resultado.Rows[j]["VENDEDOR"] = String.Format("{0:0.00}", Convert.ToDecimal(Resultado.Rows[j]["TOTAL"].ToString()) / Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()));
                        ResultadoCompleto.Rows[j]["A PRAZO"] = String.Format("{0:0.00}", Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()) - (Convert.ToDecimal(Resultado.Rows[j]["A PRAZO"].ToString()) * Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString())));
                    }
                }
                else if (Querrys[i].Equals("4"))
                {
                    ResultadoCompleto.Columns.Add("A VISTA");
                    MySqlCommand Select = new MySqlCommand("SELECT descontoavista as 'A VISTA', markup as VENDEDOR,lucro as LUCRO, id as ID  FROM produto WHERE excluido = 'N'", Com);
                    MySqlDataAdapter Resultado1 = new MySqlDataAdapter(Select);
                    DataTable Resultado = new DataTable();
                    Resultado1.Fill(Resultado);
                    Resultado.Columns.Add("TOTAL");
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {

                        try
                        {
                            MySqlCommand Select2 =
                                new MySqlCommand(
                                    " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                                    Resultado.Rows[j]["ID"].ToString() + "' ;", Com);
                            MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                            DataTable ResultadoCompleto2 = new DataTable();
                            Resultado2.Fill(ResultadoCompleto2);
                            decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                            Convert.ToDecimal(Resultado.Rows[j]["LUCRO"].ToString());
                            Resultado.Rows[j]["TOTAL"] = preco;
                        }
                        catch { }

                    }
                    for (int j = 0; j < Resultado.Rows.Count;j++)
                    {
                        if (ResultadoCompleto.Rows.Count != Resultado.Rows.Count)
                        {
                            for (int k = 0; k < Resultado.Rows.Count; k++)
                            {
                                ResultadoCompleto.Rows.Add();
                            }
                        }

                        Resultado.Rows[j]["VENDEDOR"] = String.Format("{0:0.00}", Convert.ToDecimal(Resultado.Rows[j]["TOTAL"].ToString()) / Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()));
                        ResultadoCompleto.Rows[j]["A VISTA"] = String.Format("{0:0.00}", Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()) - (Convert.ToDecimal(Resultado.Rows[j]["A VISTA"].ToString()) * Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString())));
                    }
                }
                else if (Querrys[i].Equals("5"))
                {
                    ResultadoCompleto.Columns.Add("ATACADO");
                    MySqlCommand Select =
                        new MySqlCommand(
                            "SELECT descontoatacado as 'ATACADO', markup as VENDEDOR,lucro as LUCRO, id as ID  FROM produto WHERE excluido = 'N'",
                            Com);
                    MySqlDataAdapter Resultado1 = new MySqlDataAdapter(Select);
                    DataTable Resultado = new DataTable();
                    Resultado1.Fill(Resultado);
                    Resultado.Columns.Add("TOTAL");
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {

                        try
                        {
                            MySqlCommand Select2 =
                                new MySqlCommand(
                                    " select SUM(a.valor*a.quantidade) as TOTAL FROM composicao a WHERE a.idproduto ='" +
                                    Resultado.Rows[j]["ID"].ToString() + "' ;", Com);
                            MySqlDataAdapter Resultado2 = new MySqlDataAdapter(Select2);
                            DataTable ResultadoCompleto2 = new DataTable();
                            Resultado2.Fill(ResultadoCompleto2);
                            decimal preco = Convert.ToDecimal(ResultadoCompleto2.Rows[0][0].ToString()) +
                                            Convert.ToDecimal(Resultado.Rows[j]["LUCRO"].ToString());
                            Resultado.Rows[j]["TOTAL"] = preco;
                        }
                        catch
                        {
                        }

                    }
                    for (int j = 0; j < Resultado.Rows.Count; j++)
                    {
                        if (ResultadoCompleto.Rows.Count != Resultado.Rows.Count)
                        {
                            for (int k = 0; k < Resultado.Rows.Count; k++)
                            {
                                ResultadoCompleto.Rows.Add();
                            }
                        }
                        Resultado.Rows[j]["VENDEDOR"] = String.Format("{0:0.00}",
                            Convert.ToDecimal(Resultado.Rows[j]["TOTAL"].ToString())/
                            Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()));
                        ResultadoCompleto.Rows[j]["ATACADO"] = String.Format("{0:0.00}",
                            Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString()) -
                            (Convert.ToDecimal(Resultado.Rows[j]["ATACADO"].ToString())*
                             Convert.ToDecimal(Resultado.Rows[j]["VENDEDOR"].ToString())));
                    }
                }
                else
                {
                    MySqlCommand SelectComandos = new MySqlCommand(Querrys[i].ToString(), Com);
                    MySqlDataAdapter Resultado3 = new MySqlDataAdapter(SelectComandos);
                    DataTable Resultado4 = new DataTable();
                    Resultado3.Fill(Resultado4);
                    ResultadoCompleto.Columns.Add(Resultado4.Columns[0].ColumnName);
                    if (Resultado4.Columns.Count > 1)
                    {
                        return Resultado4;
                    }
                    else
                    {
                        for (int y = 0; y < Resultado4.Rows.Count; y++)
                        {
                            if (ResultadoCompleto.Rows.Count != Resultado4.Rows.Count)
                            {
                                for (int k = 0; k < Resultado4.Rows.Count; k++)
                                {
                                    ResultadoCompleto.Rows.Add();
                                }
                            }
                            ResultadoCompleto.Rows[y][Resultado4.Columns[0].ColumnName] = Resultado4.Rows[y][0];
                        }
                    }
                }
            }
            return ResultadoCompleto;
        }

        public void SetNomeRelatorio(string Nome)
        {
            NomeRelatorio = Nome;
        }

        public string GetNomeRelatorio()
        {
            return NomeRelatorio;
        }

        public void SalvarRelatorio(ArrayList Querrys, string Relatorio)
        {
            MySqlCommand Select = new MySqlCommand("SELECT * FROM relatorios WHERE descricao = @nome", Com);
            Select.Parameters.Add("@nome", Relatorio);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            if (ResultadoCompleto.Rows.Count > 0)
            {
                MessageBox.Show("Existe um relatório com o mesmo nome já cadastrado, favor digitar outro nome. O relatório sera gerado, porem nenhum dado sera salvo!",
                    "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string ComandoCompleto = "";
                for (int i = 0; i < Querrys.Count; i++)
                {
                    ComandoCompleto = ComandoCompleto + Querrys[i] + ";";
                }
                Com.Open();
                MySqlCommand SalvarRelatorio =
                    new MySqlCommand("INSERT INTO relatorios SET descricao=@descricao, querry=@querry", Com);
                SalvarRelatorio.Parameters.Add("@descricao", Relatorio);
                SalvarRelatorio.Parameters.Add("@querry", ComandoCompleto);
                SalvarRelatorio.ExecuteNonQuery();
                Com.Close();
            }
        }

        public DataTable BuscaRelatoriosSalvos()
        {
            MySqlCommand Select = new MySqlCommand("SELECT descricao FROM relatorios WHERE excluido = 'N'", Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            return ResultadoCompleto;
        }

        public ArrayList RetornoQuerryRelatorioSalvo(string NomeRelatorioParaRecuperar)
        {
            MySqlCommand Select = new MySqlCommand("SELECT querry FROM relatorios WHERE descricao = @nome", Com);
            Select.Parameters.Add("@nome", NomeRelatorioParaRecuperar);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(Select);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
           List<string> ComandoCompleto = new List<string>();
            ArrayList QuerryArray = new ArrayList();
            ComandoCompleto = ResultadoCompleto.Rows[0][0].ToString().Split(';').ToList();
            for (int i =0; i < ComandoCompleto.Count; i++)
            {
                QuerryArray.Add(ComandoCompleto[i].ToString());
            }
            QuerryArray.RemoveAt(ComandoCompleto.Count-1);
            return QuerryArray;
        }

        public void ExcluirRelatorio(string Descricao)
        {
            Com.Open();
            MySqlCommand Insert = new MySqlCommand("UPDATE relatorios set excluido = 'S' WHERE descricao =@descricao", Com);
            Insert.Parameters.Add("@descricao", Descricao);
            Insert.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaTipos()
        {
            MySqlCommand SelectTipo = new MySqlCommand("SELECT descricao FROM tipocomposicao",Com);
            MySqlDataAdapter Resultado = new MySqlDataAdapter(SelectTipo);
            DataTable ResultadoCompleto = new DataTable();
            Resultado.Fill(ResultadoCompleto);
            return ResultadoCompleto;
        }
    }
  
}
