using System;

namespace OldMlad
{
    
class Program
    {
        static void Main(string[] args)
        {
            Person man1 = new Person { year = 1967, name = "игорь" };
            Person man2 = new Person { year = 1967, name = "макс" };
            Person man3 = new Person { year = 1967, name = "олег" };
            bool result = man1 > man3;
            bool result1 = man1 < man3;
            bool result2 = man1 == man3;
            bool result3 = man1 != man3;
            Console.WriteLine("{0} {1} {2}", result, result1, result2);
        }
    }
}

