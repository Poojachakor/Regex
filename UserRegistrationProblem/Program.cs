namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern patterns = new Pattern();
            if (patterns.validatePassword("Chhaku@1813"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }

    
}

    