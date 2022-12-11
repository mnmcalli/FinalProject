using System.Diagnostics;
using System.IO;
using static System.Console;
using Microsoft.Extensions.Configuration;

namespace FinalProject.Models;

public class Account{

    
    public int ID { get; set; }

    public double Balance { get; set; }


    double interest;    //in percentage (e.g. .07 is 7%)
    double penalty;     //in amount in $
    Account(double startingBalance){
        Balance = startingBalance;
    }
    public void deposit(double amount){ //we have assigned balance and amount.
        if(amount >= 0)
            Balance = Balance + amount;
    }
    public double withdraw(double amount){ //we have assigned balance and amount.
        if(amount >= 0 && amount >= Balance){
            Balance = Balance - amount;
            }
            return Balance;
    }
    public void roll() {        //if the balance is greater than 0, the bank will provide interest. If it's less than 0, the bank will give the account a penalty
        if(Balance > 0)
            Balance = Balance * (1 + interest);
        else if (Balance < 0)
            Balance = Balance - penalty;
    }

}