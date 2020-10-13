using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Componentes
{
    public partial class ctCategoria : System.Web.UI.UserControl
    {
        public Categoria categoria;

        protected void Page_Load(object sender, EventArgs e)
        {
            inicializaComponente();
        }

        private void inicializaComponente()
        {
            imgCategoria.Src = "../Resources/images/" + categoria.imagem;
            lblTitulo.Text = categoria.nome;
            pnlCategoria.Attributes.Add("Categoria", categoria.nome);
        }

    }
}