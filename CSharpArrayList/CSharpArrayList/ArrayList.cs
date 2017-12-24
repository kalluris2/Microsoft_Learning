using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpArrayList
{
    public partial class ArrayList : Form
    {
        System.Collections.ArrayList numbers = new System.Collections.ArrayList();
        public ArrayList()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int enteredValue = Convert.ToInt32(enterInputtextBox.Text);
            numbers.Add(enteredValue);
            foreach (int item in numbers)
                OutputTextBox.Text = OutputTextBox.Text+item.ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int enteredValue = Convert.ToInt32(enterInputtextBox.Text);
            numbers.RemoveAt(enteredValue);
            foreach (int item in numbers)
                OutputTextBox.Text = OutputTextBox.Text + item.ToString();



        }
    }
}
