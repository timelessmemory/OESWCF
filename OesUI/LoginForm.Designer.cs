namespace OesUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSystemLogo = new System.Windows.Forms.Label();
            this.ckxRemember = new System.Windows.Forms.CheckBox();
            this.lblForgetPass = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblPasswordIcon = new System.Windows.Forms.Label();
            this.lblUsernameDiv = new System.Windows.Forms.Label();
            this.lblPasswordDiv = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblUsernameErrorMessage = new System.Windows.Forms.Label();
            this.lblPassErrorMessage = new System.Windows.Forms.Label();
            this.pcTitle = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(153)))), ((int)(((byte)(1)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(200, 280);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 35);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.CausesValidation = false;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 10.5F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtUsername.Location = new System.Drawing.Point(250, 180);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 17);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.userName_Enter);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.userName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CausesValidation = false;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.txtPassword.Location = new System.Drawing.Point(250, 235);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 17);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.password_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.password_Validating);
            // 
            // lblSystemLogo
            // 
            this.lblSystemLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblSystemLogo.Image")));
            this.lblSystemLogo.Location = new System.Drawing.Point(200, 80);
            this.lblSystemLogo.Name = "lblSystemLogo";
            this.lblSystemLogo.Size = new System.Drawing.Size(300, 40);
            this.lblSystemLogo.TabIndex = 1;
            // 
            // ckxRemember
            // 
            this.ckxRemember.AutoSize = true;
            this.ckxRemember.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckxRemember.ForeColor = System.Drawing.Color.White;
            this.ckxRemember.Location = new System.Drawing.Point(199, 335);
            this.ckxRemember.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ckxRemember.Name = "ckxRemember";
            this.ckxRemember.Size = new System.Drawing.Size(110, 19);
            this.ckxRemember.TabIndex = 3;
            this.ckxRemember.TabStop = false;
            this.ckxRemember.Text = "Remember me";
            this.ckxRemember.UseVisualStyleBackColor = true;
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.AutoSize = true;
            this.lblForgetPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPass.ForeColor = System.Drawing.Color.White;
            this.lblForgetPass.Location = new System.Drawing.Point(399, 335);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(107, 15);
            this.lblForgetPass.TabIndex = 5;
            this.lblForgetPass.Text = "Forget password?";
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.BackColor = System.Drawing.Color.White;
            this.lblUserIcon.ForeColor = System.Drawing.Color.White;
            this.lblUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblUserIcon.Image")));
            this.lblUserIcon.Location = new System.Drawing.Point(220, 178);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(20, 20);
            this.lblUserIcon.TabIndex = 6;
            // 
            // lblPasswordIcon
            // 
            this.lblPasswordIcon.BackColor = System.Drawing.Color.White;
            this.lblPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordIcon.Image")));
            this.lblPasswordIcon.Location = new System.Drawing.Point(221, 233);
            this.lblPasswordIcon.Name = "lblPasswordIcon";
            this.lblPasswordIcon.Size = new System.Drawing.Size(20, 20);
            this.lblPasswordIcon.TabIndex = 7;
            // 
            // lblUsernameDiv
            // 
            this.lblUsernameDiv.BackColor = System.Drawing.Color.White;
            this.lblUsernameDiv.Location = new System.Drawing.Point(200, 170);
            this.lblUsernameDiv.Name = "lblUsernameDiv";
            this.lblUsernameDiv.Size = new System.Drawing.Size(300, 35);
            this.lblUsernameDiv.TabIndex = 8;
            // 
            // lblPasswordDiv
            // 
            this.lblPasswordDiv.BackColor = System.Drawing.Color.White;
            this.lblPasswordDiv.Location = new System.Drawing.Point(200, 225);
            this.lblPasswordDiv.Name = "lblPasswordDiv";
            this.lblPasswordDiv.Size = new System.Drawing.Size(300, 35);
            this.lblPasswordDiv.TabIndex = 9;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(203)))), ((int)(((byte)(155)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(199, 142);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(300, 20);
            this.lblErrorMessage.TabIndex = 10;
            this.lblErrorMessage.Text = "Username does\'t exist!";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Visible = false;
            // 
            // lblUsernameErrorMessage
            // 
            this.lblUsernameErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblUsernameErrorMessage.Image")));
            this.lblUsernameErrorMessage.Location = new System.Drawing.Point(506, 178);
            this.lblUsernameErrorMessage.Name = "lblUsernameErrorMessage";
            this.lblUsernameErrorMessage.Size = new System.Drawing.Size(20, 20);
            this.lblUsernameErrorMessage.TabIndex = 11;
            this.lblUsernameErrorMessage.Visible = false;
            // 
            // lblPassErrorMessage
            // 
            this.lblPassErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblPassErrorMessage.Image")));
            this.lblPassErrorMessage.Location = new System.Drawing.Point(506, 235);
            this.lblPassErrorMessage.Name = "lblPassErrorMessage";
            this.lblPassErrorMessage.Size = new System.Drawing.Size(20, 20);
            this.lblPassErrorMessage.TabIndex = 12;
            this.lblPassErrorMessage.Visible = false;
            // 
            // pcTitle
            // 
            this.pcTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcTitle.BackgroundImage")));
            this.pcTitle.Image = ((System.Drawing.Image)(resources.GetObject("pcTitle.Image")));
            this.pcTitle.Location = new System.Drawing.Point(0, -1);
            this.pcTitle.Name = "pcTitle";
            this.pcTitle.Size = new System.Drawing.Size(700, 30);
            this.pcTitle.TabIndex = 13;
            this.pcTitle.TabStop = false;
            this.pcTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcTitle_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(658, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 20);
            this.lblClose.TabIndex = 14;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pcTitle);
            this.Controls.Add(this.lblPassErrorMessage);
            this.Controls.Add(this.lblUsernameErrorMessage);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPasswordIcon);
            this.Controls.Add(this.lblPasswordDiv);
            this.Controls.Add(this.lblUserIcon);
            this.Controls.Add(this.lblUsernameDiv);
            this.Controls.Add(this.lblForgetPass);
            this.Controls.Add(this.ckxRemember);
            this.Controls.Add(this.lblSystemLogo);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Augmemtum";
            ((System.ComponentModel.ISupportInitialize)(this.pcTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblForgetPass;
        private System.Windows.Forms.CheckBox ckxRemember;
        private System.Windows.Forms.Label lblSystemLogo;
        private System.Windows.Forms.Label lblPasswordDiv;
        private System.Windows.Forms.Label lblUsernameDiv;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblUsernameErrorMessage;
        private System.Windows.Forms.Label lblPassErrorMessage;
        private System.Windows.Forms.PictureBox pcTitle;
        private System.Windows.Forms.Label lblClose;
    }
}