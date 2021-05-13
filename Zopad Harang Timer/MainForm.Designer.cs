namespace Zopad_Harang_Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.CustomPathCheck = new System.Windows.Forms.CheckBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(360, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zopad harang élményei";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveButton.Location = new System.Drawing.Point(504, 300);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(299, 221);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove Last";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(112, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default path:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PathLabel.Location = new System.Drawing.Point(244, 131);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(13, 20);
            this.PathLabel.TabIndex = 4;
            this.PathLabel.Text = ".";
            // 
            // CustomPathCheck
            // 
            this.CustomPathCheck.AutoSize = true;
            this.CustomPathCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomPathCheck.Location = new System.Drawing.Point(504, 126);
            this.CustomPathCheck.Name = "CustomPathCheck";
            this.CustomPathCheck.Size = new System.Drawing.Size(135, 28);
            this.CustomPathCheck.TabIndex = 5;
            this.CustomPathCheck.Text = "Custom Path";
            this.CustomPathCheck.UseVisualStyleBackColor = true;
            this.CustomPathCheck.CheckedChanged += new System.EventHandler(this.CustomPathCheck_CheckedChanged);
            // 
            // PathBox
            // 
            this.PathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PathBox.Location = new System.Drawing.Point(504, 172);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(384, 24);
            this.PathBox.TabIndex = 6;
            this.PathBox.Visible = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningLabel.Location = new System.Drawing.Point(645, 133);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(258, 15);
            this.WarningLabel.TabIndex = 7;
            this.WarningLabel.Text = "Note: unchecking this will revert to default path";
            this.WarningLabel.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(42, 300);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(183, 221);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Enabled = false;
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndButton.Location = new System.Drawing.Point(248, 300);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(183, 221);
            this.EndButton.TabIndex = 9;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProgressLabel.ForeColor = System.Drawing.Color.Red;
            this.ProgressLabel.Location = new System.Drawing.Point(111, 239);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(259, 25);
            this.ProgressLabel.TabIndex = 10;
            this.ProgressLabel.Text = "Harangozás in progress...";
            this.ProgressLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 641);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.CustomPathCheck);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "HARANG!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.CheckBox CustomPathCheck;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label ProgressLabel;
    }
}

