Namespace DXApplication99
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Dim viewInfoRegistrator As New CustomViewInfoRegistrator()
            navBarControl1.View = viewInfoRegistrator
        End Sub
    End Class
End Namespace
