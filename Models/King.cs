using System.Drawing;

namespace Chess_app.Models;

public class King : ChessPiece
{
    public King(Color? color, Coordinate? initialCoordiante, bool isActive) : base(color, initialCoordiante, isActive)
    {
        this.Value = null; // King has no point value
    }
}