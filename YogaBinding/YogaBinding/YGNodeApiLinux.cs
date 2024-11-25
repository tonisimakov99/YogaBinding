namespace YogaBinding
{
    internal unsafe class YGNodeApiLinux : IYGNodeApi
    {
        public YGNode* YGNodeNew()
        {
            return YGNodeApiLinuxNative.YGNodeNew();
        }

        public YGNode* YGNodeNewWithConfig(YGConfig* config)
        {
            return YGNodeApiLinuxNative.YGNodeNewWithConfig(config);
        }

        public YGNode* YGNodeClone(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeClone(node);
        }

        public void YGNodeFree(YGNode* node)
        {
            YGNodeApiLinuxNative.YGNodeFree(node);
        }

        public void YGNodeFreeRecursive(YGNode* node)
        {
            YGNodeApiLinuxNative.YGNodeFreeRecursive(node);
        }

        public void YGNodeFinalize(YGNode* node)
        {
            YGNodeApiLinuxNative.YGNodeFinalize(node);
        }

        public void YGNodeReset(YGNode* node)
        {
            YGNodeApiLinuxNative.YGNodeReset(node);
        }

        public void YGNodeCalculateLayout(YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection)
        {
            YGNodeApiLinuxNative.YGNodeCalculateLayout(node, availableWidth, availableHeight, ownerDirection);
        }

        public bool YGNodeGetHasNewLayout(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetHasNewLayout(node);
        }

        public void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout)
        {
            YGNodeApiLinuxNative.YGNodeSetHasNewLayout(node, hasNewLayout);
        }

        public bool YGNodeIsDirty(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeIsDirty(node);
        }

        public void YGNodeMarkDirty(YGNode* node)
        {
            YGNodeApiLinuxNative.YGNodeMarkDirty(node);
        }

        public void YGNodeSetDirtiedFunc(YGNode* node, delegate* unmanaged<YGNode*, void> * dirtiedFunc)
        {
            YGNodeApiLinuxNative.YGNodeSetDirtiedFunc(node, dirtiedFunc);
        }

        public delegate* unmanaged<YGNode*, void> * YGNodeGetDirtiedFunc(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetDirtiedFunc(node);
        }

        public void YGNodeInsertChild(YGNode* node, YGNode* child, ulong index)
        {
            YGNodeApiLinuxNative.YGNodeInsertChild(node, child, index);
        }

        public void YGNodeSwapChild(YGNode* node, YGNode* child, ulong index)
        {
            YGNodeApiLinuxNative.YGNodeSwapChild(node, child, index);
        }

        public void YGNodeRemoveChild(YGNode* node, YGNode* child)
        {
            YGNodeApiLinuxNative.YGNodeRemoveChild(node, child);
        }

        public void YGNodeRemoveAllChildren(YGNode* node)
        {
            YGNodeApiLinuxNative.YGNodeRemoveAllChildren(node);
        }

        public void YGNodeSetChildren(YGNode* owner, YGNode** children, ulong count)
        {
            YGNodeApiLinuxNative.YGNodeSetChildren(owner, children, count);
        }

        public YGNode* YGNodeGetChild(YGNode* node, ulong index)
        {
            return YGNodeApiLinuxNative.YGNodeGetChild(node, index);
        }

        public ulong YGNodeGetChildCount(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetChildCount(node);
        }

        public YGNode* YGNodeGetOwner(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetOwner(node);
        }

        public YGNode* YGNodeGetParent(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetParent(node);
        }

        public void YGNodeSetConfig(YGNode* node, YGConfig* config)
        {
            YGNodeApiLinuxNative.YGNodeSetConfig(node, config);
        }

        public YGConfig* YGNodeGetConfig(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetConfig(node);
        }

        public void YGNodeSetContext(YGNode* node, void* context)
        {
            YGNodeApiLinuxNative.YGNodeSetContext(node, context);
        }

        public void* YGNodeGetContext(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetContext(node);
        }

        public void YGNodeSetMeasureFunc(YGNode* node, delegate* unmanaged<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> * measureFunc)
        {
            YGNodeApiLinuxNative.YGNodeSetMeasureFunc(node, measureFunc);
        }

        public bool YGNodeHasMeasureFunc(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeHasMeasureFunc(node);
        }

        public void YGNodeSetBaselineFunc(YGNode* node, delegate* unmanaged<YGNode*, float, float, float> * baselineFunc)
        {
            YGNodeApiLinuxNative.YGNodeSetBaselineFunc(node, baselineFunc);
        }

        public bool YGNodeHasBaselineFunc(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeHasBaselineFunc(node);
        }

        public void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline)
        {
            YGNodeApiLinuxNative.YGNodeSetIsReferenceBaseline(node, isReferenceBaseline);
        }

        public bool YGNodeIsReferenceBaseline(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeIsReferenceBaseline(node);
        }

        public void YGNodeSetNodeType(YGNode* node, YGNodeType nodeType)
        {
            YGNodeApiLinuxNative.YGNodeSetNodeType(node, nodeType);
        }

        public YGNodeType YGNodeGetNodeType(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetNodeType(node);
        }

        public void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock)
        {
            YGNodeApiLinuxNative.YGNodeSetAlwaysFormsContainingBlock(node, alwaysFormsContainingBlock);
        }

        public bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node)
        {
            return YGNodeApiLinuxNative.YGNodeGetAlwaysFormsContainingBlock(node);
        }

        public bool YGNodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, YGConfig* config)
        {
            return YGNodeApiLinuxNative.YGNodeCanUseCachedMeasurement(widthMode, availableWidth, heightMode, availableHeight, lastWidthMode, lastAvailableWidth, lastHeightMode, lastAvailableHeight, lastComputedWidth, lastComputedHeight, marginRow, marginColumn, config);
        }
    }
}