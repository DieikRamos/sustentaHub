<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctCarrinhoRodape.ascx.cs" Inherits="WebApp.Componentes.ctCarrinhoRodape" %>

<div class="row totais">
    <div class="col-md-8">
        Total produtos
    </div>
    <div class="col-md-4">
        <asp:Literal runat="server" ID="lblTotal"></asp:Literal>
    </div>
</div>
<div class="row totais">
    <div class="col-md-8">
        Frete
    </div>
    <div class="col-md-4">
        <asp:Literal runat="server" ID="lblFrete"></asp:Literal>
    </div>
</div>
<div class="row totais">
    <div class="col-md-8">
        Desconto
    </div>
    <div class="col-md-4">
        R$ 0,00
    </div>
</div>
<div class="row totais total-geral">
    <div class="col-md-8">
        Total pedido
    </div>
    <div class="col-md-4">
        <asp:Literal runat="server" ID="lblTotalPedido"></asp:Literal>
    </div>
</div>

<!-- Fim Totais -->
<!-- Botões -->
<div class="row finalizar-pedido">
    <div class="form-finalizar">
        <asp:Button ID="btnFinalizar" runat="server" CssClass="form-control btn btn-danger mb-2" Text="Finalizar pedido" OnClick="btnFinalizar_Click" />
    </div>
</div>
<!-- Fim Botões -->
