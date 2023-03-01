namespace ChessPhone.Model.ChessPieces;

public sealed class KnightPiece : ChessPiece
{
    public KnightPiece()
    {
        _validMoves = new List<ValidMove>
        {
            new(1, new List<int> { 8, 6 }),
            new(2, new List<int> { 7, 9 }),
            new(3, new List<int> { 8, 4 }),
            new(4, new List<int> { 3, 9, 0 }),
            new(5, new List<int>()),
            new(6, new List<int> { 0, 7, 1 }),
            new(7, new List<int> { 2, 6 }),
            new(8, new List<int> { 3, 1 }),
            new(9, new List<int> { 2, 4 }),
            new(0, new List<int> { 6, 4 })
        };
    }
}