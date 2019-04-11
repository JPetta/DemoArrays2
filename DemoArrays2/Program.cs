using System;

namespace DemoArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 7, 4, 9, 101, 20};

            //length 
            Console.WriteLine("Size of the arrays is : " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 20);
            Console.WriteLine("The index of 20 is : "+index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Clearing the first two index");
            foreach(var number in numbers)
                Console.WriteLine(number);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy : ");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Sort() method");

            foreach(var sorted in numbers)
                Console.WriteLine(sorted);
            
            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Reverse() method");

            foreach(var sorted in numbers)
                Console.WriteLine(sorted);
            
        }
    }
}
