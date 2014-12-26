namespace CircleApp
{
    partial class CircelUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.diameterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.perimeterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius ";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(180, 37);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.AllowDrop = true;
            this.showButton.Location = new System.Drawing.Point(190, 89);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Diameter";
            // 
            // diameterTextBox
            // 
            this.diameterTextBox.Location = new System.Drawing.Point(180, 135);
            this.diameterTextBox.Name = "diameterTextBox";
            this.diameterTextBox.Size = new System.Drawing.Size(100, 20);
            this.diameterTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Area";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(180, 216);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Perimeter";
            // 
            // perimeterTextBox
            // 
            this.perimeterTextBox.Location = new System.Drawing.Point(180, 173);
            this.perimeterTextBox.Name = "perimeterTextBox";
            this.perimeterTextBox.Size = new System.Drawing.Size(100, 20);
            this.perimeterTextBox.TabIndex = 1;
            // 
            // CircelUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 291);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.perimeterTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.diameterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CircelUI";
            this.Text = "Circle UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diameterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox perimeterTextBox;
    }
}

