Imports System.Drawing
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Namespace DXApplication99
    Friend Class SkinNavigationPaneViewInfoEx
        Inherits SkinNavigationPaneViewInfo

        Public Sub New(ByVal navBar As NavBarControl)
            MyBase.New(navBar)
        End Sub

        Protected Overrides Function CalcClientRectangle(ByVal bounds As Rectangle) As Rectangle
            Dim rect As Rectangle = MyBase.CalcClientRectangle(bounds)
            Dim i As Integer = CalcOverflowPanelInfo(Me.Bounds).Bounds.Height
            rect = New Rectangle(0, i, rect.Width, rect.Height - i)
            Return rect
        End Function


        Protected Overrides Function CalcGroupsViewInfo(ByVal bounds As Rectangle) As Integer
            Groups.Clear()
            Dim expandedGroup As NavBarGroup = GetExpandedGroup()
            Dim bottom As Integer = bounds.Top
            Dim minOverflowHeight As Integer = CalcOverflowAndSplitterHeight()
            If bounds.Height + 20 > minOverflowHeight Then
                bounds.Height -= 10
            Else
                minOverflowHeight = 0
            End If
            Dim expandedInfo As NavGroupInfoArgs = Nothing
            If expandedGroup IsNot Nothing Then
                bottom = CalcExpandedGroupInfo(bounds, expandedGroup)
                expandedInfo = GetGroupInfo(expandedGroup)
                CalcButtonPositions(expandedInfo, False)
            End If
            bounds.Height += minOverflowHeight
            If bottom = 0 OrElse bottom > bounds.Bottom Then
                CalcButtonPositions(expandedInfo, True)
                Return 0
            End If
            Dim groupBounds As New Rectangle(bounds.X, bottom, bounds.Width, bounds.Bottom - bottom)
            bottom = CalcSplitterInfo(New Rectangle(groupBounds.X, groupBounds.Y, groupBounds.Width, groupBounds.Height))
            If bottom = 0 Then
                Return 0
            End If
            groupBounds = New Rectangle(bounds.X, bottom, bounds.Width, bounds.Bottom - bottom)
            CalcNavGroupsViewInfo(bounds, groupBounds, expandedGroup)
            CreateOverflowGroupsList()
            If expandedGroup IsNot Nothing Then
                Dim deltaIndex As Integer = CalcDeltaLinksTopVisibleIndex(expandedInfo)
                expandedGroup.TopVisibleLinkIndex -= deltaIndex
            End If
            CalcButtonPositions(expandedInfo, True)
            UpdateGroupPaintIndexes()
            Return 0
        End Function
        Protected Overrides Sub CalcNavGroupsViewInfo(ByVal bounds As Rectangle, ByVal groupBounds As Rectangle, ByVal expandedGroup As NavBarGroup)
            MyBase.CalcNavGroupsViewInfo(bounds, groupBounds, expandedGroup)
            OverflowInfo.Bounds = New Rectangle(0, 0, OverflowInfo.Bounds.Width, OverflowInfo.Bounds.Height)
        End Sub


        Protected Overrides Function CreateNavPaneOverflowPanelPainter() As NavigationPaneOverflowPanelPainter
            Return New SkinNavigationPaneOverflowPanelPainterEx(NavBar)
        End Function

    End Class
End Namespace