namespace Pfister_Jahresprojekt
{
    partial class f_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbGuest = new System.Windows.Forms.CheckBox();
            this.btnSeePasswordOne = new System.Windows.Forms.Button();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(192, 150);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(207, 25);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(192, 199);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(207, 25);
            this.tbPassword.TabIndex = 2;
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.pnlLogIn.Controls.Add(this.lblLogIn);
            this.pnlLogIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogIn.Location = new System.Drawing.Point(0, 0);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(453, 100);
            this.pnlLogIn.TabIndex = 3;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Franklin Gothic Book", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogIn.ForeColor = System.Drawing.Color.White;
            this.lblLogIn.Location = new System.Drawing.Point(183, 41);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(102, 43);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(65, 152);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(70, 201);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 23);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(192, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(207, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbGuest
            // 
            this.cbGuest.AutoSize = true;
            this.cbGuest.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGuest.Location = new System.Drawing.Point(36, 289);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(122, 24);
            this.cbGuest.TabIndex = 7;
            this.cbGuest.Text = "Login as guest";
            this.cbGuest.UseVisualStyleBackColor = true;
            this.cbGuest.CheckedChanged += new System.EventHandler(this.cbGuest_CheckedChanged);
            // 
            // btnSeePasswordOne
            // 
            this.btnSeePasswordOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.btnSeePasswordOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeePasswordOne.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeePasswordOne.ForeColor = System.Drawing.Color.White;
            this.btnSeePasswordOne.Location = new System.Drawing.Point(405, 194);
            this.btnSeePasswordOne.Name = "btnSeePasswordOne";
            this.btnSeePasswordOne.Size = new System.Drawing.Size(41, 36);
            this.btnSeePasswordOne.TabIndex = 14;
            this.btnSeePasswordOne.Text = "👁";
            this.btnSeePasswordOne.UseVisualStyleBackColor = false;
            this.btnSeePasswordOne.Click += new System.EventHandler(this.btnSeePasswordOne_Click);
            // 
            // f_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 559);
            this.Controls.Add(this.btnSeePasswordOne);
            this.Controls.Add(this.cbGuest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Name = "f_Login";
            this.Text = "Login";
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Panel pnlLogIn;
        private Label lblLogIn;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private CheckBox cbGuest;
        private Button btnSeePasswordOne;
    }
}