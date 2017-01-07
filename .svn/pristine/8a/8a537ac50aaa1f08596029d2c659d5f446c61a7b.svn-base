using System;

namespace LogicalSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            MetaSerie();
            GenericSerie(new FibonacciSerie());
            GenericSerie(new FibonacciSerie2());
        }
        static void GenericSerie<T>(ISerie<T> serie)
        {
            Console.WriteLine("Generating '{0}' ::", serie.Name);

            int iteration = 1;

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("...");
                T item = serie.GenerateNext();
                Console.WriteLine("Iteration #{0}: {1}", iteration, item);
                iteration++;
            }

            Console.WriteLine("Done.");
            Console.ReadKey(true);
        }

        static void MetaSerie()
        {
            Console.WriteLine("MetaSerie::");

            MetaSerie meta = new MetaSerie();

            int index = 1;

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("...");
                string item = meta.GenerateNext();
                var stat = MetaSerieStat.GetItemStat(item);
                Console.WriteLine("Item #{0}: {1}", index, item);
                Console.WriteLine("Stat #{0}: (count::{1}, 1::{2}%, 2::{3}%, 3::{4}%)",
                    index, stat.Count, stat.Pct1, stat.Pct2, stat.Pct3);
                index++;
            }

            Console.WriteLine("Done.");
            Console.ReadKey(true);
        }
    }
}
