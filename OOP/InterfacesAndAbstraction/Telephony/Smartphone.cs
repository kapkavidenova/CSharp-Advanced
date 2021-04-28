using System;
using System.Linq;


namespace Telephony
{
    public class Smartphone : Phone, IBrowsable

    {
        public override string Call(string number)
        {
            Validator.ThrowIfNumberIsInvalid(number);
            return $"Calling... {number}";
        }
        public string Browse(string url)
        {
            if (url.Any(x=>char.IsDigit(x)))
            {
                return $"Invalid URL!";
            }
            return $"Browsing: {url}!";
        }

    }
}
