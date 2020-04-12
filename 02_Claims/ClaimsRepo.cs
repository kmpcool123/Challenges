using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class ClaimsRepo
    {
        public readonly List<Claims> _claimsDirectory = new List<Claims>();
        public ClaimsReop()
        {
            Queue myQ = new Queue();
            myQ.Enqueue(_claimsDirectory);
                
                foreach (var element in myQ)
                {
                return element;

                }
                
            



        }            
    }
}
