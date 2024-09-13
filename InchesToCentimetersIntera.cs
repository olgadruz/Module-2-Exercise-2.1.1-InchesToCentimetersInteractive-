namespace InchesToCentimetersInteractive;

class Program
{
    static void Main(string[] args)
    {
        double inch = 2.54;
        string cm = Console.ReadLine();
        string[] cmww = cm.Split(" ");
        double result = Convert.ToDouble(cmww[0]);
        Console.WriteLine(result * inch + " centimeters");
    }
}
