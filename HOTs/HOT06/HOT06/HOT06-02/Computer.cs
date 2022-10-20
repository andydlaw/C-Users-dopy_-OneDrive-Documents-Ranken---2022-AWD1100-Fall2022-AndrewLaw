using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT05_02
{
    internal class Computer
    {
        //Instance Variables
        private readonly string _name;
        private readonly string _ipAddress;
        private readonly int _services;

        //Constructor
        public Computer(string name, string ipAddress, int services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetIPAddress()
        {
            return _ipAddress;
        }
        public int GetServices()
        {
            return _services;
        }
    }
}
