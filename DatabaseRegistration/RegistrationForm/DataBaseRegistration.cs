using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Data;
using System.Data.SqlClient;

namespace RegistrationForm
{

    public partial class DataBaseRegistration : Form
    {
        string userName;

        public DataBaseRegistration()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string userName = (enterUserNameTextBox.Text);
            string userId = (enterUserIdTextBox.Text);
            string password = (enterPasswordTextBox.Text);
            string conformPassword = (conformPasswordTextBox.Text);
            string role = (enterRoleTextBox.Text);

            if (string.IsNullOrEmpty(userName))
                MessageBox.Show("enter user name");
            else if (string.IsNullOrEmpty(userId))
                MessageBox.Show("enter user ID");
            else if (string.IsNullOrEmpty(password))
                MessageBox.Show("enter password");
            else if (!(Regex.IsMatch(password, pattern: @"^[a-zA-Z0-9]*$")))
            {
                MessageBox.Show(text: "enter valid password which contains 'a-z','A-Z','0-9'");
            }

            else if (password.Length > 10)
                MessageBox.Show("password length must be lessthan 10 characters");
            else if (string.IsNullOrEmpty(conformPassword))
                MessageBox.Show("enter conform passowrd");
            else if (!conformPassword.Equals(password))
                MessageBox.Show("conform password did not match with password");
            else if (string.IsNullOrEmpty(role))
                MessageBox.Show("enter role");
            else
            {
               
                try
                {
                    SqlConnection Connection = DatabaseConnection();
                    string InsertData = "insert into dbo.Data values('" + userName + "','" + userId + "','" + password + "','" + role + "')";
                    SqlCommand Command = new SqlCommand(InsertData, Connection);
                    Command.ExecuteNonQuery();         

                    Connection.Close();
                    MessageBox.Show("data entered into table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
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
            string userName = (enterUserNameTextBox.Text);
            string userId = (enterUserIdTextBox.Text);
            string password = (enterPasswordTextBox.Text);
            string conformPassword = (conformPasswordTextBox.Text);
            string role = (enterRoleTextBox.Text);

            try
            {
                SqlConnection Connection = DatabaseConnection();
                string InsertData = "update dbo.Data set UserName='" + userName + "'," + "Password='" + password + "'," + "Role='" + role + "'"+  "where UserId='" + userId + "';";                         
                          
                SqlCommand Command = new SqlCommand(InsertData, Connection);
                
                Command.ExecuteNonQuery();

                Connection.Close();
                MessageBox.Show(text: "updated data into table");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string userId = (enterUserIdTextBox.Text);
            try
            {
                SqlConnection Connection = DatabaseConnection();
                string DeleteData = "delete from dbo.Data where UserId='" + userId + "';";     


                SqlCommand Command = new SqlCommand(DeleteData, Connection);

                Command.ExecuteNonQuery();

                Connection.Close();
                MessageBox.Show(text: "deleted data from table");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

        }

        private void ViewDatabutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Connection= DatabaseConnection();
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
            string userId = (enterUserIdTextBox.Text);
            string Name = @"Data Source=DESKTOP-1FN2CN9;Initial Catalog=UserData;Integrated Security=true";
            SqlConnection Connection = new SqlConnection(Name);
            Connection.Open();
            return Connection;
        }
    }
}
