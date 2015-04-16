Imports KalikoCMS.Core
Imports KalikoCMS

Public Class customBoot
    Implements IStartupSequence


    Public Sub Startup() Implements IStartupSequence.Startup
        Dashboard.RegisterArea(New customDashboard)

    End Sub

    Public ReadOnly Property StartupOrder As Integer Implements IStartupSequence.StartupOrder
        Get
            Return 100
        End Get
    End Property
End Class
