using System;

namespace multicastDelegate
{
    class Program
    {

        public delegate void CalDelegate(int num1, int num2);
        public class Calculate
        {
            public void sum(int num1, int num2)
            {
                Console.WriteLine(num1 + num2);
            }
            public void multiply(int num1, int num2)
            {
                Console.WriteLine(num1 * num2);
            }
        }
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            CalDelegate simpleDel = new CalDelegate(cal.sum); // sum method referenced to delegate CalDelegate
            simpleDel += new CalDelegate(cal.multiply); //multicasting using += operator
            simpleDel(10, 12);
        }
    }
}
