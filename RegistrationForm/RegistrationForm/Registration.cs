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
            string entereduserid = (enterUserIdTextBox.Text);
            string enteredpassword = (enterPasswordTextBox.Text);
            string conformpassword = (conformPasswordTextBox.Text);
            string enteredrole = (enterRoleTextBox.Text);

            if (string.IsNullOrEmpty(userName))
                MessageBox.Show("enter user name");
            else if (string.IsNullOrEmpty(entereduserid))
                MessageBox.Show("enter user ID");
            else if (string.IsNullOrEmpty(enteredpassword))
                MessageBox.Show("enter password");
            else if (!Regex.IsMatch(enteredpassword, "[a-zA-Z0-9]"))
                MessageBox.Show("enter valid password");
            else if (string.IsNullOrEmpty(conformpassword))
                MessageBox.Show("enter conform passowrd");
            else if (!conformpassword.Equals(enteredpassword))
                MessageBox.Show("conform password did not match with password");
            else if (string.IsNullOrEmpty(enteredrole))
                MessageBox.Show("enter role");
            else
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = false,
                    OmitXmlDeclaration = true,
                    NewLineOnAttributes = false
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
                    xmlWriter.WriteString(entereduserid);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteStartElement("Name");
                    xmlWriter.WriteString(userName);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteStartElement("password");
                    xmlWriter.WriteString(enteredpassword);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteStartElement("Role");
                    xmlWriter.WriteString(enteredrole);
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
