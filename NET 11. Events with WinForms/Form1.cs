namespace NET_11._Events_with_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            BackColor = Color.Red;
            MessageBox.Show($"{button.Text}","Click");
        }
        private void SomeOtherMethod(object sender, EventArgs e)
        {
            MessageBox.Show("Salam", "Salam");
        }
    }
}
