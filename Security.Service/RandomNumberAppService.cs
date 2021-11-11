using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Service
{
    public class RandomNumberAppService
    {
        private Random random = new Random();
        public int RandomGeneral()
        {
            return random.Next();
        }
        public int RandomRange(int min , int max)
        {
            return random.Next(min, max);
        }
        public int RandomLessThan(int number)
        {
            return random.Next(number);
        }
    }
}
