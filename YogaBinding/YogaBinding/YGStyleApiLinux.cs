namespace YogaBinding
{
    internal unsafe class YGStyleApiLinux : IYGStyleApi
    {
        public void YGNodeCopyStyle(YGNode* dstNode, YGNode* srcNode)
        {
            YGStyleApiLinuxNative.YGNodeCopyStyle(dstNode, srcNode);
        }

        public void YGNodeStyleSetDirection(YGNode* node, YGDirection direction)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetDirection(node, direction);
        }

        public YGDirection YGNodeStyleGetDirection(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetDirection(node);
        }

        public void YGNodeStyleSetFlexDirection(YGNode* node, YGFlexDirection flexDirection)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexDirection(node, flexDirection);
        }

        public YGFlexDirection YGNodeStyleGetFlexDirection(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetFlexDirection(node);
        }

        public void YGNodeStyleSetJustifyContent(YGNode* node, YGJustify justifyContent)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetJustifyContent(node, justifyContent);
        }

        public YGJustify YGNodeStyleGetJustifyContent(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetJustifyContent(node);
        }

        public void YGNodeStyleSetAlignContent(YGNode* node, YGAlign alignContent)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetAlignContent(node, alignContent);
        }

        public YGAlign YGNodeStyleGetAlignContent(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetAlignContent(node);
        }

        public void YGNodeStyleSetAlignItems(YGNode* node, YGAlign alignItems)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetAlignItems(node, alignItems);
        }

        public YGAlign YGNodeStyleGetAlignItems(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetAlignItems(node);
        }

        public void YGNodeStyleSetAlignSelf(YGNode* node, YGAlign alignSelf)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetAlignSelf(node, alignSelf);
        }

        public YGAlign YGNodeStyleGetAlignSelf(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetAlignSelf(node);
        }

        public void YGNodeStyleSetPositionType(YGNode* node, YGPositionType positionType)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetPositionType(node, positionType);
        }

        public YGPositionType YGNodeStyleGetPositionType(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetPositionType(node);
        }

        public void YGNodeStyleSetFlexWrap(YGNode* node, YGWrap flexWrap)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexWrap(node, flexWrap);
        }

        public YGWrap YGNodeStyleGetFlexWrap(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetFlexWrap(node);
        }

        public void YGNodeStyleSetOverflow(YGNode* node, YGOverflow overflow)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetOverflow(node, overflow);
        }

        public YGOverflow YGNodeStyleGetOverflow(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetOverflow(node);
        }

        public void YGNodeStyleSetDisplay(YGNode* node, YGDisplay display)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetDisplay(node, display);
        }

        public YGDisplay YGNodeStyleGetDisplay(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetDisplay(node);
        }

        public void YGNodeStyleSetFlex(YGNode* node, float flex)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlex(node, flex);
        }

        public float YGNodeStyleGetFlex(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetFlex(node);
        }

        public void YGNodeStyleSetFlexGrow(YGNode* node, float flexGrow)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexGrow(node, flexGrow);
        }

        public float YGNodeStyleGetFlexGrow(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetFlexGrow(node);
        }

        public void YGNodeStyleSetFlexShrink(YGNode* node, float flexShrink)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexShrink(node, flexShrink);
        }

        public float YGNodeStyleGetFlexShrink(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetFlexShrink(node);
        }

        public void YGNodeStyleSetFlexBasis(YGNode* node, float flexBasis)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexBasis(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisPercent(YGNode* node, float flexBasis)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexBasisPercent(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisAuto(YGNode* node)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetFlexBasisAuto(node);
        }

        public YGValue YGNodeStyleGetFlexBasis(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetFlexBasis(node);
        }

        public void YGNodeStyleSetPosition(YGNode* node, YGEdge edge, float position)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetPosition(node, edge, position);
        }

        public void YGNodeStyleSetPositionPercent(YGNode* node, YGEdge edge, float position)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetPositionPercent(node, edge, position);
        }

        public YGValue YGNodeStyleGetPosition(YGNode* node, YGEdge edge)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetPosition(node, edge);
        }

        public void YGNodeStyleSetPositionAuto(YGNode* node, YGEdge edge)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetPositionAuto(node, edge);
        }

        public void YGNodeStyleSetMargin(YGNode* node, YGEdge edge, float margin)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMargin(node, edge, margin);
        }

        public void YGNodeStyleSetMarginPercent(YGNode* node, YGEdge edge, float margin)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMarginPercent(node, edge, margin);
        }

        public void YGNodeStyleSetMarginAuto(YGNode* node, YGEdge edge)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMarginAuto(node, edge);
        }

        public YGValue YGNodeStyleGetMargin(YGNode* node, YGEdge edge)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetMargin(node, edge);
        }

        public void YGNodeStyleSetPadding(YGNode* node, YGEdge edge, float padding)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetPadding(node, edge, padding);
        }

        public void YGNodeStyleSetPaddingPercent(YGNode* node, YGEdge edge, float padding)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetPaddingPercent(node, edge, padding);
        }

        public YGValue YGNodeStyleGetPadding(YGNode* node, YGEdge edge)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetPadding(node, edge);
        }

        public void YGNodeStyleSetBorder(YGNode* node, YGEdge edge, float border)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetBorder(node, edge, border);
        }

        public float YGNodeStyleGetBorder(YGNode* node, YGEdge edge)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetBorder(node, edge);
        }

        public void YGNodeStyleSetGap(YGNode* node, YGGutter gutter, float gapLength)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetGap(node, gutter, gapLength);
        }

        public void YGNodeStyleSetGapPercent(YGNode* node, YGGutter gutter, float gapLength)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetGapPercent(node, gutter, gapLength);
        }

        public float YGNodeStyleGetGap(YGNode* node, YGGutter gutter)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetGap(node, gutter);
        }

        public void YGNodeStyleSetBoxSizing(YGNode* node, YGBoxSizing boxSizing)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetBoxSizing(node, boxSizing);
        }

        public YGBoxSizing YGNodeStyleGetBoxSizing(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetBoxSizing(node);
        }

        public void YGNodeStyleSetWidth(YGNode* node, float width)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetWidth(node, width);
        }

        public void YGNodeStyleSetWidthPercent(YGNode* node, float width)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetWidthPercent(node, width);
        }

        public void YGNodeStyleSetWidthAuto(YGNode* node)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetWidthAuto(node);
        }

        public YGValue YGNodeStyleGetWidth(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetWidth(node);
        }

        public void YGNodeStyleSetHeight(YGNode* node, float height)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetHeight(node, height);
        }

        public void YGNodeStyleSetHeightPercent(YGNode* node, float height)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetHeightPercent(node, height);
        }

        public void YGNodeStyleSetHeightAuto(YGNode* node)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetHeightAuto(node);
        }

        public YGValue YGNodeStyleGetHeight(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetHeight(node);
        }

        public void YGNodeStyleSetMinWidth(YGNode* node, float minWidth)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMinWidth(node, minWidth);
        }

        public void YGNodeStyleSetMinWidthPercent(YGNode* node, float minWidth)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMinWidthPercent(node, minWidth);
        }

        public YGValue YGNodeStyleGetMinWidth(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetMinWidth(node);
        }

        public void YGNodeStyleSetMinHeight(YGNode* node, float minHeight)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMinHeight(node, minHeight);
        }

        public void YGNodeStyleSetMinHeightPercent(YGNode* node, float minHeight)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMinHeightPercent(node, minHeight);
        }

        public YGValue YGNodeStyleGetMinHeight(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetMinHeight(node);
        }

        public void YGNodeStyleSetMaxWidth(YGNode* node, float maxWidth)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMaxWidth(node, maxWidth);
        }

        public void YGNodeStyleSetMaxWidthPercent(YGNode* node, float maxWidth)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMaxWidthPercent(node, maxWidth);
        }

        public YGValue YGNodeStyleGetMaxWidth(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetMaxWidth(node);
        }

        public void YGNodeStyleSetMaxHeight(YGNode* node, float maxHeight)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMaxHeight(node, maxHeight);
        }

        public void YGNodeStyleSetMaxHeightPercent(YGNode* node, float maxHeight)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetMaxHeightPercent(node, maxHeight);
        }

        public YGValue YGNodeStyleGetMaxHeight(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetMaxHeight(node);
        }

        public void YGNodeStyleSetAspectRatio(YGNode* node, float aspectRatio)
        {
            YGStyleApiLinuxNative.YGNodeStyleSetAspectRatio(node, aspectRatio);
        }

        public float YGNodeStyleGetAspectRatio(YGNode* node)
        {
            return YGStyleApiLinuxNative.YGNodeStyleGetAspectRatio(node);
        }
    }
}