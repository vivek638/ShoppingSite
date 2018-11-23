<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="VIEWORDER.aspx.cs" Inherits="admin_VIEWORDER" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
    <table class="style1" style="width: 100%">
    <tr>
        <td colspan="2" class="tblhead">
            View Order</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="lbl">
            SELECT USER:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="lbl">
            ORDER STATUS:</td>
        <td>
            <asp:DropDownList ID="drpstatus" runat="server">
                <asp:ListItem>Pending</asp:ListItem>
                <asp:ListItem>Complate</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="lbl">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button9" runat="server" CssClass="btn" Text="VIEW" 
                Height="30px" onclick="Button9_Click" Width="77px" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" Width="872px" 
                AllowPaging="True" 
                onselectedindexchanging="GridView1_SelectedIndexChanging" BackColor="White" 
                BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
            <asp:TemplateField HeaderText="Image">
            <ItemTemplate>
            <asp:Image ID="imgg" ImageUrl='<%#Eval("image") %>' runat="server" Height="50" Width="50"/>
            </ItemTemplate>

            </asp:TemplateField>
            <asp:BoundField HeaderText="Item Name" DataField="iname" />
                <asp:BoundField HeaderText="Item Qnt" DataField="qnt" />
                    <asp:BoundField HeaderText="Item price" DataField="price" />
                        <asp:BoundField HeaderText="Total Price" DataField="tprice" />
            </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" ForeColor="White" Font-Bold="True" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </td>
    </tr>
</table>
    
    
</asp:Content>

