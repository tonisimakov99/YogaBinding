using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGPixelGridApiAndroidNative
    {
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor);
    }
}