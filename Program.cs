using System;



namespace _26.debugExample
{
    class Program
    {
        static void Main()
        {
            var sum = CalcSum(3, 4, 5);
            Console.WriteLine(sum);

        }
        private static int CalcSum(int a, int b, int c) 
        {
            
            var partialSum = Sum(a, b);
            var totalSum = Sum(partialSum, c);
            return totalSum;
        }
        private static int Sum(int a, int b) 
        {
            
            return a + b;
        }
    }
}
