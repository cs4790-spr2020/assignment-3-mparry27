using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DomainTest.Entities
{
    [TestClass]
    public class NotificationTest
    {
        [TestMethod]
        public void TestSetGetMessage()
        {
            // Arrange
            Notification harness = new Notification(); 
            string expected = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."; 
            harness.Message = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            // Act
            string actual = harness.Message;
            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetLink()
        {
            // Arrange
            Notification harness = new Notification(); 
            string expected = "https://www.linktoblab.com/testblab";
            harness.Link = "https://www.linktoblab.com/testblab";
            // Act
            string actual = harness.Link;
            // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
    }
}
