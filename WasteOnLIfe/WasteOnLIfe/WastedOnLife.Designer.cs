namespace WasteOnLIfe
{
    partial class WastedOnLife
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DaysLived = new System.Windows.Forms.TextBox();
            this.HoursLived = new System.Windows.Forms.TextBox();
            this.DaysLeft = new System.Windows.Forms.TextBox();
            this.DaysLivedLabel = new System.Windows.Forms.Label();
            this.HoursLivedLabel = new System.Windows.Forms.Label();
            this.DaysLeftLabel = new System.Windows.Forms.Label();
            this.DaysToCentury = new System.Windows.Forms.TextBox();
            this.NextBitrthday = new System.Windows.Forms.TextBox();
            this.DaysToCenturyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(12, 29);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(130, 27);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(8, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(66, 13);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "Date of Birth";
            this.InputLabel.Click += new System.EventHandler(this.InputLabel_Click);
            // 
            // DaysLived
            // 
            this.DaysLived.Location = new System.Drawing.Point(12, 68);
            this.DaysLived.Name = "DaysLived";
            this.DaysLived.Size = new System.Drawing.Size(100, 20);
            this.DaysLived.TabIndex = 3;
            // 
            // HoursLived
            // 
            this.HoursLived.Location = new System.Drawing.Point(12, 107);
            this.HoursLived.Name = "HoursLived";
            this.HoursLived.Size = new System.Drawing.Size(100, 20);
            this.HoursLived.TabIndex = 4;
            // 
            // DaysLeft
            // 
            this.DaysLeft.Location = new System.Drawing.Point(12, 147);
            this.DaysLeft.Name = "DaysLeft";
            this.DaysLeft.Size = new System.Drawing.Size(100, 20);
            this.DaysLeft.TabIndex = 5;
            // 
            // DaysLivedLabel
            // 
            this.DaysLivedLabel.AutoSize = true;
            this.DaysLivedLabel.Location = new System.Drawing.Point(8, 52);
            this.DaysLivedLabel.Name = "DaysLivedLabel";
            this.DaysLivedLabel.Size = new System.Drawing.Size(60, 13);
            this.DaysLivedLabel.TabIndex = 6;
            this.DaysLivedLabel.Text = "Days Lived";
            // 
            // HoursLivedLabel
            // 
            this.HoursLivedLabel.AutoSize = true;
            this.HoursLivedLabel.Location = new System.Drawing.Point(8, 91);
            this.HoursLivedLabel.Name = "HoursLivedLabel";
            this.HoursLivedLabel.Size = new System.Drawing.Size(64, 13);
            this.HoursLivedLabel.TabIndex = 7;
            this.HoursLivedLabel.Text = "Hours Lived";
            // 
            // DaysLeftLabel
            // 
            this.DaysLeftLabel.AutoSize = true;
            this.DaysLeftLabel.Location = new System.Drawing.Point(9, 131);
            this.DaysLeftLabel.Name = "DaysLeftLabel";
            this.DaysLeftLabel.Size = new System.Drawing.Size(52, 13);
            this.DaysLeftLabel.TabIndex = 8;
            this.DaysLeftLabel.Text = "Days Left";
            // 
            // DaysToCentury
            // 
            this.DaysToCentury.Location = new System.Drawing.Point(12, 195);
            this.DaysToCentury.Name = "DaysToCentury";
            this.DaysToCentury.Size = new System.Drawing.Size(100, 20);
            this.DaysToCentury.TabIndex = 9;
            // 
            // NextBitrthday
            // 
            this.NextBitrthday.Location = new System.Drawing.Point(12, 237);
            this.NextBitrthday.Name = "NextBitrthday";
            this.NextBitrthday.Size = new System.Drawing.Size(100, 20);
            this.NextBitrthday.TabIndex = 11;
            // 
            // DaysToCenturyLabel
            // 
            this.DaysToCenturyLabel.AutoSize = true;
            this.DaysToCenturyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DaysToCenturyLabel.Location = new System.Drawing.Point(8, 179);
            this.DaysToCenturyLabel.Name = "DaysToCenturyLabel";
            this.DaysToCenturyLabel.Size = new System.Drawing.Size(91, 13);
            this.DaysToCenturyLabel.TabIndex = 10;
            this.DaysToCenturyLabel.Text = "Till 100th Birthday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Next Birthday";
            // 
            // WastedOnLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextBitrthday);
            this.Controls.Add(this.DaysToCenturyLabel);
            this.Controls.Add(this.DaysToCentury);
            this.Controls.Add(this.DaysLeftLabel);
            this.Controls.Add(this.HoursLivedLabel);
            this.Controls.Add(this.DaysLivedLabel);
            this.Controls.Add(this.DaysLeft);
            this.Controls.Add(this.HoursLived);
            this.Controls.Add(this.DaysLived);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.InputTextBox);
            this.Name = "WastedOnLife";
            this.Text = "WastedOnLife";
            this.Load += new System.EventHandler(this.WastedOnLife_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox DaysLived;
        private System.Windows.Forms.TextBox HoursLived;
        private System.Windows.Forms.TextBox DaysLeft;
        private System.Windows.Forms.Label DaysLivedLabel;
        private System.Windows.Forms.Label HoursLivedLabel;
        private System.Windows.Forms.Label DaysLeftLabel;
        private System.Windows.Forms.TextBox DaysToCentury;
        private System.Windows.Forms.TextBox NextBitrthday;
        private System.Windows.Forms.Label DaysToCenturyLabel;
        private System.Windows.Forms.Label label1;
    }
}

