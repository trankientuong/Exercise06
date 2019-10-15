﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);
           
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
           
            
        }
    }
}
