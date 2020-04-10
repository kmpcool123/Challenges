using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe
{
    public class MenuRepo
    {
        public List<Menu> _menuDirectory = new List<Menu>();


        public bool AddItemToDirectory(Menu item)
        {
            int startingCount = _menuDirectory.Count;
            _menuDirectory.Add(item);
            bool wasAdded = (_menuDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public bool DeleteExistingItem(Menu menu)
        {
            bool deleteResult = _menuDirectory.Remove(menu);
            return deleteResult;
        }
        
        public List<Menu> GetItem()
        {
            return _menuDirectory;
        }

        public Menu GetItemByMealName(string mealName)
        {
            foreach (Menu item in _menuDirectory)
            {
                if(item.MealName.ToLower()== mealName.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
