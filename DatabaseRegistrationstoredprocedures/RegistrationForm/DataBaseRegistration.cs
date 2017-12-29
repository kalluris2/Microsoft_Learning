using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using User;
using DatabaseOperations;
using DALStoredProcedure;

namespace RegistrationForm
{

    public partial class DataBaseRegistration : Form
    {
        

        public DataBaseRegistration()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserInput User = new UserInput();
            User.UserName = (enterUserNameTextBox.Text);
            User.UserId = (enterUserIdTextBox.Text);
            User.Password = (enterPasswordTextBox.Text);
            User.ConformPassword = (conformPasswordTextBox.Text);
            User.Role = (enterRoleTextBox.Text);

            if (string.IsNullOrEmpty(User.UserName))
                MessageBox.Show("enter user name");
            else if (string.IsNullOrEmpty(User.UserId))
                MessageBox.Show("enter user ID");
            else if (string.IsNullOrEmpty(User.Password))
                MessageBox.Show("enter password");
            else if (!(Regex.IsMatch(User.Password, pattern: @"^[a-zA-Z0-9]*$")))
            {
                MessageBox.Show(text: "enter valid password which contains 'a-z','A-Z','0-9'");
            }

            else if (User.Password.Length > 10)
                MessageBox.Show("password length must be lessthan 10 characters");
            else if (string.IsNullOrEmpty(User.ConformPassword))
                MessageBox.Show("enter conform passowrd");
            else if (!User.ConformPassword.Equals(User.Password))
                MessageBox.Show("conform password did not match with password");
            else if (string.IsNullOrEmpty(User.Role))
                MessageBox.Show("enter role");
            else
            {
                StoredProcedure DataInsert = new StoredProcedure();
                DataInsert.Insert(User);
                MessageBox.Show("data entered into table");               
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            enterUserNameTextBox.Clear();
            enterPasswordTextBox.Clear();
            conformPasswordTextBox.Clear();
            enterUserIdTextBox.Clear();
            enterRoleTextBox.Clear();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UserInput User = new UserInput();
            User.UserName = (enterUserNameTextBox.Text);
            User.UserId = (enterUserIdTextBox.Text);
            User.Password = (enterPasswordTextBox.Text);
            User.Role = (enterRoleTextBox.Text);

            StoredProcedure DataUpdate = new StoredProcedure();
            DataUpdate.Update(User);

            MessageBox.Show(text: "updated data into table");
           
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UserInput User = new UserInput();
            User.UserId = (enterUserIdTextBox.Text);

            StoredProcedure DataDelete = new StoredProcedure();
            DataDelete.Delete(User);

            MessageBox.Show(text: "deleted data from table");
        }
        

        private void ViewDatabutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Connection= DatabaseConnection();
                Connection.Open();
                SqlCommand Command = new SqlCommand("select * from Data", Connection);
                DataSet Data = new DataSet();
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data.Tables[0];
                Connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public SqlConnection DatabaseConnection()
        {
            string Name = @"Data Source=DESKTOP-1FN2CN9;Initial Catalog=UserData;Integrated Security=true";
           // SqlConnection Connection =
                return new SqlConnection(Name);
           //return Connection;
        }
    }
}
