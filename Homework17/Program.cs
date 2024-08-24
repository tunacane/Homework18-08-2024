using System.Runtime.InteropServices;

namespace Homework17;

class Program
{
    static void Main(string[] args)
    {
        byte num1 = 40;
        short num2 = 40;
        int num3 = 40;
        long num4 = 40;

        byte sizeOfNum1 = sizeof(byte);
        System.Console.WriteLine(sizeOfNum1);    // 1
        System.Console.WriteLine(sizeof(short)); // 2
        System.Console.WriteLine(sizeof(int));   // 3 
        System.Console.WriteLine(sizeof(long));  // 4 
        //sizeof operatörü tanımlanan değerinin veri tipinde kapladığı yeri ekrana yazdırır.


    }
}
