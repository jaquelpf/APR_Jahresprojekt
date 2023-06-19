namespace Pfister_Jahresprojekt
{
    partial class cbEdit
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
            this.cbWhatToEdit = new System.Windows.Forms.ComboBox();
            this.lblWhatToCreate = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.cbWhatToEdit);
            this.panel1.Controls.Add(this.lblWhatToCreate);
            this.panel1.Controls.Add(this.lblEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 192);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(1094, 120);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbWhatToEdit
            // 
            this.cbWhatToEdit.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbWhatToEdit.FormattingEnabled = true;
            this.cbWhatToEdit.Items.AddRange(new object[] {
            "Characters",
            "Organizations",
            "Country"});
            this.cbWhatToEdit.Location = new System.Drawing.Point(817, 124);
            this.cbWhatToEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWhatToEdit.Name = "cbWhatToEdit";
            this.cbWhatToEdit.Size = new System.Drawing.Size(270, 29);
            this.cbWhatToEdit.TabIndex = 2;
            // 
            // lblWhatToCreate
            // 
            this.lblWhatToCreate.AutoSize = true;
            this.lblWhatToCreate.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhatToCreate.ForeColor = System.Drawing.Color.White;
            this.lblWhatToCreate.Location = new System.Drawing.Point(523, 131);
            this.lblWhatToCreate.Name = "lblWhatToCreate";
            this.lblWhatToCreate.Size = new System.Drawing.Size(230, 25);
            this.lblWhatToCreate.TabIndex = 1;
            this.lblWhatToCreate.Text = "What do you want to edit?";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Franklin Gothic Book", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(96, 99);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(247, 54);
            this.lblEdit.TabIndex = 0;
            this.lblEdit.Text = "Edit/Delete";
            // 
            // cbChoose
            // 
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Location = new System.Drawing.Point(25, 213);
            this.cbChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(258, 28);
            this.cbChoose.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 211);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(290, 211);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 33);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(971, 759);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 55);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(810, 759);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 55);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // cbEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 829);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cbEdit";
            this.Text = "Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnStart;
        private ComboBox cbWhatToEdit;
        private Label lblWhatToCreate;
        private Label lblEdit;
        private ComboBox cbChoose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Button btnBack;
    }
}