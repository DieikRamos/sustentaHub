<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctNotificacoes.ascx.cs" Inherits="WebApp.Componentes.ctNotificacoes" %>

<div class="row notificacoes-laterais">
    <div class="div-icone-notif" onclick="mostraPainel('pedidos-notificacao', this)">
        <i class="fa fa-bell"></i>
        <span class="qtd-notificacao">
            <asp:Literal runat="server" ID="nroNotificacoes" /></span>
    </div>
    <div class="div-icone-notif ativa" onclick="mostraPainel('pedidos-carrinho', this)">
        <i class="fa fa-shopping-basket"></i>
        <span class="qtd-itens-cesta">
            <asp:Literal runat="server" ID="nroItensCarrinho" /></span>
    </div>
</div>
