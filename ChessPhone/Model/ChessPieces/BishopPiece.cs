namespace ChessPhone.Model.ChessPieces;

public sealed class BishopPiece : ChessPiece
{
    public BishopPiece()
    {
        // The bishop may move as far as it wants, but only diagonally.
        _validMoves = new List<ValidMove>
        {
            new(1, new List<int> { 5, 9 }),
            new(2, new List<int> { 6, 4 }),
            new(3, new List<int> { 5, 7 }),
            new(4, new List<int> { 2, 8 }),
            new(5, new List<int> { 1, 9, 3, 7 }),
            new(6, new List<int> { 2, 8 }),
            new(7, new List<int> { 5, 3, 0 }),
            new(8, new List<int> { 4, 6 }),
            new(9, new List<int> { 5, 1, 0 }),
            new(0, new List<int> { 7, 9 })
        };
    }
}