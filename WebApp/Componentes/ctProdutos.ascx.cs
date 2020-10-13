using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctProdutos : System.Web.UI.UserControl
    {
        public Produtos produto;

        protected void Page_Load(object sender, EventArgs e)
        {
            inicializaComponente();
        }

        private void inicializaComponente()
        {
            lblTitulo.Text = produto.nome;
            

            imgProduto.Src = "../Resources/images/" + produto.imagem;

            linkProduto.HRef = "../Paginas/Produto.aspx?Id=" + produto.Id + "&Loja=S";
            //btnAdicionarCarrinho.Attributes.Add("Produto", produto.dadosProduto.nome);
            //linkCarrinho.Attributes.Add("onclick", "adicionarCarrinho('" + produto.dadosProduto.nome + "');");
        }

        
    }
}