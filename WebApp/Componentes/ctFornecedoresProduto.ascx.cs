using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctFornecedoresProduto : System.Web.UI.UserControl
    {
        public DTO.ProdutosFornecedor ProdutosFornecedor;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDisponivel.Text = ProdutosFornecedor.estoque.ToString() + "/" + ProdutosFornecedor.produto.unidade;
            lblNome.Text = ProdutosFornecedor.nomeFornecedor;
            lblValor.Text = formataMoeda(ProdutosFornecedor.valorUnitario);
            lblValorFrete.Text = formataMoeda(ProdutosFornecedor.valorFrete);
            imagemPerfil.ImageUrl = "../Resources/images/" + ProdutosFornecedor.foto;

        }

        private string formataMoeda(double valor) { return string.Format("{0:C}", valor); }

        protected void addCarrinho_Click(object sender, EventArgs e)
        {
            ctCarrinho controle = (ctCarrinho)Session["controleCarrinho"];
            controle.adicionarItem(ProdutosFornecedor, 1);
            controle.inicializaCarrinho();
            controle.rodape.InicalizaValores();

            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            Response.Redirect(url);
        }
    }
}