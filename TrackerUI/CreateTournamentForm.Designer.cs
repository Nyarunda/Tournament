namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.addTeam = new System.Windows.Forms.Label();
            this.createNewTeamLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentplayerListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayerlabel = new System.Windows.Forms.Label();
            this.prizeslabel = new System.Windows.Forms.Label();
            this.prizeslistBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedPlayerbutton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(10, 8);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(259, 38);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament:";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreValue.Location = new System.Drawing.Point(16, 96);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(268, 38);
            this.teamOneScoreValue.TabIndex = 10;
            this.teamOneScoreValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(10, 62);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(215, 32);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Click += new System.EventHandler(this.TeamoneScoreLabel_Click);
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreValue.Location = new System.Drawing.Point(130, 148);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(154, 38);
            this.teamTwoScoreValue.TabIndex = 13;
            this.teamTwoScoreValue.Text = "0";
            this.teamTwoScoreValue.TextChanged += new System.EventHandler(this.TeamTwoScoreValue_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLabel.Location = new System.Drawing.Point(18, 148);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(114, 32);
            this.entryFeeLabel.TabIndex = 12;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(17, 226);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(267, 45);
            this.selectTeamDropdown.TabIndex = 15;
            // 
            // addTeam
            // 
            this.addTeam.AutoSize = true;
            this.addTeam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeam.Location = new System.Drawing.Point(10, 191);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(143, 32);
            this.addTeam.TabIndex = 14;
            this.addTeam.Text = "Select Team";
            // 
            // createNewTeamLabel
            // 
            this.createNewTeamLabel.AutoSize = true;
            this.createNewTeamLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLabel.Location = new System.Drawing.Point(153, 191);
            this.createNewTeamLabel.Name = "createNewTeamLabel";
            this.createNewTeamLabel.Size = new System.Drawing.Size(131, 32);
            this.createNewTeamLabel.TabIndex = 16;
            this.createNewTeamLabel.TabStop = true;
            this.createNewTeamLabel.Text = "create new";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(82, 281);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(179, 43);
            this.AddTeamButton.TabIndex = 18;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(82, 330);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(179, 43);
            this.createPrizeButton.TabIndex = 19;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentplayerListBox
            // 
            this.tournamentplayerListBox.FormattingEnabled = true;
            this.tournamentplayerListBox.ItemHeight = 31;
            this.tournamentplayerListBox.Location = new System.Drawing.Point(380, 96);
            this.tournamentplayerListBox.Name = "tournamentplayerListBox";
            this.tournamentplayerListBox.Size = new System.Drawing.Size(273, 159);
            this.tournamentplayerListBox.TabIndex = 20;
            this.tournamentplayerListBox.SelectedIndexChanged += new System.EventHandler(this.MatchUplistBox_SelectedIndexChanged);
            // 
            // tournamentPlayerlabel
            // 
            this.tournamentPlayerlabel.AutoSize = true;
            this.tournamentPlayerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlayerlabel.Location = new System.Drawing.Point(498, 61);
            this.tournamentPlayerlabel.Name = "tournamentPlayerlabel";
            this.tournamentPlayerlabel.Size = new System.Drawing.Size(155, 32);
            this.tournamentPlayerlabel.TabIndex = 21;
            this.tournamentPlayerlabel.Text = "Team/Players";
            this.tournamentPlayerlabel.Click += new System.EventHandler(this.TournamentPlayerlabel_Click);
            // 
            // prizeslabel
            // 
            this.prizeslabel.AutoSize = true;
            this.prizeslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeslabel.Location = new System.Drawing.Point(498, 269);
            this.prizeslabel.Name = "prizeslabel";
            this.prizeslabel.Size = new System.Drawing.Size(108, 32);
            this.prizeslabel.TabIndex = 24;
            this.prizeslabel.Text = "Prize List";
            this.prizeslabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // prizeslistBox
            // 
            this.prizeslistBox.FormattingEnabled = true;
            this.prizeslistBox.ItemHeight = 31;
            this.prizeslistBox.Location = new System.Drawing.Point(380, 304);
            this.prizeslistBox.Name = "prizeslistBox";
            this.prizeslistBox.Size = new System.Drawing.Size(273, 159);
            this.prizeslistBox.TabIndex = 23;
            this.prizeslistBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // DeleteSelectedPlayerbutton
            // 
            this.DeleteSelectedPlayerbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayerbutton.Location = new System.Drawing.Point(659, 334);
            this.DeleteSelectedPlayerbutton.Name = "DeleteSelectedPlayerbutton";
            this.DeleteSelectedPlayerbutton.Size = new System.Drawing.Size(128, 76);
            this.DeleteSelectedPlayerbutton.TabIndex = 26;
            this.DeleteSelectedPlayerbutton.Text = "Delete Selected";
            this.DeleteSelectedPlayerbutton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(659, 126);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(128, 76);
            this.DeleteSelectedPrizeButton.TabIndex = 27;
            this.DeleteSelectedPrizeButton.Text = "Delete Selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(298, 497);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(188, 43);
            this.CreateTournamentButton.TabIndex = 28;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 588);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.DeleteSelectedPlayerbutton);
            this.Controls.Add(this.prizeslabel);
            this.Controls.Add(this.prizeslistBox);
            this.Controls.Add(this.tournamentPlayerlabel);
            this.Controls.Add(this.tournamentplayerListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.createNewTeamLabel);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label addTeam;
        private System.Windows.Forms.LinkLabel createNewTeamLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentplayerListBox;
        private System.Windows.Forms.Label tournamentPlayerlabel;
        private System.Windows.Forms.Label prizeslabel;
        private System.Windows.Forms.ListBox prizeslistBox;
        private System.Windows.Forms.Button DeleteSelectedPlayerbutton;
        private System.Windows.Forms.Button DeleteSelectedPrizeButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}