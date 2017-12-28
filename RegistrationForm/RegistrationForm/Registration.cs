using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;

namespace RegistrationForm
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
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
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = false,
                    NewLineOnAttributes = true,
                };
                try
                {
                    string path = @"F:\\test.xml";
                    XmlWriter xmlWriter = XmlWriter.Create(path, settings);
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("XML");
                    xmlWriter.WriteStartElement("users");
                    xmlWriter.WriteStartElement("id");

                    //to display inside angular brackets use writeattributestring
                    //xmlwriter.writeattributestring("value")
                    xmlWriter.WriteString(userId);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteStartElement("Name");
                    xmlWriter.WriteString(userName);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteStartElement("password");
                    xmlWriter.WriteString(password);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteStartElement("Role");
                    xmlWriter.WriteString(role);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                    MessageBox.Show("node registered sucessfully");
                }
                catch(System.IO.DirectoryNotFoundException exception)
                {
                    MessageBox.Show("No such Directory in the system"+ exception.Message);
                }

                
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            enterUserNameTextBox.Clear();
            enterPasswordTextBox.Clear();
            conformPasswordTextBox.Clear();
            enterUserIdTextBox.Clear();
            enterRoleTextBox.Clear();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
