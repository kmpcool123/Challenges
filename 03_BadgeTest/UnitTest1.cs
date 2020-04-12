using System;
using Badges;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_BadgeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewBadge()
        {
            Badge firstBadge = new Badge();
            BadgeRepo repo = new BadgeRepo();

            bool addResult = repo.AddNewBadge(firstBadge);

            Assert.IsTrue(addResult);
        }
        private BadgeRepo _repo;
        private Badge _badge;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new BadgeRepo();
            _badge = new Badge(123, "A1");
            _repo.AddNewBadge(_badge);
        }
    }
}
