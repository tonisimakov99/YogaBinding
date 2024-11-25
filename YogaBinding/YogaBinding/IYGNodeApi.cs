namespace YogaBinding
{
    internal unsafe interface IYGNodeApi
    {
        YGNode* YGNodeNew();
        YGNode* YGNodeNewWithConfig(YGConfig* config);
        YGNode* YGNodeClone(YGNode* node);
        void YGNodeFree(YGNode* node);
        void YGNodeFreeRecursive(YGNode* node);
        void YGNodeFinalize(YGNode* node);
        void YGNodeReset(YGNode* node);
        void YGNodeCalculateLayout(YGNode* node, float availableWidth, float availableHeight, YGDirection ownerDirection);
        bool YGNodeGetHasNewLayout(YGNode* node);
        void YGNodeSetHasNewLayout(YGNode* node, bool hasNewLayout);
        bool YGNodeIsDirty(YGNode* node);
        void YGNodeMarkDirty(YGNode* node);
        void YGNodeSetDirtiedFunc(YGNode* node, delegate* unmanaged<YGNode*, void> * dirtiedFunc);
        delegate* unmanaged<YGNode*, void> * YGNodeGetDirtiedFunc(YGNode* node);
        void YGNodeInsertChild(YGNode* node, YGNode* child, ulong index);
        void YGNodeSwapChild(YGNode* node, YGNode* child, ulong index);
        void YGNodeRemoveChild(YGNode* node, YGNode* child);
        void YGNodeRemoveAllChildren(YGNode* node);
        void YGNodeSetChildren(YGNode* owner, YGNode** children, ulong count);
        YGNode* YGNodeGetChild(YGNode* node, ulong index);
        ulong YGNodeGetChildCount(YGNode* node);
        YGNode* YGNodeGetOwner(YGNode* node);
        YGNode* YGNodeGetParent(YGNode* node);
        void YGNodeSetConfig(YGNode* node, YGConfig* config);
        YGConfig* YGNodeGetConfig(YGNode* node);
        void YGNodeSetContext(YGNode* node, void* context);
        void* YGNodeGetContext(YGNode* node);
        void YGNodeSetMeasureFunc(YGNode* node, delegate* unmanaged<YGNode*, float, YGMeasureMode, float, YGMeasureMode, YGSize> * measureFunc);
        bool YGNodeHasMeasureFunc(YGNode* node);
        void YGNodeSetBaselineFunc(YGNode* node, delegate* unmanaged<YGNode*, float, float, float> * baselineFunc);
        bool YGNodeHasBaselineFunc(YGNode* node);
        void YGNodeSetIsReferenceBaseline(YGNode* node, bool isReferenceBaseline);
        bool YGNodeIsReferenceBaseline(YGNode* node);
        void YGNodeSetNodeType(YGNode* node, YGNodeType nodeType);
        YGNodeType YGNodeGetNodeType(YGNode* node);
        void YGNodeSetAlwaysFormsContainingBlock(YGNode* node, bool alwaysFormsContainingBlock);
        bool YGNodeGetAlwaysFormsContainingBlock(YGNode* node);
        bool YGNodeCanUseCachedMeasurement(YGMeasureMode widthMode, float availableWidth, YGMeasureMode heightMode, float availableHeight, YGMeasureMode lastWidthMode, float lastAvailableWidth, YGMeasureMode lastHeightMode, float lastAvailableHeight, float lastComputedWidth, float lastComputedHeight, float marginRow, float marginColumn, YGConfig* config);
    }
}