namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "George";
            int number = 6;
            char letter = 'H';
            bool moreThan5 = true;
            double amount = 6.25;
            decimal paid = 6.54m;


            Console.WriteLine($"{name} went to the store to buy dog snacks.\n He bought {number} of them.\n The snacks start with the letter {letter}. \n Is was a {moreThan5} story. The amount of each was {amount} but he paid {paid} ");

        }
    }
}
