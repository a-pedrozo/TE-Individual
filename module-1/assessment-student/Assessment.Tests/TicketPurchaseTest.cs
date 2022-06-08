using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class TicketPurchaseTest
    {
        [TestMethod]
        public void CalculatedTotalPriceShouldCalculateBasePriceWithoutSurcharges()
        {
            //Arrange
            TicketPurchase purchase = new TicketPurchase("john", 1);


            //Act
            decimal price = purchase.Surcharge(false, false);

            //Assert
            Assert.AreEqual(purchase.BasePrice, price);
            
        }
        [DataTestMethod]
        [DataRow(1, false, false, 59.99)] // how to use data row, does not like decimals 
        public void DataRowPriceTest(int numTickets, bool earlyAccess, bool priority, double expected)
        {
            //Arrange
            TicketPurchase purchase = new TicketPurchase("john", numTickets);
            decimal expectedDecimal = (decimal)expected; // how to fix decimal inputs to data row

            //Act
            decimal price = purchase.Surcharge(earlyAccess, priority);

            //Assert
            Assert.AreEqual(expectedDecimal, price);

        }
        [TestMethod]
        public void BasePriceForTenPeopleCalculatesCorrectty() // test properties 
        {
            //Arrange
            TicketPurchase purchase = new TicketPurchase("jimmy", 10);


            //Act
            decimal actual = purchase.BasePrice;

            //Assert
            Assert.AreEqual(599.90m, actual);

        }
        [TestMethod]
        public void TicketPurchaseConstructoSetsProperietsCorrectly()
        {
            //Arrange
            TicketPurchase purchase = new TicketPurchase("john", 1);


            //Act
            //decimal price = purchase.Surcharge(false, false); how to check constructors 

            //Assert
            Assert.AreEqual("john", purchase.Name);
            Assert.AreEqual(10, purchase.NumOfTickets);

        }
    }
}
