using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrezziLibrary.Test
{
    [TestClass]
    public class PrezziTest
    {
        [DataTestMethod]
        [DataRow(0, "Incorrect number of day/s.")]
        [DataRow(1, "best subscription: Open 1 Month.")]
        [DataRow(3, "best subscription: Open 3 Month.")]
        [DataRow(6, "best subscription: Open 12 Month.")]
        public void WhichSubscriptionTest(int n, string tariffa_aspettata)
        {
            string tariffa = Prezzi.WhichSubscription(n, tariffa_aspettata);
            Assert.AreEqual(tariffa_aspettata, tariffa);
        }
    }
}
