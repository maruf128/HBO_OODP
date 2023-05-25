public class BankAccount
{
    private double _balance;

    // toegevoeg protected
    protected int YearsPassed;
    protected double InterestRate;

    public BankAccount(double getal, double rente)
    {
        _balance = getal;
        InterestRate = rente;
        YearsPassed = 0;
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

    public virtual double Withdraw(double getal)
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

    public virtual void NextYear()
    {
        ApplyInterest();
    }
    protected virtual void ApplyInterest()
    {
        _balance = _balance * InterestRate;
    }
}
