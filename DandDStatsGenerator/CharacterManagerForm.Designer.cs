namespace DandDStatsGenerator
{
    partial class CharacterManagerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GenerateStats
            // 
            this.GenerateStats.Location = new System.Drawing.Point(147, 43);
            this.GenerateStats.Name = "GenerateStats";
            this.GenerateStats.Size = new System.Drawing.Size(86, 38);
            this.GenerateStats.TabIndex = 0;
            this.GenerateStats.Text = "Generate stats";
            this.GenerateStats.UseVisualStyleBackColor = true;
            this.GenerateStats.Click += new System.EventHandler(this.GenerateStats_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 368);
            this.listBox1.TabIndex = 1;
            // 
            // CharacterManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 393);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GenerateStats);
            this.Name = "CharacterManagerForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateStats;
        private System.Windows.Forms.ListBox listBox1;
    }
}