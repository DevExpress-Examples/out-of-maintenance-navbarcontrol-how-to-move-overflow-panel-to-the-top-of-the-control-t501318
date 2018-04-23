Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace DXApplication99

    Public Class CustomViewInfoRegistrator
        Inherits SkinNavigationPaneViewInfoRegistrator

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyView"
            End Get
        End Property

        Public Overrides Function CreateViewInfo(ByVal navBar As NavBarControl) As NavBarViewInfo
            Dim info = New SkinNavigationPaneViewInfoEx(navBar)
            Return info
        End Function
    End Class
End Namespace