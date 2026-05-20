using System;
public class Program
{
    public static void Main(string[] args)
    {
        
        for (int i = 0; i < args.Length; ++i)
        {
            switch (args[i])
            {
                case("print"):
                    Console.WriteLine(args[i+1]);

                break;
            }
        }


    }

}