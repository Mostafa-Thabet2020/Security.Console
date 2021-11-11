using Security.Service;
using System;

class Program
{

    static void Main(string[] args)
    {
        Services services = new Services();

        Console.WriteLine("Choose securty service");
        Console.WriteLine("For random number enter 1 \nFor Secure random number enter 2 \nFor hashing enter 3 ");
        int choosen = Convert.ToInt32(Console.ReadLine());
        switch (choosen)
        {
            case 1:
                services.GeneralRandom();
                break;
            case 2:
                services.SecureRandom();
                break;
            case 3:
                services.Hashing();
                break;
        }
        Console.ReadLine();

    }

}

