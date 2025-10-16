namespace TrackerUI
{
    partial class CreatePrizesForm
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
            createPrizeLabel = new Label();
            createPrizeButton = new Button();
            prizePercentageLabel = new Label();
            prizePercentageValue = new TextBox();
            placeAmountLabel = new Label();
            placeAmountValue = new TextBox();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            orLabel = new Label();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeLabel.Location = new Point(2, 9);
            createPrizeLabel.Margin = new Padding(3, 0, 2, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(158, 37);
            createPrizeLabel.TabIndex = 16;
            createPrizeLabel.Text = "Create Prize";
            createPrizeLabel.Click += createPrizeLabel_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(76, 199);
            createPrizeButton.Margin = new Padding(4, 3, 4, 3);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(142, 44);
            createPrizeButton.TabIndex = 44;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(14, 162);
            prizePercentageLabel.Margin = new Padding(2, 0, 0, 0);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(167, 30);
            prizePercentageLabel.TabIndex = 43;
            prizePercentageLabel.Text = "Prize Percentage";
            prizePercentageLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageValue.Location = new Point(184, 166);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(137, 29);
            prizePercentageValue.TabIndex = 42;
            // 
            // placeAmountLabel
            // 
            placeAmountLabel.AutoSize = true;
            placeAmountLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeAmountLabel.Location = new Point(14, 106);
            placeAmountLabel.Margin = new Padding(2, 0, 0, 0);
            placeAmountLabel.Name = "placeAmountLabel";
            placeAmountLabel.Size = new Size(143, 30);
            placeAmountLabel.TabIndex = 41;
            placeAmountLabel.Text = "Place Amount";
            placeAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // placeAmountValue
            // 
            placeAmountValue.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeAmountValue.Location = new Point(184, 107);
            placeAmountValue.Name = "placeAmountValue";
            placeAmountValue.Size = new Size(137, 29);
            placeAmountValue.TabIndex = 40;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(16, 76);
            placeNameLabel.Margin = new Padding(2, 0, 0, 0);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(124, 30);
            placeNameLabel.TabIndex = 39;
            placeNameLabel.Text = "Place Name";
            placeNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameValue.Location = new Point(184, 79);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(137, 29);
            placeNameValue.TabIndex = 38;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(16, 46);
            placeNumberLabel.Margin = new Padding(2, 0, 0, 0);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(144, 30);
            placeNumberLabel.TabIndex = 37;
            placeNumberLabel.Text = "Place Number";
            placeNumberLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberValue.Location = new Point(184, 50);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(137, 29);
            placeNumberValue.TabIndex = 36;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(117, 136);
            orLabel.Margin = new Padding(2, 0, 0, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 30);
            orLabel.TabIndex = 45;
            orLabel.Text = "- Or -";
            orLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CreatePrizesForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(344, 272);
            Controls.Add(orLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(placeAmountLabel);
            Controls.Add(placeAmountValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CreatePrizesForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label placeAmountLabel;
        private System.Windows.Forms.TextBox placeAmountValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label orLabel;
    }
}