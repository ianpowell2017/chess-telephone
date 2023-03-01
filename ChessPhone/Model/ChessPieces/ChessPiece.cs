using System.Text;

namespace ChessPhone.Model.ChessPieces;

public abstract class ChessPiece
{
    private const int MaxLength = 7; // Seven digits in length
    private const int StartingDigit = 2; // Must not start with 0 or 1;
    protected List<ValidMove> _validMoves; // Must be populated with possible moves
    
    public List<string> GetTelephoneNumbers()
    {
        var bufferText = new StringBuilder(MaxLength);
        var discovered = new List<string>();
        for (var i = StartingDigit; i <= 9; i++)
        {
            moveOptions(ref bufferText, ref discovered, i);
        }

        return discovered;
    }

    private void moveOptions(ref StringBuilder bufferText, ref List<string> discovered, int from)
    {
        bufferText.Append(from);
        if (bufferText.Length == MaxLength)
        {
            if (!discovered.Contains(bufferText.ToString()))
            {
                discovered.Add(bufferText.ToString());
                bufferText.Remove(bufferText.Length - 1, 1);
                return;
            }
        }

        foreach (var validMove in _validMoves.FindAll(x => x.From == from))
        {
            foreach (var nextMove in validMove.To)
            {
                moveOptions(ref bufferText, ref discovered, nextMove);
            }

            bufferText.Remove(bufferText.Length - 1, 1);
        }
    }
}