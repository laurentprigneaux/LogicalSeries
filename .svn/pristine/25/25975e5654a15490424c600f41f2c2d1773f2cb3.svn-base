using System;
using System.Linq;

namespace LogicalSeries
{
    
    public class MetaSerie : ISerie<string>
    {
        private string lastItem;

        public MetaSerie() : this("1")
        {
        }

        public MetaSerie(string startItem)
        {
            lastItem = startItem;
        }

        public string Name
        {
            get { return "MetaSerie"; }
        }

        public string GenerateNext()
        {
            string nextItem = string.Empty;

            int length = lastItem.Length;
            int index = 0;
            int count = 0;
            char current;

            var item = lastItem.ToCharArray();

            while (index < length)
            {
                current = item[index];
                count = 1;
                index++;

                while (index < length && item[index] == current)
                {
                    count++;
                    index++;
                }

                nextItem += count;
                nextItem += current;
            }

            lastItem = nextItem;

            return nextItem;
        }
    }

    static class MetaSerieStat
    {
        public struct ItemStat
        {
            public int Count;
            public int Count1;
            public int Count2;
            public int Count3;
            public double Pct1;
            public double Pct2;
            public double Pct3;
        }

        public static ItemStat GetItemStat(string item)
        {
            var stat = new ItemStat();

            for(int i = 0; i < item.Length; i++)
            {
                switch (item[i])
                {
                    case '1':
                        stat.Count1++;
                        stat.Count++;
                        break;
                    case '2':
                        stat.Count2++;
                        stat.Count++;
                        break;
                    case '3':
                        stat.Count3++;
                        stat.Count++;
                        break;
                }
            }

            if (stat.Count > 0)
            {
                stat.Pct1 = Math.Round(stat.Count1 * 100D / stat.Count, 1);
                stat.Pct2 = Math.Round(stat.Count2 * 100D / stat.Count, 1);
                stat.Pct3 = Math.Round(stat.Count3 * 100D / stat.Count, 1);
            }

            return stat;
        }
    }
}
