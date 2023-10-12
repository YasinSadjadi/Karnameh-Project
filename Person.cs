using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karnameh_Project
{
    public class Person
    {
        public Person()
        {
            Score = -1;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Score { get; set; }
    }
}
