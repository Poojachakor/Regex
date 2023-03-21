namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pattern pattern = new Pattern();
            if (pattern.validatePinCode("Pooja"))//Valid name
                                                   //if (pattern.validatePinCode("poojachakor"))//invalid name
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