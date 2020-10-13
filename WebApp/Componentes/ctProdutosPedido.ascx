<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctProdutosPedido.ascx.cs" Inherits="WebApp.Componentes.ctProdutosPedido" %>

<div class="col-md-1">
</div>
<div class="col-md-7 checkout-produtos-labels">
    <span class="checkout-produto"><asp:Literal runat="server" ID="lblQuantidade"></asp:Literal> de <asp:Literal runat="server" ID="lblProduto"></asp:Literal></span>
</div>
<div class="col-md-4 checkout-produtos-valores">
    <span class="checkout-produto-valor"><asp:Literal runat="server" ID="lblTotal"></asp:Literal></span>
</div>
