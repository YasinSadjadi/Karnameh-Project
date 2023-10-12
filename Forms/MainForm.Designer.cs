namespace Karnameh_Project
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
            label1 = new Label();
            fillScoreButton = new Button();
            WatchScoreButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 164);
            label1.Name = "label1";
            label1.Size = new Size(288, 28);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Karnameh project";
            // 
            // fillScoreButton
            // 
            fillScoreButton.Location = new Point(639, 383);
            fillScoreButton.Name = "fillScoreButton";
            fillScoreButton.Size = new Size(122, 29);
            fillScoreButton.TabIndex = 2;
            fillScoreButton.Text = "fill the score";
            fillScoreButton.UseVisualStyleBackColor = true;
            fillScoreButton.Click += fillScoreButton_Click;
            // 
            // WatchScoreButton
            // 
            WatchScoreButton.Location = new Point(37, 383);
            WatchScoreButton.Name = "WatchScoreButton";
            WatchScoreButton.Size = new Size(132, 29);
            WatchScoreButton.TabIndex = 3;
            WatchScoreButton.Text = "watch the scores";
            WatchScoreButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WatchScoreButton);
            Controls.Add(fillScoreButton);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(fillScoreButton, 0);
            Controls.SetChildIndex(WatchScoreButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button fillScoreButton;
        private Button WatchScoreButton;
    }
}