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
            this.strengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthLabel.Location = new System.Drawing.Point(248, 6);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(29, 17);
            this.strengthLabel.TabIndex = 2;
            this.strengthLabel.Text = "Str";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Str";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CharacterManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GenerateStats);
            this.Name = "CharacterManagerForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateStats;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label label1;
    }
}