namespace YogaBinding
{
    public unsafe class YGNodeApi
    {
        public YGNodeApi(Platform platform)
        {
            if (platform == Platform.Windows)
                lib = new YGNodeApiWindows();
            else if (platform == Platform.Linux)
                lib = new YGNodeApiLinux();
            else if (platform == Platform.Android)
                lib = new YGNodeApiAndroid();
            else
                throw new System.NotSupportedException("not supported");
        }

        IYGNodeApi lib;
        public YGNode* YGNodeNew()
        {
            return lib.YGNodeNew();
        }

        public YGNode* YGNodeNewWithConfig(YGConfig* config)
        {
            return lib.YGNodeNewWithConfig(config);
        }

        public YGNode* YGNodeClone(YGNode* node)
        {
            return lib.YGNodeClone(node);
        }

        public void YGNodeFree(YGNode* node)
        {
            lib.YGNodeFree(node);
        }

        public void YGNodeFreeRecursive(YGNode* node)
        {
            lib.YGNodeFreeRecursive(node);
        }

        public void YGNodeFinalize(YGNode* node)
        {
            lib.YGNodeFinalize(node);
        }

        public void YGNodeReset(YGNode* node)
        {
            lib.YGNodeReset(node);
        }

        public void YGNodeCalculateLayout(YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection)
        {
            lib.YGNodeCalculateLayout(node, availableWidth, availableHeight, ownerDirection);
        }

        public bool YGNodeGetHasNewLayout(YGNode* node)
        {
            return lib.YGNodeGetHasNewLayout(node);
        }

        public void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout)
        {
            lib.YGNodeSetHasNewLayout(node, hasNewLayout);
        }

        public bool YGNodeIsDirty(YGNode* node)
        {
            return lib.YGNodeIsDirty(node);
        }

        public void YGNodeMarkDirty(YGNode* node)
        {
            lib.YGNodeMarkDirty(node);
        }

        public void YGNodeSetDirtiedFunc(YGNode* node, delegate* unmanaged<YGNode*, void> * dirtiedFunc)
        {
            lib.YGNodeSetDirtiedFunc(node, dirtiedFunc);
        }

        public delegate* unmanaged<YGNode*, void> * YGNodeGetDirtiedFunc(YGNode* node)
        {
            return lib.YGNodeGetDirtiedFunc(node);
        }

        public void YGNodeInsertChild(YGNode* node, YGNode* child, ulong index)
        {
            lib.YGNodeInsertChild(node, child, index);
        }

        public void YGNodeSwapChild(YGNode* node, YGNode* child, ulong index)
        {
            lib.YGNodeSwapChild(node, child, index);
        }

        public void YGNodeRemoveChild(YGNode* node, YGNode* child)
        {
            lib.YGNodeRemoveChild(node, child);
        }

        public void YGNodeRemoveAllChildren(YGNode* node)
        {
            lib.YGNodeRemoveAllChildren(node);
        }

        public void YGNodeSetChildren(YGNode* owner, YGNode** children, ulong count)
        {
            lib.YGNodeSetChildren(owner, children, count);
        }

        public YGNode* YGNodeGetChild(YGNode* node, ulong index)
        {
            return lib.YGNodeGetChild(node, index);
        }

        public ulong YGNodeGetChildCount(YGNode* node)
        {
            return lib.YGNodeGetChildCount(node);
        }

        public YGNode* YGNodeGetOwner(YGNode* node)
        {
            return lib.YGNodeGetOwner(node);
        }

        public YGNode* YGNodeGetParent(YGNode* node)
        {
            return lib.YGNodeGetParent(node);
        }

        public void YGNodeSetConfig(YGNode* node, YGConfig* config)
        {
            lib.YGNodeSetConfig(node, config);
        }

        public YGConfig* YGNodeGetConfig(YGNode* node)
        {
            return lib.YGNodeGetConfig(node);
        }

        public void YGNodeSetContext(YGNode* node, void* context)
        {
            lib.YGNodeSetContext(node, context);
        }

        public void* YGNodeGetContext(YGNode* node)
        {
            return lib.YGNodeGetContext(node);
        }

        public void YGNodeSetMeasureFunc(YGNode* node, delegate* unmanaged<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> * measureFunc)
        {
            lib.YGNodeSetMeasureFunc(node, measureFunc);
        }

        public bool YGNodeHasMeasureFunc(YGNode* node)
        {
            return lib.YGNodeHasMeasureFunc(node);
        }

        public void YGNodeSetBaselineFunc(YGNode* node, delegate* unmanaged<YGNode*, float, float, float> * baselineFunc)
        {
            lib.YGNodeSetBaselineFunc(node, baselineFunc);
        }

        public bool YGNodeHasBaselineFunc(YGNode* node)
        {
            return lib.YGNodeHasBaselineFunc(node);
        }

        public void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline)
        {
            lib.YGNodeSetIsReferenceBaseline(node, isReferenceBaseline);
        }

        public bool YGNodeIsReferenceBaseline(YGNode* node)
        {
            return lib.YGNodeIsReferenceBaseline(node);
        }

        public void YGNodeSetNodeType(YGNode* node, YGNodeType nodeType)
        {
            lib.YGNodeSetNodeType(node, nodeType);
        }

        public YGNodeType YGNodeGetNodeType(YGNode* node)
        {
            return lib.YGNodeGetNodeType(node);
        }

        public void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock)
        {
            lib.YGNodeSetAlwaysFormsContainingBlock(node, alwaysFormsContainingBlock);
        }

        public bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node)
        {
            return lib.YGNodeGetAlwaysFormsContainingBlock(node);
        }

        public bool YGNodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, YGConfig* config)
        {
            return lib.YGNodeCanUseCachedMeasurement(widthMode, availableWidth, heightMode, availableHeight, lastWidthMode, lastAvailableWidth, lastHeightMode, lastAvailableHeight, lastComputedWidth, lastComputedHeight, marginRow, marginColumn, config);
        }
    }
}