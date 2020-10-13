<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctFornecedoresProduto.ascx.cs" Inherits="WebApp.Componentes.ctFornecedoresProduto" %>
<div class="row historico">
    <div class="historico-imagem">
        <%--<img src="../Resources/images/profile-image.jpg" class="profile-thumbnail-historico" />--%>
        <asp:Image ID="imagemPerfil" runat="server" CssClass="profile-thumbnail-historico"/>
    </div>
    <div class="col-md-3">
        <h3 class="historico-fornecedor"><asp:Literal runat="server" ID="lblNome"></asp:Literal> <span class="historico-data"></span></h3>
        <span class="historico-qtd-itens">32 Outros Itens</span>
        <a href="#"><span class="historico-acao-ver">Ver detalhes</span></a>
    </div>  
    <div class="col-md-2 historico-valor">
        <span>Disponível<br /><asp:Literal runat="server" ID="lblDisponivel"></asp:Literal></span>
    </div>
    <div class="col-md-2 historico-valor">
        <span>Valor Unitario<br /><asp:Literal runat="server" ID="lblValor"></asp:Literal></span>
    </div>
    <div class="col-md-2 historico-valor">
        <span>Valor Frete<br /><asp:Literal runat="server" ID="lblValorFrete"></asp:Literal></span>
    </div>
    <div class="col-md-1 historico-ir-pedido">
        <asp:LinkButton runat="server" ID="addCarrinho" OnClick="addCarrinho_Click"><i style="padding-top: 5px;font-size: 30px;" class="fa fa-shopping-cart" aria-hidden="true"></i></asp:LinkButton>
    </div>
</div>
