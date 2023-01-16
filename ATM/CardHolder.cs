using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CardHolder
    {
        public string cardNumber;
        public int pin;
        public string firstName;
        public string lastName;
        public double balance;

        public CardHolder(string cardNumber, int pin, string firstName, string lastName, double balance)
        {
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
        public string GetNum()
        {
            return cardNumber;
        }
        public int GetPin()
        {
            return pin;
        }
        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }
        public double GetBalance()
        {
            return balance;
        }

        public void SetNum(string newNum)
        {
            this.cardNumber = newNum;
        }
        public void SetPin(int newPin)
        {
            this.pin = newPin;
        }
        public void SetFirstName(string NewFirstName)
        {
            this.firstName = NewFirstName;
        }
        public void setLastName(string newLastName)
        {
            this.lastName = newLastName;
        }

        public void SetBalance(double newBalance)
        {
            this.balance = newBalance;
        }


    }
}
