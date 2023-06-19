namespace Pfister_Jahresprojekt
{
    partial class f_MainPage
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
            this.components = new System.ComponentModel.Container();
            this.flp_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.pl_HomeButton = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbSidebar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnStory = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLastCharacter = new System.Windows.Forms.Label();
            this.lblLastCharNameFill = new System.Windows.Forms.Label();
            this.lblLastCharAgeFill = new System.Windows.Forms.Label();
            this.lblLastCharGenderFill = new System.Windows.Forms.Label();
            this.flp_Main.SuspendLayout();
            this.pl_HomeButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_Main
            // 
            this.flp_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flp_Main.Controls.Add(this.pl_HomeButton);
            this.flp_Main.Controls.Add(this.panel2);
            this.flp_Main.Controls.Add(this.panel3);
            this.flp_Main.Controls.Add(this.panel4);
            this.flp_Main.Controls.Add(this.btnStory);
            this.flp_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_Main.Location = new System.Drawing.Point(2, 0);
            this.flp_Main.MaximumSize = new System.Drawing.Size(247, 616);
            this.flp_Main.MinimumSize = new System.Drawing.Size(90, 616);
            this.flp_Main.Name = "flp_Main";
            this.flp_Main.Size = new System.Drawing.Size(247, 616);
            this.flp_Main.TabIndex = 0;
            // 
            // pl_HomeButton
            // 
            this.pl_HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.pl_HomeButton.Controls.Add(this.lblMenu);
            this.pl_HomeButton.Controls.Add(this.pbSidebar);
            this.pl_HomeButton.Location = new System.Drawing.Point(3, 3);
            this.pl_HomeButton.Name = "pl_HomeButton";
            this.pl_HomeButton.Size = new System.Drawing.Size(247, 124);
            this.pl_HomeButton.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(96, 52);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(60, 25);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            // 
            // pbSidebar
            // 
            this.pbSidebar.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_sidebar1;
            this.pbSidebar.Location = new System.Drawing.Point(3, 35);
            this.pbSidebar.Name = "pbSidebar";
            this.pbSidebar.Size = new System.Drawing.Size(87, 92);
            this.pbSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSidebar.TabIndex = 0;
            this.pbSidebar.TabStop = false;
            this.pbSidebar.Click += new System.EventHandler(this.pbSidebar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_Create);
            this.panel2.Location = new System.Drawing.Point(3, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 67);
            this.panel2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_Home1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 133);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(273, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "                   Home";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_Home1;
            this.btn_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create.Location = new System.Drawing.Point(-11, 3);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_Create.Size = new System.Drawing.Size(273, 76);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "                   Create";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Location = new System.Drawing.Point(3, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 67);
            this.panel3.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_Home1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 133);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(273, 76);
            this.button6.TabIndex = 3;
            this.button6.Text = "                   Home";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_Characters;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-11, 3);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(273, 76);
            this.button7.TabIndex = 2;
            this.button7.Text = "                   Edit";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.btnMap);
            this.panel4.Location = new System.Drawing.Point(3, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 67);
            this.panel4.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_Home1;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 133);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(273, 76);
            this.button8.TabIndex = 3;
            this.button8.Text = "                   Home";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Transparent;
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMap.ForeColor = System.Drawing.Color.White;
            this.btnMap.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_map;
            this.btnMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMap.Location = new System.Drawing.Point(-11, 3);
            this.btnMap.Name = "btnMap";
            this.btnMap.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMap.Size = new System.Drawing.Size(273, 76);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "                   Show";
            this.btnMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnStory
            // 
            this.btnStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStory.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStory.ForeColor = System.Drawing.Color.White;
            this.btnStory.Image = global::Pfister_Jahresprojekt.Properties.Resources.pic_story;
            this.btnStory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStory.Location = new System.Drawing.Point(3, 352);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(273, 76);
            this.btnStory.TabIndex = 4;
            this.btnStory.Text = "                   Story";
            this.btnStory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStory.UseVisualStyleBackColor = false;
            this.btnStory.Click += new System.EventHandler(this.btnStory_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(832, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(207, 45);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLastCharacter
            // 
            this.lblLastCharacter.AutoSize = true;
            this.lblLastCharacter.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastCharacter.Location = new System.Drawing.Point(282, 80);
            this.lblLastCharacter.Name = "lblLastCharacter";
            this.lblLastCharacter.Size = new System.Drawing.Size(211, 38);
            this.lblLastCharacter.TabIndex = 8;
            this.lblLastCharacter.Text = "Last Character:";
            // 
            // lblLastCharNameFill
            // 
            this.lblLastCharNameFill.AutoSize = true;
            this.lblLastCharNameFill.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastCharNameFill.Location = new System.Drawing.Point(417, 132);
            this.lblLastCharNameFill.Name = "lblLastCharNameFill";
            this.lblLastCharNameFill.Size = new System.Drawing.Size(0, 20);
            this.lblLastCharNameFill.TabIndex = 24;
            // 
            // lblLastCharAgeFill
            // 
            this.lblLastCharAgeFill.AutoSize = true;
            this.lblLastCharAgeFill.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastCharAgeFill.Location = new System.Drawing.Point(417, 172);
            this.lblLastCharAgeFill.Name = "lblLastCharAgeFill";
            this.lblLastCharAgeFill.Size = new System.Drawing.Size(0, 20);
            this.lblLastCharAgeFill.TabIndex = 29;
            // 
            // lblLastCharGenderFill
            // 
            this.lblLastCharGenderFill.AutoSize = true;
            this.lblLastCharGenderFill.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastCharGenderFill.Location = new System.Drawing.Point(417, 152);
            this.lblLastCharGenderFill.Name = "lblLastCharGenderFill";
            this.lblLastCharGenderFill.Size = new System.Drawing.Size(0, 20);
            this.lblLastCharGenderFill.TabIndex = 30;
            // 
            // f_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 616);
            this.Controls.Add(this.lblLastCharGenderFill);
            this.Controls.Add(this.lblLastCharAgeFill);
            this.Controls.Add(this.lblLastCharNameFill);
            this.Controls.Add(this.lblLastCharacter);
            this.Controls.Add(this.flp_Main);
            this.Controls.Add(this.btnRegister);
            this.Name = "f_MainPage";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Text = "Mainpage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_MainPage_FormClosing);
            this.Load += new System.EventHandler(this.f_MainPage_Load);
            this.flp_Main.ResumeLayout(false);
            this.pl_HomeButton.ResumeLayout(false);
            this.pl_HomeButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flp_Main;
        private Panel pl_HomeButton;
        private Panel panel2;
        private Button button4;
        private Button btn_Create;
        private Panel panel3;
        private Button button6;
        private Button button7;
        private Panel panel4;
        private Button button8;
        private Button btnMap;
        private PictureBox pbSidebar;
        private Label lblMenu;
        private System.Windows.Forms.Timer SidebarTimer;
        private Button btnStory;
        private Button btnRegister;
        private Label lblLastCharacter;
        private Label lblLastCharNameFill;
        private Label lblLastCharAgeFill;
        private Label lblLastCharGenderFill;
    }
}