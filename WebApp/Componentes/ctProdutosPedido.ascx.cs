using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctProdutosPedido : System.Web.UI.UserControl
    {
        public ProdutosCarrinho produto;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblProduto.Text = produto.dadosItem.produto.nome;
            lblQuantidade.Text = produto.quantidade.ToString();
            lblTotal.Text = (produto.quantidade * produto.dadosItem.valorUnitario).ToString("C", CultureInfo.CurrentCulture);
        }
    }
}