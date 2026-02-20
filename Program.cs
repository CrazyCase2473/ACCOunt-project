using CAPSTONE_PROJECTSS;


public class Program
{

    static void ShowNullableInt(int? number)
    {
        if (number.HasValue)
        {
            Console.WriteLine("Value: " + number.Value);
        }
        else
            Console.WriteLine("No Value (Null)");
    }
    static void Main(String[] args)
    {
        Account account1 = new Account("Bob", 100);
        account1.show();
        Console.WriteLine("about to withdraw 150 from account1");
        if (account1.withdraw(150))
        {
            Console.Write("withdrew $150");
        }
        else
            Console.WriteLine("Insufficient funds, current account info: ");
        account1.show();
        account1.deposit(200);
        Console.WriteLine("depositing 200 into account 1, new status: ");
        account1.show();
        Console.WriteLine("about to withdraw 150 from account1");
        if (account1.withdraw(150))
        {
            Console.WriteLine("withdrew $150, new status: ");
        }
        else
            Console.WriteLine("Insufficient funds, current account info: ");
        account1.show();
        Console.WriteLine("making account2");
        Account account2 = new Account("Mary", 100);
        account2.show();
        Console.WriteLine("transfering 50 from bob to mary");
        if (account1.transfer(account2, 50))
        {
            Console.WriteLine("success, new account info: ");
        }
        else
            Console.WriteLine("failure, account info: ");
        account1.show();
        account2.show();


        account1.Balance = -200; //should not work
        account1.show(); //checks if it worked or not
        Console.WriteLine("Account Owner: " + account1.owner);

        int? x1 = 20;
        int? x2 = null;

        ShowNullableInt(x1);
        ShowNullableInt(x2);

        string? s = null;
        Console.WriteLine(s);
        Account? acc = null;
        Console.WriteLine(acc);

        Console.WriteLine("this was added on mainchange branch");
        //hehehehehefe
    }
}

