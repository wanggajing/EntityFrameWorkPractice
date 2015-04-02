<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertDestination.aspx.cs" Inherits="EntityFrameWorkPractice.InsertDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="InsertDestionation" OnClick="Button1_Click"/>
        <table>
            <tr>
                <th>Country</th>
                <th>Description</th>
                <th>Name</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="EntityFrameWorkPractice.Model.Destination">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.Country %><</td>
                        <td><%#:Item.Description %><</td>
                        <td><%#:Item.Name %><</td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
