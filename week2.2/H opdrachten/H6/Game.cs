public class Game
{
    // maak hier de piece aan via de class
    public DominoPiece StartPiece;

    public void SetDomino(List<DominoPiece> hand, int index)
    {
        // indien het niet geldig is
        if (index < 0 || index >= hand.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        var piece = hand[index];
        // check of het invalid move is
        if (StartPiece == null ||
            StartPiece.Pips1 == piece.Pips1 ||
            StartPiece.Pips1 == piece.Pips2 ||
            StartPiece.Pips2 == piece.Pips1 ||
            StartPiece.Pips2 == piece.Pips2 ||
            StartPiece.Pips1 == 0 ||
            StartPiece.Pips2 == 0)
        {
            hand.RemoveAt(index);
            piece.Next = StartPiece;
            StartPiece = piece;
        }
        else
        {
            Console.WriteLine("Invalid move: not placed and not removed from hand");
        }
    }

    public void DisplayGame()
    {
        // display hoe codegrade wilt
        var piece = StartPiece;
        while (piece != null)
        {
            Console.WriteLine("+---+");
            Console.WriteLine("| {0} |", piece.Pips1);
            Console.WriteLine("|   |");
            Console.WriteLine("| {0} |", piece.Pips2);
            Console.WriteLine("+---+");
            piece = piece.Next;
        }
    }
}