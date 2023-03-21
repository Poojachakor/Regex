namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pattern pattern = new Pattern();
            if (pattern.validatePinCode("Chakor"))//Valid name
                                                    //if (pattern.validatePinCode("chakor"))//invalid name
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