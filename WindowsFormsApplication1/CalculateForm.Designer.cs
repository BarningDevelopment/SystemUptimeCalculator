namespace CalculateFormApplication
{
    partial class CalculateForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ComputerNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DagenActief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Minuten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seconden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MilliSeconden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComputerNaam,
            this.DagenActief,
            this.Uren,
            this.Minuten,
            this.Seconden,
            this.MilliSeconden});
            this.listView1.Location = new System.Drawing.Point(25, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 194);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ComputerNaam
            // 
            this.ComputerNaam.Text = "ComputerNaam";
            this.ComputerNaam.Width = 200;
            // 
            // DagenActief
            // 
            this.DagenActief.Text = "Dagen Actief";
            this.DagenActief.Width = 80;
            // 
            // Uren
            // 
            this.Uren.Text = "uren";
            // 
            // Minuten
            // 
            this.Minuten.Text = "Minuten";
            // 
            // Seconden
            // 
            this.Seconden.Text = "Seconden";
            // 
            // MilliSeconden
            // 
            this.MilliSeconden.Text = "MilliSeconden";
            this.MilliSeconden.Width = 100;
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 277);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "CalculateForm";
            this.Text = "BarningSystemUptimeCalculator";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ComputerNaam;
        private System.Windows.Forms.ColumnHeader DagenActief;
        private System.Windows.Forms.ColumnHeader Uren;
        private System.Windows.Forms.ColumnHeader Minuten;
        private System.Windows.Forms.ColumnHeader Seconden;
        private System.Windows.Forms.ColumnHeader MilliSeconden;
    }
}