namespace IterationDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var name = "Renuka Chougule";
            //for (var i = 0; i <= name.Length; i++) 
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name) 
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int [] { 1, 2, 3,4};
            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}

            //var i = 0;

            //while (i < 10) 
            //{
            //    if (i % 10 == 0) 
            //    {
            //        Console.WriteLine(i);

            //        i++;
            //    }

            //}

            //while (true)
            //{
            //    Console.Write("Type Your Name:");

            //    var input = Console.ReadLine();

            //    if (string.IsNullOrEmpty(input))
            //        break;
            //    {
            //        Console.WriteLine("@Echo:" + input);
                  

            //    }

               


            //}

            while (true)
            {
                Console.Write("Type Your Name:");

               var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))

                {
                    Console.WriteLine("@Echo:" + input);
                    break;

                }

                continue;


            }
        }

    }
}
