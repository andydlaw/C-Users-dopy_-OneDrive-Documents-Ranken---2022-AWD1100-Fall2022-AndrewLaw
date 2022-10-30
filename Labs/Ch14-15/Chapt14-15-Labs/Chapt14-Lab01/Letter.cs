using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt14_Lab01
{
    public class Letter
    {

        //instance variables
        string _recipient;
        DateTime _sentDate;
        //readonly decimal _price;

        //constructor
        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        public string Recipient => _recipient;
        public DateTime SentDate => _sentDate;

        public virtual decimal Price => 0.55m;

        public override string ToString()
        {
            return (SentDate.ToString("MM/dd/yyyy") + " " + Recipient + ", " + Price.ToString("c"));
        }
    }
}
