namespace Karnameh_Project
{
    partial class ExitForm
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
            noButton = new Button();
            yesButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // noButton
            // 
            noButton.Location = new Point(104, 92);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 0;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += NoButton_Click;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(474, 92);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 1;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += YesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 22);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 2;
            label1.Text = "Are you sure to exit?";
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(693, 145);
            Controls.Add(label1);
            Controls.Add(yesButton);
            Controls.Add(noButton);
            Name = "ExitForm";
            Text = "ExitForm";
            Load += ExitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button noButton;
        private Button yesButton;
        private Label label1;
    }
}