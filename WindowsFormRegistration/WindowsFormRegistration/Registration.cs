using System;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormRegistration
{


    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string enteredinput = (enterUserNameTextBox.Text);
            if (enteredinput == null)
                MessageBox.Show("please enter  valid userID");
            string enteredpassword = (enterPasswordTextBox.Text);
            if (string.IsNullOrEmpty(enteredpassword))
                MessageBox.Show("please enter valid password");
            string conformpassword = (conformPasswordTextBox.Text);
            if (string.IsNullOrEmpty(conformpassword))
                MessageBox.Show("please enter valid password");
            else if (!conformpassword.Equals(enteredpassword))
            {
                MessageBox.Show("conform Password dont match with password, enter valid password");
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);

                XmlNode rootNode = doc.CreateElement("registration");
                doc.AppendChild(rootNode);


                XmlNode userNode = doc.CreateElement("user");
                XmlAttribute userAttribute = doc.CreateAttribute("id");
                userAttribute.Value = enteredinput;
                userNode.Attributes.Append(userAttribute);
                rootNode.AppendChild(userNode);
                XmlAttribute passwordAttribute = doc.CreateAttribute("password");
                passwordAttribute.Value = enteredpassword;
                userNode.Attributes.Append(passwordAttribute);
                rootNode.AppendChild(userNode);
                doc.Save(@"E:\User-Registration.xml");
                MessageBox.Show("node registered sucessfully");

            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            enterUserNameTextBox.Clear();
            enterPasswordTextBox.Clear();
            conformPasswordTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
