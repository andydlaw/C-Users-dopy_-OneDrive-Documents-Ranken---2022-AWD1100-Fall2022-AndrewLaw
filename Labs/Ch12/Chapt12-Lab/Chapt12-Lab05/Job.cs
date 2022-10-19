using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Chapt12_Lab05
{
    public class Job
    {
        const decimal TRIP_FEE = 35.00m;

        private  string _description;
        private  decimal _hoursToComplete;
        private  decimal _hourlyFee;
        private decimal _totalFee;

        public Job(string description, decimal hoursToComplete, decimal hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;            
        }
        public string GetDescription()
        {
            return _description;
        }
        public decimal GetHoursToComplete()
        {
            return _hoursToComplete;
        }
        public decimal GetHourlyFee()
        {
            return _hourlyFee;
        }
        public decimal getTotalFee()
        {
            return _totalFee;
        }

        public string Description { get; set; }
        public decimal HourlyFee { get; set; }
        public decimal HoursToComplete {get; set; }
        public decimal TotalFee 
        { 
            get 
            { 
                return ((_hourlyFee * _hoursToComplete) + TRIP_FEE); 
            } 
        }

    }
}

