using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karnameh_Project
{
    public partial class ScoreFillForm : BaseForm
    {
        public ScoreFillForm()
        {
            InitializeComponent();
        }
        public MainForm f1 = new MainForm();

        Person Student =
                new Person();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameSumbitButton_Click(object sender, EventArgs e)
        {
            Student.FirstName = FirstNameSumbitButton.Text;
            FirstNameLabel.Text = "submited";
            FirstNameLabel.ForeColor = Color.Blue;
        }




        private void ScoreFillForm_Load(object sender, EventArgs e)
        {

        }

        private void LastNameSubmitButton_Click_1(object sender, EventArgs e)
        {
            Student.LastName = LastNameSubmitButton.Text;
            LastNameLabel.ForeColor = Color.Blue;
            LastNameLabel.Text = "Submited";
        }

        private void ScoreSubmitButton_Click(object sender, EventArgs e)
        {
            double score = 0;
            bool NumberChecker = double.TryParse(ScoreTextBox.Text, out score);
            if (NumberChecker)
            {
                Student.Score = score;
                ScoreLabel.ForeColor = Color.Blue;
                ScoreLabel.Text = "Submited";
            }
            else
            {
                ScoreLabel.ForeColor = Color.DarkRed;
                ScoreLabel.Text = "Error , please try again";
            }
        }

        private void submitAllButton_Click(object sender, EventArgs e)
        {
            if (Student.FirstName != string.Empty && Student.LastName != string.Empty && Student.Score != -1)
            {
                f1.Students.Add(Student);
            }
        }
    }
}
