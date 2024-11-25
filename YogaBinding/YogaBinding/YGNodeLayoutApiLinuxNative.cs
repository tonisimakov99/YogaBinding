using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGNodeLayoutApiLinuxNative
    {
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetLeft(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetTop(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetRight(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetBottom(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetWidth(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetHeight(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGDirection YGNodeLayoutGetDirection(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeLayoutGetHadOverflow(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge);
    }
}