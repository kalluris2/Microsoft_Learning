using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpList
{
    public partial class List : Form
    {
        List<int> numbers = new List<int>();
        int i = 0;

        public List()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int enteredNumber = Convert.ToInt32(EnterInputTextbox.Text);
                    
                numbers.Add(enteredNumber);
               
                     
            foreach (int item in numbers)
                outputTextBox.Text +=  item.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /* int enteredNumber = Convert.ToInt32(EnterInputTextbox.Text);
             numbers.Remove(enteredNumber);
             foreach (int item in numbers)
                 outputTextBox.Text += item.ToString();*/
            //to remove a value which is in specific index we use removeAt

            int enteredNumber = Convert.ToInt32(EnterInputTextbox.Text);
            numbers.RemoveAt(enteredNumber);
            foreach (int item in numbers)
                outputTextBox.Text += item.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
