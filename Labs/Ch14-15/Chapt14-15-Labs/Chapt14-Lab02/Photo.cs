using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt14_Lab02
{
    public class Photo
    {

        // instance variables
        private decimal _width;
        private decimal _height;

        // construtor
        public Photo(decimal width, decimal height)
        {
            _width = width;
            _height = height;
        }

        //getters and setters
        public decimal Width=> _width;
        public decimal Height=> _height;

        // override the ToString() Method
        public override string ToString()
        {
            return (Width+ " x "+ Height);

        }
    }
}
