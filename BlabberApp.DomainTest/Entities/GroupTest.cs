using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DomainTest.Entities
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void TestSetGetName()
        {
            // Arrange
            Group harness = new Group();
            string expected = "Test Group"; 
            harness.Name = "Test Group";
            // Act
            string actual = harness.Name;
            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUsers()
        {
            // Arrange
            User John = new User();
            Group harness = new Group("TestGroup",new List<User> { John }); 
            List<User> expected = new List<User>(new User[] { John });
            harness.Users.Add(John);
            // Act
            List<User> actual = harness.Users; // Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
    }
}
