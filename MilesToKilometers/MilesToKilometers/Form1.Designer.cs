namespace MilesToKilometers
{
    partial class KiloForm
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
            this.convertButton = new System.Windows.Forms.Button();
            this.milesLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.kilosLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(173, 142);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(99, 49);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Click to convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesLabel.Location = new System.Drawing.Point(49, 75);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(213, 23);
            this.milesLabel.TabIndex = 1;
            this.milesLabel.Text = "Enter the number of miles:";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(278, 77);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(70, 22);
            this.milesTextBox.TabIndex = 2;
            this.milesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kilosLabel
            // 
            this.kilosLabel.AutoSize = true;
            this.kilosLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilosLabel.Location = new System.Drawing.Point(49, 238);
            this.kilosLabel.Name = "kilosLabel";
            this.kilosLabel.Size = new System.Drawing.Size(0, 20);
            this.kilosLabel.TabIndex = 3;
            this.kilosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KiloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 346);
            this.Controls.Add(this.kilosLabel);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "KiloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miles to Kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label kilosLabel;
    }
}

