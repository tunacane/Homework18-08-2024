namespace Homework07;

class Program
{
    static void Main(string[] args)
    {
        int number2 = 3000000;
        byte newNumber2 = Convert.ToByte(number2);
        System.Console.WriteLine(newNumber2);
        //Unhandled exception. System.OverflowException: Value was either too large or too small for an unsigned byte. byte sayı aralığının dışında kalan bir sayı olması sebebiyle taşma meydana gelir ve hata verir.
    }
}
