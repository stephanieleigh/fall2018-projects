namespace CarRental
{
    partial class RentalForm
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.milesLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.totalRentalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(37, 72);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(220, 20);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Enter the number of rental days:\r\n";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(297, 69);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(60, 27);
            this.daysTextBox.TabIndex = 1;
            this.daysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Location = new System.Drawing.Point(37, 132);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(228, 20);
            this.milesLabel.TabIndex = 2;
            this.milesLabel.Text = "Enter the number of miles driven:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(297, 129);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(60, 27);
            this.milesTextBox.TabIndex = 3;
            this.milesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalRentalLabel
            // 
            this.totalRentalLabel.AutoSize = true;
            this.totalRentalLabel.Location = new System.Drawing.Point(37, 252);
            this.totalRentalLabel.Name = "totalRentalLabel";
            this.totalRentalLabel.Size = new System.Drawing.Size(0, 20);
            this.totalRentalLabel.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(276, 184);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 34);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 334);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalRentalLabel);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.daysLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cramer Car Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label totalRentalLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

