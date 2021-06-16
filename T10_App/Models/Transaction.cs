using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T10_App.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string CompanyName { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}
