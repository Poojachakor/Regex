namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pattern pattern = new Pattern();
            if (pattern.validateFirstName("Pooja"))//Valid name
                                                   //if (pattern.validateFirstName("poojachakor"))//invalid name
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
