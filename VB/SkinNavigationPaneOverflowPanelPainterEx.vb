Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace DXApplication99
    Friend Class SkinNavigationPaneOverflowPanelPainterEx
        Inherits SkinNavigationPaneOverflowPanelPainter

        Public Sub New(ByVal navBar As NavBarControl)
            MyBase.New(navBar)

        End Sub
        Public Overrides Sub DrawObject(ByVal e As ObjectInfoArgs)
            Dim clipRect As RectangleF = e.Graphics.ClipBounds
            e.Graphics.ResetClip()
            MyBase.DrawObject(e)
            e.Graphics.SetClip(clipRect)
        End Sub
    End Class
End Namespace