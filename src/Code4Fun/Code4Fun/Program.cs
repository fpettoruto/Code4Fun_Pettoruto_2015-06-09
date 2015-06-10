using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code4Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert a max number of element:");
                var  maxNumber=0;
                var input = Console.ReadLine();
                int.TryParse(input,  out maxNumber);
                var rad = new RandomArrayDistinct(maxNumber);
                rad.PopulateArray();
                for (int i = 0; i < rad.DistinctArray.Length; i++)
                {
                    Console.WriteLine(i + "-->\t" + rad.DistinctArray[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                Console.WriteLine("Press any key");
                Console.WriteLine("\n");
                Console.ReadKey();
            }

            //Console.ReadKey();


        }

    }
}
