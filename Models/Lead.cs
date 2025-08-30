using System;

namespace WindowsFormsApp4.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public int Score { get; set; }
        public string Status { get; set; }
        public string Agent { get; set; }
    }
}