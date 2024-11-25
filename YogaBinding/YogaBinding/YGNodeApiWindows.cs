namespace YogaBinding
{
    internal unsafe class YGNodeApiWindows : IYGNodeApi
    {
        public YGNode* YGNodeNew()
        {
            return YGNodeApiWindowsNative.YGNodeNew();
        }

        public YGNode* YGNodeNewWithConfig(YGConfig* config)
        {
            return YGNodeApiWindowsNative.YGNodeNewWithConfig(config);
        }

        public YGNode* YGNodeClone(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeClone(node);
        }

        public void YGNodeFree(YGNode* node)
        {
            YGNodeApiWindowsNative.YGNodeFree(node);
        }

        public void YGNodeFreeRecursive(YGNode* node)
        {
            YGNodeApiWindowsNative.YGNodeFreeRecursive(node);
        }

        public void YGNodeFinalize(YGNode* node)
        {
            YGNodeApiWindowsNative.YGNodeFinalize(node);
        }

        public void YGNodeReset(YGNode* node)
        {
            YGNodeApiWindowsNative.YGNodeReset(node);
        }

        public void YGNodeCalculateLayout(YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection)
        {
            YGNodeApiWindowsNative.YGNodeCalculateLayout(node, availableWidth, availableHeight, ownerDirection);
        }

        public bool YGNodeGetHasNewLayout(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetHasNewLayout(node);
        }

        public void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout)
        {
            YGNodeApiWindowsNative.YGNodeSetHasNewLayout(node, hasNewLayout);
        }

        public bool YGNodeIsDirty(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeIsDirty(node);
        }

        public void YGNodeMarkDirty(YGNode* node)
        {
            YGNodeApiWindowsNative.YGNodeMarkDirty(node);
        }

        public void YGNodeSetDirtiedFunc(YGNode* node, delegate* unmanaged<YGNode*, void> * dirtiedFunc)
        {
            YGNodeApiWindowsNative.YGNodeSetDirtiedFunc(node, dirtiedFunc);
        }

        public delegate* unmanaged<YGNode*, void> * YGNodeGetDirtiedFunc(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetDirtiedFunc(node);
        }

        public void YGNodeInsertChild(YGNode* node, YGNode* child, ulong index)
        {
            YGNodeApiWindowsNative.YGNodeInsertChild(node, child, index);
        }

        public void YGNodeSwapChild(YGNode* node, YGNode* child, ulong index)
        {
            YGNodeApiWindowsNative.YGNodeSwapChild(node, child, index);
        }

        public void YGNodeRemoveChild(YGNode* node, YGNode* child)
        {
            YGNodeApiWindowsNative.YGNodeRemoveChild(node, child);
        }

        public void YGNodeRemoveAllChildren(YGNode* node)
        {
            YGNodeApiWindowsNative.YGNodeRemoveAllChildren(node);
        }

        public void YGNodeSetChildren(YGNode* owner, YGNode** children, ulong count)
        {
            YGNodeApiWindowsNative.YGNodeSetChildren(owner, children, count);
        }

        public YGNode* YGNodeGetChild(YGNode* node, ulong index)
        {
            return YGNodeApiWindowsNative.YGNodeGetChild(node, index);
        }

        public ulong YGNodeGetChildCount(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetChildCount(node);
        }

        public YGNode* YGNodeGetOwner(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetOwner(node);
        }

        public YGNode* YGNodeGetParent(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetParent(node);
        }

        public void YGNodeSetConfig(YGNode* node, YGConfig* config)
        {
            YGNodeApiWindowsNative.YGNodeSetConfig(node, config);
        }

        public YGConfig* YGNodeGetConfig(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetConfig(node);
        }

        public void YGNodeSetContext(YGNode* node, void* context)
        {
            YGNodeApiWindowsNative.YGNodeSetContext(node, context);
        }

        public void* YGNodeGetContext(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetContext(node);
        }

        public void YGNodeSetMeasureFunc(YGNode* node, delegate* unmanaged<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> * measureFunc)
        {
            YGNodeApiWindowsNative.YGNodeSetMeasureFunc(node, measureFunc);
        }

        public bool YGNodeHasMeasureFunc(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeHasMeasureFunc(node);
        }

        public void YGNodeSetBaselineFunc(YGNode* node, delegate* unmanaged<YGNode*, float, float, float> * baselineFunc)
        {
            YGNodeApiWindowsNative.YGNodeSetBaselineFunc(node, baselineFunc);
        }

        public bool YGNodeHasBaselineFunc(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeHasBaselineFunc(node);
        }

        public void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline)
        {
            YGNodeApiWindowsNative.YGNodeSetIsReferenceBaseline(node, isReferenceBaseline);
        }

        public bool YGNodeIsReferenceBaseline(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeIsReferenceBaseline(node);
        }

        public void YGNodeSetNodeType(YGNode* node, YGNodeType nodeType)
        {
            YGNodeApiWindowsNative.YGNodeSetNodeType(node, nodeType);
        }

        public YGNodeType YGNodeGetNodeType(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetNodeType(node);
        }

        public void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock)
        {
            YGNodeApiWindowsNative.YGNodeSetAlwaysFormsContainingBlock(node, alwaysFormsContainingBlock);
        }

        public bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node)
        {
            return YGNodeApiWindowsNative.YGNodeGetAlwaysFormsContainingBlock(node);
        }

        public bool YGNodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, YGConfig* config)
        {
            return YGNodeApiWindowsNative.YGNodeCanUseCachedMeasurement(widthMode, availableWidth, heightMode, availableHeight, lastWidthMode, lastAvailableWidth, lastHeightMode, lastAvailableHeight, lastComputedWidth, lastComputedHeight, marginRow, marginColumn, config);
        }
    }
}