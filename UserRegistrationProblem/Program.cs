namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pattern pattern = new Pattern();
            if (pattern.validateLastName("Chakor"))//Valid name
                                                    //if (pattern.validateLastName("chakor"))//invalid name
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
