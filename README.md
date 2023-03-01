# Telephone Chess

## Key pad

| 1 | 2 | 3 |   |           |
|---|---|---|---|-----------|
| 4 | 5 | 6 | ↓ | Forwards  |
| 7 | 8 | 9 | ↑ | Backwards |
| * | 0 | # |   |           |

## Valid Moves

- King
    - The king can only move one square in any direction - up, down, to the sides, and diagonally.
- Queen
    - The queen is the most powerful piece. She can move in any one straight direction - forward, backward, sideways, or diagonally - as far as possible as long as she does not move through any of her own pieces.
- Bishop
    - The bishop may move as far as it wants, but only diagonally. Each bishop starts on one color (light or dark) and must always stay on that color.
- Knight
    - Knights move in a very different way from the other pieces – going two squares in one direction, and then one more move at a 90-degree angle, just like the shape of an “L”.
- Rook
    - The rook may move as far as it wants, but only forward, backward, and to the sides.
- Pawn
    - Pawns are unusual because they move and capture in different ways: they move forward but capture diagonally. Pawns can only move forward one square at a time, except for their very first move where they can move forward two squares.

## What you are looking for

- Maintainable
    - Each piece I have mapped out the possible next positions given the initial digit
- New keyboard layouts
    - Need to rebuild the next possible positions list
- Different rules
    - Need to rebuild the next possible positions list
- New types of chess piece
    - Inherit from `ChessPiece` and build the next possible position list using [keypad](#key-pad)

## Questions

- How do you know what you have developed is correct?
    - I started with a much smaller `MAXLENGTH` and `King`, developed the algorithm and with unit tests until I was happy then extended it to 7 digits.  Then re-ran the unit tests and then randomly sampled a selection from the output.
- How can you make it more efficient?
    - Cache the results in a lookup table
    - Spawn multiple threads to process each starting digit, on completion concatenate the results
    - Return the result set of each starting digit to the console window using `IEnumerable<string>` and `yield` keywords, this would mean that when processing the `Queen` results are returned more quickly as currently it may appear as the application has locked up because the results are only returned at the end of processing the chess piece.


## References

- https://www.chess.com/learn-how-to-play-chess
- Verified with team that pawns only needed to be coded as moving one position at a time.
- Verified with team that forwards can be interpreted as down the keypad or away from 1
