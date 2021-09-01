using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFundamentals_2.Classes
{
    public class BankAccount
    {
        private float balance;

        public float Balance
        {
            get { return balance; }
            set 
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else balance = 0;
            }
        }

        private string owner;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }


        public BankAccount(float balance, string owner)
        {
            this.balance = balance;
            this.owner = owner;
        }

        public virtual float AddBalance(float balanceToBeAdded)
        {
            return balance + balanceToBeAdded;
        }

        public virtual float AddBalance(float balanceToBeAdded, bool canBeNegative)
        {
            if (canBeNegative)
            {
                balance += balanceToBeAdded;
                return balance;
            } else
            {
                balance += balanceToBeAdded;
                return balance;
            }
        }

        public async Task<string> GetData()
        {
            Thread.Sleep(2000);
            return "completed";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        private string parent;

        public string Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public ChildBankAccount(float balance, string owner, string parent) : base(balance, owner)
        {
            Parent = parent;
        }

        public override float AddBalance(float balanceToBeAdded)
        {
            if(balanceToBeAdded >= -10f)
                return base.AddBalance(balanceToBeAdded);
            return Balance;
        }

        public override float AddBalance(float balanceToBeAdded, bool canBeNegative)
        {
            if(balanceToBeAdded >= -10f)
                return base.AddBalance(balanceToBeAdded, canBeNegative);
            return Balance;
        }
    }
}
