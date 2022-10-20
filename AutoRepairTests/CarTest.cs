using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutoRepair.Tests {
    [TestClass()]
    public class CarTest {
        Repair r1, r2, r3, r4;
        Car testCar;
        DateTime testDateTime;

        [TestInitialize()]
        public void SetUp() {
            testCar = new Car("Test make", "Test model", 2022);
            testDateTime = DateTime.Now;
            r1 = new Repair(testDateTime, "Test1", 25.00);
            r2 = new Repair(testDateTime, "Test2", 15.00);
            r3 = new Repair(testDateTime, "Test3", 35.00);
            r4 = new Repair(testDateTime, "Test4", 50.00);
            testCar.AddRepair(r1);
            testCar.AddRepair(r2);
            testCar.AddRepair(r3);
        }

        [TestMethod()]
        public void AddInitalRepairTest() {
            Assert.AreEqual(3, testCar.NumberRepair());
        }

        [TestMethod()]
        public void AddRepairTest() {
            testCar.AddRepair(r4);
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
            testCar.AddRepair(latestRepairTest);
            Repair returnTestRepair = testCar.LatestRepair();
            Assert.AreEqual(latestRepairTest.Date, returnTestRepair.Date);
            Assert.AreEqual(latestRepairTest.Description, returnTestRepair.Description);
            Assert.AreEqual(latestRepairTest.Amount, returnTestRepair.Amount);
        }

        [TestMethod()]
        public void RemoveRepairTest() {
            testCar.RemoveRepair(r1);
            Assert.AreEqual(2, testCar.NumberRepair());
        }
    }
}
