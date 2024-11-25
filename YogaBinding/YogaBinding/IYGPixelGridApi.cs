namespace YogaBinding
{
    internal unsafe interface IYGPixelGridApi
    {
        float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor);
    }
}