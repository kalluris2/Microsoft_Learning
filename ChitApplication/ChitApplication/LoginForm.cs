using ChitFundRegistration;
using DataBaseConnection;
using RegistrationInputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //EventHandler chitSelectorComboBox_SelectedIndexChanged = null;
            //chitSelectorComboBox.SelectedIndexChanged += new EventHandler(chitSelectorComboBox_SelectedIndexChanged);

        }

        private void organizerLoginPageButton_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
        }

        private void chitPayeeDetailsButton_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            //firstnametextbox.Clear();
            IDtextBox.Clear();
            passwordtextBox.Clear();
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeClearButton_Click(object sender, EventArgs e)
        {
            jobIdTextBox.Clear();
            employeeFirstNametextBox.Clear();
            employeeLastNametextBox.Clear();
            employeeIDTextBox.Clear();
            employeePasswordTextBox.Clear();
            employeeConfirmPasswordTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeSubmitButton_Click(object sender, EventArgs e)
        {
            Person input = new Person();
            input.FirstName = (employeeFirstNametextBox.Text);
            input.SecondName = (employeeLastNametextBox.Text);
            input.Password = (employeePasswordTextBox.Text);
            if (!(Regex.IsMatch(employeeIDTextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "Employee Id should contain only numbers from 0-9");
            }
            else if (!(Regex.IsMatch(jobIdTextBox.Text, pattern: "^[ 1-3]")))
            {
                MessageBox.Show(text: "Job ID should contain only numbers '1','2','3'");
            }
            else if (string.IsNullOrEmpty(input.FirstName))
            {
                MessageBox.Show("please enter first name");
            }
            else if (string.IsNullOrEmpty(input.SecondName))
            {
                MessageBox.Show("please enter last name");
            }
            else if (!(Regex.IsMatch(input.Password, pattern: @"^[a-zA-Z0-9]*$")))
            {
                MessageBox.Show(text: "Enter valid password which contains a-zA-Z0-9");
            }
            if (!(Regex.IsMatch(employeeConfirmPasswordTextBox.Text, pattern: @"^[a-zA-Z0-9]*$")))
            {
                MessageBox.Show(text: "Employee valid confirm password");
            }
            else if (!(employeeConfirmPasswordTextBox.Text).Equals(input.Password))
            {
                MessageBox.Show("conform password did not match with password");
            }
            else
            {
                input.JobId = Convert.ToInt32(jobIdTextBox.Text);
                input.EmployeeId = Convert.ToInt32(employeeIDTextBox.Text);
                Operations Insert = new Operations();
                Insert.InsertEmployee(input);
                MessageBox.Show("data entered into table");

            }
        }

        private void organizerRegisterButton_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
        }

        private void organizerLoginButton_Click(object sender, EventArgs e)
        {
            Person value = new Person();

            value.Password = passwordtextBox.Text;
            if (!(Regex.IsMatch(IDtextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "Employee Id should contain only numbers from 0-9");
            }
            else if (!(Regex.IsMatch(value.Password, pattern: @"^[a-zA-Z0-9]*$")))
            {
                MessageBox.Show(text: "Enter valid password which contains a-zA-Z0-9");
            }
            else if (string.IsNullOrEmpty(value.Password))
            {
                MessageBox.Show(text: "Enter password");
            }
            else
            {
                value.EmployeeId = Convert.ToInt32(IDtextBox.Text);
                Operations Authentication = new Operations();
                bool res=Authentication.EmployeeLogin(value.EmployeeId, value.Password);
                if (res)
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    UserRegistration form = new UserRegistration();

                    //PaymentDetails form = new PaymentDetails();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("please enter correct details");
                }

                

            }

        }

        private void customerClearbutton_Click(object sender, EventArgs e)
        {
            registrationnumbertextBox.Clear();
            customerPasswordTextBox.Clear();
            customerFirstNameTextBox.Clear();
        }

        private void customerExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerLoginbutton_Click(object sender, EventArgs e)
        {
            Person value = new Person();
            value.FirstName = customerFirstNameTextBox.Text;
            value.Password = customerPasswordTextBox.Text;
            if (!(Regex.IsMatch(registrationnumbertextBox.Text, pattern: "^[ 0-9]")))
            {
                MessageBox.Show(text: "Employee Id should contain only numbers from 0-9");
            }
            else if (!(Regex.IsMatch(value.Password, pattern: @"^[a-zA-Z0-9]*$")))
            {
                MessageBox.Show(text: "Enter valid password which contains a-zA-Z0-9");
            }
            else if (string.IsNullOrEmpty(value.Password))
            {
                MessageBox.Show(text: "Enter password");
            }
            else if (string.IsNullOrEmpty(value.FirstName))
            {
                MessageBox.Show("enter first name");
            }

            else
            {
                value.RegistrationNumber = Convert.ToInt32(registrationnumbertextBox.Text);
                Operations Authentication = new Operations();
                bool res = Authentication.CustomerLogin(value.RegistrationNumber, value.Password);
                if (res)
                {
                    MessageBox.Show("Login Successful");
                    //EventHandler chitSelectorComboBox_SelectedIndexChanged = null;
                    //  chitSelectorComboBox.SelectedIndexChanged += new EventHandler(chitSelectorComboBox_SelectedIndexChanged);
                    GetChitValues();


                }
            }
        }
        public void chitSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetChitValues();
        }

        private void GetChitValues()
        {
            string value = "";
            if (chitSelectorComboBox.SelectedItem != null)
                value = chitSelectorComboBox.SelectedItem.ToString();
            Operations viewdata = new Operations();
            var Data = viewdata.ViewData(value);
            customerDataGridView.DataSource = Data;
        }
    }
}
