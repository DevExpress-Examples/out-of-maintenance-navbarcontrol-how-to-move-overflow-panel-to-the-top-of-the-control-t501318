Namespace DXApplication99
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
            DirectCast(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup1
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6})
            Me.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
            Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 140
            Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.navBarControl1.Size = New System.Drawing.Size(140, 240)
            Me.navBarControl1.TabIndex = 0
            Me.navBarControl1.Text = "navBarControl1"
            ' 
            ' navBarGroup1
            ' 
            Me.navBarGroup1.Appearance.ForeColor = System.Drawing.Color.Yellow
            Me.navBarGroup1.Appearance.Options.UseForeColor = True
            Me.navBarGroup1.Caption = "navBarGroup1"
            Me.navBarGroup1.Expanded = True
            Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2) _
            })
            Me.navBarGroup1.Name = "navBarGroup1"
            Me.navBarGroup1.SelectedLinkIndex = 0
            ' 
            ' navBarItem1
            ' 
            Me.navBarItem1.Caption = "navBarItem1"
            Me.navBarItem1.Name = "navBarItem1"
            ' 
            ' navBarItem2
            ' 
            Me.navBarItem2.Caption = "navBarItem2"
            Me.navBarItem2.Name = "navBarItem2"
            ' 
            ' navBarGroup2
            ' 
            Me.navBarGroup2.Caption = "navBarGroup2"
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4) _
            })
            Me.navBarGroup2.Name = "navBarGroup2"
            ' 
            ' navBarItem3
            ' 
            Me.navBarItem3.Caption = "navBarItem3"
            Me.navBarItem3.Name = "navBarItem3"
            ' 
            ' navBarItem4
            ' 
            Me.navBarItem4.Caption = "navBarItem4"
            Me.navBarItem4.Name = "navBarItem4"
            ' 
            ' navBarGroup3
            ' 
            Me.navBarGroup3.Caption = "navBarGroup3"
            Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6) _
            })
            Me.navBarGroup3.Name = "navBarGroup3"
            ' 
            ' navBarItem5
            ' 
            Me.navBarItem5.Caption = "navBarItem5"
            Me.navBarItem5.Name = "navBarItem5"
            ' 
            ' navBarItem6
            ' 
            Me.navBarItem6.Caption = "navBarItem6"
            Me.navBarItem6.Name = "navBarItem6"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(374, 240)
            Me.Controls.Add(Me.navBarControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
        Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
        Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
        Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
        Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
        Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
        Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
        Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
        Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
        Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
    End Class
End Namespace

