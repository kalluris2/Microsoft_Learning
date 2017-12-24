using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDictionary
{
    public partial class Dictionary : Form
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        public Dictionary()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int Key = Convert.ToInt32(keyTextBox.Text);
            int Value = Convert.ToInt32(ValueTextBox.Text);
            numbers.Add(Key, Value);
            foreach( KeyValuePair<int, int> pair in numbers)
            {
                outputKeyTextBox.Text += Convert.ToString(pair.Key);
                outputValueTextBox.Text += Convert.ToString(pair.Value);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int Key = Convert.ToInt32(keyTextBox.Text);
            int Value = Convert.ToInt32(ValueTextBox.Text);
            numbers.Remove(Key);
            foreach (KeyValuePair<int, int> pair in numbers)
            {                              
                outputKeyTextBox.Text += Convert.ToString(pair.Key);
                outputValueTextBox.Text += Convert.ToString(pair.Value);

            }
        }
    }
}
