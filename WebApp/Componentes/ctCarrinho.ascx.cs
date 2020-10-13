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
    public partial class ctCarrinho : System.Web.UI.UserControl
    {
        public Carrinho carrinho;

        public ctCarrinhoRodape rodape { get { return carrinhoRodape; } set { carrinhoRodape = value; } }



        protected void Page_Load(object sender, EventArgs e)
        {

            inicializaCarrinho();

        }

        public void inicializaCarrinho()
        {
            if (Session["Carrinho"] != null)
            {
                carrinho = (Carrinho)Session["Carrinho"];
                carrinhoRodape.Visible = true;
                carrinhoVzio.Visible = false;
            }
            else
            {
                carrinho = new Carrinho();
                Session["Carrinho"] = carrinho;
                carrinhoRodape.Visible = true;

            }

            Session["controleCarrinho"] = this;
            produtosCarrinho.Controls.Clear();

            foreach (ProdutosCarrinho item in carrinho.itensCarrinho)
            {
                var controle = (WebApp.Componentes.ctCarrinhoProduto)Page.LoadControl("~/Componentes/ctCarrinhoProduto.ascx");
                controle.oProduto = item;
                produtosCarrinho.Controls.Add(controle);
            }


            if (carrinho.getTotalItens() == 0)
            {
                carrinhoRodape.Visible = false;
                carrinhoVzio.Visible = true;
            }
        }

        public void adicionarItem(ProdutosFornecedor item, double quantidade)
        {
            ProdutosCarrinho prod = new ProdutosCarrinho();

            prod.dadosItem = item;
            prod.quantidade = quantidade;

            carrinho.itensCarrinho.Add(prod);
            Session["Carrinho"] = carrinho;
            carrinhoVzio.Visible = false;
            carrinhoRodape.Visible = true;
        }

        public void removerItem(ProdutosCarrinho item)
        {
            carrinho.itensCarrinho.Remove(item);

            if (carrinho.itensCarrinho.Count == 0)
            {
                carrinhoVzio.Visible = true;
                carrinhoRodape.Visible = false;
                Session["Carrinho"] = null;
            }

        }

        public void alteraQuantidade(ProdutosCarrinho item, string operacao)
        {
            carrinho.itensCarrinho = carrinho.itensCarrinho.Where(x => x.dadosItem.produto.nome != item.dadosItem.produto.nome).ToList();

            if (operacao == "+")
            {
                item.quantidade = item.quantidade + 1;
            }
            else if (item.quantidade > 1)
            {
                item.quantidade = item.quantidade - 1;
            }

            carrinho.itensCarrinho.Add(item);
        }

        public void fecharPedido()
        {
            pnlCarrinho.Visible = false;
            pnlCheckout.Visible = true;
            double valorTotalPedido = 0.0;
            double valorItem = 0.0;
            double valorFrete = 0.0;
            double valorTotalFrete = 0.0;

            foreach (var item in carrinho.itensCarrinho)
            {                
                var controle = (WebApp.Componentes.ctProdutosPedido)Page.LoadControl("~/Componentes/ctProdutosPedido.ascx");
                controle.produto = item;
                produtosPedido.Controls.Add(controle);
                
            }

            for (int i = 0; i < carrinho.itensCarrinho.Count; i++)
            {
                valorItem = carrinho.itensCarrinho[i].dadosItem.valorUnitario * carrinho.itensCarrinho[i].quantidade;
                valorFrete = carrinho.itensCarrinho[i].dadosItem.valorFrete;
                valorTotalFrete = valorTotalFrete + valorFrete;
                valorTotalPedido = valorTotalPedido + valorItem + valorFrete;
            }
            lblFrete.Text = valorTotalFrete.ToString("C", CultureInfo.CurrentCulture);
            lblFinal.Text = valorTotalPedido.ToString("C", CultureInfo.CurrentCulture);

        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            string retornoBoleto = DAL.Objetos.Pedidos.GeraBoletos(lblFinal.Text.Replace("R$", "").Replace(",", "").Trim(),"João da Silva");
            Response.Write("<script>window.open ('"+ retornoBoleto + "','_blank');</script>");
        }
    }
}