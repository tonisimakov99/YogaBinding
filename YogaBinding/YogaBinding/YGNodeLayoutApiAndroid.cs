namespace YogaBinding
{
    internal unsafe class YGNodeLayoutApiAndroid : IYGNodeLayoutApi
    {
        public float YGNodeLayoutGetLeft(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetLeft(node);
        }

        public float YGNodeLayoutGetTop(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetTop(node);
        }

        public float YGNodeLayoutGetRight(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetRight(node);
        }

        public float YGNodeLayoutGetBottom(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetBottom(node);
        }

        public float YGNodeLayoutGetWidth(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetWidth(node);
        }

        public float YGNodeLayoutGetHeight(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetHeight(node);
        }

        public YGDirection YGNodeLayoutGetDirection(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetDirection(node);
        }

        public bool YGNodeLayoutGetHadOverflow(YGNode* node)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetHadOverflow(node);
        }

        public float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetMargin(node, edge);
        }

        public float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetBorder(node, edge);
        }

        public float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge)
        {
            return YGNodeLayoutApiAndroidNative.YGNodeLayoutGetPadding(node, edge);
        }
    }
}