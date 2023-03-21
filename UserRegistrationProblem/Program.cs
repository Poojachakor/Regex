namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pattern pattern = new Pattern();
            if (pattern.validateEmail("abc.xyz@bl.co.in"))//Valid email
                                                            //if (pattern.validateEmail("abc.xyz@gmail.com.in1"))//invalid name
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
