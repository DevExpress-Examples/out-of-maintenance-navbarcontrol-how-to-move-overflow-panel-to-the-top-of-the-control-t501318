using System.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace DXApplication99
{
    class SkinNavigationPaneViewInfoEx : SkinNavigationPaneViewInfo {
        public SkinNavigationPaneViewInfoEx(NavBarControl navBar) : base(navBar) {
        }

        protected override Rectangle CalcClientRectangle(Rectangle bounds) {
            Rectangle rect = base.CalcClientRectangle(bounds);
            int i = CalcOverflowPanelInfo(this.Bounds).Bounds.Height;
            rect = new Rectangle(0, i, rect.Width, rect.Height - i);
            return rect;
        }


        protected override int CalcGroupsViewInfo(Rectangle bounds) {
            Groups.Clear();
            NavBarGroup expandedGroup = GetExpandedGroup();
            int bottom = bounds.Top;
            int minOverflowHeight = CalcOverflowAndSplitterHeight();
            if (bounds.Height + 20 > minOverflowHeight) {
                bounds.Height -= 10;
            } else {
                minOverflowHeight = 0;
            }
            NavGroupInfoArgs expandedInfo = null;
            if (expandedGroup != null) {
                bottom = CalcExpandedGroupInfo(bounds, expandedGroup);
                expandedInfo = GetGroupInfo(expandedGroup);
                CalcButtonPositions(expandedInfo, false);
            }
            bounds.Height += minOverflowHeight;
            if (bottom == 0 || bottom > bounds.Bottom) {
                CalcButtonPositions(expandedInfo, true);
                return 0;
            }
            Rectangle groupBounds = new Rectangle(bounds.X, bottom, bounds.Width, bounds.Bottom - bottom);
            bottom = CalcSplitterInfo(new Rectangle(groupBounds.X, groupBounds.Y, groupBounds.Width, groupBounds.Height));
            if (bottom == 0) return 0;
            groupBounds = new Rectangle(bounds.X, bottom, bounds.Width, bounds.Bottom - bottom);
            CalcNavGroupsViewInfo(bounds, groupBounds, expandedGroup);
            CreateOverflowGroupsList();
            if (expandedGroup != null) {
                int deltaIndex = CalcDeltaLinksTopVisibleIndex(expandedInfo);
                expandedGroup.TopVisibleLinkIndex -= deltaIndex;
            }
            CalcButtonPositions(expandedInfo, true);
            UpdateGroupPaintIndexes();
            return 0;
        }
        protected override void CalcNavGroupsViewInfo(Rectangle bounds, Rectangle groupBounds, NavBarGroup expandedGroup) {
            base.CalcNavGroupsViewInfo(bounds, groupBounds, expandedGroup);
            OverflowInfo.Bounds = new Rectangle(0, 0, OverflowInfo.Bounds.Width, OverflowInfo.Bounds.Height);
        }


        protected override NavigationPaneOverflowPanelPainter CreateNavPaneOverflowPanelPainter() {
            return new SkinNavigationPaneOverflowPanelPainterEx(NavBar);
        }

    }
}