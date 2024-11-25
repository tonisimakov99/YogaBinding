namespace YogaBinding
{
    internal unsafe class YGStyleApiWindows : IYGStyleApi
    {
        public void YGNodeCopyStyle(YGNode* dstNode, YGNode* srcNode)
        {
            YGStyleApiWindowsNative.YGNodeCopyStyle(dstNode, srcNode);
        }

        public void YGNodeStyleSetDirection(YGNode* node, YGDirection direction)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetDirection(node, direction);
        }

        public YGDirection YGNodeStyleGetDirection(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetDirection(node);
        }

        public void YGNodeStyleSetFlexDirection(YGNode* node, YGFlexDirection flexDirection)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexDirection(node, flexDirection);
        }

        public YGFlexDirection YGNodeStyleGetFlexDirection(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetFlexDirection(node);
        }

        public void YGNodeStyleSetJustifyContent(YGNode* node, YGJustify justifyContent)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetJustifyContent(node, justifyContent);
        }

        public YGJustify YGNodeStyleGetJustifyContent(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetJustifyContent(node);
        }

        public void YGNodeStyleSetAlignContent(YGNode* node, YGAlign alignContent)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetAlignContent(node, alignContent);
        }

        public YGAlign YGNodeStyleGetAlignContent(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetAlignContent(node);
        }

        public void YGNodeStyleSetAlignItems(YGNode* node, YGAlign alignItems)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetAlignItems(node, alignItems);
        }

        public YGAlign YGNodeStyleGetAlignItems(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetAlignItems(node);
        }

        public void YGNodeStyleSetAlignSelf(YGNode* node, YGAlign alignSelf)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetAlignSelf(node, alignSelf);
        }

        public YGAlign YGNodeStyleGetAlignSelf(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetAlignSelf(node);
        }

        public void YGNodeStyleSetPositionType(YGNode* node, YGPositionType positionType)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetPositionType(node, positionType);
        }

        public YGPositionType YGNodeStyleGetPositionType(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetPositionType(node);
        }

        public void YGNodeStyleSetFlexWrap(YGNode* node, YGWrap flexWrap)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexWrap(node, flexWrap);
        }

        public YGWrap YGNodeStyleGetFlexWrap(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetFlexWrap(node);
        }

        public void YGNodeStyleSetOverflow(YGNode* node, YGOverflow overflow)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetOverflow(node, overflow);
        }

        public YGOverflow YGNodeStyleGetOverflow(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetOverflow(node);
        }

        public void YGNodeStyleSetDisplay(YGNode* node, YGDisplay display)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetDisplay(node, display);
        }

        public YGDisplay YGNodeStyleGetDisplay(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetDisplay(node);
        }

        public void YGNodeStyleSetFlex(YGNode* node, float flex)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlex(node, flex);
        }

        public float YGNodeStyleGetFlex(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetFlex(node);
        }

        public void YGNodeStyleSetFlexGrow(YGNode* node, float flexGrow)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexGrow(node, flexGrow);
        }

        public float YGNodeStyleGetFlexGrow(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetFlexGrow(node);
        }

        public void YGNodeStyleSetFlexShrink(YGNode* node, float flexShrink)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexShrink(node, flexShrink);
        }

        public float YGNodeStyleGetFlexShrink(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetFlexShrink(node);
        }

        public void YGNodeStyleSetFlexBasis(YGNode* node, float flexBasis)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexBasis(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisPercent(YGNode* node, float flexBasis)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexBasisPercent(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisAuto(YGNode* node)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetFlexBasisAuto(node);
        }

        public YGValue YGNodeStyleGetFlexBasis(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetFlexBasis(node);
        }

        public void YGNodeStyleSetPosition(YGNode* node, YGEdge edge, float position)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetPosition(node, edge, position);
        }

        public void YGNodeStyleSetPositionPercent(YGNode* node, YGEdge edge, float position)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetPositionPercent(node, edge, position);
        }

        public YGValue YGNodeStyleGetPosition(YGNode* node, YGEdge edge)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetPosition(node, edge);
        }

        public void YGNodeStyleSetPositionAuto(YGNode* node, YGEdge edge)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetPositionAuto(node, edge);
        }

        public void YGNodeStyleSetMargin(YGNode* node, YGEdge edge, float margin)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMargin(node, edge, margin);
        }

        public void YGNodeStyleSetMarginPercent(YGNode* node, YGEdge edge, float margin)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMarginPercent(node, edge, margin);
        }

        public void YGNodeStyleSetMarginAuto(YGNode* node, YGEdge edge)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMarginAuto(node, edge);
        }

        public YGValue YGNodeStyleGetMargin(YGNode* node, YGEdge edge)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetMargin(node, edge);
        }

        public void YGNodeStyleSetPadding(YGNode* node, YGEdge edge, float padding)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetPadding(node, edge, padding);
        }

        public void YGNodeStyleSetPaddingPercent(YGNode* node, YGEdge edge, float padding)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetPaddingPercent(node, edge, padding);
        }

        public YGValue YGNodeStyleGetPadding(YGNode* node, YGEdge edge)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetPadding(node, edge);
        }

        public void YGNodeStyleSetBorder(YGNode* node, YGEdge edge, float border)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetBorder(node, edge, border);
        }

        public float YGNodeStyleGetBorder(YGNode* node, YGEdge edge)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetBorder(node, edge);
        }

        public void YGNodeStyleSetGap(YGNode* node, YGGutter gutter, float gapLength)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetGap(node, gutter, gapLength);
        }

        public void YGNodeStyleSetGapPercent(YGNode* node, YGGutter gutter, float gapLength)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetGapPercent(node, gutter, gapLength);
        }

        public float YGNodeStyleGetGap(YGNode* node, YGGutter gutter)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetGap(node, gutter);
        }

        public void YGNodeStyleSetBoxSizing(YGNode* node, YGBoxSizing boxSizing)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetBoxSizing(node, boxSizing);
        }

        public YGBoxSizing YGNodeStyleGetBoxSizing(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetBoxSizing(node);
        }

        public void YGNodeStyleSetWidth(YGNode* node, float width)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetWidth(node, width);
        }

        public void YGNodeStyleSetWidthPercent(YGNode* node, float width)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetWidthPercent(node, width);
        }

        public void YGNodeStyleSetWidthAuto(YGNode* node)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetWidthAuto(node);
        }

        public YGValue YGNodeStyleGetWidth(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetWidth(node);
        }

        public void YGNodeStyleSetHeight(YGNode* node, float height)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetHeight(node, height);
        }

        public void YGNodeStyleSetHeightPercent(YGNode* node, float height)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetHeightPercent(node, height);
        }

        public void YGNodeStyleSetHeightAuto(YGNode* node)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetHeightAuto(node);
        }

        public YGValue YGNodeStyleGetHeight(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetHeight(node);
        }

        public void YGNodeStyleSetMinWidth(YGNode* node, float minWidth)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMinWidth(node, minWidth);
        }

        public void YGNodeStyleSetMinWidthPercent(YGNode* node, float minWidth)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMinWidthPercent(node, minWidth);
        }

        public YGValue YGNodeStyleGetMinWidth(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetMinWidth(node);
        }

        public void YGNodeStyleSetMinHeight(YGNode* node, float minHeight)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMinHeight(node, minHeight);
        }

        public void YGNodeStyleSetMinHeightPercent(YGNode* node, float minHeight)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMinHeightPercent(node, minHeight);
        }

        public YGValue YGNodeStyleGetMinHeight(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetMinHeight(node);
        }

        public void YGNodeStyleSetMaxWidth(YGNode* node, float maxWidth)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMaxWidth(node, maxWidth);
        }

        public void YGNodeStyleSetMaxWidthPercent(YGNode* node, float maxWidth)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMaxWidthPercent(node, maxWidth);
        }

        public YGValue YGNodeStyleGetMaxWidth(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetMaxWidth(node);
        }

        public void YGNodeStyleSetMaxHeight(YGNode* node, float maxHeight)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMaxHeight(node, maxHeight);
        }

        public void YGNodeStyleSetMaxHeightPercent(YGNode* node, float maxHeight)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetMaxHeightPercent(node, maxHeight);
        }

        public YGValue YGNodeStyleGetMaxHeight(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetMaxHeight(node);
        }

        public void YGNodeStyleSetAspectRatio(YGNode* node, float aspectRatio)
        {
            YGStyleApiWindowsNative.YGNodeStyleSetAspectRatio(node, aspectRatio);
        }

        public float YGNodeStyleGetAspectRatio(YGNode* node)
        {
            return YGStyleApiWindowsNative.YGNodeStyleGetAspectRatio(node);
        }
    }
}