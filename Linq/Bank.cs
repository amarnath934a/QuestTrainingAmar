using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
}

public class Transaction
{
    public int TransactionId { get; set; }
    public int FromId { get; set; }
    public int ToId { get; set; }
    public decimal Amount { get; set; }
    public DateTime DateTime { get; set; }
}

class Program
{
    static void Main()
    {
        var accounts = new List<Account>
        {
            new Account { Id = 1, Name = "Amar", Balance = 50000 },
            new Account { Id = 2, Name = "Ravi", Balance = 10000 },
            new Account { Id = 3, Name = "Charan", Balance = 50000 }
        };

        var transactions = new List<Transaction>
        {
            new Transaction { TransactionId = 1, FromId = 1, ToId = 2, Amount = 100, DateTime = DateTime.Now },
            new Transaction { TransactionId = 2, FromId = 2, ToId = 3, Amount = 200, DateTime = DateTime.Now }
        };

        var transactionDetails = transactions
            .Join(
                accounts,
                t => t.FromId,
                a => a.Id,
                (transaction, account) => new { Transaction = transaction, FromAccount = account })
            .Join(
                accounts,
                res => res.Transaction.ToId,
                a => a.Id,
                (res, toAccount) => new
                {
                    TransactionId = res.Transaction.TransactionId,
                    FromAccountName = res.FromAccount.Name,
                    ToAccountName = toAccount.Name,
                    Amount = res.Transaction.Amount,
                    Date = res.Transaction.DateTime
                });

        foreach (var transfer in transactionDetails)
        {
            Console.WriteLine($"{transfer.FromAccountName} transferred {transfer.Amount} rupees to {transfer.ToAccountName} on {transfer.Date}");
        }
        Console.ReadKey();
    }
}


