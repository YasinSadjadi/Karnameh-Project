namespace Karnameh_Project
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }



        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            ExitForm ExitForm1
               = new ExitForm();

            ExitForm1.ShowDialog();
        }
    }
}