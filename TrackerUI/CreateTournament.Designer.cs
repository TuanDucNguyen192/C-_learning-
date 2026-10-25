namespace TrackerUI
{
    partial class CreateTournament
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
            TournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            EntryFreeLabel = new Label();
            textBox1 = new TextBox();
            SelectTeamLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            CreatePrizeButton = new Button();
            TournamentPlayerListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            DeleteSelectedPlayerButton = new Button();
            DeleteSelectedPrizeButton = new Button();
            label1 = new Label();
            PrizesListBox = new ListBox();
            CreateTournamentLabel = new Label();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentNameValue
            // 
            TournamentNameValue.Location = new Point(358, 103);
            TournamentNameValue.Name = "TournamentNameValue";
            TournamentNameValue.Size = new Size(100, 33);
            TournamentNameValue.TabIndex = 3;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentNameLabel.Location = new Point(90, 99);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(246, 37);
            TournamentNameLabel.TabIndex = 9;
            TournamentNameLabel.Text = "TournamentName";
            // 
            // EntryFreeLabel
            // 
            EntryFreeLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EntryFreeLabel.Location = new Point(196, 169);
            EntryFreeLabel.Name = "EntryFreeLabel";
            EntryFreeLabel.Size = new Size(121, 34);
            EntryFreeLabel.TabIndex = 1;
            EntryFreeLabel.Text = "EntryFee";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI Historic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectTeamLabel.Location = new Point(101, 243);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(216, 47);
            SelectTeamLabel.TabIndex = 21;
            SelectTeamLabel.Text = "Select Team";
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(110, 303);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(324, 33);
            SelectTeamDropDown.TabIndex = 20;
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(327, 265);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 25);
            createNewTeamLink.TabIndex = 22;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = SystemColors.Desktop;
            addTeamButton.Location = new Point(213, 362);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(136, 40);
            addTeamButton.TabIndex = 23;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.Desktop;
            CreatePrizeButton.Location = new Point(213, 430);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(136, 40);
            CreatePrizeButton.TabIndex = 24;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayerListBox
            // 
            TournamentPlayerListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayerListBox.FormattingEnabled = true;
            TournamentPlayerListBox.ItemHeight = 25;
            TournamentPlayerListBox.Location = new Point(484, 149);
            TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            TournamentPlayerListBox.Size = new Size(317, 102);
            TournamentPlayerListBox.TabIndex = 25;
            // 
            // TournamentPlayersLabel
            // 
           
            // 
            // DeleteSelectedPlayerButton
            // 
            DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayerButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPlayerButton.ForeColor = SystemColors.Desktop;
            DeleteSelectedPlayerButton.Location = new Point(839, 169);
            DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            DeleteSelectedPlayerButton.Size = new Size(136, 65);
            DeleteSelectedPlayerButton.TabIndex = 27;
            DeleteSelectedPlayerButton.Text = "Delete Selected";
            DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrizeButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPrizeButton.ForeColor = SystemColors.Desktop;
            DeleteSelectedPrizeButton.Location = new Point(839, 373);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new Size(136, 65);
            DeleteSelectedPrizeButton.TabIndex = 30;
            DeleteSelectedPrizeButton.Text = "Delete Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(484, 307);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 29;
            label1.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 25;
            PrizesListBox.Location = new Point(484, 353);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(317, 102);
            PrizesListBox.TabIndex = 28;
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentLabel.Location = new Point(90, 19);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(262, 37);
            CreateTournamentLabel.TabIndex = 31;
            CreateTournamentLabel.Text = "Create Tournament";
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.Desktop;
            CreateTournamentButton.Location = new Point(381, 515);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(219, 40);
            CreateTournamentButton.TabIndex = 32;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1047, 598);
            Controls.Add(CreateTournamentButton);
            Controls.Add(CreateTournamentLabel);
            Controls.Add(DeleteSelectedPrizeButton);
            Controls.Add(label1);
            Controls.Add(PrizesListBox);
            Controls.Add(DeleteSelectedPlayerButton);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(TournamentPlayerListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(SelectTeamLabel);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(textBox1);
            Controls.Add(EntryFreeLabel);
            Controls.Add(TournamentNameValue);
            Controls.Add(TournamentNameLabel);
            Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "CreateTournament";
            Text = "CreateTournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TournamentNameValue;
        private Label TournamentNameLabel;
        private Label EntryFreeLabel;
        private TextBox textBox1;
        private Label SelectTeamLabel;
        private ComboBox SelectTeamDropDown;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayerListBox;
        private Label TournamentPlayersLabel;
        private Button DeleteSelectedPlayerButton;
        private Button DeleteSelectedPrizeButton;
        private Label label1;
        private ListBox PrizesListBox;
        private Label CreateTournamentLabel;
        private Button CreateTournamentButton;
    }
}