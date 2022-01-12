using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Account
    {
        //instance varibales
        //AccountNumber int
        //AccountTitle String
        //AccountBalance double
        private int _AccountNumber = 0;
        private String _AccountTitle = String.Empty;
        private double _AccountBalance = 0.0;
        private Account account;

        //properties
        public int AccountNumber {
            set { this._AccountNumber = value; }
            get { return this._AccountNumber; }
        }
        public String AccountTitle
        {
            set { this._AccountTitle = value; }
            get { return this._AccountTitle; }
        }
        public double AccountBalance
        {
            set { this._AccountBalance = value; }
            get { return this._AccountBalance; }
        }
        //constructor
        public Account() {

        }
        public Account(int acNum,String acTitle,double acBalance)
        {
            this._AccountTitle = acTitle;
            this._AccountNumber = acNum;
            this._AccountBalance = acBalance;
        }

     

        //methods
        public void Deposit(double amount)
        {
            //  this._AccountBalance = this._AccountBalance + amount;
            this._AccountBalance += amount;

        }
        public void WithDraw(double amount)
        {
            //  this._AccountBalance = this._AccountBalance - amount;
            this._AccountBalance -= amount;
        }
    }
}
