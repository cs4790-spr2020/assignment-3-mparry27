using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DomainTest.Entities
{
    [TestClass]
    public class NotificationTest
    {
        [TestMethod]
        public void TestSetGetBlab()
        {
            // Arrange
            Notification harness = new Notification(); 
            Blab expected = new Blab(); 
            harness.Blab = new Blab();
            // Act
            Blab actual = harness.Blab;
            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUserID()
        {
            // Arrange
            Blab harness = new Blab(); 
            string expected = "foobar@example.com";
            harness.UserID = "foobar@example.com";
            // Act
            string actual = harness.UserID;
            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetSysId()
        {
            // Arrange
            Blab harness = new Blab();
            string expected = harness.getSysId();
            // Act
            string actual = harness.getSysId();
            // Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(true, harness.getSysId() is string);
        }
    }
}
