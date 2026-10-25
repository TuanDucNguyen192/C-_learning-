namespace TrackerUI
{
    partial class TournamentViewerForm
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
            TournamentName = new Label();
            TournamentLabel = new Label();
            RoundDropDown = new ComboBox();
            UnplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            versusLabel = new Label();
            scoreButton = new Button();
            TeamTwoName = new Label();
            teamTwoScoreLabel = new Label();
            RoundLabel = new Label();
            SuspendLayout();
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.BackColor = SystemColors.ControlDarkDark;
            TournamentName.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentName.Location = new Point(269, 34);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(153, 47);
            TournamentName.TabIndex = 0;
            TournamentName.Text = "<none>";
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentLabel.Location = new Point(14, 34);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(228, 47);
            TournamentLabel.TabIndex = 1;
            TournamentLabel.Text = "Tournament:";
            // 
            // RoundDropDown
            // 
            RoundDropDown.FormattingEnabled = true;
            RoundDropDown.Location = new Point(227, 120);
            RoundDropDown.Name = "RoundDropDown";
            RoundDropDown.Size = new Size(195, 23);
            RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            UnplayedOnlyCheckbox.AutoSize = true;
            UnplayedOnlyCheckbox.FlatStyle = FlatStyle.Popup;
            UnplayedOnlyCheckbox.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnplayedOnlyCheckbox.Location = new Point(227, 153);
            UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            UnplayedOnlyCheckbox.Size = new Size(223, 41);
            UnplayedOnlyCheckbox.TabIndex = 4;
            UnplayedOnlyCheckbox.Text = "Unplayed Only";
            UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 15;
            matchupListBox.Location = new Point(105, 205);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(317, 107);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamOneName.Location = new Point(456, 186);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(175, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamOneScoreLabel.Location = new Point(456, 236);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(84, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(546, 250);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 23);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(546, 359);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(100, 23);
            teamTwoScoreValue.TabIndex = 11;
            teamTwoScoreValue.TextChanged += textBox1_TextChanged;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            versusLabel.Location = new Point(534, 276);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(54, 25);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.Desktop;
            scoreButton.Location = new Point(677, 272);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(109, 40);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TeamTwoName
            // 
            TeamTwoName.AutoSize = true;
            TeamTwoName.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamTwoName.Location = new Point(456, 301);
            TeamTwoName.Name = "TeamTwoName";
            TeamTwoName.Size = new Size(175, 37);
            TeamTwoName.TabIndex = 17;
            TeamTwoName.Text = "<team two>";
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamTwoScoreLabel.Location = new Point(456, 345);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(84, 37);
            teamTwoScoreLabel.TabIndex = 18;
            teamTwoScoreLabel.Text = "score";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoundLabel.Location = new Point(50, 107);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(137, 47);
            RoundLabel.TabIndex = 19;
            RoundLabel.Text = "Round:";
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(936, 450);
            Controls.Add(RoundLabel);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(TeamTwoName);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(UnplayedOnlyCheckbox);
            Controls.Add(RoundDropDown);
            Controls.Add(TournamentLabel);
            Controls.Add(TournamentName);
            Name = "TournamentViewerForm";
            Text = "Tournament:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentName;
        private Label TournamentLabel;
        //private Label RoundLabel;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        //private Label teamTwoScoreLabel;
        //private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
        private Label TeamTwoName;
        private Label teamTwoScoreLabel;
        private Label RoundLabel;
        //private Label teamTwoScoreLabel;
    }
}
