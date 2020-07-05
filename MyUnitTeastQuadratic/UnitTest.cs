using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using MyQuadraticProj;

namespace MyUnitTeastQuadratic
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestAnswerNoRoots()
        {
            Quadratic newCoefs = new Quadratic(3, 4, 10);
            string actual = newCoefs.Answer();
            Assert.AreEqual("Рівняння коренів немає", actual);
        }

        [Test]
        public void TestAnswerAequalNull()
        {
            Quadratic newCoefs = new Quadratic(0, 4, 10);
            string actual = newCoefs.Answer();
            Assert.AreEqual("Не вірно задані корені рівняння", actual);
        }

        [Test]
        public void TestAnswerDiscrEqualNull()
        {
            Quadratic newCoefs = new Quadratic(1, 12, 36);
            string actual = newCoefs.Answer();
            Assert.AreEqual("x = -6", actual);
        }

        [Test]
        public void TestAnswerDiscrMoreThenNull()
        {
            Quadratic newCoefs = new Quadratic(1, -1, -90);
            string actual = newCoefs.Answer();
            Assert.AreEqual("x1 = 10, x2 = -9", actual);
        }
    }
}
