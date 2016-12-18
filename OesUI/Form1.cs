using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesLogic;
using OesUI.Custom;
using System.Runtime.InteropServices;

namespace OesUI
{
    public partial class FormExamList : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public FormExamList()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            this.lblHome.BackColor = Color.FromArgb(210, 218, 227);
            this.lblMyExam.BackColor = Color.White;
            this.pnlHome.Visible = true;
            this.pnlMyExam.Visible = false;
        }

        private void lblMyExam_Click(object sender, EventArgs e)
        {
            this.lblMyExam.BackColor = Color.FromArgb(210, 218, 227);
            this.lblHome.BackColor = Color.White;
            this.pnlMyExam.Visible = true;
            this.pnlHome.Visible = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        //private void lblmax_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }
        //    else
        //    {
        //        this.WindowState = FormWindowState.Maximized;
        //    }
        //}
    }
}
