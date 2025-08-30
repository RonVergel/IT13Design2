using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Controllers;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4
{
    public partial class Leads : Form
    {
        private LeadController leadController = new LeadController();
        public Leads()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addLeads form = new addLeads();
            form.ShowDialog();
            // Example: After closing addLeads, you could refresh the list from leadController
            // var leads = leadController.GetAllLeads();
        }
    }
}
