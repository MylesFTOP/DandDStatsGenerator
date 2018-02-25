namespace DandDStatsGenerator
{
    partial class MainForm
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
            this.GenerateStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateStats
            // 
            this.GenerateStats.Location = new System.Drawing.Point(84, 144);
            this.GenerateStats.Name = "GenerateStats";
            this.GenerateStats.Size = new System.Drawing.Size(86, 38);
            this.GenerateStats.TabIndex = 0;
            this.GenerateStats.Text = "Generate stats";
            this.GenerateStats.UseVisualStyleBackColor = true;
            this.GenerateStats.Click += new System.EventHandler(this.GenerateStats_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 393);
            this.Controls.Add(this.GenerateStats);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateStats;
    }
}