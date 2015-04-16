Imports KalikoCMS.Admin.Templates.MasterPages

Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' set here the title of the page
        DirectCast(MyBase.Master, Admin).ActiveArea = "Custom Dashboard"
    End Sub

End Class