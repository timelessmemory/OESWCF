using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OesUI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void lblShowDialog_Click(object sender, EventArgs e)
        {
            //this.customTipDialog.Visible = true;
        }

        private void lblhidedialog_Click(object sender, EventArgs e)
        {
            //this.customTipDialog.Hide();
        }
    }
}
