namespace YogaBinding
{
    internal unsafe class YGNodeApiAndroid : IYGNodeApi
    {
        public YGNode* YGNodeNew()
        {
            return YGNodeApiAndroidNative.YGNodeNew();
        }

        public YGNode* YGNodeNewWithConfig(YGConfig* config)
        {
            return YGNodeApiAndroidNative.YGNodeNewWithConfig(config);
        }

        public YGNode* YGNodeClone(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeClone(node);
        }

        public void YGNodeFree(YGNode* node)
        {
            YGNodeApiAndroidNative.YGNodeFree(node);
        }

        public void YGNodeFreeRecursive(YGNode* node)
        {
            YGNodeApiAndroidNative.YGNodeFreeRecursive(node);
        }

        public void YGNodeFinalize(YGNode* node)
        {
            YGNodeApiAndroidNative.YGNodeFinalize(node);
        }

        public void YGNodeReset(YGNode* node)
        {
            YGNodeApiAndroidNative.YGNodeReset(node);
        }

        public void YGNodeCalculateLayout(YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection)
        {
            YGNodeApiAndroidNative.YGNodeCalculateLayout(node, availableWidth, availableHeight, ownerDirection);
        }

        public bool YGNodeGetHasNewLayout(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetHasNewLayout(node);
        }

        public void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout)
        {
            YGNodeApiAndroidNative.YGNodeSetHasNewLayout(node, hasNewLayout);
        }

        public bool YGNodeIsDirty(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeIsDirty(node);
        }

        public void YGNodeMarkDirty(YGNode* node)
        {
            YGNodeApiAndroidNative.YGNodeMarkDirty(node);
        }

        public void YGNodeSetDirtiedFunc(YGNode* node, delegate* unmanaged<YGNode*, void> * dirtiedFunc)
        {
            YGNodeApiAndroidNative.YGNodeSetDirtiedFunc(node, dirtiedFunc);
        }

        public delegate* unmanaged<YGNode*, void> * YGNodeGetDirtiedFunc(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetDirtiedFunc(node);
        }

        public void YGNodeInsertChild(YGNode* node, YGNode* child, ulong index)
        {
            YGNodeApiAndroidNative.YGNodeInsertChild(node, child, index);
        }

        public void YGNodeSwapChild(YGNode* node, YGNode* child, ulong index)
        {
            YGNodeApiAndroidNative.YGNodeSwapChild(node, child, index);
        }

        public void YGNodeRemoveChild(YGNode* node, YGNode* child)
        {
            YGNodeApiAndroidNative.YGNodeRemoveChild(node, child);
        }

        public void YGNodeRemoveAllChildren(YGNode* node)
        {
            YGNodeApiAndroidNative.YGNodeRemoveAllChildren(node);
        }

        public void YGNodeSetChildren(YGNode* owner, YGNode** children, ulong count)
        {
            YGNodeApiAndroidNative.YGNodeSetChildren(owner, children, count);
        }

        public YGNode* YGNodeGetChild(YGNode* node, ulong index)
        {
            return YGNodeApiAndroidNative.YGNodeGetChild(node, index);
        }

        public ulong YGNodeGetChildCount(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetChildCount(node);
        }

        public YGNode* YGNodeGetOwner(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetOwner(node);
        }

        public YGNode* YGNodeGetParent(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetParent(node);
        }

        public void YGNodeSetConfig(YGNode* node, YGConfig* config)
        {
            YGNodeApiAndroidNative.YGNodeSetConfig(node, config);
        }

        public YGConfig* YGNodeGetConfig(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetConfig(node);
        }

        public void YGNodeSetContext(YGNode* node, void* context)
        {
            YGNodeApiAndroidNative.YGNodeSetContext(node, context);
        }

        public void* YGNodeGetContext(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetContext(node);
        }

        public void YGNodeSetMeasureFunc(YGNode* node, delegate* unmanaged<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> * measureFunc)
        {
            YGNodeApiAndroidNative.YGNodeSetMeasureFunc(node, measureFunc);
        }

        public bool YGNodeHasMeasureFunc(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeHasMeasureFunc(node);
        }

        public void YGNodeSetBaselineFunc(YGNode* node, delegate* unmanaged<YGNode*, float, float, float> * baselineFunc)
        {
            YGNodeApiAndroidNative.YGNodeSetBaselineFunc(node, baselineFunc);
        }

        public bool YGNodeHasBaselineFunc(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeHasBaselineFunc(node);
        }

        public void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline)
        {
            YGNodeApiAndroidNative.YGNodeSetIsReferenceBaseline(node, isReferenceBaseline);
        }

        public bool YGNodeIsReferenceBaseline(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeIsReferenceBaseline(node);
        }

        public void YGNodeSetNodeType(YGNode* node, YGNodeType nodeType)
        {
            YGNodeApiAndroidNative.YGNodeSetNodeType(node, nodeType);
        }

        public YGNodeType YGNodeGetNodeType(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetNodeType(node);
        }

        public void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock)
        {
            YGNodeApiAndroidNative.YGNodeSetAlwaysFormsContainingBlock(node, alwaysFormsContainingBlock);
        }

        public bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node)
        {
            return YGNodeApiAndroidNative.YGNodeGetAlwaysFormsContainingBlock(node);
        }

        public bool YGNodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, YGConfig* config)
        {
            return YGNodeApiAndroidNative.YGNodeCanUseCachedMeasurement(widthMode, availableWidth, heightMode, availableHeight, lastWidthMode, lastAvailableWidth, lastHeightMode, lastAvailableHeight, lastComputedWidth, lastComputedHeight, marginRow, marginColumn, config);
        }
    }
}