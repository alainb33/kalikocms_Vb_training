
Imports KalikoCMS.Attributes
Imports KalikoCMS.Core
Imports KalikoCMS.Serialization

<PropertyType("9033A828-B49A-4A19-9C20-0F9BEBBD3293", "Role", "Role", "~/PropertyTypes/RoleSelectorPropertyEditor.ascx")> _
Public Class RoleSelectorProperty
    Inherits PropertyData

    Private _cachedHashCode As System.Nullable(Of Integer)

    Protected Overrides Function DeserializeFromJson(data As String) As PropertyData
        Return JsonSerialization.DeserializeJson(Of RoleSelectorProperty)(data)
    End Function

    Public restrictview As Boolean

    Public Restrictedlist As New List(Of String)


    Public Sub New()

    End Sub


    Public Sub New(_restrictview As Boolean, _Restrictedlist As List(Of String))
        restrictview = _restrictview
        Restrictedlist = _Restrictedlist

    End Sub



    Public Overrides Function GetHashCode() As Integer
        If _cachedHashCode Is Nothing Then
            _cachedHashCode = CalculateHashCode()
        End If
        Return _cachedHashCode
    End Function

    Private Function CalculateHashCode() As Integer
        Dim hash As Integer = JsonSerialization.GetNewHash
        hash = JsonSerialization.CombineHashCode(hash, restrictview)
        hash = JsonSerialization.CombineHashCode(hash, Restrictedlist)

        Return hash

    End Function
    Protected Overrides ReadOnly Property StringValue As String
        Get
            Return String.Join(",", Restrictedlist)
        End Get
    End Property


End Class
