namespace IGDB_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectGame = new System.Windows.Forms.Button();
            this.txtSelectedGame = new System.Windows.Forms.TextBox();
            this.lstGameTitles = new System.Windows.Forms.ListBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGameSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Name:";
            // 
            // btnSelectGame
            // 
            this.btnSelectGame.Location = new System.Drawing.Point(426, 35);
            this.btnSelectGame.Name = "btnSelectGame";
            this.btnSelectGame.Size = new System.Drawing.Size(75, 23);
            this.btnSelectGame.TabIndex = 1;
            this.btnSelectGame.Text = "Select";
            this.btnSelectGame.UseVisualStyleBackColor = true;
            this.btnSelectGame.Click += new System.EventHandler(this.btnSelectGame_Click);
            // 
            // txtSelectedGame
            // 
            this.txtSelectedGame.Location = new System.Drawing.Point(118, 35);
            this.txtSelectedGame.Name = "txtSelectedGame";
            this.txtSelectedGame.Size = new System.Drawing.Size(286, 20);
            this.txtSelectedGame.TabIndex = 2;
            // 
            // lstGameTitles
            // 
            this.lstGameTitles.FormattingEnabled = true;
            this.lstGameTitles.Location = new System.Drawing.Point(118, 91);
            this.lstGameTitles.Name = "lstGameTitles";
            this.lstGameTitles.Size = new System.Drawing.Size(286, 95);
            this.lstGameTitles.TabIndex = 3;
            this.lstGameTitles.Click += new System.EventHandler(this.lstGameTitles_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(30, 301);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(35, 13);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "label2";
            // 
            // lblGameSummary
            // 
            this.lblGameSummary.AutoSize = true;
            this.lblGameSummary.Location = new System.Drawing.Point(30, 332);
            this.lblGameSummary.Name = "lblGameSummary";
            this.lblGameSummary.Size = new System.Drawing.Size(35, 13);
            this.lblGameSummary.TabIndex = 5;
            this.lblGameSummary.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 506);
            this.Controls.Add(this.lblGameSummary);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lstGameTitles);
            this.Controls.Add(this.txtSelectedGame);
            this.Controls.Add(this.btnSelectGame);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectGame;
        private System.Windows.Forms.TextBox txtSelectedGame;
        private System.Windows.Forms.ListBox lstGameTitles;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblGameSummary;
    }
}

