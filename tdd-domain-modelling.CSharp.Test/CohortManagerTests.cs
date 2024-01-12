using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]
        public void FirstTest()
        {
            CohortManager core = new CohortManager();


            Assert.IsTrue(core.AddItem("Chocolate", 25, 1));
        }

        [Test]
        public void SecondTest()
        {
            CohortManager core = new CohortManager();

            core.AddItem("Bread", 15.0, 3);
            core.AddItem("Milk", 20, 2);

            Assert.AreEqual(core.Sum(), 85);
        }

        [Test]
        public void ThirdTest() 
        { 
            CohortManager core = new CohortManager();

            Assert.AreEqual(core.Sum(), 0);
        }
    }
}