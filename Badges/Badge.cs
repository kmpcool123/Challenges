using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public string DoorNames { get; set; }

        


        public Badge() { }
        public Badge(int badgeId, string doorName)
        {
            BadgeID = badgeId;

            DoorNames = doorName;

        }
        

    }
    
}
