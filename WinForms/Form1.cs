using WinForms.Presenter;
using WinForms.Views;

namespace WinForms
{
    public partial class Form1 : Form, IPerson
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string FirstName { get => firstNameText.Text; set => firstNameText.Text = value; }
        public string LastName { get => lastNameText.Text; set => lastNameText.Text = value; }

        private void sayHelloButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {firstNameText.Text} {lastNameText.Tex}"); // without MVP
            PersonPresenter personPresenter = new PersonPresenter(this);
            MessageBox.Show(personPresenter.SayFullName());

        }
    }
}