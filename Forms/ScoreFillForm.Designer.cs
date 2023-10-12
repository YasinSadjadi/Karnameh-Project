namespace Karnameh_Project
{
    partial class ScoreFillForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            ScoreTextBox = new TextBox();
            ScoreLabel = new Label();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            FirstNameSumbitButton = new Button();
            LastNameSubmitButton = new Button();
            ScoreSubmitButton = new Button();
            submitAllButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 132);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 1;
            label1.Text = "FirstName : ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 214);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "LastName : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 302);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Score : ";
            // 
            // ScoreTextBox
            // 
            ScoreTextBox.Location = new Point(165, 302);
            ScoreTextBox.Name = "ScoreTextBox";
            ScoreTextBox.Size = new Size(168, 27);
            ScoreTextBox.TabIndex = 6;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(165, 347);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(156, 20);
            ScoreLabel.TabIndex = 7;
            ScoreLabel.Text = "Please enter a number";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(165, 262);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(0, 20);
            LastNameLabel.TabIndex = 8;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(165, 177);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(0, 20);
            FirstNameLabel.TabIndex = 9;
            // 
            // FirstNameSumbitButton
            // 
            FirstNameSumbitButton.Location = new Point(356, 132);
            FirstNameSumbitButton.Name = "FirstNameSumbitButton";
            FirstNameSumbitButton.Size = new Size(94, 27);
            FirstNameSumbitButton.TabIndex = 10;
            FirstNameSumbitButton.Text = "submit";
            FirstNameSumbitButton.UseVisualStyleBackColor = true;
            FirstNameSumbitButton.Click += FirstNameSumbitButton_Click;
            // 
            // LastNameSubmitButton
            // 
            LastNameSubmitButton.Location = new Point(356, 214);
            LastNameSubmitButton.Name = "LastNameSubmitButton";
            LastNameSubmitButton.Size = new Size(94, 27);
            LastNameSubmitButton.TabIndex = 11;
            LastNameSubmitButton.Text = "submit";
            LastNameSubmitButton.UseVisualStyleBackColor = true;
            LastNameSubmitButton.Click += LastNameSubmitButton_Click_1;
            // 
            // ScoreSubmitButton
            // 
            ScoreSubmitButton.Location = new Point(356, 302);
            ScoreSubmitButton.Name = "ScoreSubmitButton";
            ScoreSubmitButton.Size = new Size(94, 27);
            ScoreSubmitButton.TabIndex = 12;
            ScoreSubmitButton.Text = "submit";
            ScoreSubmitButton.UseVisualStyleBackColor = true;
            ScoreSubmitButton.Click += ScoreSubmitButton_Click;
            // 
            // submitAllButton
            // 
            submitAllButton.Location = new Point(662, 396);
            submitAllButton.Name = "submitAllButton";
            submitAllButton.Size = new Size(94, 29);
            submitAllButton.TabIndex = 13;
            submitAllButton.Text = "submit all";
            submitAllButton.UseVisualStyleBackColor = true;
            submitAllButton.Click += submitAllButton_Click;
            // 
            // ScoreFillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitAllButton);
            Controls.Add(ScoreSubmitButton);
            Controls.Add(LastNameSubmitButton);
            Controls.Add(FirstNameSumbitButton);
            Controls.Add(FirstNameLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(ScoreLabel);
            Controls.Add(ScoreTextBox);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ScoreFillForm";
            Text = "ScoreFillForm";
            Load += ScoreFillForm_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBox2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(ScoreTextBox, 0);
            Controls.SetChildIndex(ScoreLabel, 0);
            Controls.SetChildIndex(LastNameLabel, 0);
            Controls.SetChildIndex(FirstNameLabel, 0);
            Controls.SetChildIndex(FirstNameSumbitButton, 0);
            Controls.SetChildIndex(LastNameSubmitButton, 0);
            Controls.SetChildIndex(ScoreSubmitButton, 0);
            Controls.SetChildIndex(submitAllButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox ScoreTextBox;
        private Label ScoreLabel;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private Button FirstNameSumbitButton;
        private Button LastNameSubmitButton;
        private Button ScoreSubmitButton;
        private Button submitAllButton;
    }
}