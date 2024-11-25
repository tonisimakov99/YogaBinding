using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGNodeApiWindowsNative
    {
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeNew();
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeNewWithConfig(YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeClone(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeFree(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeFreeRecursive(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeFinalize(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeReset(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeCalculateLayout(YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeGetHasNewLayout(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeIsDirty(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeMarkDirty(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetDirtiedFunc(YGNode* node, delegate* unmanaged<YGNode*, void> * dirtiedFunc);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern delegate* unmanaged<YGNode*, void> * YGNodeGetDirtiedFunc(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeInsertChild(YGNode* node, YGNode* child, ulong index);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSwapChild(YGNode* node, YGNode* child, ulong index);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeRemoveChild(YGNode* node, YGNode* child);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeRemoveAllChildren(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetChildren(YGNode* owner, YGNode** children, ulong count);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeGetChild(YGNode* node, ulong index);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong YGNodeGetChildCount(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeGetOwner(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNode* YGNodeGetParent(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetConfig(YGNode* node, YGConfig* config);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGConfig* YGNodeGetConfig(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetContext(YGNode* node, void* context);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* YGNodeGetContext(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetMeasureFunc(YGNode* node, delegate* unmanaged<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> * measureFunc);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeHasMeasureFunc(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetBaselineFunc(YGNode* node, delegate* unmanaged<YGNode*, float, float, float> * baselineFunc);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeHasBaselineFunc(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeIsReferenceBaseline(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetNodeType(YGNode* node, YGNodeType nodeType);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGNodeType YGNodeGetNodeType(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node);
        [DllImport("runtimes/win-x64/yogacore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGNodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, YGConfig* config);
    }
}