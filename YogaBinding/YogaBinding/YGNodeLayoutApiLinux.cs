namespace YogaBinding
{
    internal unsafe class YGNodeLayoutApiLinux : IYGNodeLayoutApi
    {
        public float YGNodeLayoutGetLeft(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetLeft(node);
        }

        public float YGNodeLayoutGetTop(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetTop(node);
        }

        public float YGNodeLayoutGetRight(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetRight(node);
        }

        public float YGNodeLayoutGetBottom(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetBottom(node);
        }

        public float YGNodeLayoutGetWidth(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetWidth(node);
        }

        public float YGNodeLayoutGetHeight(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetHeight(node);
        }

        public YGDirection YGNodeLayoutGetDirection(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetDirection(node);
        }

        public bool YGNodeLayoutGetHadOverflow(YGNode* node)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetHadOverflow(node);
        }

        public float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetMargin(node, edge);
        }

        public float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetBorder(node, edge);
        }

        public float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiLinuxNative.YGNodeLayoutGetPadding(node, edge);
        }
    }
}