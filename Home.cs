using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoadFormInPanel(Form form)
        {
            panel3.Controls.Clear();             
            form.TopLevel = false;                        
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.Fill;                  
            panel3.Controls.Add(form);          
            form.Show();                                  
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Search for leads, properties, and more... ")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;   
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "Search for leads, properties, and more... ";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Leads());
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new Contacts());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Deals());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new frmProperties());
        }
    }
}
