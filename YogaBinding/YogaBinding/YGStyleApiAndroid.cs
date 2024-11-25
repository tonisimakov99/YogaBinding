namespace YogaBinding
{
    internal unsafe class YGStyleApiAndroid : IYGStyleApi
    {
        public void YGNodeCopyStyle(YGNode* dstNode, YGNode* srcNode)
        {
            YGStyleApiAndroidNative.YGNodeCopyStyle(dstNode, srcNode);
        }

        public void YGNodeStyleSetDirection(YGNode* node, YGDirection direction)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetDirection(node, direction);
        }

        public YGDirection YGNodeStyleGetDirection(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetDirection(node);
        }

        public void YGNodeStyleSetFlexDirection(YGNode* node, YGFlexDirection flexDirection)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexDirection(node, flexDirection);
        }

        public YGFlexDirection YGNodeStyleGetFlexDirection(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetFlexDirection(node);
        }

        public void YGNodeStyleSetJustifyContent(YGNode* node, YGJustify justifyContent)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetJustifyContent(node, justifyContent);
        }

        public YGJustify YGNodeStyleGetJustifyContent(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetJustifyContent(node);
        }

        public void YGNodeStyleSetAlignContent(YGNode* node, YGAlign alignContent)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetAlignContent(node, alignContent);
        }

        public YGAlign YGNodeStyleGetAlignContent(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetAlignContent(node);
        }

        public void YGNodeStyleSetAlignItems(YGNode* node, YGAlign alignItems)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetAlignItems(node, alignItems);
        }

        public YGAlign YGNodeStyleGetAlignItems(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetAlignItems(node);
        }

        public void YGNodeStyleSetAlignSelf(YGNode* node, YGAlign alignSelf)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetAlignSelf(node, alignSelf);
        }

        public YGAlign YGNodeStyleGetAlignSelf(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetAlignSelf(node);
        }

        public void YGNodeStyleSetPositionType(YGNode* node, YGPositionType positionType)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetPositionType(node, positionType);
        }

        public YGPositionType YGNodeStyleGetPositionType(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetPositionType(node);
        }

        public void YGNodeStyleSetFlexWrap(YGNode* node, YGWrap flexWrap)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexWrap(node, flexWrap);
        }

        public YGWrap YGNodeStyleGetFlexWrap(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetFlexWrap(node);
        }

        public void YGNodeStyleSetOverflow(YGNode* node, YGOverflow overflow)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetOverflow(node, overflow);
        }

        public YGOverflow YGNodeStyleGetOverflow(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetOverflow(node);
        }

        public void YGNodeStyleSetDisplay(YGNode* node, YGDisplay display)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetDisplay(node, display);
        }

        public YGDisplay YGNodeStyleGetDisplay(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetDisplay(node);
        }

        public void YGNodeStyleSetFlex(YGNode* node, float flex)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlex(node, flex);
        }

        public float YGNodeStyleGetFlex(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetFlex(node);
        }

        public void YGNodeStyleSetFlexGrow(YGNode* node, float flexGrow)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexGrow(node, flexGrow);
        }

        public float YGNodeStyleGetFlexGrow(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetFlexGrow(node);
        }

        public void YGNodeStyleSetFlexShrink(YGNode* node, float flexShrink)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexShrink(node, flexShrink);
        }

        public float YGNodeStyleGetFlexShrink(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetFlexShrink(node);
        }

        public void YGNodeStyleSetFlexBasis(YGNode* node, float flexBasis)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexBasis(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisPercent(YGNode* node, float flexBasis)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexBasisPercent(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisAuto(YGNode* node)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetFlexBasisAuto(node);
        }

        public YGValue YGNodeStyleGetFlexBasis(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetFlexBasis(node);
        }

        public void YGNodeStyleSetPosition(YGNode* node, YGEdge edge, float position)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetPosition(node, edge, position);
        }

        public void YGNodeStyleSetPositionPercent(YGNode* node, YGEdge edge, float position)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetPositionPercent(node, edge, position);
        }

        public YGValue YGNodeStyleGetPosition(YGNode* node, YGEdge edge)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetPosition(node, edge);
        }

        public void YGNodeStyleSetPositionAuto(YGNode* node, YGEdge edge)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetPositionAuto(node, edge);
        }

        public void YGNodeStyleSetMargin(YGNode* node, YGEdge edge, float margin)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMargin(node, edge, margin);
        }

        public void YGNodeStyleSetMarginPercent(YGNode* node, YGEdge edge, float margin)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMarginPercent(node, edge, margin);
        }

        public void YGNodeStyleSetMarginAuto(YGNode* node, YGEdge edge)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMarginAuto(node, edge);
        }

        public YGValue YGNodeStyleGetMargin(YGNode* node, YGEdge edge)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetMargin(node, edge);
        }

        public void YGNodeStyleSetPadding(YGNode* node, YGEdge edge, float padding)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetPadding(node, edge, padding);
        }

        public void YGNodeStyleSetPaddingPercent(YGNode* node, YGEdge edge, float padding)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetPaddingPercent(node, edge, padding);
        }

        public YGValue YGNodeStyleGetPadding(YGNode* node, YGEdge edge)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetPadding(node, edge);
        }

        public void YGNodeStyleSetBorder(YGNode* node, YGEdge edge, float border)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetBorder(node, edge, border);
        }

        public float YGNodeStyleGetBorder(YGNode* node, YGEdge edge)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetBorder(node, edge);
        }

        public void YGNodeStyleSetGap(YGNode* node, YGGutter gutter, float gapLength)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetGap(node, gutter, gapLength);
        }

        public void YGNodeStyleSetGapPercent(YGNode* node, YGGutter gutter, float gapLength)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetGapPercent(node, gutter, gapLength);
        }

        public float YGNodeStyleGetGap(YGNode* node, YGGutter gutter)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetGap(node, gutter);
        }

        public void YGNodeStyleSetBoxSizing(YGNode* node, YGBoxSizing boxSizing)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetBoxSizing(node, boxSizing);
        }

        public YGBoxSizing YGNodeStyleGetBoxSizing(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetBoxSizing(node);
        }

        public void YGNodeStyleSetWidth(YGNode* node, float width)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetWidth(node, width);
        }

        public void YGNodeStyleSetWidthPercent(YGNode* node, float width)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetWidthPercent(node, width);
        }

        public void YGNodeStyleSetWidthAuto(YGNode* node)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetWidthAuto(node);
        }

        public YGValue YGNodeStyleGetWidth(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetWidth(node);
        }

        public void YGNodeStyleSetHeight(YGNode* node, float height)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetHeight(node, height);
        }

        public void YGNodeStyleSetHeightPercent(YGNode* node, float height)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetHeightPercent(node, height);
        }

        public void YGNodeStyleSetHeightAuto(YGNode* node)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetHeightAuto(node);
        }

        public YGValue YGNodeStyleGetHeight(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetHeight(node);
        }

        public void YGNodeStyleSetMinWidth(YGNode* node, float minWidth)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMinWidth(node, minWidth);
        }

        public void YGNodeStyleSetMinWidthPercent(YGNode* node, float minWidth)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMinWidthPercent(node, minWidth);
        }

        public YGValue YGNodeStyleGetMinWidth(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetMinWidth(node);
        }

        public void YGNodeStyleSetMinHeight(YGNode* node, float minHeight)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMinHeight(node, minHeight);
        }

        public void YGNodeStyleSetMinHeightPercent(YGNode* node, float minHeight)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMinHeightPercent(node, minHeight);
        }

        public YGValue YGNodeStyleGetMinHeight(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetMinHeight(node);
        }

        public void YGNodeStyleSetMaxWidth(YGNode* node, float maxWidth)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMaxWidth(node, maxWidth);
        }

        public void YGNodeStyleSetMaxWidthPercent(YGNode* node, float maxWidth)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMaxWidthPercent(node, maxWidth);
        }

        public YGValue YGNodeStyleGetMaxWidth(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetMaxWidth(node);
        }

        public void YGNodeStyleSetMaxHeight(YGNode* node, float maxHeight)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMaxHeight(node, maxHeight);
        }

        public void YGNodeStyleSetMaxHeightPercent(YGNode* node, float maxHeight)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetMaxHeightPercent(node, maxHeight);
        }

        public YGValue YGNodeStyleGetMaxHeight(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetMaxHeight(node);
        }

        public void YGNodeStyleSetAspectRatio(YGNode* node, float aspectRatio)
        {
            YGStyleApiAndroidNative.YGNodeStyleSetAspectRatio(node, aspectRatio);
        }

        public float YGNodeStyleGetAspectRatio(YGNode* node)
        {
            return YGStyleApiAndroidNative.YGNodeStyleGetAspectRatio(node);
        }
    }
}