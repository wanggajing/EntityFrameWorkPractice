<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListEmployee.aspx.cs" Inherits="EntityFrameWorkPractice.Pages.ListEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>EmployeeName</th>
                <th>Age</th>
                <th>Department</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server" ItemType="EntityFrameWorkPractice.Model.Employee" SelectMethod="GetEmployees">
                <ItemTemplate>
                    <tr>
                        <td><%#:Item.Name %></td>
                        <td><%#:Item.Age %></td>
                        <td><%#:Item.Department.Name %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
