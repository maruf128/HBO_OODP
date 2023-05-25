public class SavingsAccount : BankAccount
{
    private bool _locked = true;

    public SavingsAccount(double getal, double rente) : base(getal, rente)
    {
    }

    public override double Withdraw(double getal)
    {
        if (_locked)
        {
            return 0;
        }
        else
        {
            return base.Withdraw(getal);
        }
    }
    public override void NextYear()
    {
        YearsPassed++;
        // gebruik de oude base
        if (YearsPassed < 5)
        {
            base.NextYear();
        }
        else
        {
            _locked = false;
        }
    }
}