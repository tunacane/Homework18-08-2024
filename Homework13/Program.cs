using System.ComponentModel;

namespace Homework13;

class Program
{
    static void Main(string[] args)
    {
        long number7 = 400000000000;
       // int newNumber7 = Convert.ToInt32(number7);
        int newNumber7 = (int)number7;
        System.Console.WriteLine(newNumber7);
        //overflow taşma meydana gelir 9 bite kadar yazdırır
    }
}
