using System.Drawing;

namespace Chess_app.Models;

public class Bishop : ChessPiece
{
    public Bishop(Color? color, Coordinate? initialCoordiante, bool isActive) : base(color, initialCoordiante, isActive)
    {
        this.Value = 3;
    }
}
