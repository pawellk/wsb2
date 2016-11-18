using Microsoft.VisualStudio.TestTools.UnitTesting;
using Walidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walidator.Tests
{
    [TestClass()]
    public class PESELWalidatorTests
    {
        [TestMethod()]
        public void PESELWalidatorTest()
        {

            PESELWalidator pw = new PESELWalidator("91042215012");
            Assert.IsNotNull(pw);
            try
            {
                pw = new PESELWalidator("910422a5012");
                Assert.Fail();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod()]
        public void LoadPeselTest()
        {
            PESELWalidator pw = new PESELWalidator("91042215012");
            Assert.IsNotNull(pw);
            try
            {
                pw .LoadPesel("910422a5012");
                Assert.Fail();
            }
            catch(Exception e)
            {
                throw e;
            }
        }


        [TestMethod()]
        public void ControlSumTest()
        {
            
            PESELWalidator pw = new PESELWalidator("91042215012");
            Assert.AreEqual(3, pw.ControlSum());
            Assert.IsTrue(pw.ControlSum() >= 0 && pw.ControlSum() < 10);

            pw.LoadPesel("9104221534");
            Assert.AreNotEqual(4, pw.ControlSum());
            Assert.IsTrue(pw.ControlSum() >= 0 && pw.ControlSum() < 10);

        }
       
        [TestMethod()]
        public void DateOfBirthTest()
        {
            PESELWalidator pw = new PESELWalidator("91042215012");
            Assert.AreEqual("22.04.1991", pw.DateOfBirth());
            pw.LoadPesel("19821115422");
            Assert.AreEqual("11.02.1819", pw.DateOfBirth());
        }

        [TestMethod()]
        public void SexTest()
        {
            PESELWalidator pw = new PESELWalidator("91042215012");
            Assert.AreEqual("Man", pw.Sex());
            pw.LoadPesel("91042215023");
            Assert.AreEqual("Woman", pw.Sex());
        }

        [TestMethod()]
        public void CheckPesel()
        {
            PESELWalidator pw = new PESELWalidator("91042215012");
            Assert.IsTrue(pw.CheckPesel());
            pw.LoadPesel("91043215012");
            Assert.IsFalse(pw.CheckPesel());
            pw.LoadPesel("910432");
            Assert.IsFalse(pw.CheckPesel());
        }
    }
}