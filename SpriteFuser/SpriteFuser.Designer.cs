namespace SpriteFuser
{
    partial class SpriteFuser
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
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FusionButton = new System.Windows.Forms.Button();
            this.ColumnsInput = new System.Windows.Forms.NumericUpDown();
            this.RowsInput = new System.Windows.Forms.NumericUpDown();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.LenghtInput = new System.Windows.Forms.NumericUpDown();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColumnsLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtInput)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(55, 60);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(442, 13);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Complete all the required inputs and click on \"Fuse sprites\" to generate the comb" +
    "ined image.";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(197, 20);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(124, 26);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "SpriteFuser";
            // 
            // FusionButton
            // 
            this.FusionButton.Location = new System.Drawing.Point(220, 177);
            this.FusionButton.Name = "FusionButton";
            this.FusionButton.Size = new System.Drawing.Size(91, 30);
            this.FusionButton.TabIndex = 4;
            this.FusionButton.Text = "Fuse sprites\r\n";
            this.FusionButton.UseVisualStyleBackColor = true;
            this.FusionButton.Click += new System.EventHandler(this.FusionButton_Click);
            // 
            // ColumnsInput
            // 
            this.ColumnsInput.Location = new System.Drawing.Point(80, 121);
            this.ColumnsInput.Name = "ColumnsInput";
            this.ColumnsInput.Size = new System.Drawing.Size(56, 20);
            this.ColumnsInput.TabIndex = 5;
            this.ColumnsInput.ValueChanged += new System.EventHandler(this.ColumnsInput_ValueChanged);
            // 
            // RowsInput
            // 
            this.RowsInput.Location = new System.Drawing.Point(157, 121);
            this.RowsInput.Name = "RowsInput";
            this.RowsInput.Size = new System.Drawing.Size(56, 20);
            this.RowsInput.TabIndex = 6;
            this.RowsInput.ValueChanged += new System.EventHandler(this.RowsInput_ValueChanged);
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(314, 121);
            this.WidthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(56, 20);
            this.WidthInput.TabIndex = 7;
            this.WidthInput.ValueChanged += new System.EventHandler(this.WidthInput_ValueChanged);
            // 
            // LenghtInput
            // 
            this.LenghtInput.Location = new System.Drawing.Point(391, 121);
            this.LenghtInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LenghtInput.Name = "LenghtInput";
            this.LenghtInput.Size = new System.Drawing.Size(56, 20);
            this.LenghtInput.TabIndex = 8;
            this.LenghtInput.ValueChanged += new System.EventHandler(this.HeightInput_ValueChanged);
            // 
            // RowsLabel
            // 
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Location = new System.Drawing.Point(164, 105);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(39, 13);
            this.RowsLabel.TabIndex = 9;
            this.RowsLabel.Text = "# rows";
            // 
            // ColumnsLabel
            // 
            this.ColumnsLabel.AutoSize = true;
            this.ColumnsLabel.Location = new System.Drawing.Point(77, 105);
            this.ColumnsLabel.Name = "ColumnsLabel";
            this.ColumnsLabel.Size = new System.Drawing.Size(56, 13);
            this.ColumnsLabel.TabIndex = 10;
            this.ColumnsLabel.Text = "# columns";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(324, 105);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(32, 13);
            this.WidthLabel.TabIndex = 11;
            this.WidthLabel.Text = "width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(398, 105);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(36, 13);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "height";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResultLabel.Location = new System.Drawing.Point(80, 232);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultLabel.Size = new System.Drawing.Size(367, 13);
            this.ResultLabel.TabIndex = 13;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpriteFuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.ColumnsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.LenghtInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.RowsInput);
            this.Controls.Add(this.ColumnsInput);
            this.Controls.Add(this.FusionButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InstructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpriteFuser";
            this.Text = "SpriteFuser";
            ((System.ComponentModel.ISupportInitialize)(this.ColumnsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button FusionButton;
        private System.Windows.Forms.NumericUpDown ColumnsInput;
        private System.Windows.Forms.NumericUpDown RowsInput;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.NumericUpDown LenghtInput;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label ColumnsLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

