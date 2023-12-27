using System.Drawing;

namespace Chess_app.Models;

public class Rook : ChessPiece
{
    public Rook(Color? color, Coordinate? initialCoordiante, bool isActive) : base(color, initialCoordiante, isActive)
    {
        this.Value = 5;
    }
}
