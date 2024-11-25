namespace YogaBinding
{
    public unsafe class YGStyleApi
    {
        public YGStyleApi(Platform platform)
        {
            if (platform == Platform.Windows)
                lib = new YGStyleApiWindows();
            else if (platform == Platform.Linux)
                lib = new YGStyleApiLinux();
            else if (platform == Platform.Android)
                lib = new YGStyleApiAndroid();
            else
                throw new System.NotSupportedException("not supported");
        }

        IYGStyleApi lib;
        public void YGNodeCopyStyle(YGNode* dstNode, YGNode* srcNode)
        {
            lib.YGNodeCopyStyle(dstNode, srcNode);
        }

        public void YGNodeStyleSetDirection(YGNode* node, YGDirection direction)
        {
            lib.YGNodeStyleSetDirection(node, direction);
        }

        public YGDirection YGNodeStyleGetDirection(YGNode* node)
        {
            return lib.YGNodeStyleGetDirection(node);
        }

        public void YGNodeStyleSetFlexDirection(YGNode* node, YGFlexDirection flexDirection)
        {
            lib.YGNodeStyleSetFlexDirection(node, flexDirection);
        }

        public YGFlexDirection YGNodeStyleGetFlexDirection(YGNode* node)
        {
            return lib.YGNodeStyleGetFlexDirection(node);
        }

        public void YGNodeStyleSetJustifyContent(YGNode* node, YGJustify justifyContent)
        {
            lib.YGNodeStyleSetJustifyContent(node, justifyContent);
        }

        public YGJustify YGNodeStyleGetJustifyContent(YGNode* node)
        {
            return lib.YGNodeStyleGetJustifyContent(node);
        }

        public void YGNodeStyleSetAlignContent(YGNode* node, YGAlign alignContent)
        {
            lib.YGNodeStyleSetAlignContent(node, alignContent);
        }

        public YGAlign YGNodeStyleGetAlignContent(YGNode* node)
        {
            return lib.YGNodeStyleGetAlignContent(node);
        }

        public void YGNodeStyleSetAlignItems(YGNode* node, YGAlign alignItems)
        {
            lib.YGNodeStyleSetAlignItems(node, alignItems);
        }

        public YGAlign YGNodeStyleGetAlignItems(YGNode* node)
        {
            return lib.YGNodeStyleGetAlignItems(node);
        }

        public void YGNodeStyleSetAlignSelf(YGNode* node, YGAlign alignSelf)
        {
            lib.YGNodeStyleSetAlignSelf(node, alignSelf);
        }

        public YGAlign YGNodeStyleGetAlignSelf(YGNode* node)
        {
            return lib.YGNodeStyleGetAlignSelf(node);
        }

        public void YGNodeStyleSetPositionType(YGNode* node, YGPositionType positionType)
        {
            lib.YGNodeStyleSetPositionType(node, positionType);
        }

        public YGPositionType YGNodeStyleGetPositionType(YGNode* node)
        {
            return lib.YGNodeStyleGetPositionType(node);
        }

        public void YGNodeStyleSetFlexWrap(YGNode* node, YGWrap flexWrap)
        {
            lib.YGNodeStyleSetFlexWrap(node, flexWrap);
        }

        public YGWrap YGNodeStyleGetFlexWrap(YGNode* node)
        {
            return lib.YGNodeStyleGetFlexWrap(node);
        }

        public void YGNodeStyleSetOverflow(YGNode* node, YGOverflow overflow)
        {
            lib.YGNodeStyleSetOverflow(node, overflow);
        }

        public YGOverflow YGNodeStyleGetOverflow(YGNode* node)
        {
            return lib.YGNodeStyleGetOverflow(node);
        }

        public void YGNodeStyleSetDisplay(YGNode* node, YGDisplay display)
        {
            lib.YGNodeStyleSetDisplay(node, display);
        }

        public YGDisplay YGNodeStyleGetDisplay(YGNode* node)
        {
            return lib.YGNodeStyleGetDisplay(node);
        }

        public void YGNodeStyleSetFlex(YGNode* node, float flex)
        {
            lib.YGNodeStyleSetFlex(node, flex);
        }

        public float YGNodeStyleGetFlex(YGNode* node)
        {
            return lib.YGNodeStyleGetFlex(node);
        }

        public void YGNodeStyleSetFlexGrow(YGNode* node, float flexGrow)
        {
            lib.YGNodeStyleSetFlexGrow(node, flexGrow);
        }

        public float YGNodeStyleGetFlexGrow(YGNode* node)
        {
            return lib.YGNodeStyleGetFlexGrow(node);
        }

        public void YGNodeStyleSetFlexShrink(YGNode* node, float flexShrink)
        {
            lib.YGNodeStyleSetFlexShrink(node, flexShrink);
        }

        public float YGNodeStyleGetFlexShrink(YGNode* node)
        {
            return lib.YGNodeStyleGetFlexShrink(node);
        }

        public void YGNodeStyleSetFlexBasis(YGNode* node, float flexBasis)
        {
            lib.YGNodeStyleSetFlexBasis(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisPercent(YGNode* node, float flexBasis)
        {
            lib.YGNodeStyleSetFlexBasisPercent(node, flexBasis);
        }

        public void YGNodeStyleSetFlexBasisAuto(YGNode* node)
        {
            lib.YGNodeStyleSetFlexBasisAuto(node);
        }

        public YGValue YGNodeStyleGetFlexBasis(YGNode* node)
        {
            return lib.YGNodeStyleGetFlexBasis(node);
        }

        public void YGNodeStyleSetPosition(YGNode* node, YGEdge edge, float position)
        {
            lib.YGNodeStyleSetPosition(node, edge, position);
        }

        public void YGNodeStyleSetPositionPercent(YGNode* node, YGEdge edge, float position)
        {
            lib.YGNodeStyleSetPositionPercent(node, edge, position);
        }

        public YGValue YGNodeStyleGetPosition(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeStyleGetPosition(node, edge);
        }

        public void YGNodeStyleSetPositionAuto(YGNode* node, YGEdge edge)
        {
            lib.YGNodeStyleSetPositionAuto(node, edge);
        }

        public void YGNodeStyleSetMargin(YGNode* node, YGEdge edge, float margin)
        {
            lib.YGNodeStyleSetMargin(node, edge, margin);
        }

        public void YGNodeStyleSetMarginPercent(YGNode* node, YGEdge edge, float margin)
        {
            lib.YGNodeStyleSetMarginPercent(node, edge, margin);
        }

        public void YGNodeStyleSetMarginAuto(YGNode* node, YGEdge edge)
        {
            lib.YGNodeStyleSetMarginAuto(node, edge);
        }

        public YGValue YGNodeStyleGetMargin(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeStyleGetMargin(node, edge);
        }

        public void YGNodeStyleSetPadding(YGNode* node, YGEdge edge, float padding)
        {
            lib.YGNodeStyleSetPadding(node, edge, padding);
        }

        public void YGNodeStyleSetPaddingPercent(YGNode* node, YGEdge edge, float padding)
        {
            lib.YGNodeStyleSetPaddingPercent(node, edge, padding);
        }

        public YGValue YGNodeStyleGetPadding(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeStyleGetPadding(node, edge);
        }

        public void YGNodeStyleSetBorder(YGNode* node, YGEdge edge, float border)
        {
            lib.YGNodeStyleSetBorder(node, edge, border);
        }

        public float YGNodeStyleGetBorder(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeStyleGetBorder(node, edge);
        }

        public void YGNodeStyleSetGap(YGNode* node, YGGutter gutter, float gapLength)
        {
            lib.YGNodeStyleSetGap(node, gutter, gapLength);
        }

        public void YGNodeStyleSetGapPercent(YGNode* node, YGGutter gutter, float gapLength)
        {
            lib.YGNodeStyleSetGapPercent(node, gutter, gapLength);
        }

        public float YGNodeStyleGetGap(YGNode* node, YGGutter gutter)
        {
            return lib.YGNodeStyleGetGap(node, gutter);
        }

        public void YGNodeStyleSetBoxSizing(YGNode* node, YGBoxSizing boxSizing)
        {
            lib.YGNodeStyleSetBoxSizing(node, boxSizing);
        }

        public YGBoxSizing YGNodeStyleGetBoxSizing(YGNode* node)
        {
            return lib.YGNodeStyleGetBoxSizing(node);
        }

        public void YGNodeStyleSetWidth(YGNode* node, float width)
        {
            lib.YGNodeStyleSetWidth(node, width);
        }

        public void YGNodeStyleSetWidthPercent(YGNode* node, float width)
        {
            lib.YGNodeStyleSetWidthPercent(node, width);
        }

        public void YGNodeStyleSetWidthAuto(YGNode* node)
        {
            lib.YGNodeStyleSetWidthAuto(node);
        }

        public YGValue YGNodeStyleGetWidth(YGNode* node)
        {
            return lib.YGNodeStyleGetWidth(node);
        }

        public void YGNodeStyleSetHeight(YGNode* node, float height)
        {
            lib.YGNodeStyleSetHeight(node, height);
        }

        public void YGNodeStyleSetHeightPercent(YGNode* node, float height)
        {
            lib.YGNodeStyleSetHeightPercent(node, height);
        }

        public void YGNodeStyleSetHeightAuto(YGNode* node)
        {
            lib.YGNodeStyleSetHeightAuto(node);
        }

        public YGValue YGNodeStyleGetHeight(YGNode* node)
        {
            return lib.YGNodeStyleGetHeight(node);
        }

        public void YGNodeStyleSetMinWidth(YGNode* node, float minWidth)
        {
            lib.YGNodeStyleSetMinWidth(node, minWidth);
        }

        public void YGNodeStyleSetMinWidthPercent(YGNode* node, float minWidth)
        {
            lib.YGNodeStyleSetMinWidthPercent(node, minWidth);
        }

        public YGValue YGNodeStyleGetMinWidth(YGNode* node)
        {
            return lib.YGNodeStyleGetMinWidth(node);
        }

        public void YGNodeStyleSetMinHeight(YGNode* node, float minHeight)
        {
            lib.YGNodeStyleSetMinHeight(node, minHeight);
        }

        public void YGNodeStyleSetMinHeightPercent(YGNode* node, float minHeight)
        {
            lib.YGNodeStyleSetMinHeightPercent(node, minHeight);
        }

        public YGValue YGNodeStyleGetMinHeight(YGNode* node)
        {
            return lib.YGNodeStyleGetMinHeight(node);
        }

        public void YGNodeStyleSetMaxWidth(YGNode* node, float maxWidth)
        {
            lib.YGNodeStyleSetMaxWidth(node, maxWidth);
        }

        public void YGNodeStyleSetMaxWidthPercent(YGNode* node, float maxWidth)
        {
            lib.YGNodeStyleSetMaxWidthPercent(node, maxWidth);
        }

        public YGValue YGNodeStyleGetMaxWidth(YGNode* node)
        {
            return lib.YGNodeStyleGetMaxWidth(node);
        }

        public void YGNodeStyleSetMaxHeight(YGNode* node, float maxHeight)
        {
            lib.YGNodeStyleSetMaxHeight(node, maxHeight);
        }

        public void YGNodeStyleSetMaxHeightPercent(YGNode* node, float maxHeight)
        {
            lib.YGNodeStyleSetMaxHeightPercent(node, maxHeight);
        }

        public YGValue YGNodeStyleGetMaxHeight(YGNode* node)
        {
            return lib.YGNodeStyleGetMaxHeight(node);
        }

        public void YGNodeStyleSetAspectRatio(YGNode* node, float aspectRatio)
        {
            lib.YGNodeStyleSetAspectRatio(node, aspectRatio);
        }

        public float YGNodeStyleGetAspectRatio(YGNode* node)
        {
            return lib.YGNodeStyleGetAspectRatio(node);
        }
    }
}