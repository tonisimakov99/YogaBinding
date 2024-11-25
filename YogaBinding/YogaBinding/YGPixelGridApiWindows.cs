namespace YogaBinding
{
    internal unsafe class YGPixelGridApiWindows : IYGPixelGridApi
    {
        public float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor)
        {
            return YGPixelGridApiWindowsNative.YGRoundValueToPixelGrid(value, pointScaleFactor, forceCeil, forceFloor);
        }
    }
}