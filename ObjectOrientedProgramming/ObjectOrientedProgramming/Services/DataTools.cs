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

        public static bool SortByName(Item item1, Item item2)
        {
            return item1.Name.CompareTo(item2.Name) > 0;
        }

        public static bool SortByCost_Ascending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        public static bool SortByCost_Descending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        public static List<Item> Sort(List<Item> items, Func<Item, Item, bool> type)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for(int j = 1; j < items.Count; j++)
                {
                    if (type(items[j-1], items[j]))
                    {
                        Item temp = (Item)items[j-1].Clone();
                        items[j-1] = items[j];
                        items[j] = temp;
                    }
                }
            }
            return items;
        }
    }
}
