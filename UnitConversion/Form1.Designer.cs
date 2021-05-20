
namespace UnitConversion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.choiceTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Blue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(410, 47);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Linear Conversion";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // informationLabel
            // 
            this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.informationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informationLabel.Location = new System.Drawing.Point(134, 66);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(164, 125);
            this.informationLabel.TabIndex = 1;
            this.informationLabel.Text = "1. Inches to Centimetres\r\n\r\n2. Feet to Centimetres\r\n\r\n3. Yards to Metres\r\n\r\n4. Mi" +
    "les to Kilometres";
            // 
            // infoLabel2
            // 
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoLabel2.Location = new System.Drawing.Point(41, 212);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(204, 22);
            this.infoLabel2.TabIndex = 2;
            this.infoLabel2.Text = "Enter conversion choice (1-4):";
            // 
            // infoLabel3
            // 
            this.infoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoLabel3.Location = new System.Drawing.Point(41, 243);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(204, 22);
            this.infoLabel3.TabIndex = 3;
            this.infoLabel3.Text = "Enter value to be converted:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(91, 280);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(255, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // choiceTextBox
            // 
            this.choiceTextBox.Location = new System.Drawing.Point(267, 211);
            this.choiceTextBox.MaxLength = 1;
            this.choiceTextBox.Name = "choiceTextBox";
            this.choiceTextBox.Size = new System.Drawing.Size(100, 20);
            this.choiceTextBox.TabIndex = 5;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(267, 242);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(12, 347);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(410, 22);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 386);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.choiceTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Linear Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox choiceTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

