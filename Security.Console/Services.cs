using Security.Service;
using System;

public class Services
{
    RandomNumberAppService randomService = new RandomNumberAppService();
    RTLRandomAppService RTLService = new RTLRandomAppService();
    HashingAppService HashingService = new HashingAppService();

    public void GeneralRandom()
    {
        Console.WriteLine("general rendom number: " + randomService.RandomGeneral());

        Console.WriteLine("insert number");
        int randomLess = randomService.RandomLessThan(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Random less is: " + randomLess);

        Console.WriteLine("Insert minimum");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert Maximam");
        int max = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Random range is:" + randomService.RandomRange(min, max));
    }
    public void SecureRandom()
    {
        Console.WriteLine("enter lenght");
        int lenght = Convert.ToInt32(Console.ReadLine());
        string random = RTLService.GenerateSecureRandomNumberToString(lenght);
        Console.WriteLine("Secure random number is: " + random);
    }
    public void Hashing()
    {
        Console.WriteLine("To MD5 press 1\nTo SHA1 press 2\nTo SHA256 press 3\nTo SHA512 press 4");
        int Choosen = Convert.ToInt32(Console.ReadLine());
        string text;
        switch (Choosen)
        {
            case 1:
                Console.WriteLine("Enter text");
                text = Console.ReadLine();
                Console.WriteLine("MD5 Hashed: " + HashingService.ComputeHashMD5ToString(text));
                break;
            case 2:
                Console.WriteLine("Enter text");
                text = Console.ReadLine();
                Console.WriteLine("SHA1 Hashed: " + HashingService.ComputeHashSHA1ToString(text));
                break;
            case 3:
                Console.WriteLine("Enter text");
                text = Console.ReadLine();
                Console.WriteLine("SHA256 Hashed: " + HashingService.ComputeHashSHA256ToString(text));
                break;
            case 4:
                Console.WriteLine("Enter text");
                text = Console.ReadLine();
                Console.WriteLine("SHA512 Hashed: " + HashingService.ComputeHashSHA512ToString(text));
                break;
        }


    }
}



