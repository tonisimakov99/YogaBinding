namespace YogaBinding
{
    public unsafe class YGPixelGridApi
    {
        public YGPixelGridApi(Platform platform)
        {
            if (platform == Platform.Windows)
                lib = new YGPixelGridApiWindows();
            else if (platform == Platform.Linux)
                lib = new YGPixelGridApiLinux();
            else if (platform == Platform.Android)
                lib = new YGPixelGridApiAndroid();
            else
                throw new System.NotSupportedException("not supported");
        }

        IYGPixelGridApi lib;
        public float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor)
        {
            return lib.YGRoundValueToPixelGrid(value, pointScaleFactor, forceCeil, forceFloor);
        }
    }
}