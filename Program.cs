using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Random rndm = new Random();

            for (int f=0; f<=100 ;f++ )
            {                
                int r = rndm.Next(1,101);
                if (r>=30 && r<=60 && r % 3 == 0)
                {
                    i= i+ r;
                    Console.WriteLine(r);
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();

            
        }
        
    }
}
