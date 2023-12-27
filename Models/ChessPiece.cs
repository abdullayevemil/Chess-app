using System.Drawing;

namespace Chess_app.Models;
public abstract class ChessPiece
{
    public Color? Color { get; private set; }
    public int? Value { get; protected set; }
    public Coordinate? CurrentCoordinate { get; set; }
    public IEnumerable<Coordinate?>? PossibleMoves { get; protected set; }
    public bool IsActive { get; protected set; }
    public ChessPiece(Color? color, Coordinate? initialCoordiante, bool isActive)
    {
        this.Color = color;
        this.CurrentCoordinate = initialCoordiante;
        this.IsActive = isActive;
    }
    public virtual void Move(Coordinate? destination)
    {
        if (destination is null) return;
        if (PossibleMoves is null) return;
        if (destination is not Coordinate) return;
        if (!PossibleMoves.Contains(destination)) return;
        CurrentCoordinate = destination;
    }
}

public class ChessBoard 
{
    private readonly ChessPiece[][]? ChessPieces;
    public ChessBoard(ChessPiece[][]? chessPieces)
    {
        this.ChessPieces = chessPieces;
    }
}