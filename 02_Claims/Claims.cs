using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public enum ClaimType
    {
        Car,
        Home,
        Theft,
    }
    public class Claims
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }

        public string Description { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool IsValid
        {
            get
            {
                if ((DateOfClaim - DateTime.Now).TotalDays < 30)
                {
                    return true;
                }
                else

                {
                    return false;
                }
            }

            set { }
        
        }

        public Claims() { }
        public Claims( int claimID, ClaimType type, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = type;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}