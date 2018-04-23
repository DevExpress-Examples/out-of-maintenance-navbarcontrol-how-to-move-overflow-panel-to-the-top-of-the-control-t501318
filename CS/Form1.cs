namespace DXApplication99 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            CustomViewInfoRegistrator viewInfoRegistrator = new CustomViewInfoRegistrator();
            navBarControl1.View = viewInfoRegistrator;
        }
    }
}
