using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepair
{
    public class Repair
    {
        private double amount;
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount {
            get { return amount; }
            private set { amount = value; }
        }

        public Repair(DateTime date, string description, double amount) {
            Date = date;
            Description = description;
            Amount = amount;
        }
    }
}
