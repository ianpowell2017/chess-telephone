using ChessPhone.Model.ChessPieces;

namespace ChessPhone.Console;

internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(EmbeddedResources.WelcomeScreen);

        WriteOutput(new KingPiece(), "King");
        WriteOutput(new BishopPiece(), "Bishop");
        WriteOutput(new KnightPiece(), "Knight");
        WriteOutput(new PawnPiece(), "Pawn");
        WriteOutput(new RookPiece(), "Rook");
        WriteOutput(new QueenPiece(), "Queen");
    }

    static void WriteOutput(ChessPiece chessPiece, string headerValue)
    {
        if (!string.IsNullOrEmpty(headerValue))
        {
            System.Console.WriteLine(headerValue);
            var underLine = new string('=', headerValue.Length);
            System.Console.WriteLine(underLine);
        }

        foreach (var telephoneNumber in chessPiece.GetTelephoneNumbers())
        {
            System.Console.WriteLine(telephoneNumber);
        }

        System.Console.WriteLine(Environment.NewLine);
    }
}