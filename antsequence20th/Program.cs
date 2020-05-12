using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("몇번째 수열?: ");
            int num = int.Parse(Console.ReadLine()), cnt, i, j;
            string current = "1", next;
            char temp;

            for (i = 0; i < num; i++) //수열 갯수?
            {
                Console.WriteLine(i + 1 + "번째 수열: " + current);
                temp = current[0];
                cnt = 0;
                next = "";

                for (j = 0; j < current.Length; j++)
                {
                    if (temp == current[j])//갯수 증가
                        cnt++;
                    else
                    {
                        next += "" + temp + cnt;
                        temp = current[j];
                        cnt = 1;
                    }

                    if (j == current.Length - 1)
                        next += "" + temp + cnt;
                }
                current = next;
            }
        }
    }
}
