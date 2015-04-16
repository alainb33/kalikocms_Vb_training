Imports KalikoCMS.PropertyType
Imports KalikoCMS.Core

Public Class RoleSelectorPropertyEditor
    Inherits PropertyEditorBase

    Private restrictlist As New List(Of String)



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim RoleManager = KalikoCMS.Identity.IdentityRoleManager.GetManager
        chkRoles.Items.Clear()

        For Each role In RoleManager.Roles            

            Dim newitem As New ListItem
            newitem.Value = role.Name
            newitem.Text = role.Name
            If restrictlist.Contains(role.Name) Then
                newitem.Selected = True
            End If
            chkRoles.Items.Add(newitem)

        Next


    End Sub

    Public Overrides WriteOnly Property Parameters As String
        Set(value As String)
            Throw New System.NotImplementedException()
        End Set
    End Property

    Public Overrides WriteOnly Property PropertyLabel As String
        Set(value As String)

        End Set
    End Property

    Public Overrides Property PropertyValue As PropertyData
        Get
            UpdateRestricList()

            Dim prop = New RoleSelectorProperty
            prop.restrictview = chkrestrict.Checked
            prop.Restrictedlist = restrictlist

            Return prop
        End Get
        Set(value As PropertyData)
            Dim prop = CType(value, RoleSelectorProperty)
            chkrestrict.Checked = prop.restrictview
            restrictlist = prop.Restrictedlist

        End Set
    End Property

    Private Sub UpdateRestricList()
        restrictlist.Clear()
        For Each item As ListItem In chkRoles.Items
            If item.Selected Then
                restrictlist.Add(item.Value)
            End If
        Next

    End Sub

    Public Overloads Overrides Function Validate() As Boolean
        Return True
    End Function

    Public Overloads Overrides Function Validate(required As Boolean) As Boolean
        Return True
    End Function
End Class