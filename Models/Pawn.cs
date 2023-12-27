using System.Drawing;

namespace Chess_app.Models;

public class Pawn : ChessPiece
{
    public Pawn(Color? color, Coordinate? initialCoordiante, bool isActive) : base(color, initialCoordiante, isActive)
    {
        this.Value = 1;
    }
}
