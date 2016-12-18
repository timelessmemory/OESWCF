using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OesLogic;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.ServiceModel;
using OesWCFContract;

namespace OesUI
{
    public partial class LoginForm : Form
    {
        private const string NOT_CORRECT_PASS = "Login password is incorrect!";
        private const string USER_NAME_NOT_EXIST = "Username does't exist!";
        private const string USERNAME = "Username";
        private const string PASSWORD = "Password";
        private const string USE_AND_PASSS_REQ = "Username and login password are required!";
        private const string PASS_REQ = "Login password is required!";
        private const string LINE = "-";
        private const string USER_NAME_REQ = "Username is required!";
        private const char DOT = '●';

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int VM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            CancelEventArgs cea = new CancelEventArgs();
            userName_Validating(sender, cea);
            password_Validating(sender, cea);

            if (cea.Cancel == false)
            {
                UserService.UserServiceClient usermanage = new UserService.UserServiceClient();
                try
                {
                    MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(this.txtPassword.Text);
                    byte[] hashCode = Md5.ComputeHash(passwordBytes);
                    string encryptPassword = BitConverter.ToString(hashCode).Replace(LINE, Constants.emptyStr);
                    bool result = usermanage.VerifyUserLogin(this.txtUsername.Text, encryptPassword);

                    if (result == true)
                    {
                        RememberSomeParameter.username = this.txtUsername.Text;
                        RememberSomeParameter.userId = Convert.ToInt32(usermanage.queryUserIdByName(this.txtUsername.Text));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.lblPassErrorMessage.Visible = true;
                        this.lblErrorMessage.Text = NOT_CORRECT_PASS;
                        this.lblErrorMessage.Visible = true;
                    }
                }
                catch (FaultException<UserNameNotExistent>)
                {
                    this.lblUsernameErrorMessage.Visible = true;
                    this.lblErrorMessage.Text = USER_NAME_NOT_EXIST;
                    this.lblErrorMessage.Visible = true;
                }
                catch (CommunicationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception exx)
                {
                    Console.WriteLine(exx.Message);
                }
            }

        }

        private void userName_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtUsername.Text.Length == 0 || this.txtUsername.Text.Equals(USERNAME))
            {
                this.lblUsernameErrorMessage.Visible = true;
                this.lblErrorMessage.Text = USER_NAME_REQ;
                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPassword.Text.Length == 0 || this.txtPassword.Text.Equals(PASSWORD))
            {
                this.lblPassErrorMessage.Visible = true;
                if (this.lblErrorMessage.Text.Equals(USER_NAME_REQ))
                {
                    this.lblErrorMessage.Text = USE_AND_PASSS_REQ;
                }
                else
                {
                    this.lblErrorMessage.Text = PASS_REQ;
                }

                this.lblErrorMessage.Visible = true;
                e.Cancel = true;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            this.lblPassErrorMessage.Visible = false;
            this.lblErrorMessage.Visible = false;
            this.txtPassword.Text = string.Empty;
            this.txtPassword.PasswordChar = DOT;
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text.Equals(USERNAME))
            {
                this.txtUsername.Text = string.Empty;
            }

            this.lblUsernameErrorMessage.Visible = false;
            this.lblErrorMessage.Visible = false;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                Login_Click(null, null);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, VM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

    }
}
