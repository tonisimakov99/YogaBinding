namespace YogaBinding
{
    internal unsafe class YGPixelGridApiLinux : IYGPixelGridApi
    {
        public float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor)
        {
            return YGPixelGridApiLinuxNative.YGRoundValueToPixelGrid(value, pointScaleFactor, forceCeil, forceFloor);
        }
    }
}