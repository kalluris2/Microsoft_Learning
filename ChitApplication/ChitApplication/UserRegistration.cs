using DataBaseConnection;
using PaymentInfo;
using RegistrationInputs;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ChitApplication
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            registrationNumberTextBox.Clear();
            firstNameTextBox.Clear();
            secondNameTextBox.Clear();
            addressTextBox.Clear();
            phoneNumberTextBox.Clear();
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Person input = new Person();


            input.FirstName = (firstNameTextBox.Text);
            input.SecondName = (secondNameTextBox.Text);
            input.Address = (addressTextBox.Text);
            
            if (!(Regex.IsMatch(registrationNumberTextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "registration number should contain only numbers from 0-9");
            }
            else if (string.IsNullOrEmpty(registrationNumberTextBox.Text))
            {
                MessageBox.Show("please enter registration number");
            }
            else if(string.IsNullOrEmpty(input.FirstName))
            {
                MessageBox.Show("please enter first name");
            }
            else if (string.IsNullOrEmpty(input.SecondName))
            {
                MessageBox.Show("please enter second name");
            }
            else if (string.IsNullOrEmpty(input.Address))
            {
                MessageBox.Show("please enter address");
            }
            else if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("please enter phone number");
            }
            else if(!((twolksRadioButton.Checked) || (oneLkRadioButton.Checked)|| (fiftyKRadioButton.Checked)||(tenKRadioButton.Checked)))
            {
              MessageBox.Show("please select one Chit Id ");
            }
            else if (!(Regex.IsMatch(phoneNumberTextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "enter valid phone number");
            }

            else
            {
                input.RegistrationNumber = Convert.ToInt32(registrationNumberTextBox.Text);
                input.PhoneNumber = (phoneNumberTextBox.Text);
                if (twolksRadioButton.Checked == true)
                {
                    input.ChitId = "2lks";
                }
                else if (oneLkRadioButton.Checked == true)
                {
                    input.ChitId = "1lk";
                }
                else if (fiftyKRadioButton.Checked == true)
                {
                    input.ChitId = "50k";
                }
                else if(tenKRadioButton.Checked == true)
                {
                    input.ChitId = "10k";
                }

                Operations Insert = new Operations();
                Insert.InsertRegistration(input);
                MessageBox.Show("data entered into table");
                
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentDetails form2 = new PaymentDetails();
            form2.ShowDialog();
        }
    }
}
