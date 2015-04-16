Imports KalikoCMS

Public Class customDashboard
    Implements IDashboardArea


    Public ReadOnly Property Icon As String Implements IDashboardArea.Icon
        Get
            Return "icon-gears"
        End Get
    End Property

    Public ReadOnly Property MenuName As String Implements IDashboardArea.MenuName
        Get
            Return "CustomDashboard"
        End Get
    End Property

    Public ReadOnly Property Path As String Implements IDashboardArea.Path
        Get
            Return "extensions/customdashboard"
        End Get
    End Property

    Public ReadOnly Property Title As String Implements IDashboardArea.Title
        Get
            Return "Custom Dashboard"
        End Get
    End Property
End Class
