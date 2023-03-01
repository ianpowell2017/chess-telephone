namespace ChessPhone.Model.ChessPieces;

public sealed class PawnPiece : ChessPiece
{
    public PawnPiece()
    {
        // Pawns move forward. Pawns can only move forward one square at a time, except for their very first move where they can move forward two squares.
        _validMoves = new List<ValidMove>
        {
            new(1, new List<int> { 4, 7 }),
            new(2, new List<int> { 5, 8, 0 }),
            new(3, new List<int> { 6, 9 }),
            new(4, new List<int> { 7 }),
            new(5, new List<int> { 8, 0 }),
            new(6, new List<int> { 9 }),
            new(7, new List<int> { }),
            new(8, new List<int> { 0 }),
            new(9, new List<int> { }),
            new(0, new List<int> { })
        };
    }
}