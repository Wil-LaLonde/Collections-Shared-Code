namespace AutoRepair {
    public class Car {
        private List<Repair> repairList;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year) {
            Make = make;
            Model = model;
            Year = year;
            repairList = new List<Repair>();
        }

        public void AddRepair(DateTime date, string description, double amount) {
            Repair repair = new Repair(date, description, amount);
            repairList.Add(repair);
        }
        
        public int NumberRepair() {
            return repairList.Count;
        }
        
        public double TotalRepairs() {
            double totalAmount = 0;
            foreach (Repair repair in repairList)
            {
                totalAmount += repair.Amount;
            }
            return totalAmount;
        }

        public Repair LatestRepair() {
            Repair latestRepair = repairList[0];
            DateTime latestDate = repairList[0].Date;
            foreach (Repair repair in repairList)
            {
                if(latestDate < repair.Date) {
                    latestRepair = repair;
                    latestDate = repair.Date;
                }
            }
            return latestRepair;
        }
    }
}
