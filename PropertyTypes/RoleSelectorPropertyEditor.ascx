<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="RoleSelectorPropertyEditor.ascx.vb" Inherits="kalikotest1.RoleSelectorPropertyEditor" %>
<fieldset>
    <legend>Security</legend>


    <div class="form-group">

    
            <label for="<%= chkrestrict.ClientID%>"  class="control-label col-xs-2">Restrict view</label>  
        <div Class="controls col-xs-10">
            <div class="checkbox">
                <asp:CheckBox ID="chkrestrict" runat="server" />
                  <asp:Label ID="Label1" AssociatedControlID="chkrestrict" runat="server" />
            </div>
      
        </div>  
        <div class="form-group">
              <label for="<%=chkRoles.ClientID%>" class="control-label col-xs-2">Roles allowed to View</label>
            <div Class="controls col-xs-10">
              
    
                <asp:CheckBoxList ID="chkRoles"  CssClass="form-control"  runat="server" RepeatDirection="Horizontal" CellPadding="4" CellSpacing="4" RepeatColumns="5">
                </asp:CheckBoxList>
            </div>
        </div>
    </div>

</fieldset>