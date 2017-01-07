using System;

namespace LogicalSeries
{
    public class FibonacciSerie : ISerie<FibonacciData>
    {
        private FibonacciData data = new FibonacciData();

        public FibonacciData GenerateNext()
        {
            double next = data.Previous + data.Current;
            data.Previous = data.Current;
            data.Current = next;
            if (next > 0D)
                data.Ratio = data.Current / data.Previous;

            return data;
        }

        public string Name
        {
            get { return "FibonacciSerie"; }
        }
    }

    public class FibonacciSerie2 : ISerie<FibonacciData2>
    {
        private FibonacciData2 data = new FibonacciData2();

        public FibonacciData2 GenerateNext()
        {
            double next = data.PriorToPrevious + data.Previous + data.Current;
            data.PriorToPrevious = data.Previous;
            data.Previous = data.Current;
            data.Current = next;
            if (next > 0D)
                data.Ratio = data.Current / data.Previous;

            return data;
        }

        public string Name
        {
            get { return "FibonacciSerie2"; }
        }
    }

    public class FibonacciData
    {
        public double Previous = 0;
        public double Current = 1;
        public double Ratio = double.NaN;

        public override string ToString()
        {
            return String.Format("Current={0}, Ratio={1}", Current, Ratio);
        }
    }

    public class FibonacciData2
    {
        public double PriorToPrevious = 0;
        public double Previous = 1;
        public double Current = 2;
        public double Ratio = double.NaN;

        public override string ToString()
        {
            return String.Format("Current={0}, Ratio={1}", Current, Ratio);
        }
    }
}
