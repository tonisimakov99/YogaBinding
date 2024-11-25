namespace YogaBinding
{
    internal unsafe class YGPixelGridApiAndroid : IYGPixelGridApi
    {
        public float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor)
        {
            return YGPixelGridApiAndroidNative.YGRoundValueToPixelGrid(value, pointScaleFactor, forceCeil, forceFloor);
        }
    }
}