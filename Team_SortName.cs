using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_12_IComparable
{
    internal class Team_SortName : IComparer<Team>
    {
        public enum SortingOrder { Ascending, Descending };
        public SortingOrder _sorting; 

        public Team_SortName() 
        {
            _sorting = SortingOrder.Descending;
        }

        //Overload to take sorting order
        public Team_SortName(SortingOrder sorting)
        {
            _sorting = sorting;
        }

        public int Compare(Team x, Team y)
        {
            if(_sorting== SortingOrder.Descending)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return x.Name.CompareTo(y.Name) * -1;
            }
           
        }
    }
}
