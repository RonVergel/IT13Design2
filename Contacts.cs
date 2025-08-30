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
    public partial class Contacts : Form
    {
        private ContactController contactController = new ContactController();
        public Contacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addContacts form = new addContacts();
            form.ShowDialog();
            // Example: After closing addContacts, you could refresh the list from contactController
            // var contacts = contactController.GetAllContacts();
        }
    }
}
