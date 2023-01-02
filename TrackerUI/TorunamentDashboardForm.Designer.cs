namespace TrackerUI
{
    partial class TorunamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorunamentDashboardForm));
            this.TournamntDahsboardLabel = new System.Windows.Forms.Label();
            this.loanExisitingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamntDahsboardLabel
            // 
            this.TournamntDahsboardLabel.AutoSize = true;
            this.TournamntDahsboardLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamntDahsboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamntDahsboardLabel.Location = new System.Drawing.Point(143, 9);
            this.TournamntDahsboardLabel.Name = "TournamntDahsboardLabel";
            this.TournamntDahsboardLabel.Size = new System.Drawing.Size(307, 38);
            this.TournamntDahsboardLabel.TabIndex = 33;
            this.TournamntDahsboardLabel.Text = "Tournament Dashboard";
            // 
            // loanExisitingTournamentDropdown
            // 
            this.loanExisitingTournamentDropdown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanExisitingTournamentDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loanExisitingTournamentDropdown.FormattingEnabled = true;
            this.loanExisitingTournamentDropdown.Location = new System.Drawing.Point(141, 100);
            this.loanExisitingTournamentDropdown.Name = "loanExisitingTournamentDropdown";
            this.loanExisitingTournamentDropdown.Size = new System.Drawing.Size(311, 45);
            this.loanExisitingTournamentDropdown.TabIndex = 35;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(151, 65);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(290, 32);
            this.loadExistingTournamentLabel.TabIndex = 34;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(181, 245);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(230, 55);
            this.CreateTournamentButton.TabIndex = 37;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentButton.Location = new System.Drawing.Point(207, 167);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(179, 43);
            this.loadTournamentButton.TabIndex = 36;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TorunamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 341);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loanExisitingTournamentDropdown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.TournamntDahsboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TorunamentDashboardForm";
            this.Text = "TorunamentDashboardForm";
            this.Load += new System.EventHandler(this.TorunamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamntDahsboardLabel;
        private System.Windows.Forms.ComboBox loanExisitingTournamentDropdown;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button CreateTournamentButton;
        private System.Windows.Forms.Button loadTournamentButton;
    }
}