namespace TrackerUI
{
    partial class SelectTeamcomboBox
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
            CreateTeamLabel = new Label();
            TeamNameValue = new TextBox();
            TeamNameLabel = new Label();
            addMemberButton = new Button();
            SelectTeamLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            groupBox1 = new GroupBox();
            LastNameValue = new TextBox();
            LastNameLabel = new Label();
            FIrstNameValue = new TextBox();
            FirstNameLabel = new Label();
            CellphoneValue = new TextBox();
            CellphoneLabel = new Label();
            EmailValue = new TextBox();
            EmailLabel = new Label();
            CreateMembersButton = new Button();
            TeamMembersListBox = new ListBox();
            DeleteSelectedMember = new Button();
            CreateTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamLabel.Location = new Point(61, 27);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(177, 37);
            CreateTeamLabel.TabIndex = 34;
            CreateTeamLabel.Text = "Create Team";
            CreateTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(61, 120);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(324, 33);
            TeamNameValue.TabIndex = 32;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamNameLabel.Location = new Point(61, 73);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(135, 30);
            TeamNameLabel.TabIndex = 33;
            TeamNameLabel.Text = "Team Name";
            TeamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = SystemColors.Desktop;
            addMemberButton.Location = new Point(144, 276);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(145, 40);
            addMemberButton.TabIndex = 37;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectTeamLabel.Location = new Point(61, 175);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(136, 30);
            SelectTeamLabel.TabIndex = 36;
            SelectTeamLabel.Text = "Select Team";
            SelectTeamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(61, 222);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(324, 33);
            SelectTeamDropDown.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CreateMembersButton);
            groupBox1.Controls.Add(CellphoneValue);
            groupBox1.Controls.Add(CellphoneLabel);
            groupBox1.Controls.Add(EmailValue);
            groupBox1.Controls.Add(EmailLabel);
            groupBox1.Controls.Add(LastNameValue);
            groupBox1.Controls.Add(LastNameLabel);
            groupBox1.Controls.Add(FIrstNameValue);
            groupBox1.Controls.Add(FirstNameLabel);
            groupBox1.Location = new Point(61, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 311);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // LastNameValue
            // 
            LastNameValue.Location = new Point(156, 102);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(158, 33);
            LastNameValue.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastNameLabel.Location = new Point(14, 101);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(121, 30);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Last Name";
            // 
            // FIrstNameValue
            // 
            FIrstNameValue.Location = new Point(156, 45);
            FIrstNameValue.Name = "FIrstNameValue";
            FIrstNameValue.Size = new Size(158, 33);
            FIrstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNameLabel.Location = new Point(14, 44);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(123, 30);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First Name";
            // 
            // CellphoneValue
            // 
            CellphoneValue.Location = new Point(156, 219);
            CellphoneValue.Name = "CellphoneValue";
            CellphoneValue.Size = new Size(158, 33);
            CellphoneValue.TabIndex = 16;
            // 
            // CellphoneLabel
            // 
            CellphoneLabel.AutoSize = true;
            CellphoneLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CellphoneLabel.Location = new Point(14, 218);
            CellphoneLabel.Name = "CellphoneLabel";
            CellphoneLabel.Size = new Size(122, 30);
            CellphoneLabel.TabIndex = 15;
            CellphoneLabel.Text = "Cellphone ";
            // 
            // EmailValue
            // 
            EmailValue.Location = new Point(156, 162);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(158, 33);
            EmailValue.TabIndex = 14;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(14, 161);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(68, 30);
            EmailLabel.TabIndex = 13;
            EmailLabel.Text = "Email";
            // 
            // CreateMembersButton
            // 
            CreateMembersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateMembersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateMembersButton.FlatStyle = FlatStyle.Flat;
            CreateMembersButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateMembersButton.ForeColor = SystemColors.Desktop;
            CreateMembersButton.Location = new Point(83, 265);
            CreateMembersButton.Name = "CreateMembersButton";
            CreateMembersButton.Size = new Size(145, 40);
            CreateMembersButton.TabIndex = 39;
            CreateMembersButton.Text = "Create Member";
            CreateMembersButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 25;
            TeamMembersListBox.Location = new Point(421, 169);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(339, 404);
            TeamMembersListBox.TabIndex = 39;
            // 
            // DeleteSelectedMember
            // 
            DeleteSelectedMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedMember.FlatStyle = FlatStyle.Flat;
            DeleteSelectedMember.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedMember.ForeColor = SystemColors.Desktop;
            DeleteSelectedMember.Location = new Point(799, 346);
            DeleteSelectedMember.Name = "DeleteSelectedMember";
            DeleteSelectedMember.Size = new Size(100, 74);
            DeleteSelectedMember.TabIndex = 40;
            DeleteSelectedMember.Text = "Delete Selected";
            DeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamButton.ForeColor = SystemColors.Desktop;
            CreateTeamButton.Location = new Point(323, 662);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(219, 40);
            CreateTeamButton.TabIndex = 41;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamcomboBox
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(928, 742);
            Controls.Add(CreateTeamButton);
            Controls.Add(DeleteSelectedMember);
            Controls.Add(TeamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addMemberButton);
            Controls.Add(SelectTeamLabel);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(CreateTeamLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamNameLabel);
            Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "SelectTeamcomboBox";
            Text = "CreateTeamForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTeamLabel;
        private TextBox TeamNameValue;
        private Label TeamNameLabel;
        private Button addMemberButton;
        private Label SelectTeamLabel;
        private ComboBox SelectTeamDropDown;
        private GroupBox groupBox1;
        private TextBox LastNameValue;
        private Label LastNameLabel;
        private TextBox FIrstNameValue;
        private Label FirstNameLabel;
        private Button CreateMembersButton;
        private TextBox CellphoneValue;
        private Label CellphoneLabel;
        private TextBox EmailValue;
        private Label EmailLabel;
        private ListBox TeamMembersListBox;
        private Button DeleteSelectedMember;
        private Button CreateTeamButton;
    }
}