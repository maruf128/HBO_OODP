public class Account : IComparable<Account>
{
    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }
    public bool Equals(Account item)
    {
        if (item == null) // aka hij is leeg
        {
            return false;
        }
        // kijk of het gelijk is
        if (this.AccountNumber == item.AccountNumber && this.AccountHolderName == item.AccountHolderName && this.Balance == item.Balance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override bool Equals(object item)
    {
        if (item == null)
        {
            return false;
        }
        if (item is Account)
        {
            // dus als het een persoon is roep dan allen de andere equals aan
            Account person = (Account)item; // maak er een person object van
            return Equals(person); // return the result of the call to Equals(Person item) method
        }
        return false;
    }
    public int CompareTo(Account other)
    {
        if (other == null)
        {
            return 1;
        }
        return this.AccountNumber.CompareTo(other.AccountNumber);
    }
}