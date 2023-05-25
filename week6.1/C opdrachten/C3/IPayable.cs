interface IPayable
{
    string Name { get; set; } // get en set
    string Info { get; }
    double GetPaymentAmount(); // moet een double returne
}