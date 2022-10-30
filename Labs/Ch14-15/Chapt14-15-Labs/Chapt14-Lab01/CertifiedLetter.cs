using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapt14_Lab01
{
    public class CertifiedLetter : Letter
    {
        //Instance variable
        string _trackingNumber;

        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber)
                        : base (recipient,sentDate)
        {
            _trackingNumber = trackingNumber;
        }

        public string TrackingNumber => _trackingNumber;

        public override decimal Price
        {
            get
            {
                return 0.65m;
            }
        }

        public override string ToString()
        {
            return (base.SentDate.ToString("MM/dd/yyyy") + " " + base.Recipient + ", " + Price.ToString("c") + ", " + TrackingNumber);
        }
    }
}
