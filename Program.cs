namespace Set1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul numar: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti al 2-lea numar: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = -b / a;


            Console.WriteLine($"Rezultatul ecuatiei {a}*x+{b}=0 este {x}");
        }
    }
}