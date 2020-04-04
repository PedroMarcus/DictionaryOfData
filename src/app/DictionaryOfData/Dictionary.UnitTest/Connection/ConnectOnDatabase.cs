using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.UnitTest.Connection
{
    public class ConnectOnDatabase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VerifyInputsRequired() 
        {
            Assert.Pass();
        }

        [Test]
        public void TryConnectOnDatabaseSqlServer() 
        {
            Assert.Pass(); 
        }

        [Test]
        public void TryConnectOnDatabaseOracle() 
        {
            Assert.Pass(); 
        }

        [Test]
        public void TryConnectOnDatabaseMySQL() 
        {
            Assert.Pass();
        }
    }
}
