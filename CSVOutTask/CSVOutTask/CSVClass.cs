using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;

namespace CSVTask
{
    public class CSVClass
    {
      public  CSVClass() { }
        public  void ReadCSV()
        {

     
            using (var reader = new StreamReader("data.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                int p = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (p > 0)
                    {

                        var values = line.Split(',');

                        listA.Add(values[0]);
                        listA.Add(values[1]);
                        listB.Add(values[2]);
                    }
                    p++;
                }

                var LNames = listA.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).OrderBy(x => x.Value).OrderByDescending(x => x.Key).ToList();

                var orderedadd = listB.OrderBy(u => Alphabets(u)).ToList();
                 System.IO.StreamWriter file = new System.IO.StreamWriter("j.txt");

                file.WriteLine("--------------Names ordered--------------------------");

                foreach (var item in LNames)
                {
                    file.WriteLine(item.Key + "   " + item.Value);
                }
                file.WriteLine("--------------Addressess--------------------------");
                foreach (var item in orderedadd)
                {
                    file.WriteLine(item );
                }
                file.Close();
                file.Dispose();

            }
        }
        public  string Alphabets(String input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in input)
                if (!Char.IsDigit(c))
                    sb.Append(c);

            return sb.ToString();
        }
    }
}
