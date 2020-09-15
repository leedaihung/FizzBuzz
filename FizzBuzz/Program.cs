using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var count = 100;    // default 100

                if (args.Length == 1)
                {
                    int.TryParse(args[0], out count);
                }

                var result = FizzBuzzUtil.GetFizzBuzzCollection(count);
                Console.WriteLine(string.Join(", ", result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
