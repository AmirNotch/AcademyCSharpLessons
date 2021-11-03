using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyCSharpLesson19._10._2021
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Problem #1");
            int[] numbers = { 3, 4, 8, 5, 9, 7 };`

            IEnumerable<int> reverseNumbers = numbers.Reverse();

            foreach (var item in reverseNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Problem #2");

            int[] negPost = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

            IEnumerable<int> countPosi = from i in negPost
                                         where i > 0
                                         select i;

            IEnumerable<int> countNega = from i in negPost
                                         where i < 0
                                         select i;

            int countNegaResult = countNega.Sum();
            int countPosiResult = countPosi.Count();

            List<int> SumAndCountResult = new List<int>();

            SumAndCountResult.Add(countPosiResult);
            SumAndCountResult.Add(countNegaResult);

            foreach (var item in SumAndCountResult)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Problem #3");

            string[] things = new[] {"Telescopes", "Glasses", "Eyes", "Monocles" };

            IEnumerable<string> sortedThings = from s in things orderby s.Count() select s;

            foreach (var item in sortedThings)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Problem #4");

            double[] unique = new[] { 1.0, 1.0, 1.0, 2.0, 1.0, 1.0 };
            
            var uniqueNum = unique.OrderBy(p => p).ToList();
            double uniqueResult = 0;
            for (int i = 0; i < uniqueNum.Count(); i++)
            {
                if (i == 0 || i+1 != uniqueNum.Count())
                {
                    if (uniqueNum[i] == uniqueNum[i + 1])
                    {
                        uniqueResult = uniqueNum.First();
                    }
                    else
                    {
                        uniqueResult = uniqueNum.Last();
                    }
                }
            }

            Console.WriteLine(uniqueResult);

            double[] unique1 = new[] { 0, 0, 0.55, 0, 0 };
            
            var uniqueNum1 = unique1.OrderBy(p => p).ToList();
            double uniqueResult1 = 0;
            for (int i = 0; i < uniqueNum1.Count(); i++)
            {
                if (i == 0 || i+1 != uniqueNum1.Count())
                {
                    if (uniqueNum1[i] == uniqueNum1[i + 1])
                    {
                        uniqueResult1 = uniqueNum1.First();
                    }
                    else
                    {
                        uniqueResult1 = uniqueNum1.Last();
                    }
                }
            }

            Console.WriteLine(uniqueResult1);
        }
    }
}