using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = pageCount(6, 2);
            Console.WriteLine(a);

            Console.ReadLine();
        }

        static int pageCount(int n, int p)
        {
            if (n == p)
                return 0;

            int count = 0;
            int x = -1;
            for (int i = 1; i <= n; i+=2)
            {
                x++;
                if (i==p||i-1==p)
                {
                    break;
                }
            }
            int y = -1;
            if (n % 2 == 0)
            {
                for (int i = n; i > 0; i -= 2)
                {
                    y++;
                    if (i == p || i + 1 == p)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = n - 1; i > 0; i -= 2)
                {
                    y++;
                    if (i == p || i + 1 == p)
                    {
                        break;
                    }
                }
            }
            if (x>y)
                count = y;
            
            else
                count = x;

            return count;
        }

    }
}
