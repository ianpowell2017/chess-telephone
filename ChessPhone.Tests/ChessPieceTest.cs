using ChessPhone.Model.ChessPieces;
using Xunit.Abstractions;

namespace ChessPhone.Tests;

public class ChessPieceTest
{
    [Fact]
    public void KingTest()
    {
        var piece = new KingPiece();
        var discovered = piece.GetTelephoneNumbers();
        Assert.Equal(124908, discovered.Count);
    }


    [Fact]
    public void KnightTest()
    {
        var piece = new KnightPiece();
        var discovered = piece.GetTelephoneNumbers();
        Assert.Equal(952, discovered.Count);
    }

    [Fact]
    public void BishopTest()
    {
        var piece = new BishopPiece();
        var discovered = piece.GetTelephoneNumbers();
        Assert.Equal(2341, discovered.Count);
    }

    [Fact] // Warning this does take awhile to execute and may slow down a CI/CD process - 15mins on my Mac M1 Pro
    public void QueenTest()
    {
        var piece = new QueenPiece();
        var discovered = piece.GetTelephoneNumbers();
        Assert.Equal(751503, discovered.Count);
    }

    [Fact]
    public void PawnTest()
    {
        var piece = new PawnPiece();
        var discovered = piece.GetTelephoneNumbers();
        Assert.Empty(discovered); // If the pawn can only go forwards then the keypad needs to be 7 digits long
    }

    [Fact]
    public void RookTest()
    {
        var piece = new RookPiece();
        var discovered = piece.GetTelephoneNumbers();
        Assert.Equal(49326, discovered.Count);
        Assert.Contains(discovered, s => s == "3145289");
    }
}