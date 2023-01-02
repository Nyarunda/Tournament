namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.createteamLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.selectMemberDropdown = new System.Windows.Forms.ComboBox();
            this.addMemberLabel = new System.Windows.Forms.Label();
            this.addnewmembergroupBox1 = new System.Windows.Forms.GroupBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhonLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMemberListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamtButton = new System.Windows.Forms.Button();
            this.addnewmembergroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameValue.Location = new System.Drawing.Point(41, 120);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(312, 38);
            this.TeamNameValue.TabIndex = 13;
            this.TeamNameValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(35, 79);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(176, 38);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Teams Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.TournamentNameLabel_Click);
            // 
            // createteamLabel
            // 
            this.createteamLabel.AutoSize = true;
            this.createteamLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createteamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createteamLabel.Location = new System.Drawing.Point(41, 31);
            this.createteamLabel.Name = "createteamLabel";
            this.createteamLabel.Size = new System.Drawing.Size(170, 38);
            this.createteamLabel.TabIndex = 11;
            this.createteamLabel.Text = "Create Team";
            this.createteamLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddMemberButton.Location = new System.Drawing.Point(119, 247);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(179, 43);
            this.AddMemberButton.TabIndex = 21;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectMemberDropdown
            // 
            this.selectMemberDropdown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMemberDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectMemberDropdown.FormattingEnabled = true;
            this.selectMemberDropdown.Location = new System.Drawing.Point(42, 196);
            this.selectMemberDropdown.Name = "selectMemberDropdown";
            this.selectMemberDropdown.Size = new System.Drawing.Size(311, 45);
            this.selectMemberDropdown.TabIndex = 20;
            // 
            // addMemberLabel
            // 
            this.addMemberLabel.AutoSize = true;
            this.addMemberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberLabel.Location = new System.Drawing.Point(35, 161);
            this.addMemberLabel.Name = "addMemberLabel";
            this.addMemberLabel.Size = new System.Drawing.Size(241, 32);
            this.addMemberLabel.TabIndex = 19;
            this.addMemberLabel.Text = "Select Team Member";
            // 
            // addnewmembergroupBox1
            // 
            this.addnewmembergroupBox1.Controls.Add(this.createMemberButton);
            this.addnewmembergroupBox1.Controls.Add(this.cellPhoneValue);
            this.addnewmembergroupBox1.Controls.Add(this.cellPhonLabel);
            this.addnewmembergroupBox1.Controls.Add(this.emailValue);
            this.addnewmembergroupBox1.Controls.Add(this.emailLabel);
            this.addnewmembergroupBox1.Controls.Add(this.lastNameValue);
            this.addnewmembergroupBox1.Controls.Add(this.lastNameLabel);
            this.addnewmembergroupBox1.Controls.Add(this.FirstNameValue);
            this.addnewmembergroupBox1.Controls.Add(this.firstNameLabel);
            this.addnewmembergroupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewmembergroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addnewmembergroupBox1.Location = new System.Drawing.Point(41, 313);
            this.addnewmembergroupBox1.Name = "addnewmembergroupBox1";
            this.addnewmembergroupBox1.Size = new System.Drawing.Size(311, 276);
            this.addnewmembergroupBox1.TabIndex = 22;
            this.addnewmembergroupBox1.TabStop = false;
            this.addnewmembergroupBox1.Text = "Add New Member";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValue.Location = new System.Drawing.Point(123, 51);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(182, 34);
            this.FirstNameValue.TabIndex = 24;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.firstNameLabel.Location = new System.Drawing.Point(11, 56);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 28);
            this.firstNameLabel.TabIndex = 23;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameValue.Location = new System.Drawing.Point(123, 96);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(182, 34);
            this.lastNameValue.TabIndex = 26;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lastNameLabel.Location = new System.Drawing.Point(11, 101);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 28);
            this.lastNameLabel.TabIndex = 25;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValue.Location = new System.Drawing.Point(123, 140);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(182, 34);
            this.emailValue.TabIndex = 28;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(11, 145);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 28);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhoneValue.Location = new System.Drawing.Point(123, 186);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(182, 34);
            this.cellPhoneValue.TabIndex = 30;
            // 
            // cellPhonLabel
            // 
            this.cellPhonLabel.AutoSize = true;
            this.cellPhonLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPhonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cellPhonLabel.Location = new System.Drawing.Point(11, 191);
            this.cellPhonLabel.Name = "cellPhonLabel";
            this.cellPhonLabel.Size = new System.Drawing.Size(104, 28);
            this.cellPhonLabel.TabIndex = 29;
            this.cellPhonLabel.Text = "Cell Phone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberButton.Location = new System.Drawing.Point(78, 222);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(157, 50);
            this.createMemberButton.TabIndex = 23;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMemberListBox
            // 
            this.teamMemberListBox.FormattingEnabled = true;
            this.teamMemberListBox.ItemHeight = 37;
            this.teamMemberListBox.Location = new System.Drawing.Point(379, 104);
            this.teamMemberListBox.Name = "teamMemberListBox";
            this.teamMemberListBox.Size = new System.Drawing.Size(305, 485);
            this.teamMemberListBox.TabIndex = 23;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(690, 259);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(128, 64);
            this.deleteSelectedMemberButton.TabIndex = 28;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamtButton
            // 
            this.CreateTeamtButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamtButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamtButton.Location = new System.Drawing.Point(277, 620);
            this.CreateTeamtButton.Name = "CreateTeamtButton";
            this.CreateTeamtButton.Size = new System.Drawing.Size(233, 43);
            this.CreateTeamtButton.TabIndex = 29;
            this.CreateTeamtButton.Text = "Create Team";
            this.CreateTeamtButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 677);
            this.Controls.Add(this.CreateTeamtButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMemberListBox);
            this.Controls.Add(this.addnewmembergroupBox1);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.selectMemberDropdown);
            this.Controls.Add(this.addMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.createteamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addnewmembergroupBox1.ResumeLayout(false);
            this.addnewmembergroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label createteamLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.ComboBox selectMemberDropdown;
        private System.Windows.Forms.Label addMemberLabel;
        private System.Windows.Forms.GroupBox addnewmembergroupBox1;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhonLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ListBox teamMemberListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamtButton;
    }
}