using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_IComparable
{
    internal class Team_SortBudgetDesc : IComparer<Team>
    {
        public int Compare(Team x, Team y)
        {
            //if(x.Budget > y.Budget) return 1;
            //else if(x.Budget< y.Budget) return -1;
            //else return 0;
            return x.Budget.CompareTo(y.Budget)*-1; 
        }
    }
}
