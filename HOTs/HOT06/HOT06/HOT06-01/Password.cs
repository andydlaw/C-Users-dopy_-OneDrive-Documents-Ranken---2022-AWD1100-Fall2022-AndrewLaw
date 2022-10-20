using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT05_01
{
    public class Password
    {
        private string _raw;
        private string _hash;


        public Password(string r, string h)
        {
            _raw = r;
            _hash = h;


        }
        public string GetRaw()
        {
            return _raw;
        }
        public string GetHash()
        {
            return _hash;
        }
    }
}
