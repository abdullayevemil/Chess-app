using System.Drawing;

namespace Chess_app.Models;

public class Queen : ChessPiece
{
    public Queen(Color? color, Coordinate? initialCoordiante, bool isActive) : base(color, initialCoordiante, isActive)
    {
        this.Value = 9;
    }
}
