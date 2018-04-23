using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace DXApplication99
{

    public class CustomViewInfoRegistrator : SkinNavigationPaneViewInfoRegistrator {
        public override string ViewName { get { return "MyView"; } }

        public override NavBarViewInfo CreateViewInfo(NavBarControl navBar) {
            var info = new SkinNavigationPaneViewInfoEx(navBar);
            return info;
        }
    }
}