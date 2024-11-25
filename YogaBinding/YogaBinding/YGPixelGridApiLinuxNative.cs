using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGPixelGridApiLinuxNative
    {
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor);
    }
}