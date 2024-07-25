using Microsoft.VisualStudio.TestTools.UnitTesting;
using prjCreatingIndexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCreatingIndexes.Tests
{
    [TestClass()]
    public class CatTests
    {
        [TestMethod()]
        public void returnAge()
        {
            Cat cat = new Cat(1, 5, "Pookie", "Mr.Haroldson", "Tabby");
            double expected = 1;
            double actual = Convert.ToDouble(cat[0]);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void returnWeight()
        {
            Cat cat = new Cat(1, 5, "Pookie", "Mr.Haroldson", "Tabby");
            double expected = 5;
            double actual = Convert.ToDouble(cat[1]);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void returnName()
        {
            Cat cat = new Cat(1, 5, "Pookie", "Mr.Haroldson", "Tabby");
            string expected = "Pookie";
            string actual = cat[2].ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void returnOwner()
        {
            Cat cat = new Cat(1, 5, "Pookie", "Mr.Haroldson", "Tabby");
            string expected = "Mr.Haroldson";
            string actual = cat[3].ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void returnBreed()
        {
            Cat cat = new Cat(1, 5, "Pookie", "Mr.Haroldson", "Tabby");
            string expected = "Tabby";
            string actual = cat[4].ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}