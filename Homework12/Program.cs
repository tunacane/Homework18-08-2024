namespace Homework12;

class Program
{
    static void Main(string[] args)
    {
        float number5 = 1.23f;
      //  double newNumber5 = (double)number5;
        double newNumber5 = Convert.ToDouble(number5);
        System.Console.WriteLine(number5);
        System.Console.WriteLine(newNumber5);
        //double daha fazla basamak hassasiyeti sağlar 15 -16 basamak
    }
}
