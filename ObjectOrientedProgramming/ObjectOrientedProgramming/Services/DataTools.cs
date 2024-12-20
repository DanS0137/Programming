using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedProgramming.Model;

namespace ObjectOrientedProgramming.Services
{
    public static class DataTools
    {
        public delegate List<Item> Sort(List<Item> items);

        public static bool FilterByCost(Item item)
        {
            return item.Cost > 49999;
        }

        public static bool FilterByAttack(Item item)
        {
            return item.Category == Category.Attack;
        }

        public static List<Item> Filter(List<Item> items, Func<Item, bool> type)
        {
            List<Item> filteredItems = new List<Item>();
            foreach(Item item in items)
            {
                if (type(item))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }
    }
}
