namespace YogaBinding
{
    internal unsafe class YGNodeLayoutApiWindows : IYGNodeLayoutApi
    {
        public float YGNodeLayoutGetLeft(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetLeft(node);
        }

        public float YGNodeLayoutGetTop(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetTop(node);
        }

        public float YGNodeLayoutGetRight(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetRight(node);
        }

        public float YGNodeLayoutGetBottom(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetBottom(node);
        }

        public float YGNodeLayoutGetWidth(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetWidth(node);
        }

        public float YGNodeLayoutGetHeight(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetHeight(node);
        }

        public YGDirection YGNodeLayoutGetDirection(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetDirection(node);
        }

        public bool YGNodeLayoutGetHadOverflow(YGNode* node)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetHadOverflow(node);
        }

        public float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetMargin(node, edge);
        }

        public float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetBorder(node, edge);
        }

        public float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiWindowsNative.YGNodeLayoutGetPadding(node, edge);
        }
    }
}