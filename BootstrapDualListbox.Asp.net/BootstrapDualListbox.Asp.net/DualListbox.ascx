<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DualListbox.ascx.cs" Inherits="BootstrapDualListbox.Asp.net.DualListbox" %>
<div class="dummy">
    <asp:ListBox ID="dlbGeneric" SelectionMode="Multiple" ClientIDMode="Static" runat="server">
</asp:ListBox>
<asp:HiddenField ID="hfSelectedValues" ClientIDMode="Static"  runat="server" />
<asp:HiddenField ID="hfselectedListLabel" ClientIDMode="Static" runat="server" Value="Selected options" />
<asp:HiddenField ID="hfnonSelectedListLabel" ClientIDMode="Static" runat="server" Value="Available options"/>
</div>