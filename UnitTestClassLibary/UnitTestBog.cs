using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClassLibary
{
    [TestClass]
    public class UnitTestBog
    {
        

     
        public Bog GetBook()
        {
            return new Bog("test", "tester Hansen", 100, "HerEr13Cifree");
        }

        [TestMethod]
        public  void TestCreateInitialBook()
        {
            Bog bog1 = new Bog("test", "tester Hansen", 100, "HerEr13Cifree");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateBookToFewPages()
        {
            Bog bog1 = new Bog("test", "tester Hansen", 2, "HerEr13Cifree");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateBookToManyPages()
        {
            Bog bog1 = new Bog("test", "tester Hansen", 1001, "HerEr13Cifree");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateBookToShotForfatter()
        {
            Bog bog1 = new Bog("test", "t", 100, "HerEr13Cifree");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateBookToFewISBN()
        {
            Bog bog1 = new Bog("test", "t", 100, "HerEr12Cifre");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCreateBookToManyISBN()
        {
            Bog bog1 = new Bog("test", "t", 100, "HerEr14Cifreee");
        }

        [TestMethod]
        public void TestSetTitle()
        { 
            Bog bog = GetBook();
            bog.Title = "test2";
            Assert.AreEqual("test2", bog.Title);
        }

        [TestMethod]
        public void TestSetForfatter()
        {
            Bog bog = GetBook();
            bog.Forfatter = "tester Jensen";
            Assert.AreEqual("tester Jensen", bog.Forfatter);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetForfatterToShort()
        {
            Bog bog = GetBook();
            bog.Forfatter = "t";
           
        }

        [TestMethod]
        public void ChangeBookPages()
        {
            Bog bog = GetBook();
            bog.SideTal = 200;
            Assert.AreEqual(200,bog.SideTal);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangeBookPagesToFewPages()
        {
            Bog bog = GetBook();
            bog.SideTal = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangeBookPagesToManyPages()
        {
            Bog bog = GetBook();
            bog.SideTal = 1001;
        }

        [TestMethod]
        public void ChangeISBN()
        {
            Bog bog = GetBook();
            bog.ISBN13 = "DetteErOgså13";
            Assert.AreEqual("DetteErOgså13", bog.ISBN13);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangeISBNMore()
        {
            Bog bog = GetBook();
            bog.ISBN13 = "DetteErMereEnd13";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChangeISBNFew()
        {
            Bog bog = GetBook();
            bog.ISBN13 = "DerErMinre13";
        }
    }
}
