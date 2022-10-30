using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt14_Lab02
{
    public class MattedPhoto : Photo
    {
        //color enumerator
        public enum Color
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 4,
            WHITE = 7

        }

        //instance variable
        Color _color;
        //constructor
        public MattedPhoto(decimal w, decimal h, Color c)
                        :base(w, h)
        {
            _color = c;
        }

        //Getter and setter
        public Color TheColor => _color;
        public override string ToString()
        {
            return base.ToString() + " Matted " + TheColor.ToString();
        }
    }
}
