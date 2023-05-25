class BankAccount
{
    //standaard op 0
    public static double InterestRatePercentage = 0.0;
    public double Balance = 0.0;

    // constructor
    public BankAccount(int balance, int interestRatePercentage)
    {
        InterestRatePercentage = interestRatePercentage;
        Balance = balance;
    }

    public void Deposit(double getal)
    {
        // increase de balance met het getal
        Balance = Balance + getal;
    }

    public void ApplyInterest()
    {
        // doe het keer 1. inretesrate
        Balance *= (1 + (InterestRatePercentage / 100));

    }
}

