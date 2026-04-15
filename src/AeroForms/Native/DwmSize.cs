using System.Runtime.InteropServices;

namespace FireBlade.AeroForms.Native {

    [StructLayout(LayoutKind.Sequential)]
    internal struct DwmSize {

        public int Width;
        public int Height;

        public Size ToNativeSize() {
            return new Size(Width, Height);
        }

        public System.Drawing.Size ToSize() {
            return new System.Drawing.Size(Width, Height);
        }

    }

}
