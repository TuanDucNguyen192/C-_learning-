namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            LoadExistingTournamentLabel = new Label();
            LoadExistingTournamentDropDown = new ComboBox();
            TournamentDashboardLabel = new Label();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // LoadExistingTournamentLabel
            // 
            LoadExistingTournamentLabel.AutoSize = true;
            LoadExistingTournamentLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadExistingTournamentLabel.Location = new Point(223, 141);
            LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            LoadExistingTournamentLabel.Size = new Size(278, 30);
            LoadExistingTournamentLabel.TabIndex = 42;
            LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            LoadExistingTournamentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadExistingTournamentDropDown
            // 
            LoadExistingTournamentDropDown.FormattingEnabled = true;
            LoadExistingTournamentDropDown.Location = new Point(210, 190);
            LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            LoadExistingTournamentDropDown.Size = new Size(324, 33);
            LoadExistingTournamentDropDown.TabIndex = 41;
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentDashboardLabel.Location = new Point(210, 63);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(318, 37);
            TournamentDashboardLabel.TabIndex = 40;
            TournamentDashboardLabel.Text = "Tournament Dashboard";
            TournamentDashboardLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadTournamentButton.ForeColor = SystemColors.Desktop;
            LoadTournamentButton.Location = new Point(275, 244);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(188, 40);
            LoadTournamentButton.TabIndex = 43;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.Desktop;
            CreateTournamentButton.Location = new Point(275, 309);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(188, 40);
            CreateTournamentButton.TabIndex = 44;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(727, 442);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadExistingTournamentLabel);
            Controls.Add(LoadExistingTournamentDropDown);
            Controls.Add(TournamentDashboardLabel);
            Controls.Add(LoadTournamentButton);
            Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoadExistingTournamentLabel;
        private ComboBox LoadExistingTournamentDropDown;
        private Label TournamentDashboardLabel;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}