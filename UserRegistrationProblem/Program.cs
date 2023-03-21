namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            if (pattern.validateMobileFormat("+91 7218533707"))//Valid phone number
                                                          //if (pattern.validateMobileFormat("+91 7218533399"))//invalid phone number
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
