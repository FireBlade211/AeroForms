using System;
using System.Windows.Forms;

namespace AeroForms_Showcase {

    public partial class ControlPanel : FireBlade.AeroForms.AeroForm {

        public ControlPanel() {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

    }

}
