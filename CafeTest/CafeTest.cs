using System;
using System.Collections.Generic;
using _01_Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafeTest
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void AddToMenu()
        {
            Menu firstItem = new Menu();
            MenuRepo repo = new MenuRepo();

            bool addResult = repo.AddItemToDirectory(firstItem);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetMenu()
        {
            Menu testMenu = new Menu();
            MenuRepo repo = new MenuRepo();
            repo.AddItemToDirectory(testMenu);

            List<Menu> testList = repo.GetItem();
            bool directoryHasItem = testList.Contains(testMenu);
            Assert.IsTrue(directoryHasItem);

        }

        private MenuRepo _repo;
        private Menu _menu;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepo();
            _menu = new Menu(5, "Burger", "Premium Wagu between a toasted brioche bun.", 22.99);
            _repo.AddItemToDirectory(_menu);
        }
        [TestMethod]
        public void GetbyMealName()
        {
            Menu searchResult = _repo.GetItemByMealName("Burger");
            Assert.AreEqual(_menu, searchResult);
        }

        [TestMethod]
        public void DeleteItem()
        {
            Menu toBeDeleted = _repo.GetItemByMealName("Burger");

            bool removeResult = _repo.DeleteExistingItem(toBeDeleted);
            Assert.IsTrue(removeResult);
        }
    }
}
