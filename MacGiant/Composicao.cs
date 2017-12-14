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
    public partial class Composicao : Form
    {
        QuerryMysql ComposicaoProduto = new QuerryMysql();

        public Composicao(string Id)
        {
            InitializeComponent();


            DataTable Resultado2 = new DataTable();
            Resultado2 = ComposicaoProduto.BuscarProdutoCodigo(Id);
            DataTable Resultado = new DataTable();
            Resultado = ComposicaoProduto.RetornaComposicao(Resultado2.Rows[0]["ID"].ToString());
            for (int i = 0; i < Resultado.Rows.Count; i++)
            {
                if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("1"))
                {
                    
                    ListAviamentos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                }
                else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("3"))
                {
                   
                    ListMateriaPrima.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                }
                else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("4"))
                {
                    
                    ListServicos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                }
                else if (Resultado.Rows[i]["idtipocomposicao"].ToString().Equals("5"))
                {
                   
                    ListCustos.Rows.Add(Resultado.Rows[i]["idcomposicao"].ToString(), Resultado.Rows[i]["tipo"].ToString(), Resultado.Rows[i]["valor"].ToString(), Resultado.Rows[i]["quantidade"].ToString());
                }

            }
            label6.Text = Resultado2.Rows[0]["DESCRIÇÃO"].ToString()+":";
        }
    }
    }

