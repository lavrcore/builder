using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Builder> builders = new List<Builder>
        {
            new Builder(2010, 5, 1000),
            new Builder(2005, 3, 800),
            new Builder(2015, 7, 1200),
            new Builder(2000, 2, 600),
            new Builder(2012, 4, 900)
        };

            Console.WriteLine("Original list:");
            foreach (var builder in builders)
            {
                Console.WriteLine($"Year: {builder.YearOfConstruction}, Offices: {builder.NumberOfOffices}, Area: {builder.TotalArea}");
            }

            //С sort не получилось, к сожалению , сделать 



        }
        public class Builder : IComparable
        {
            public int YearOfConstruction { get; set; }
            public int NumberOfOffices { get; set; }
            public double TotalArea { get; set; }

            public Builder(int yearOfConstruction, int numberOfOffices, double totalArea)
            {
                YearOfConstruction = yearOfConstruction;
                NumberOfOffices = numberOfOffices;
                TotalArea = totalArea;
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }
        public interface Comparer
        {
            int CompareTo(object obj);
        }

        public class SortOfficiceBuilderComparere : IComparer
        { 

            public int Compare(object x, object y)
            {
                throw new NotImplementedException();
            }
        }

        public class SortAreaBuilderComparere : IComparer
        {

            public int Compare(object x, object y)
            {
                throw new NotImplementedException();
            }
        }
    }
}


