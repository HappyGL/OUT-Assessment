using CSVTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSVOutTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVClass csv = new CSVClass();
            csv.ReadCSV();
            Console.WriteLine("All Done!!!");
        }
    }
}
