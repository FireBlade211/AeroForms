using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeroForms_Showcase.Properties;
using FireBlade.AeroForms;

namespace WindowsFormsAeroShowcase {

    public partial class Main : FireBlade.AeroForms.AeroForm {

        private Form _thumbnailedWindow = null;

        public Main() {
            InitializeComponent();

            _thumbnailedWindow = new ThumbnailedWindow();
            _thumbnailedWindow.Show(this);
            _thumbnailedWindow.Location = new Point(Location.X + Size.Width, Location.Y);

            thumbnailViewer1.SetThumbnail(_thumbnailedWindow, true);

            ResizeRedraw = true;
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);

            GlassMargins = new Padding(0, themedLabel1.Height, 0, themedLabel2.Height);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            _thumbnailedWindow.Close();
        }

        private void commandLink3_Click(object sender, EventArgs e) {
            ControlPanel cp = new ControlPanel();
            cp.ShowDialog();
            cp.Dispose();
        }

        private void commandLink1_Click(object sender, EventArgs e) {

        }

        private void commandLink4_Click(object sender, EventArgs e) {
            HorizontalPanelExample hp = new HorizontalPanelExample();
            hp.ShowDialog();
            hp.Dispose();
        }

        private async void buttonVDesktop_Click(object sender, EventArgs e) {
            // Some delay to allow users to switch virtual desktop

            buttonVDesktop.Text = "5...";
            await Task.Delay(1000);
            buttonVDesktop.Text = "4...";
            await Task.Delay(1000);
            buttonVDesktop.Text = "3...";
            await Task.Delay(1000);
            buttonVDesktop.Text = "2...";
            await Task.Delay(1000);
            buttonVDesktop.Text = "1...";
            await Task.Delay(1000);

            buttonVDesktop.Text = "Refresh again?";

            labelVDesktopCurrent.Text = (VirtualDesktopManager.IsWindowOnCurrentVirtualDesktop(this)) ?
                "Form is on currently active virtual desktop" :
                "Form is NOT on currently active virtual desktop";

            labelVDesktopId.Text = VirtualDesktopManager.GetWindowDesktopId(this).Id.ToString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawImage(Resources.AeroForms64, 0f, 0f, 56f, 56f);
        }
    }

}
