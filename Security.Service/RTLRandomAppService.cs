using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Security.Service
{
    public class RTLRandomAppService
    {
        public byte[] GenerateSecureRandomNumber(int lenght)
        {
            using (var randomNomberGenerate = new RNGCryptoServiceProvider())
            {
                var randomNumber =new byte[lenght];
                randomNomberGenerate.GetBytes(randomNumber);
                return randomNumber;
            }
        }
        public string GenerateSecureRandomNumberToString(int lenght)
        {
            return Convert.ToBase64String(GenerateSecureRandomNumber(lenght));
        }
    }
}
