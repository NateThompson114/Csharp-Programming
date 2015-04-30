<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Csharp_WebDBControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="Id" DataSourceID="LinqDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="lastName" HeaderText="lastName" SortExpression="lastName" />
                <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
                <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Csharp_WebDBControl.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="FullNamePeoples">
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
