using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helper
{
    public class RandomNameHelper
    {
        // Use this to generate random email: RandomName.RandomString(6) + "@mail.com"
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string WithSpecialCharacter(int length)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            const string specialChars = "!@#$%^&*";
            return new string(Enumerable.Repeat(chars + specialChars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
