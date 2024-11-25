namespace YogaBinding
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct YGValue
    {
        public float value;
        public YGUnit unit;
    }
}