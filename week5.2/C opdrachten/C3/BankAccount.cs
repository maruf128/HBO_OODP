public class BankAccount
{
    private double _balance;

    public BankAccount(double getal)
    {
        _balance = getal;
    }

    public double ReadBalance()
    {
        // method om de private field uit te lezen
        return _balance;
    }

    public void Deposit(double getal)
    {
        if (getal > 0) // aka positief
        {
            _balance += getal;
        }
    }

    public double Withdraw(double getal)
    {
        if (SufficientBalance(getal))
        {
            // aka het is genoeg geld om eraf te halen
            _balance -= getal;
            return _balance;
        }
        else
        {
            return 0;
        }
    }

    private bool SufficientBalance(double getal)
    {
        if (getal <= _balance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
