using System.Collections.Generic;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4.Controllers
{
    public class LeadController
    {
        private List<Lead> leads = new List<Lead>();

        public IEnumerable<Lead> GetAllLeads()
        {
            return leads;
        }

        public void AddLead(Lead lead)
        {
            leads.Add(lead);
        }

        // Add more methods as needed (Edit, Delete, etc.)
    }
}