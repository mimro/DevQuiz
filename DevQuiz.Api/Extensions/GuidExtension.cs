using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuiz.Api.Extensions
{
    public static class GuidExtension
    {
        public static string EncodetToBase64String(this Guid guid)
        {
            return Convert.ToBase64String(guid.ToByteArray()).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        public static Guid DecodetFromBase64String(this string encodedString)
        {
            string incoming = encodedString.Replace('_', '/').Replace('-', '+');
            switch (encodedString.Length % 4)
            {
                case 2: incoming += "=="; break;
                case 3: incoming += "="; break;
            }
            byte[] bytes = Convert.FromBase64String(incoming);

            return new Guid(bytes);
        }
    }
}
