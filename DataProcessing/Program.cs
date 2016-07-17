using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IChangeBoxedData> data = new List<IChangeBoxedData>() {
                new InfoData() { FirstName = "Qwerty", LastName = "Asdf" },
                new InfoData() { FirstName = "Tyuio", LastName = "Bnm" }
            };

            Source source = new Source();
            source.CheckAndProceed(data);

            foreach (var item in data)
            {
                Console.WriteLine(((InfoData)item).ToString());
            }
        }
    }
}
