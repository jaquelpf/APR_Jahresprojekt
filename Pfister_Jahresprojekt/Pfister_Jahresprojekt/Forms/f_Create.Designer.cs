namespace Pfister_Jahresprojekt
{
    partial class f_Create
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbWhatToCreate = new System.Windows.Forms.ComboBox();
            this.lblWhatToCreate = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.cbWhatToCreate);
            this.panel1.Controls.Add(this.lblWhatToCreate);
            this.panel1.Controls.Add(this.lblCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 144);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(957, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbWhatToCreate
            // 
            this.cbWhatToCreate.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbWhatToCreate.FormattingEnabled = true;
            this.cbWhatToCreate.Items.AddRange(new object[] {
            "Character",
            "Organization",
            "Country"});
            this.cbWhatToCreate.Location = new System.Drawing.Point(715, 93);
            this.cbWhatToCreate.Name = "cbWhatToCreate";
            this.cbWhatToCreate.Size = new System.Drawing.Size(237, 29);
            this.cbWhatToCreate.TabIndex = 2;
            // 
            // lblWhatToCreate
            // 
            this.lblWhatToCreate.AutoSize = true;
            this.lblWhatToCreate.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhatToCreate.ForeColor = System.Drawing.Color.White;
            this.lblWhatToCreate.Location = new System.Drawing.Point(458, 98);
            this.lblWhatToCreate.Name = "lblWhatToCreate";
            this.lblWhatToCreate.Size = new System.Drawing.Size(251, 25);
            this.lblWhatToCreate.TabIndex = 1;
            this.lblWhatToCreate.Text = "What do you want to create?";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Franklin Gothic Book", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.ForeColor = System.Drawing.Color.White;
            this.lblCreate.Location = new System.Drawing.Point(94, 68);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(152, 54);
            this.lblCreate.TabIndex = 0;
            this.lblCreate.Text = "Create";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.btnSave.Location = new System.Drawing.Point(829, 680);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(688, 680);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // f_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 733);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "f_Create";
            this.Text = "Create";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cbWhatToCreate;
        private Label lblWhatToCreate;
        private Label lblCreate;
        private Button btnSave;
        private Button btnBack;
        private Button btnStart;
    }
}