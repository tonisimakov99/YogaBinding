namespace YogaBinding
{
    internal unsafe interface IYGNodeLayoutApi
    {
        float YGNodeLayoutGetLeft(YGNode* node);
        float YGNodeLayoutGetTop(YGNode* node);
        float YGNodeLayoutGetRight(YGNode* node);
        float YGNodeLayoutGetBottom(YGNode* node);
        float YGNodeLayoutGetWidth(YGNode* node);
        float YGNodeLayoutGetHeight(YGNode* node);
        YGDirection YGNodeLayoutGetDirection(YGNode* node);
        bool YGNodeLayoutGetHadOverflow(YGNode* node);
        float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge);
        float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge);
        float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge);
    }
}