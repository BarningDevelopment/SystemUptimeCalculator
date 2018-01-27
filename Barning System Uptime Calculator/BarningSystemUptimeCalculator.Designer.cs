namespace BarningSystemUptimeCalculator
{
    partial class BarningSystemUptimeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarningSystemUptimeCalculator));
            this.Calculate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calculate_button
            // 
            this.Calculate_button.BackColor = System.Drawing.Color.Navy;
            this.Calculate_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Calculate_button.Location = new System.Drawing.Point(189, 209);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(98, 23);
            this.Calculate_button.TabIndex = 0;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = false;
            this.Calculate_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // BarningSystemUptimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(467, 272);
            this.Controls.Add(this.Calculate_button);
            this.Name = "BarningSystemUptimeCalculator";
            this.Text = "Barning System Uptime Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calculate_button;
    }
}

