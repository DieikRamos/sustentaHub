<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Loja.aspx.cs" Inherits="WebApp.Paginas.Itens" %>

<%@ Register Src="~/Componentes/ctCategoria.ascx" TagPrefix="uc1" TagName="ctCategoria" %>
<%@ Register Src="~/Componentes/ctCarrinho.ascx" TagPrefix="uc1" TagName="ctCarrinho" %>
<%@ Register Src="~/Componentes/ctProdutos.ascx" TagPrefix="uc1" TagName="ctProdutos" %>
<%@ Register Src="~/Componentes/ctLista.ascx" TagPrefix="uc1" TagName="ctLista" %>
<%@ Register Src="~/Componentes/ctPedidos.ascx" TagPrefix="uc1" TagName="ctPedidos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Corpo" runat="server">
    <!-- Fim icones categorias -->
    <div class="row conteudo-central prod-destaque">
        <h4>Categorias</h4><span class="span-pequeno">Ver todas</span>
    </div>
    <!-- Icones catwgorias -->
    <div class="row" runat="server" id="pnlCategorias">
    </div>
    <!-- Fim icones categorias -->
    <div class="row conteudo-central prod-destaque">
        <h4>Produtos</h4>
    </div>
    <!-- Coluna Produtos -->
    <section class="top-products-area pt-100 pb-70">
        <div class="container" runat="server" id="divConteudo">
        </div>
    </section>
    <script>
        document.addEventListener('ScriptsCarregados', function (e) {
            validaCategoria();
        });
    </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Lateral" runat="server">
</asp:Content>
