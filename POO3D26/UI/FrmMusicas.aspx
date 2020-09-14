<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMusicas.aspx.cs" Inherits="POO3D26.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Manutenção de Músicas</title>
    <link href="../css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <h1>Músicas</h1>
                <asp:Label style="color: red" ID="lblError" runat="server" Visible="false"></asp:Label><br />
                <asp:Label runat="server">Nome da Música</asp:Label>                
                <asp:TextBox ID="txtNome" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server">Nome do Autor</asp:Label>
                <asp:TextBox ID="txtNomeAutor" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server">Id da Gravadora</asp:Label>
                <asp:TextBox ID="txtIdGravadora" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label runat="server">Id do CD</asp:Label>
                <asp:TextBox ID="txtIdCD" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                <div class="row">
                    <div class="col-md-4">
                        <asp:Button ID="btnGravar" Text="Gravar" CssClass="btn btn-success" runat="server" OnClick="btnGravar_Click"/>

                    </div>
                    <div class="col-md-4">
                        <asp:TextBox ID="txtBuscar" placeholder="Digite o parâmetro de busca" type="text" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <asp:Button ID="btnBuscar" Text="Buscar" CssClass=" btn btn-info" runat="server" OnClick="btnBuscar_Click" />
                    </div>
                </div>

                <br />               


               <asp:GridView ID="GridMusicas" OnRowDeleting="GridMusicas_RowDeleting" OnRowCancelingEdit="GridMusicas_RowCancelingEdit" OnRowEditing="GridMusicas_RowEditing" OnRowUpdating="GridMusicas_RowUpdating" AllowPaging="True" OnPageIndexChanging="GridMusicas_PageIndexChanging" PageSize="5" runat="server">
                   <Columns>
                       <asp:CommandField ShowDeleteButton="true" ButtonType="Button"/>
                       <asp:CommandField ShowEditButton="true" ButtonType="Button" UpdateText="Gravar" />
                   </Columns>
                   <PagerSettings Position="TopAndBottom" />
               </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
