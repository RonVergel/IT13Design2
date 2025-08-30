using System.Collections.Generic;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4.Controllers
{
    public class DealController
    {
        private List<Deal> deals = new List<Deal>();

        public IEnumerable<Deal> GetAllDeals()
        {
            return deals;
        }

        public void AddDeal(Deal deal)
        {
            deals.Add(deal);
        }

        // Add more methods as needed (Edit, Delete, etc.)
    }
}