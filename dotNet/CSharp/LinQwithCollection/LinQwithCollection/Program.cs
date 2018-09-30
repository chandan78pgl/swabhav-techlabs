using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQwithCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Account> bank = new List<Account>();

            bank.Add(new Account { AccountNo = 101, AccountName = "Chandan", AccountBalance = 20000 });
            bank.Add(new Account { AccountNo = 102, AccountName = "Foo", AccountBalance = 22000 });
            bank.Add(new Account { AccountNo = 103, AccountName = "Dharmesh", AccountBalance = 18000 });
            bank.Add(new Account { AccountNo = 104, AccountName = "Bar", AccountBalance = 15000 });
            bank.Add(new Account { AccountNo = 105, AccountName = "John", AccountBalance = 25000 });
            
            //Getting Accounts using LINQ
            IEnumerable<Account> myBankOrderedAccounts = bank.Select((account) => account).OrderBy<Account, String>((account) => account.AccountName);
            var myaccountWithOnlyNameAndBalance = bank.Select((account) => new { account.AccountName, account.AccountBalance }).OrderBy((account) => account.AccountName);
            var richAccount = myBankOrderedAccounts.Max((account) => account);

            IEnumerable<Account> mybankAccountsQuerySyntax = from a in bank
                                                             where a.AccountBalance >= 20000
                                                             select a;


            //Display Results of Accounts
            Console.WriteLine("Max Salary:\nAccount No: {0}\n Account Name: {1}\n Account balance: {2}",
                                    richAccount.AccountNo, richAccount.AccountName, richAccount.AccountBalance);

            Console.WriteLine("\nAll Accounts\n");
            foreach (Account account in myBankOrderedAccounts)
            {
                Console.WriteLine("Account No: {0}\n Account Name: {1}\n Account balance: {2}",
                                    account.AccountNo, account.AccountName, account.AccountBalance);
            }

            Console.WriteLine("\nAll Accounts With Name And Balance Only\n\n");
            foreach (var item in myaccountWithOnlyNameAndBalance)
            {
                Console.WriteLine("Account Name: {0}\n Account balance: {1}", item.AccountName, item.AccountBalance);
            }

            Console.WriteLine("\nAll Accounts above 20k Salary With QuerySyntax\n\n");
            foreach (Account account in mybankAccountsQuerySyntax)
            {
                Console.WriteLine("Account No: {0}\n Account Name: {1}\n Account balance: {2}",
                                    account.AccountNo, account.AccountName, account.AccountBalance);
            }
        }
    }
}
