using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGPixelGridApiWindowsNative
    {
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGRoundValueToPixelGrid(double value, double pointScaleFactor, bool forceCeil, bool forceFloor);
    }
}