using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Badges
{

    public class BadgeRepo
    {
        public readonly List<Badge> _badgeList = new List<Badge>();
        public Dictionary<int, Badge> Access()
        {
            var badges = new Dictionary<int, Badge>();
            var theBadge = new Badge(123, ("A1" + "A2"));
            badges.Add(123, theBadge);
            theBadge = new Badge(456, "A1 & A2");
            badges.Add(456, theBadge);

            return badges;


        }
        public List<Badge> GetBadges(){
            return _badgeList;
        }

        public bool AddNewBadge(Badge badges)
        {
            int startingCount = _badgeList.Count;
            _badgeList.Add(badges);
            bool wasAdded = (_badgeList.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public Badge GetBadgeById(int badgeID)
        {
            foreach (Badge badges in _badgeList)
            {
                if (badges.BadgeID == badgeID)
                {
                    return badges;
                }
            }
            return null;
        }
        public bool EditBadge(int originalBadgeID, Badge editBadge)
        {
            Badge oldBadge = GetBadgeById(originalBadgeID);
            if (oldBadge != null){
                oldBadge.BadgeID = editBadge.BadgeID;
                oldBadge.DoorNames = editBadge.DoorNames;

                return true;

            }
            else
            {
                return false;
            }
        }


    }
}
