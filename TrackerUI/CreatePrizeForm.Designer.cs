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
            CreatePrizeLabel = new Label();
            PrizePercentageValue = new TextBox();
            PrizePercentageLabel = new Label();
            PrizeAmountValue = new TextBox();
            PrizeAmountLabel = new Label();
            PlaceNameValue = new TextBox();
            PlaceNameLabel = new Label();
            PlaceNumberValue = new TextBox();
            PlaceNumberLabel = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeLabel.Location = new Point(97, 35);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(170, 37);
            CreatePrizeLabel.TabIndex = 35;
            CreatePrizeLabel.Text = "Create Prize";
            CreatePrizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PrizePercentageValue
            // 
            PrizePercentageValue.Location = new Point(288, 293);
            PrizePercentageValue.Name = "PrizePercentageValue";
            PrizePercentageValue.Size = new Size(158, 33);
            PrizePercentageValue.TabIndex = 43;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrizePercentageLabel.Location = new Point(97, 296);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(184, 30);
            PrizePercentageLabel.TabIndex = 42;
            PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // PrizeAmountValue
            // 
            PrizeAmountValue.Location = new Point(288, 239);
            PrizeAmountValue.Name = "PrizeAmountValue";
            PrizeAmountValue.Size = new Size(158, 33);
            PrizeAmountValue.TabIndex = 41;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrizeAmountLabel.Location = new Point(97, 239);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(151, 30);
            PrizeAmountLabel.TabIndex = 40;
            PrizeAmountLabel.Text = "Prize Amount";
            // 
            // PlaceNameValue
            // 
            PlaceNameValue.Location = new Point(288, 180);
            PlaceNameValue.Name = "PlaceNameValue";
            PlaceNameValue.Size = new Size(158, 33);
            PlaceNameValue.TabIndex = 39;
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlaceNameLabel.Location = new Point(97, 179);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.Size = new Size(134, 30);
            PlaceNameLabel.TabIndex = 38;
            PlaceNameLabel.Text = "Place Name";
            // 
            // PlaceNumberValue
            // 
            PlaceNumberValue.Location = new Point(288, 122);
            PlaceNumberValue.Name = "PlaceNumberValue";
            PlaceNumberValue.Size = new Size(158, 33);
            PlaceNumberValue.TabIndex = 37;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlaceNumberLabel.Location = new Point(97, 122);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(156, 30);
            PlaceNumberLabel.TabIndex = 36;
            PlaceNumberLabel.Text = "Place Number";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.Desktop;
            CreatePrizeButton.Location = new Point(193, 367);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(145, 40);
            CreatePrizeButton.TabIndex = 44;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(558, 470);
            Controls.Add(CreatePrizeButton);
            Controls.Add(PrizePercentageValue);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PrizeAmountValue);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PlaceNameValue);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PlaceNumberValue);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeLabel);
            Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLabel;
        private TextBox PrizePercentageValue;
        private Label PrizePercentageLabel;
        private TextBox PrizeAmountValue;
        private Label PrizeAmountLabel;
        private TextBox PlaceNameValue;
        private Label PlaceNameLabel;
        private TextBox PlaceNumberValue;
        private Label PlaceNumberLabel;
        private Button CreatePrizeButton;
    }
}