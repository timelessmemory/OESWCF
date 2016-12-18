using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OesUI.Custom
{
    public partial class CustomTipDialog : UserControl
    {
        public CustomTipDialog()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
