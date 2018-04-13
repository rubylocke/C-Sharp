using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Program_10_2_Inheritance___Encapsulation
{
    // Checking class inherits Accounts class
    // It has access to all Accounts class fields and methods (class members)
    // Account class is called base class or superclass
    // Checking Class is called a "derived class" or "subclass"
    // "Is a" relationship, Checking "is an" Accounts
    class Checking : Accounts
    {
        public Checking(decimal Balance, decimal Deposits, decimal Withdrawals)
            // The keyword :base calls the constructor of the base class (Accounts)
            : base(Balance, Deposits, Withdrawals)
        {
            
        }
    }
}
