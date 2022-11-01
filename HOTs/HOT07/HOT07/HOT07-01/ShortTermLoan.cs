using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT07_01
{
    public class ShortTermLoan
    {
        string _name;
         decimal _monthlyPayment = 450m;
         decimal _interestRate = .1m;
        decimal _amount; 
        decimal _balance;
        decimal _accumulatedInterest;


        public ShortTermLoan(string n, decimal a)
        {
            _name = n;
            _amount = a;
            _balance = _amount;
        }
        public decimal MakeAPayment(decimal b)
        {
            _balance = b - _monthlyPayment;
            return _balance;
        }
        public decimal ApplyInterest()
        {
            _accumulatedInterest = _balance * _interestRate;
            return _accumulatedInterest;
        }
        public decimal GetMontlyPayment()
        {
            return _monthlyPayment;
        }
        public string GetName()
        {
            return _name;
        }
        public decimal GetAmount()
        {
            return _amount;
        }
        public decimal GetInterestRate()
        {
            return _interestRate;
        }

    }
}
