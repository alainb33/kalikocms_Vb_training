Imports Kaliko
Imports KalikoCMS
Imports KalikoCMS.Core
Imports System
Imports System.Web
Imports KalikoCMS.WebForms.Framework

Public MustInherit Class PageTemplate_WithSecurity(Of T As CmsPage)
    Inherits PageTemplate(Of T)

    Private Property CurrentRoleSelector As RoleSelectorProperty


    Private Sub Page_PreLoad(sender As Object, e As EventArgs) Handles Me.PreLoad
        CurrentRoleSelector = Me.CurrentPage.Property("Role")
        HandleSecurity()
    End Sub

    Friend Property LoginUrl As String = "~/login.aspx"
    Friend Property ForbiddenUrl As String = "~/forbidden.aspx"


    Private Sub HandleSecurity()
        If CurrentRoleSelector Is Nothing Then
            Throw New Exception("Role selector is not defined !")
        Else
            Dim isRestricted As Boolean = CurrentRoleSelector.restrictview
            Dim rolelist As List(Of String) = CurrentRoleSelector.Restrictedlist

            If isRestricted = True Then
                If Context.User.Identity.IsAuthenticated = False Then
                    Response.Redirect(LoginUrl & "?ReturnUrl=" & CurrentPage.PageUrl.ToString)

                Else
                    Dim isAllowed As Boolean = False
                    For Each item In rolelist
                        Dim tmpresult = Context.User.IsInRole(item)
                        If tmpresult = True Then
                            isAllowed = True
                        End If
                    Next
                    If isAllowed = False Then
                        'System.Web.Security.Roles
                        Response.Redirect(ForbiddenUrl)
                    End If
                End If

            End If
        End If

    End Sub

End Class
