using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutoRepair.Tests {
    [TestClass()]
    public class CarTest {
        Car testCar;

        [TestInitialize()]
        public void SetUp() {
            testCar = new Car("Test make", "Test model", 2022);
            testCar.AddRepair(DateTime.Now, "Test1", 25.00);
            testCar.AddRepair(DateTime.Now, "Test2", 15.00);
            testCar.AddRepair(DateTime.Now, "Test3", 35.00);
        }

        [TestMethod()]
        public void AddInitalRepairTest() {
            Assert.AreEqual(3, testCar.NumberRepair());
        }

        [TestMethod()]
        public void AddRepairTest() {
            testCar.AddRepair(DateTime.Now, "Test4", 50.00);
            Assert.AreEqual(4, testCar.NumberRepair());
        }

        [TestMethod()]
        public void TotalAmountTest() {
            Assert.AreEqual(25 + 15 + 35, testCar.TotalRepairs());
        }

        [TestMethod()]
        public void LatestRepairTest() {
            DateTime dateTimeTest = DateTime.Now.AddDays(1);
            Repair latestRepairTest = new Repair(dateTimeTest, "TestLatest", 75.00);
            testCar.AddRepair(dateTimeTest, "TestLatest", 75.00);
            Repair returnTestRepair = testCar.LatestRepair();
            Assert.AreEqual(latestRepairTest.Date, returnTestRepair.Date);
            Assert.AreEqual(latestRepairTest.Description, returnTestRepair.Description);
            Assert.AreEqual(latestRepairTest.Amount, returnTestRepair.Amount);
        }
    }
}
