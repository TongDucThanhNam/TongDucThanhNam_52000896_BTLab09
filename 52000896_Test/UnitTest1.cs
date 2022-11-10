using StudentServiceLib;
using Xunit.Sdk;

namespace _52000896_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        []
        public void Add_negetive_Should_return_Exception()
        {
            Student student = new Student();

            student.Score = -1;

            Assert.AreEqual(student.Score);

        }

        [TestMethod]
        public void Add_1_Should_return_1()
        {
            Student student2 = new Student();

            student2.Score = 1;

            Assert.AreEqual(1, student2.Score);

        }

        [TestMethod]
        public void Add_11_Should_return_Exeptcion()
        {
            Student student3 = new Student();

            student3.Score = 1;

            Assert.AreEqual(1, student3.Score);

        }
    }
}