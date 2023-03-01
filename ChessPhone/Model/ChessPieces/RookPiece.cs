namespace ChessPhone.Model.ChessPieces;

public sealed class RookPiece : ChessPiece
{
    public RookPiece()
    {
        // The rook may move as far as it wants, but only forward, backward, and to the sides.
        _validMoves = new List<ValidMove>
        {
            new(1, new List<int> { 2, 3, 4, 7 }),
            new(2, new List<int> { 1, 3, 5, 8, 0 }),
            new(3, new List<int> { 2, 1, 6, 9 }),
            new(4, new List<int> { 1, 7, 5, 6 }),
            new(5, new List<int> { 2, 8, 0, 4, 6 }),
            new(6, new List<int> { 3, 9, 5, 4 }),
            new(7, new List<int> { 4, 1, 8, 9 }),
            new(8, new List<int> { 5, 2, 0, 7, 9 }),
            new(9, new List<int> { 6, 3, 8, 7 }),
            new(0, new List<int> { 8, 5, 2 })
        };
    }
}