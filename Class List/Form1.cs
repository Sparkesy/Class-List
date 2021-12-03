using System;
using System.Windows.Forms;

namespace Class_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // grab the value supplied
            string newstudent = txtbxStudentName.Text;
            // add the name to the listbox
            listBox1.Items.Add(newstudent);
            // clear the textbox
            txtbxStudentName.Clear();
            // make sure that the textbox gets focus back
            txtbxStudentName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //check for selection
            if (listBox1.SelectedItem != null)
            {
                // remove from names list the currently selected name
                listBox1.Items.Remove(listBox1.SelectedItem);
                //o selection show error message
            }
            else
            {
                MessageBox.Show("No selection has been made",
                "Remove name",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if any names currently listed
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            // names loaded show error message
            else
                MessageBox.Show("No students have been entered",
                "Clear names",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}

