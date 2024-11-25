using System.Runtime.InteropServices;

namespace YogaBinding
{
    internal static unsafe class YGStyleApiLinuxNative
    {
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeCopyStyle(YGNode* dstNode, YGNode* srcNode);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetDirection(YGNode* node, YGDirection direction);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGDirection YGNodeStyleGetDirection(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexDirection(YGNode* node, YGFlexDirection flexDirection);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGFlexDirection YGNodeStyleGetFlexDirection(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetJustifyContent(YGNode* node, YGJustify justifyContent);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGJustify YGNodeStyleGetJustifyContent(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetAlignContent(YGNode* node, YGAlign alignContent);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGAlign YGNodeStyleGetAlignContent(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetAlignItems(YGNode* node, YGAlign alignItems);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGAlign YGNodeStyleGetAlignItems(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetAlignSelf(YGNode* node, YGAlign alignSelf);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGAlign YGNodeStyleGetAlignSelf(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetPositionType(YGNode* node, YGPositionType positionType);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGPositionType YGNodeStyleGetPositionType(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexWrap(YGNode* node, YGWrap flexWrap);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGWrap YGNodeStyleGetFlexWrap(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetOverflow(YGNode* node, YGOverflow overflow);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGOverflow YGNodeStyleGetOverflow(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetDisplay(YGNode* node, YGDisplay display);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGDisplay YGNodeStyleGetDisplay(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlex(YGNode* node, float flex);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeStyleGetFlex(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexGrow(YGNode* node, float flexGrow);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeStyleGetFlexGrow(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexShrink(YGNode* node, float flexShrink);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeStyleGetFlexShrink(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexBasis(YGNode* node, float flexBasis);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexBasisPercent(YGNode* node, float flexBasis);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetFlexBasisAuto(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetFlexBasis(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetPosition(YGNode* node, YGEdge edge, float position);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetPositionPercent(YGNode* node, YGEdge edge, float position);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetPosition(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetPositionAuto(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMargin(YGNode* node, YGEdge edge, float margin);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMarginPercent(YGNode* node, YGEdge edge, float margin);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMarginAuto(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetMargin(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetPadding(YGNode* node, YGEdge edge, float padding);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetPaddingPercent(YGNode* node, YGEdge edge, float padding);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetPadding(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetBorder(YGNode* node, YGEdge edge, float border);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeStyleGetBorder(YGNode* node, YGEdge edge);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetGap(YGNode* node, YGGutter gutter, float gapLength);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetGapPercent(YGNode* node, YGGutter gutter, float gapLength);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeStyleGetGap(YGNode* node, YGGutter gutter);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetBoxSizing(YGNode* node, YGBoxSizing boxSizing);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGBoxSizing YGNodeStyleGetBoxSizing(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetWidth(YGNode* node, float width);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetWidthPercent(YGNode* node, float width);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetWidthAuto(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetWidth(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetHeight(YGNode* node, float height);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetHeightPercent(YGNode* node, float height);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetHeightAuto(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetHeight(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMinWidth(YGNode* node, float minWidth);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMinWidthPercent(YGNode* node, float minWidth);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetMinWidth(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMinHeight(YGNode* node, float minHeight);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMinHeightPercent(YGNode* node, float minHeight);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetMinHeight(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMaxWidth(YGNode* node, float maxWidth);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMaxWidthPercent(YGNode* node, float maxWidth);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetMaxWidth(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMaxHeight(YGNode* node, float maxHeight);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetMaxHeightPercent(YGNode* node, float maxHeight);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern YGValue YGNodeStyleGetMaxHeight(YGNode* node);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern void YGNodeStyleSetAspectRatio(YGNode* node, float aspectRatio);
        [DllImport("runtimes/linux-x64/libyogacore.so", CallingConvention = CallingConvention.Cdecl)]
        public static extern float YGNodeStyleGetAspectRatio(YGNode* node);
    }
}