using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGConfigApiWindowsNative
    {
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGConfigNew();
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigFree(YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGConfigGetDefault();
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGConfigGetUseWebDefaults(YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGConfigGetPointScaleFactor(YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetErrata(YGConfig* config, YGErrata errata);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGErrata YGConfigGetErrata(YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetContext(YGConfig* config, void* context);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* YGConfigGetContext(YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback);
    }
}