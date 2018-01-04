using ChitApplication;
using DataBaseConnection;
using RegistrationInputs;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChitFundRegistration
{
    public partial class PaymentDetails : Form
    {
        public PaymentDetails()
        {
            InitializeComponent();
            chitIdComboBox.SelectedIndexChanged += new EventHandler(chitIdComboBox_SelectedIndexChanged);
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
        public void chitIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = "";
            if (chitIdComboBox.SelectedItem!=null)
             value= chitIdComboBox.SelectedItem.ToString();
            Operations viewdata = new Operations();
            var Data = viewdata.ViewData(value);
            dataGridView.DataSource = Data.Tables[0];
        }

        
        private void paymentViewTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void paymentRegistrationTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void paymentEditTabbutton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            PatmentidTextBox.Clear();
            RegistrationNotextBox.Clear();
            datepaidTextBox.Clear();
            amountPaidByTextBox.Clear();
            amountPaidTextBox.Clear();
            AmountReceivedByTextBox.Clear();
        }

        private void SubbmitButton_Click(object sender, EventArgs e)
        {
            Person input = new Person();
            input.FirstName = (amountPaidByTextBox.Text);
            input.PaymentId = (PatmentidTextBox.Text);
            input.DatePaidOn = (datepaidTextBox.Text);
            input.AmountReceivedBy = (AmountReceivedByTextBox.Text);

            if (!(Regex.IsMatch(RegistrationNotextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "registration number should contain only numbers from 0-9");
            }
            else if (!(Regex.IsMatch(amountPaidTextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "please enter valid amount");
            }
            else if (!((twolksPolicyButton.Checked) || (onelkPolicyButton.Checked) || (fiftyThousandPolicyButton.Checked) || (tenThousandPolicyButton.Checked)))
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
                input.RegistrationNumber = Convert.ToInt32(RegistrationNotextBox.Text);
                input.AmountPaid = Convert.ToInt32(amountPaidTextBox.Text);
                if (twolksPolicyButton.Checked == true)
                {
                    input.ChitId = "2lks";
                }
                else if (onelkPolicyButton.Checked == true)
                {
                    input.ChitId = "1lk";
                }
                else if (fiftyThousandPolicyButton.Checked == true)
                {
                    input.ChitId = "50k";
                }
                else if (tenThousandPolicyButton.Checked == true)
                {
                    input.ChitId = "10k";
                }

                Operations Insert = new Operations();
                Insert.InsertPayment(input);
                MessageBox.Show("data entered into table");

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistration form = new UserRegistration();
            form.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            amountPaidByTextBox.Clear();
            PatmentidTextBox.Clear();
            datepaidTextBox.Clear();
            AmountReceivedByTextBox.Clear();

        }
    }
}
