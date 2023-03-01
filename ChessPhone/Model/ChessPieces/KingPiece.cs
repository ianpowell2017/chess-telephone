namespace ChessPhone.Model.ChessPieces;

public sealed class KingPiece : ChessPiece
{
    public KingPiece()
    {
        // The king can only move one square in any direction - up, down, to the sides, and diagonally.
        _validMoves = new List<ValidMove>
        {
            new(1, new List<int> { 4, 5, 2 }),
            new(2, new List<int> { 1, 3, 4, 5, 6 }),
            new(3, new List<int> { 2, 5, 6 }),
            new(4, new List<int> { 1, 2, 5, 8, 7 }),
            new(5, new List<int> { 1, 2, 3, 4, 6, 7, 8, 9 }),
            new(6, new List<int> { 3, 2, 5, 8, 9 }),
            new(7, new List<int> { 4, 5, 8, 0 }),
            new(8, new List<int> { 4, 5, 6, 7, 9, 0 }),
            new(9, new List<int> { 8, 0, 6, 5 }),
            new(0, new List<int> { 7, 8, 9 })
        };
    }
}