using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctNotificacoes : System.Web.UI.UserControl
    {
        public int QtdNotificacoes;
        public int QtdCarrinho;

        protected void Page_Load(object sender, EventArgs e)
        {
            nroItensCarrinho.Text = QtdCarrinho.ToString();
            nroNotificacoes.Text = QtdNotificacoes.ToString();
        }
    }
}