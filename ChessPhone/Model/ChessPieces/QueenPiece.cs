namespace ChessPhone.Model.ChessPieces;

public sealed class QueenPiece : ChessPiece
{
    public QueenPiece()
    {
        // The queen is the most powerful piece. She can move in any one straight direction - forward, backward, sideways, or diagonally - as far as possible as long as she does not move through any of her own pieces.
        _validMoves = new List<ValidMove>
        {
            new(1, new List<int> { 4, 7, 2, 3, 5, 9 }),
            new(2, new List<int> { 1, 3, 5, 8, 0, 4, 6 }),
            new(3, new List<int> { 2, 1, 6, 9, 5, 7 }),
            new(4, new List<int> { 1, 7, 5, 6, 2, 8 }),
            new(5, new List<int> { 2, 8, 0, 4, 6, 1, 9, 3, 7 }),
            new(6, new List<int> { 3, 9, 5, 4, 2, 8 }),
            new(7, new List<int> { 4, 1, 8, 9, 5, 3, 0 }),
            new(8, new List<int> { 5, 2, 0, 4, 6, 9, 7 }),
            new(9, new List<int> { 5, 1, 0, 8, 7, 6, 3 }),
            new(0, new List<int> { 8, 5, 2, 7, 9 })
        };
    }
}