using DataBaseConnection;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chitIdComboBox.SelectedIndexChanged += new EventHandler(chitIdComboBox_SelectedIndexChanged);

        }
        public void chitIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = chitIdComboBox.SelectedValue.ToString();
            Operations viewdata = new Operations();
            DataSet Data = viewdata.ViewData(value);
            dataGridView.DataSource = Data.Tables[0];
        }

        private void viewPersonChitsButton_Click(object sender, EventArgs e)
        {

        }

        private void chitIdComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
