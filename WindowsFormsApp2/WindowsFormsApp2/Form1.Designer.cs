namespace WindowsFormsApp2
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
            this.ViestiLabel = new System.Windows.Forms.Label();
            this.ViestiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViestiLabel
            // 
            this.ViestiLabel.AutoSize = true;
            this.ViestiLabel.Location = new System.Drawing.Point(94, 74);
            this.ViestiLabel.Name = "ViestiLabel";
            this.ViestiLabel.Size = new System.Drawing.Size(35, 13);
            this.ViestiLabel.TabIndex = 0;
            this.ViestiLabel.Text = "label1";
            this.ViestiLabel.Visible = false;
            // 
            // ViestiButton
            // 
            this.ViestiButton.Location = new System.Drawing.Point(269, 267);
            this.ViestiButton.Name = "ViestiButton";
            this.ViestiButton.Size = new System.Drawing.Size(75, 23);
            this.ViestiButton.TabIndex = 1;
            this.ViestiButton.Text = "button1";
            this.ViestiButton.UseVisualStyleBackColor = true;
            this.ViestiButton.Click += new System.EventHandler(this.ViestiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViestiButton);
            this.Controls.Add(this.ViestiLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViestiLabel;
        private System.Windows.Forms.Button ViestiButton;
    }
}

