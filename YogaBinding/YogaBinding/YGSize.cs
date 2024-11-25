namespace YogaBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct YGSize
    {
        public float width;
        public float height;
    }
}