namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberValue.Location = new System.Drawing.Point(208, 67);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(182, 34);
            this.placeNumberValue.TabIndex = 31;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.PlaceNumberValue_TextChanged);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(44, 70);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(149, 30);
            this.placeNumberLabel.TabIndex = 30;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(166, 38);
            this.createPrizeLabel.TabIndex = 32;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageValue.Location = new System.Drawing.Point(233, 216);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(157, 34);
            this.prizePercentageValue.TabIndex = 36;
            this.prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(44, 219);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(174, 30);
            this.prizePercentageLabel.TabIndex = 35;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountValue.Location = new System.Drawing.Point(208, 151);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(182, 34);
            this.prizeAmountValue.TabIndex = 38;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmountLabel.Location = new System.Drawing.Point(44, 154);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.prizeAmountLabel.TabIndex = 37;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameValue.Location = new System.Drawing.Point(208, 109);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(182, 34);
            this.placeNameValue.TabIndex = 40;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(44, 112);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(127, 30);
            this.placeNameLabel.TabIndex = 39;
            this.placeNameLabel.Text = "Place Name";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(174, 188);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(52, 30);
            this.orLabel.TabIndex = 41;
            this.orLabel.Text = "-or-";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(115, 297);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(233, 43);
            this.CreatePrizeButton.TabIndex = 42;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 423);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}