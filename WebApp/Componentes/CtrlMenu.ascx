<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtrlMenu.ascx.cs" Inherits="WebApp.Componentes.CtrlMenu" %>

<nav id="sidebar" class="sidebar-wrapper">

    <div class="sidebar-topo">
        <a href="Dashboard.aspx"><svg width="31" height="38" viewBox="0 0 31 38" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M30.29 25.39C30.29 32.39 25.18 37.21 15.25 37.21C8.47 37.21 1.61 34.48 0 28.54L8.53 25.88C8.81 27.35 10.21 29.73 15.38 29.73C19.09 29.73 21.19 28.4 21.19 26.02C21.19 22.66 16.08 22.8 11.89 21.89C5.04 20.49 1.54 17.2 1.54 11.12C1.54 4.41 7.14 0 15.46 0C21.55 0 27.56 3.01 29.03 9.16L20.99 11.12C20.57 9.3 18.82 7.48 15.46 7.48C12.87 7.48 10.21 8.46 10.21 11.12C10.21 14.27 14.97 14.48 17.76 15.11C26.44 17 30.29 19.38 30.29 25.39Z" fill="#00BF7C" />
        </svg>
            </a>
    </div>
    <div class="sidebar-content">
        <div class="sidebar-menu" runat="server" id="divMenu">
            <ul>
                <li class='sidebar'>
                    <a href="../Paginas/Dashboard.aspx"><i class='fa fa-th'></i></a>
                </li>
                <li class='sidebar'>
                    <a href="../Paginas/Loja.aspx"><i class='fa fa-shopping-cart' style="margin-left: -5px;"></i></a>
                </li>

            </ul>
        </div>
    </div>
</nav>
