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
    public partial class ctCarrinhoProduto : System.Web.UI.UserControl
    {
        public ProdutosCarrinho oProduto;

        protected void Page_Load(object sender, EventArgs e)
        {
            inicializaComponente();
        }

        private void inicializaComponente()
        {
            lblDescricao.Text = oProduto.dadosItem.produto.nome;
            inputQuantidade.Value = oProduto.quantidade.ToString();
            lblValor.Text = oProduto.dadosItem.valorUnitario.ToString("C", CultureInfo.CurrentCulture);
            lblValorTotal.Text = (oProduto.quantidade * oProduto.dadosItem.valorUnitario).ToString("C", CultureInfo.CurrentCulture);

            imgProdutos.Src = "../Resources/images/" + oProduto.dadosItem.produto.imagem;

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            ctCarrinho controle = (ctCarrinho)Session["controleCarrinho"];
            controle.removerItem(oProduto);            
            controle.inicializaCarrinho();
            controle.rodape.InicalizaValores();
            
        }

        protected void lkbAtualizaQtdeMenos_Click(object sender, EventArgs e)
        {
            ctCarrinho controle = (ctCarrinho)Session["controleCarrinho"];
            controle.alteraQuantidade(oProduto, "-");
            controle.inicializaCarrinho();
            controle.rodape.InicalizaValores();
        }

        protected void lkbAtualizaQtdeMais_Click(object sender, EventArgs e)
        {
            ctCarrinho controle = (ctCarrinho)Session["controleCarrinho"];
            controle.alteraQuantidade(oProduto, "+");
            controle.inicializaCarrinho();
            controle.rodape.InicalizaValores();
        }
    }
}
