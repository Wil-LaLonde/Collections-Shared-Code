using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepair
{
    public class Car
    {
        private List<Repair> repairList;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            repairList = new List<Repair>();
        }

        public void AddRepair(DateTime date, string description, double amount)
        {
            Repair repair = new Repair(date, description, amount);
            repairList.Add(repair);

        }
        
        public int NumberRepair()
        {
            return repairList.Count;
        }
        
        public double TotalRepairs()
        {
            double totalAmount = 0;
            foreach (Repair repair in repairList)
            {
                totalAmount += repair.Amount;
            }
            return totalAmount;
        }

        public Repair LatestRepair()
        {
            DateTime LatestDate = repairList[0].Date;
            foreach (Repair repair in repairList)
            {
                
            }
        }

    }
}
