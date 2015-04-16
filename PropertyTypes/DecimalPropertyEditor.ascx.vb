Imports KalikoCMS.Core
Imports KalikoCMS.PropertyType
Imports System
Imports System.Globalization
Imports System.Web.UI.WebControls

Public Class DecimalPropertyEditor
    Inherits PropertyEditorBase




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Overrides WriteOnly Property Parameters As String
        Set(value As String)

        End Set
    End Property

    Public Overrides WriteOnly Property PropertyLabel As String
        Set(value As String)
            Me.LabelText.Text = value
        End Set
    End Property

    Public Overrides Property PropertyValue As PropertyData
        Get
            Return New DecimalPropertyType(Me.ValueField.Text)
        End Get

        Set(value As PropertyData)
            Dim DecimalProperty As DecimalPropertyType = DirectCast(value, DecimalPropertyType)
            If (DecimalProperty.ValueSet) Then
                Me.ValueField.Text = DecimalProperty.Value.ToString(CultureInfo.InvariantCulture)
            End If
        End Set
    
    End Property

    Public Overloads Overrides Function Validate() As Boolean
        Dim num As Decimal
        Dim text As String = Me.ValueField.Text
        If (Not String.IsNullOrEmpty(text) AndAlso Not Decimal.TryParse(text, num)) Then
            Return False
        End If
        Return True
    End Function

    Public Overloads Overrides Function Validate(required As Boolean) As Boolean
        Dim num As Decimal
        If (Decimal.TryParse(Me.ValueField.Text, num)) Then
            Return True
        End If
        Return False
    End Function
End Class