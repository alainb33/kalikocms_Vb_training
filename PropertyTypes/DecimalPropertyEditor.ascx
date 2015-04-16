<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="DecimalPropertyEditor.ascx.vb" Inherits="kalikotest1.DecimalPropertyEditor" %>
<div class="form-group">
    <asp:Label AssociatedControlID="ValueField" runat="server" ID="LabelText" Text="Number" CssClass="control-label col-xs-2" />
    <div class="controls col-xs-4">
        <asp:TextBox runat="server" CssClass="form-control" ID="ValueField" />
        <asp:Literal ID="ErrorText" runat="server" />
    </div>
</div>