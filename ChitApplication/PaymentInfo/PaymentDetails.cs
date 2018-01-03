using DataBaseConnection;
using RegistrationInputs;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PaymentInfo
{
    public partial class PaymentDetails : Form
    {
        public PaymentDetails()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            paymentIdTextBox.Clear();
            registrationNumberTextBox.Clear();
            dateTextBox.Clear();
            amtPaidByTextBox.Clear();
            amtReceivedByTextBox.Clear();
            amtPaidTextBox.Clear();
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Person input = new Person();
            input.FirstName = (amtPaidByTextBox.Text);
            input.PaymentId = (paymentIdTextBox.Text);
            input.DatePaidOn = (dateTextBox.Text);
            input.AmountReceivedBy = (amtReceivedByTextBox.Text);

            if (!(Regex.IsMatch(registrationNumberTextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "registration number should contain only numbers from 0-9");
            }
            else if (!(Regex.IsMatch(amtPaidTextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "please enter valid amount");
            }
            else if (!((twoLkRadioButton.Checked) || (oneLkRadioButton.Checked) || (fiftyKRadioButton.Checked) || (tenKRadioButton.Checked)))
            {
                MessageBox.Show("please select one Chit Id ");
            }
            else if (string.IsNullOrEmpty(input.FirstName))
            {
                MessageBox.Show("please enter Amount paid by name");
            }
            else if (string.IsNullOrEmpty(input.DatePaidOn))
            {
                MessageBox.Show("please enter Date");
            }
            else if (string.IsNullOrEmpty(input.PaymentId))
            {
                MessageBox.Show("please enter Payment ID");
            }
            else if (string.IsNullOrEmpty(input.AmountReceivedBy))
            {
                MessageBox.Show("please enter Amount Received  by name");
            }
            else
            {
                input.RegistrationNumber = Convert.ToInt32(registrationNumberTextBox.Text);
                input.AmountPaid = Convert.ToInt32(amtPaidTextBox.Text);
                if (twoLkRadioButton.Checked == true)
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
                else if (tenKRadioButton.Checked == true)
                {
                    input.ChitId = "10k";
                }

                Operations Insert = new Operations();
                Insert.InsertPayment(input);
                MessageBox.Show("data entered into table");

            }
        }
    }
}
