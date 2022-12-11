namespace FinalProject.Models;

public class DBManager {
static bool saveTransactions(double? amount)
    {
      using (var db = new bank())
      {
        var Account = new Account
        {
          ID = ID,
          Balance = Balance
        };

        // mark product as added in change tracking
        db.Account.set(Account);

        // save tracked changes to database 
        int affected = db.SaveChanges();
        return (affected == 1);
      }
    }
}
