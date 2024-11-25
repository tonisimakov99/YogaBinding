using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGConfigApiAndroidNative
    {
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGConfigNew();
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigFree(YGConfig* config);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGConfigGetDefault();
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGConfigGetUseWebDefaults(YGConfig* config);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGConfigGetPointScaleFactor(YGConfig* config);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetErrata(YGConfig* config, YGErrata errata);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGErrata YGConfigGetErrata(YGConfig* config);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetContext(YGConfig* config, void* context);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* YGConfigGetContext(YGConfig* config);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature);
        [DllImport("libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback);
    }
}