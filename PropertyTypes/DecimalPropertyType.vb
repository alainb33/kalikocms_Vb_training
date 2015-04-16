Imports KalikoCMS.Attributes
Imports KalikoCMS.Core
Imports System.Globalization
Imports KalikoCMS.Serialization

<PropertyType("9033A828-B49A-4A19-1234-0F9BEBBD3270", "Decimal", "Decimal", "~/PropertyTypes/DecimalPropertyEditor.ascx")> _
Public Class DecimalPropertyType
    Inherits PropertyData

    '   Private _cachedHashCode As Nullable(Of Integer)

    Public Property ValueSet As Boolean

    Private _value As Decimal
    Public Property Value As Decimal
        Get
            Return Me._value
        End Get
        Set(ByVal value As Decimal)
            Me._value = value
            Me.ValueSet = True
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal value As Decimal)
        MyBase.New()
        Me.Value = value
    End Sub

    Public Sub New(ByVal value As String)
        MyBase.New()
        Dim num As Decimal
        If (Decimal.TryParse(value, num)) Then
            Me.Value = num
        End If
    End Sub


    Protected Overrides Function DeserializeFromJson(data As String) As PropertyData
        Return JsonSerialization.DeserializeJson(Of DecimalPropertyType)(data)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Me.Value.GetHashCode()
    End Function

    Protected Overrides ReadOnly Property StringValue As String
        Get
            Return Me._value.ToString(CultureInfo.InvariantCulture)
        End Get
    End Property
End Class
