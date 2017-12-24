using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class TryCatch : Form
    {
        List<int> Numbers = new List<int>();
        public TryCatch()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int EnteredNumber = Convert.ToInt32(enterInputTextBox.Text);
                Numbers.Add(EnteredNumber);
                foreach (int item in Numbers)
                    outputTextBox.Text += item.ToString();
            }
            catch(OverflowException)
            {
                MessageBox.Show("entered number is too big for integer");
            }
            catch (FormatException)
            {
                MessageBox.Show("please enter correct input");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int EnteredNumber = Convert.ToInt32(enterInputTextBox.Text);
                Numbers.RemoveAt(EnteredNumber);
                foreach (int item in Numbers)
                    outputTextBox.Text += item.ToString();
            }
            catch(OverflowException)
            {
                MessageBox.Show("enter the value which is in the integer range");
            }
            catch (FormatException)
            {
                MessageBox.Show("enter integer values");
            }
        }
    }
}
