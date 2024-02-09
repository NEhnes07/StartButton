namespace StartButton
{
    partial class BackgroundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.CountdownText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.FlatAppearance.BorderSize = 2;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("NSimSun", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StartButton.Location = new System.Drawing.Point(142, 74);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(222, 78);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CountdownText
            // 
            this.CountdownText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountdownText.Font = new System.Drawing.Font("NSimSun", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountdownText.Location = new System.Drawing.Point(60, 232);
            this.CountdownText.Name = "CountdownText";
            this.CountdownText.Size = new System.Drawing.Size(381, 66);
            this.CountdownText.TabIndex = 1;
            this.CountdownText.Text = "Starting in 3..";
            this.CountdownText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackgroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(505, 371);
            this.Controls.Add(this.CountdownText);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackgroundForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label CountdownText;
    }
}

