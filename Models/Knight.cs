using System.Drawing;

namespace Chess_app.Models;

public class Knight : ChessPiece
{
    public Knight(Color? color, Coordinate? initialCoordiante, bool isActive) : base(color, initialCoordiante, isActive)
    {
        this.Value = 3;
    }
}
