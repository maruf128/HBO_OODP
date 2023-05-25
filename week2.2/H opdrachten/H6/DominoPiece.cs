public class DominoPiece
{
    // zet de variables van de puntjes aan
    public int Pips1 { get; set; }
    public int Pips2 { get; set; }
    public DominoPiece Next { get; set; }

    // constructor
    public DominoPiece(int pips1, int pips2)
    {
        Pips1 = pips1;
        Pips2 = pips2;
        Next = null;
    }
}