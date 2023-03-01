using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_IComparable
{
    public class Team : IComparable<Team>
    {
        string _name;
        string _city;
        double _budget;

        public Team(string name, string city)
        {
            Random rand = new Random();
            _name = name;
            _city = city;
            _budget = rand.Next(1000000, 100000000);
        }

        public string Name { get => _name; set => _name = value; }
        public string City { get => _city; set => _city = value; }
        public double Budget { get => _budget; set => _budget = value; }

        public int CompareTo(Team other)
        {
            //Write the code that tells "sort" how to organize list
            //This is ascend, but can flip logic to descend
            if (this._budget > other._budget)
            {
                return 1;
            }
            else if (this._budget < other._budget)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            // Will try to compare "x" and "y"
            //Comparing "x>y" then return 1, x<y return -1, x=y return 0
            //return _budget.CompareTo(other.Budget) defaults descending
            //Can add *-1 to reverse order

            //Can be done with strings
            //return _city.CompareTo(other._city);

        }

        public override string? ToString()
        {
            return $"{_city} {_name} - {_budget.ToString("c")}";
        }
    }
}
