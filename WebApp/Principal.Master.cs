
using System;

namespace WebApp
{
    public partial class Principal : System.Web.UI.MasterPage
    {

        public Componentes.ctHeader cabecalho { get { return this.ctHeader; } set { ctHeader = value; } }
        public Componentes.ctCarrinho carrinho { get { return this.ctCarrinho; } set { ctCarrinho = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            ctNotificacoes.QtdNotificacoes = 10;
            ctNotificacoes.QtdCarrinho = 0;
            carrinho.inicializaCarrinho();
            if (carrinho.carrinho != null)
            {
                ctNotificacoes.QtdCarrinho = carrinho.carrinho.itensCarrinho.Count;
            }

        }

    }
}