<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="WebApp.Paginas.Produto" %>

<%@ Register Src="~/Componentes/ctHistoricoPedidos.ascx" TagPrefix="uc1" TagName="ctHistoricoPedidos" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Corpo" runat="server">
    <div class="row">
        <div class="detalhes-produto" id="detallhesProduto" runat="server">
            <div class="col-md-10 nome-produto">
                <h2>
                    <asp:Literal runat="server" ID="lblTitulo"></asp:Literal>
                    <span>
                        <asp:Literal runat="server" ID="lblTipo"></asp:Literal></span> </h2>
                <span class="produto-codigo"><strong>COD: </strong>
                    <asp:Literal runat="server" ID="lblCodigo"></asp:Literal></span>
                <span class="badge-status-compra">Compra Automática</span>
            </div>
            <div class="col-md-2">
                <div class="comprar" id="divComprar" runat="server" visible="false">
                    <asp:LinkButton ID="btnComprarProduto" runat="server" ToolTip="Comprar Produto" OnClick="btnComprarProduto_Click"><i class="fa fa-shopping-cart" aria-hidden="true"></i></asp:LinkButton>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="status-produto">
            <h2>Status do produto</h2>
            <div class="row status-produto-conteudo">
                <div class="col-md-4 bloco-texto">
                    <div class="status-produto-painel">
                        <div class="col-md-10">

                            <h4>Produto acabando</h4>
                            <span class="status-produto-texto">Restam somente 25% do estoque
atual. Faça uma nova compra ou ative
a compra automática para este produto.</span>
                        </div>
                        <div class="col-md-2 alinharCentro">
                            <i class="fa fa-calendar-alt" aria-hidden="true"></i>
                        </div>
                    </div>
                </div>

                <div class="col-md-4 bloco-texto">
                    <div class="status-produto-painel">
                        <div class="col-md-12">
                            <h4>Tempo de armazenamento</h4>
                            <span class="status-produto-texto">Se armazenado corretamente este produto dura em média 4 - 5 dias. Fique atento a validade dos produtos no estoque.</span>
                        </div>
                    </div>

                </div>

                <div class="col-md-4 bloco-texto-consumo">
                    <div class="status-produto-painel">
                        <div class="col-md-12">
                            <h4>Consumo Mensal</h4>
                            <h2 class="status-produto-consumo">12,30 Kg</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row" runat="server" id="pnlHistoricos">
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Lateral" runat="server">
</asp:Content>
