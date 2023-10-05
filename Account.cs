public class Account
{
    private decimal _balance;

    public string AccountName { get; set; }

    public Account(decimal initialBalance, string accountName)
    {
        _balance = initialBalance;
        AccountName = accountName;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
