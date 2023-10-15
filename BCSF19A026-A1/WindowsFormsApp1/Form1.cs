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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> subjects;
        public Form1()
        {
            InitializeComponent();
            this.subjects = new List<String>();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            string firstname = this.first.Text;
            string lastname = this.last.Text;
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("All fields are required.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string subject = this.comboBox1.SelectedItem != null ? this.comboBox1.SelectedItem.ToString() : "";
            if (string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please add atleast one subject.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (subjects.Contains(subject))
            {
                MessageBox.Show($"{subject} has already been added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool check = this.checkBox1.Checked;
                if (check)
                {
                    subjects.Add(subject);
                    subjects_list.Items.Add(subject);
                    MessageBox.Show($"{subject} has been added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Only students with pre-requisites clear are allowed to enroll in a subject", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            
            if (subjects.Count > 0)
            {
                this.label4.Text = $"First Name: {firstname}, Last Name: {lastname}\n" +
                    $"Subjects Enrolled: ";
                foreach (var sub in this.subjects)
                {
                    this.label4.Text += sub;
                    label4.Text += ", ";
                }
                checkBox1.Checked = false;
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
