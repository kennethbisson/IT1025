using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            Console.WriteLine(math.add(9, 19));
            Console.WriteLine(math.factorial(9));
            Console.WriteLine(math.min(20, 21));
            Console.WriteLine(math.multiply(19, 2));
            Console.ReadLine();
        }
    }

    class MyMath
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int factorial(int n)
        {
            int answer = 1;
            for (int i = 1; i <= n; i++)
                answer *= i;
            return answer;
        }
        public int min(int c, int d)
        {
            int answer = 1;
            if (c < d)
            {
                answer = c;
            }
            if (c > d)
            {
                answer = d;
            }
            return answer;
        }   


        public int multiply(int x, int y)
        {
            return x *= y;

        }
      

    }   
}
