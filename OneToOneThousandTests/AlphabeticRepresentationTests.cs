using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using onetoonethousand;

namespace OneToOneThousandTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AlphabeticRepresentationTests
    {
        public AlphabeticRepresentationTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void OneReturnsProperly()
        {
            int i = 1;
            Assert.AreEqual("one", i.GetAlphabeticalRepresentation());
        }

        [TestMethod]
        public void OneHundredReturnsProperly()
        {
            int i = 100;
            Assert.AreEqual("one hundred", i.GetAlphabeticalRepresentation());
        }

        [TestMethod]
        public void OneThousandReturnsProperly()
        {
            int i = 1000;
            Assert.AreEqual("one thousand", i.GetAlphabeticalRepresentation());
        }

        [TestMethod]
        public void OneHundredAndOneReturnsProperly()
        {
            int i = 101;
            Assert.AreEqual("one hundred and one", i.GetAlphabeticalRepresentation());
        }

        [TestMethod]
        public void TwoHundredAndOneReturnsProperly()
        {
            int i = 201;
            Assert.AreEqual("two hundred and one", i.GetAlphabeticalRepresentation());
        }

        [TestMethod]
        public void FiftySevenReturnsProperly()
        {
            int i = 57;
            Assert.AreEqual("fifty seven", i.GetAlphabeticalRepresentation());
        }

        [TestMethod]
        public void SeventeenOneReturnsProperly()
        {
            int i = 17;
            Assert.AreEqual("seventeen", i.GetAlphabeticalRepresentation());
        }
    }
}
