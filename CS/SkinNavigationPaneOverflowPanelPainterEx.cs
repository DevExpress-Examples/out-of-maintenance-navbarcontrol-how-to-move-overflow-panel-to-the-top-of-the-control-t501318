using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace DXApplication99
{
    class SkinNavigationPaneOverflowPanelPainterEx : SkinNavigationPaneOverflowPanelPainter {
        public SkinNavigationPaneOverflowPanelPainterEx(NavBarControl navBar) : base(navBar) {

        }
        public override void DrawObject(ObjectInfoArgs e) {
            RectangleF clipRect = e.Graphics.ClipBounds;
            e.Graphics.ResetClip();
            base.DrawObject(e);
            e.Graphics.SetClip(clipRect);
        }
    }
}