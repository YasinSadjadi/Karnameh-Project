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
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            ScoreForm.f1 = this;
        }
        ScoreFillForm ScoreForm = new ScoreFillForm();
        
        
        

        public List<Person> Students = new List<Person>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void fillScoreButton_Click(object sender, EventArgs e)
        {
            var ScoreForm = new ScoreFillForm();
            ScoreForm.ShowDialog();
        }
    }
}
