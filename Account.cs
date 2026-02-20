namespace CAPSTONE_PROJECTSS;

class Account
{
    public string owner { get; }
    private double balance;
    public double Balance
    {
        get => balance;
        set
        {
            if (value >= 0)
                balance = value;
        }
    }
    public Account(string owner, double balance)
    {
        this.owner = owner;
        this.balance = balance;
    }

    public void show()
    {
        Console.WriteLine("Owner: " + owner + ", Balance: " + balance);
    }

    public void deposit(double amount)
    {
        balance += amount;
    }
    public Boolean withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        else
            return false;

    }
    public Boolean transfer(Account other, double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            other.balance += amount;
            return true;

        }
        else
            return false;
    }

}