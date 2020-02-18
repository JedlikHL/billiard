using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leeső=LeesőSoroló(golyók);
            Kiíró(golyók);
            
        }

        static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.WriteLine($"{item}");
            }
        }

        static int LeesőSoroló(List<int> golyók)
        {
            Random gép = new Random();
            int szám= gép.Next(golyók.Count);
            golyók.Remove(szám);
            return golyók[szám];
        }
        
        

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
