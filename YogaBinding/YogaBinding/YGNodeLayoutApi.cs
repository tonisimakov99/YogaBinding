namespace YogaBinding
{
    public unsafe class YGNodeLayoutApi
    {
        public YGNodeLayoutApi(Platform platform)
        {
            if (platform == Platform.Windows)
                lib = new YGNodeLayoutApiWindows();
            else if (platform == Platform.Linux)
                lib = new YGNodeLayoutApiLinux();
            else if (platform == Platform.Android)
                lib = new YGNodeLayoutApiAndroid();
            else
                throw new System.NotSupportedException("not supported");
        }

        IYGNodeLayoutApi lib;
        public float YGNodeLayoutGetLeft(YGNode* node)
        {
            return lib.YGNodeLayoutGetLeft(node);
        }

        public float YGNodeLayoutGetTop(YGNode* node)
        {
            return lib.YGNodeLayoutGetTop(node);
        }

        public float YGNodeLayoutGetRight(YGNode* node)
        {
            return lib.YGNodeLayoutGetRight(node);
        }

        public float YGNodeLayoutGetBottom(YGNode* node)
        {
            return lib.YGNodeLayoutGetBottom(node);
        }

        public float YGNodeLayoutGetWidth(YGNode* node)
        {
            return lib.YGNodeLayoutGetWidth(node);
        }

        public float YGNodeLayoutGetHeight(YGNode* node)
        {
            return lib.YGNodeLayoutGetHeight(node);
        }

        public YGDirection YGNodeLayoutGetDirection(YGNode* node)
        {
            return lib.YGNodeLayoutGetDirection(node);
        }

        public bool YGNodeLayoutGetHadOverflow(YGNode* node)
        {
            return lib.YGNodeLayoutGetHadOverflow(node);
        }

        public float YGNodeLayoutGetMargin(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeLayoutGetMargin(node, edge);
        }

        public float YGNodeLayoutGetBorder(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeLayoutGetBorder(node, edge);
        }

        public float YGNodeLayoutGetPadding(YGNode* node, YGEdge edge)
        {
            return lib.YGNodeLayoutGetPadding(node, edge);
        }
    }
}