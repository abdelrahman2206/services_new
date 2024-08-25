<%@ Page Title="services_new" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="services_new.aspx.cs" Inherits="services_new.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   &nbsp;<html lang="en"><head><meta charset="UTF-8"><meta name="viewport" content="width=device-width, initial-scale=1.0"><link rel="stylesheet" href="services_new.css"><title>Document</title></head><body><div id="main">
        <div id="title">
            <h3>System</h3>
        </div>
        <div id="Logo"></div>
        <div id="bloc1">
            
           <asp:TextBox ID="Mname" runat="server" Placeholder="Name"></asp:TextBox>
            <asp:DropDownList ID="MType" runat="server">
                <asp:ListItem Text="" Value="new0"></asp:ListItem>
                <asp:ListItem Text="EGP" Value="new1"></asp:ListItem>
                <asp:ListItem Text="USD" Value="new2"></asp:ListItem>
                <asp:ListItem Text="EURO" Value="new3"></asp:ListItem>
                <asp:ListItem Text="RSA" Value="new4"></asp:ListItem>
            </asp:DropDownList>
            
            
            <asp:TextBox ID="Mqty" runat="server" TextMode="Number" Placeholder="Quantity"></asp:TextBox>
            
            <asp:TextBox ID="Mprice" runat="server" TextMode="Number" Placeholder="Price"></asp:TextBox>
            <asp:DropDownList ID="Manu" runat="server"  >
                <asp:ListItem Text="" Value="new0"></asp:ListItem>
                <asp:ListItem Text="service_1" Value="new1"></asp:ListItem>
                <asp:ListItem Text="service_2" Value="new2"></asp:ListItem>
                <asp:ListItem Text="service_3" Value="new3"></asp:ListItem>
                <asp:ListItem Text="service_4" Value="new4"></asp:ListItem>
            </asp:DropDownList>

            
            
        </div>
        <br /><br />
        <div id="Bt_block1">
             <asp:Button ID="Editbtn" runat="server" Text="Edit" Height="30px" Width="94px" OnClick="Editbtn_Click" /> <button runat="server">Delete</button>
            <asp:Button ID="addbtn" runat="server" Text="Add" OnClick="Addbtn_Click" Height="30px" Width="94px" /> 
             </div>
        <br /> <br />
        <div id="grid_table">

            <asp:GridView id="GV1" runat="server" AutoGenerateSelectButton="True" CellPadding="4"  ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GV1_SelectedIndexChanged" >
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>

        </div>
</div>
</body>

</html>
</asp:Content>
